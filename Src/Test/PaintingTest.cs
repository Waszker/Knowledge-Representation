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
    /// Simple test for checking if detecting different types of actions works.
    /// </summary>
    [TestClass]
    public class PaintingTest
    {
        protected World world;
        protected Fluent painted;
        protected Actor Fred;
        protected Actor Bill;
        protected Action clear;
        protected Action paint;

        protected World CreateITWorld()
        {
            var world = World.Instance;
            painted = new Fluent("painted");
            paint = new Action("PAINT");
            clear = new Action("CLEAR");
            Fred = new Actor("Fred");
            Bill = new Actor("Bill");

            world.SetActions(new List<Action>() { paint, clear });
            world.SetActors(new List<Actor>() { Fred, Bill });
            world.SetFluents(new List<Fluent> { painted });

            var domain = new Domain();
            domain.AddInitiallyClause(new Initially(new Negation(painted)));
            domain.AddCausesClause(new Causes(clear, true, new List<Actor>(), new Negation(painted)));
            domain.AddTypicallyCausesClause(new TypicallyCauses(paint, false, new List<Actor>() { Fred }, painted));
            world.SetDomain(domain);
            world.Build();
            return world;
        }

        [TestMethod]
        public void PaintingTestTypicallyAccessibleQuery()
        {
            world = CreateITWorld();
            var q = new AccessibleTypicallyQuery(new Negation(painted), new Negation(painted));

            var r = q.Evaluate(world);
            Assert.AreEqual(r, true);
        }

        [TestMethod]
        public void PaintingTestEverAccessibleQuery()
        {
            world = CreateITWorld();
            var q = new AccessibleEverQuery(new Negation(painted), new Negation(painted));

            var r = q.Evaluate(world);
            Assert.AreEqual(r, true);
        }

        [TestMethod]
        public void PaintingTestAlwaysAccessibleQuery()
        {
            world = CreateITWorld();
            var q = new AccessibleAlwaysQuery(new Negation(painted), (painted));

            var r = q.Evaluate(world);
            Assert.AreEqual(false, r);
        }

        [TestMethod]
        public void PaintingTestAlwaysAccessibleQuery2()
        {
            world = CreateITWorld();
            var q = new AccessibleAlwaysQuery(new Negation(painted), new Negation(painted));

            var r = q.Evaluate(world);
            Assert.AreEqual(true, r);
        }
    }
}
