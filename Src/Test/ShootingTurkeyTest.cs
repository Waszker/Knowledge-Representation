using Microsoft.VisualStudio.TestTools.UnitTesting;
using KR.Main.Engine;
using KR.Main.Entities;
using KR.Main.Entities.Conditions;
using KR.Main.Entities.Queries;
using KR.Main.Entities.Statements;
using System.Collections.Generic;

namespace KR.Test
{
    /// <summary>
    /// This simple test is run on this domain:
    /// 
    /// DOMAIN:
    /// initially ~loaded && alive
    /// LOAD causes loaded
    /// ENTICE causes walking
    /// SHOOT causes ~loaded
    /// SHOOT typically causes ~alive
    /// ALWAYS walking -> alive
    /// ENTICE preserves alive
    /// </summary>
    [TestClass]
    public class ShootingTurkeyTest
    {
        private Fluent alive = new Fluent("alive"),
                       walking = new Fluent("walking"),
                       loaded = new Fluent("loaded");
        private Action shoot = new Action("SHOOT"),
                       entice = new Action("ENTICE"),
                       load = new Action("LOAD");
        private Actor Bill = new Actor("Bill");

        protected World CreateITWorld()
        {
            var world = World.Instance;
            world.SetActions(new List<Action>() { shoot, entice, load });
            world.SetActors(new List<Actor>() { Bill });
            world.SetFluents(new List<Fluent> { alive, walking, loaded });
                        
            world.SetDomain(createDomain());
            world.Build();
            return world;
        }

        /// <summary>
        /// This method checks answers for all possible accessible queries (always/ever/typically)
        /// when asking about possibilty to end up in state ~walking from the initiall state(s).
        /// </summary>
        [TestMethod]
        public void ShootingTurkeyAccessibleQueries1()
        {
            var world = CreateITWorld();
            var q1 = new AccessibleTypicallyQuery(new True(), new Negation(walking));
            var q2 = new AccessibleEverQuery(new True(), new Negation(walking));
            var q3 = new AccessibleAlwaysQuery(new True(), new Negation(walking));

            Assert.AreEqual(q1.Evaluate(world), true); // there's possibility to kill turkey or start in state when it's not walking
            Assert.AreEqual(q2.Evaluate(world), true); // killing turkey is typicall scenario
            Assert.AreEqual(q3.Evaluate(world), false); // not always shooting will kill turkey
        }

        /// <summary>
        /// This method checks answers for all possible accessible queries (always/ever/typically)
        /// when asking about possibilty to end up in state with loaded gun from the initiall state(s).
        /// </summary>
        [TestMethod]
        public void ShootingTurkeyAccessibleQueries2()
        {
            var world = CreateITWorld();
            var q1 = new AccessibleTypicallyQuery(new True(), loaded);
            var q2 = new AccessibleEverQuery(new True(), loaded);
            var q3 = new AccessibleAlwaysQuery(new True(), loaded);

            Assert.AreEqual(q1.Evaluate(world), true); // loading our gun will always/ever/typically cause it to be loaded!!!
            Assert.AreEqual(q2.Evaluate(world), true);
            Assert.AreEqual(q3.Evaluate(world), true);
        }

        /// <summary>
        /// This method checks answers for all possible accessible queries (always/ever/typically)
        /// when asking about possibilty to end up in state with walking turkey from the initiall state(s).
        /// </summary>
        [TestMethod]
        public void ShootingTurkeyAccessibleQueries3()
        {
            var world = CreateITWorld();
            var q1 = new AccessibleTypicallyQuery(new True(), walking);
            var q2 = new AccessibleEverQuery(new True(), walking);
            var q3 = new AccessibleAlwaysQuery(new True(), walking);

            Assert.AreEqual(q1.Evaluate(world), true); // enticing turkey will always/ever/typically cause it to walk!!!
            Assert.AreEqual(q2.Evaluate(world), true);
            Assert.AreEqual(q3.Evaluate(world), true);
        }

        /// <summary>
        /// Checks if state with loaded gun is present after performing (LOAD, BILL) scenario
        /// </summary>
        [TestMethod]
        public void ShootingTurkeyAfterQueries1()
        {
            var world = CreateITWorld();
            var scenario = new Scenario();
            scenario.AddScenarioStep(new ScenarioStep(load, Bill));
            var q1 = new AfterScenarioAlwaysQuery(new True(), loaded, scenario);
            var q2 = new AfterScenarioEverQuery(new True(), loaded, scenario);
            var q3 = new AfterScenarioTypicallyQuery(new True(), loaded, scenario);

            Assert.AreEqual(q1.Evaluate(world), true); // all queries should return true!
            Assert.AreEqual(q2.Evaluate(world), true);
            Assert.AreEqual(q3.Evaluate(world), true);
        }

        /// <summary>
        /// Checks if state with dead turkey is present after performing (LOAD, BILL), (SHOOT, BILL) scenario
        /// </summary>
        [TestMethod]
        public void ShootingTurkeyAfterQueries2()
        {
            var world = CreateITWorld();
            var scenario = new Scenario();
            scenario.AddScenarioStep(new ScenarioStep(load, Bill));
            scenario.AddScenarioStep(new ScenarioStep(shoot, Bill));
            var q1 = new AfterScenarioAlwaysQuery(new True(), new Negation(alive), scenario);
            var q2 = new AfterScenarioEverQuery(new True(), new Negation(alive), scenario);
            var q3 = new AfterScenarioTypicallyQuery(new True(), new Negation(alive), scenario);

            Assert.AreEqual(q1.Evaluate(world), false);
            Assert.AreEqual(q2.Evaluate(world), true);
            Assert.AreEqual(q3.Evaluate(world), true);
        }

        /// <summary>
        /// Checks if state with walking turkey is present after performing (ENTICE, BILL) scenario from initiall state
        /// </summary>
        [TestMethod]
        public void ShootingTurkeyAfterQueries3()
        {
            var world = CreateITWorld();
            var scenario = new Scenario();
            scenario.AddScenarioStep(new ScenarioStep(entice, Bill));
            var q1 = new AfterScenarioAlwaysQuery(new True(), walking, scenario);
            var q2 = new AfterScenarioEverQuery(new True(), walking, scenario);
            var q3 = new AfterScenarioTypicallyQuery(new True(), walking, scenario);

            Assert.AreEqual(q1.Evaluate(world), true);
            Assert.AreEqual(q2.Evaluate(world), true);
            Assert.AreEqual(q3.Evaluate(world), true);
        }

        private Domain createDomain()
        {
            Domain domain = new Domain();
            var emptyList = new List<Actor>();

            domain.AddInitiallyClause(new Initially(new Conjunction(new Negation(loaded), alive)));
            domain.AddCausesClause(new Causes(load, true, emptyList, loaded));
            domain.AddCausesClause(new Causes(shoot, true, emptyList, new Negation(loaded)));
            domain.AddCausesClause(new Causes(entice, true, emptyList, walking));
            domain.AddTypicallyCausesClause(new TypicallyCauses(shoot, true, emptyList, new Negation(alive)));
            domain.AddAlwaysClause(new Always(new Implication(walking, alive)));
            domain.AddPreservesClause(new Preserves(entice, true, emptyList, alive, null));

            return domain;
        }
    }
}
