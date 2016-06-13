using KR.Main.Engine;
using KR.Main.Entities;
using KR.Main.Entities.Conditions;
using KR.Main.Entities.Queries;
using KR.Main.Entities.Statements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace KR.Test
{
    [TestClass]
    public class AccessibleQueriesTest
    {
        protected Fluent cm;
        protected World world;
        protected Fluent cc;
        protected Actor Fred;
        protected Actor Bill;
        protected Action refactor;
        protected Action debug;
        protected Action code;

        public AccessibleQueriesTest()
        {
        }

        protected World CreateITWorld()
        {
            var world = World.Instance;
            cm = new Fluent("cm");
            code = new Action("Code");
            refactor = new Action("Refactor");
            debug = new Action("Debug");
            cc = new Fluent("cc");
            Fred = new Actor("Fred");
            Bill = new Actor("Bill");
            world.SetActions(new List<Action>() { code, refactor, debug });
            world.SetActors(new List<Actor>() { Fred, Bill });
            world.SetFluents(new List<Fluent> { cc, cm });
            var domain = new Domain();
            domain.AddCausesClause(new Causes(code, false, new List<Actor>() { Bill }, new Negation(cc)));
            domain.AddInitiallyClause(new Initially(new Conjunction(cc, cm)));
            domain.AddReleasesClause(new Releases(code, false, new List<Actor>() { Bill }, cm, cm));
            domain.AddTypicallyCausesClause(new TypicallyCauses(code, false, new List<Actor>() { Fred }, cm, new Negation(cc)));
            domain.AddCausesClause(new Causes(refactor, false, new List<Actor>() { Fred }, cc));
            domain.AddCausesClause(new Causes(debug, true, null, cm));
            domain.AddImpossibleClause(new Impossible(code, false, new List<Actor>() { Fred }, new Negation(cm)));
            world.SetDomain(domain);
            world.Build();
            return world;
        }

        [TestMethod]
        public void AccessibleAlways()
        {
            world = CreateITWorld();
            var q = new AccessibleAlwaysQuery(new Conjunction(new Negation(cm), new Negation(cc)), new Alternative(cc, cm));
            var q2 = new AccessibleAlwaysQuery(new Alternative(cc, cm), new Conjunction(new Negation(cm), new Negation(cc)));

            var r = q.Evaluate(world);
            var r2 = q2.Evaluate(world);
            Assert.AreEqual(r, false);
            Assert.AreEqual(r2, false);
        }

        [TestMethod]
        public void AccessibleEver()
        {
            world = CreateITWorld();
            var q = new AccessibleEverQuery(new Conjunction(new Negation( new Fluent("cm")),new Negation( new Fluent("cc"))), new Conjunction(new Fluent("cm"), new Fluent("cc")));
            var q2 = new AccessibleEverQuery(new Conjunction(new Fluent("cm"), new Fluent("cc")), new Conjunction(new Negation(new Fluent("cm")), new Negation(new Fluent("cc"))));

            var r = q.Evaluate(world);
            var r2 = q2.Evaluate(world);
            Assert.AreEqual(r, true);
            Assert.AreEqual(r2, true);
        }

        [TestMethod]
        public void AccessibleTypically()
        {
            world = CreateITWorld();
            var q = new AccessibleTypicallyQuery(new Negation(new Fluent("cc")), new Negation(new Fluent("cm")));
            var q2 = new AccessibleTypicallyQuery(new Fluent("cc"), new Negation(new Fluent("cc")));


            var r = q.Evaluate(world);
            var r2 = q2.Evaluate(world);
            Assert.AreEqual(r, true);
            Assert.AreEqual(r2, true);
        }

        [TestMethod]
        public void Fish()
        {
            var fishWorld = World.Instance;
            var alive = new Fluent("alive");
            var kill = new Action("kill");
            var Tom = new Actor("Tom");

            fishWorld.SetActions(new List<Action> { kill });
            fishWorld.SetActors(new List<Actor> { Tom });
            fishWorld.SetFluents(new List<Fluent> { alive });

            var domain = new Domain();
            domain.AddInitiallyClause(new Initially(alive));
            domain.AddReleasesClause(new Releases(kill, false, new List<Actor>() { Tom }, alive, new True()));
            fishWorld.SetDomain(domain);
            fishWorld.Build();

            var q = new AccessibleEverQuery(new Negation(alive), alive);
            var r = q.Evaluate(fishWorld);
            Assert.AreEqual(r, true);
        }
        [TestMethod]
        public void PQTest()
        {
            var p = new Fluent("p");
            var q = new Fluent("q");
            var domain = new Domain();
            domain.AddInitiallyClause(new Initially(new Conjunction(p, q)));
            domain.AddAlwaysClause(new Always( new Alternative(p, q)));
            var A = new Action("A");
            domain.AddCausesClause(new Causes(A, true, new List<Actor> { }, new Negation(p)));
            domain.AddTypicallyCausesClause(new TypicallyCauses(A, true, new List<Actor> { }, new Negation(q), p));
            var world = World.Instance;
            world.SetActions(new List<Action> { A });
            var Tom = new Actor("Tom");
            world.SetActors(new List<Actor> { Tom });
            world.SetFluents(new List<Fluent> { p, q });
            world.SetDomain(domain);
            world.Build();
            var scenario = new Scenario();
            scenario.AddScenarioStep(new ScenarioStep(A, Tom));
            var q1 = new AccessibleAlwaysScenarioQuery(p, new Conjunction(new Negation(p), q), scenario);
            var r1 = q1.Evaluate(world);
            Assert.AreEqual(r1, true);
            var q2 = new AccessibleEverScenarioQuery(p, new Conjunction(new Negation(p), q), scenario);
            r1=q2.Evaluate(world);
            Assert.AreEqual(r1, true);
            var q3 = new AccessibleTypicallyScenarioQuery(p, new Conjunction(new Negation(p), q), scenario);
            r1 = q3.Evaluate(world);
            Assert.AreEqual(r1, false); //end
        }
        [TestMethod]
        public void NeronTest()
        {
            var domain = new Domain();
            var Neron = new Actor("Nero");
            var drink = new Action("drink");
            var torch = new Action("torch");
            var rest = new Action("rest");
            var burned = new Fluent("burned");
            var ent = new Fluent("ent");
            var world = World.Instance;
            world.SetActions(new List<Action> { drink, torch, rest });
            world.SetFluents(new List<Fluent> { burned, ent });
            world.SetActors(new List<Actor> { Neron });
            domain.AddInitiallyClause(new Initially(new Conjunction(new Negation(burned), new Negation(ent))));
            domain.AddReleasesClause(new Releases(drink, false, new List<Actor> { Neron }, ent, new Negation(ent)));
            domain.AddTypicallyCausesClause(new TypicallyCauses(torch, false, new List<Actor> { Neron }, ent));
            domain.AddCausesClause(new Causes(torch, false, new List<Actor> { Neron }, burned));
            domain.AddCausesClause(new Causes(rest, false, new List<Actor> { Neron }, new Negation(ent)));
            domain.AddImpossibleClause(new Impossible(torch, false, new List<Actor> { Neron }, burned));
            world.SetDomain(domain);
            world.Build();
            var scenario = new Scenario();
            scenario.AddScenarioStep(new ScenarioStep(torch, Neron));
            var q = new AccessibleEverScenarioQuery(burned, new Negation(burned), scenario);
            var r = q.Evaluate(world);
            Assert.AreEqual(r, false);
            var q2 = new AccessibleAlwaysScenarioQuery(burned, new Negation(burned), scenario);
            r = q2.Evaluate(world);
            Assert.AreEqual(r, true);
        }
    }
}
