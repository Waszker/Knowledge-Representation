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
            world = CreateITWorld();
        }

        private World CreateITWorld()
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
            var q = new AccessibleTypicallyQuery(new Negation(new Fluent("cc")), new Negation(new Fluent("cm")));
            var q2 = new AccessibleTypicallyQuery(new Fluent("cc"), new Negation(new Fluent("cc")));

            var r = q.Evaluate(world);
            var r2 = q2.Evaluate(world);
            Assert.AreEqual(r, true);
            Assert.AreEqual(r2, true);
        }
    }
}
