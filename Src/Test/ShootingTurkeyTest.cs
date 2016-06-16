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
            var q1 = new AccessibleTypicallyQuery(null, new Negation(walking));
            var q2 = new AccessibleEverQuery(null, new Negation(walking));
            var q3 = new AccessibleAlwaysQuery(null, new Negation(walking));

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
            var q1 = new AccessibleTypicallyQuery(null, loaded);
            var q2 = new AccessibleEverQuery(null, loaded);
            var q3 = new AccessibleAlwaysQuery(null, loaded);

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
            var q1 = new AccessibleTypicallyQuery(null, walking);
            var q2 = new AccessibleEverQuery(null, walking);
            var q3 = new AccessibleAlwaysQuery(null, walking);

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
            var loadingScenario = new Scenario();
            loadingScenario.AddScenarioStep(new ScenarioStep(load, Bill));
            var q1 = new AfterScenarioAlwaysQuery(null, loaded, loadingScenario);
            var q2 = new AfterScenarioEverQuery(null, loaded, loadingScenario);
            var q3 = new AfterScenarioTypicallyQuery(null, loaded, loadingScenario);

            Assert.AreEqual(q1.Evaluate(world), true); // all queries should return true!
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
