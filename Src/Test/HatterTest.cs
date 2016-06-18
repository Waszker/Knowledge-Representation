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
    public class HatterTest
    {
        protected World world;

        protected Fluent aliceSmall;
        protected Fluent hatterMad;
        protected Fluent catVisible;
        protected Fluent cakeExists;
        protected Fluent elixirExists;

        protected Actor alice;
        protected Actor cat;
        protected Actor hatter;
        protected Actor rabbit;

        protected Action drink;
        protected Action eat;


        protected World CreateITWorld()
        {
            var world = World.Instance;

            aliceSmall = new Fluent("aliceSmall");
            hatterMad = new Fluent("hatterMad");
            catVisible = new Fluent("catVisible");
            cakeExists = new Fluent("cakeExists");
            elixirExists = new Fluent("elixirExists");

            alice = new Actor("alice");
            cat = new Actor("cat");
            hatter = new Actor("hatter");
            rabbit = new Actor("rabbit");

            drink = new Action("drink");
            eat = new Action("eat");

            world.SetActions(new List<Action>() { drink, eat });
            world.SetActors(new List<Actor>() { alice, cat, hatter, rabbit });
            world.SetFluents(new List<Fluent> { aliceSmall, hatterMad, catVisible, cakeExists, elixirExists });

            var domain = new Domain();

            domain.AddInitiallyClause(new Initially(new Conjunction(new Negation(aliceSmall), new Negation(hatterMad), new Negation(catVisible))));
            domain.AddInitiallyClause(new Initially(new Conjunction(cakeExists, elixirExists)));
            domain.AddCausesClause(new Causes(drink, false, new List<Actor>() { alice }, aliceSmall, elixirExists));
            domain.AddCausesClause(new Causes(eat, false, new List<Actor>() { alice }, new Negation(aliceSmall)));
            domain.AddImpossibleClause(new Impossible(eat, false, new List<Actor>() { cat }, new True()));
            domain.AddTypicallyCausesClause(new TypicallyCauses(drink, false, new List<Actor>() { cat }, catVisible, elixirExists));
            domain.AddReleasesClause(new Releases(drink, false, new List<Actor>() { hatter }, hatterMad, new Conjunction(new Negation(hatterMad), elixirExists)));
            domain.AddTypicallyCausesClause(new TypicallyCauses(eat, false, new List<Actor>() { hatter }, new Negation(hatterMad), hatterMad));
            domain.AddCausesClause(new Causes(eat, true, new List<Actor>(), new Negation(cakeExists)));
            domain.AddImpossibleClause(new Impossible(eat, true, new List<Actor>(), new Negation(cakeExists)));
            domain.AddReleasesClause(new Releases(drink, true, new List<Actor>(), elixirExists, elixirExists));
            domain.AddImpossibleClause(new Impossible(eat, false, new List<Actor>() { rabbit }, new True()));
            domain.AddCausesClause(new Causes(drink, false, new List<Actor>() { rabbit }, cakeExists, elixirExists));


            world.SetDomain(domain);
            world.Build();
            return world;
        }

        #region Q1

        [TestMethod]
        public void AlwaysExecutableQuery()
        {
            world = CreateITWorld();

            var sc1 = new Scenario();
            sc1.AddScenarioStep(new ScenarioStep(eat, alice));
            sc1.AddScenarioStep(new ScenarioStep(drink, alice));
            sc1.AddScenarioStep(new ScenarioStep(drink, rabbit));
            sc1.AddScenarioStep(new ScenarioStep(eat, alice));
            var q1 = new ScenarioAlwaysExecutableQuery(sc1);

            var sc2 = new Scenario();
            sc2.AddScenarioStep(new ScenarioStep(drink, alice));
            sc2.AddScenarioStep(new ScenarioStep(drink, rabbit));
            sc2.AddScenarioStep(new ScenarioStep(drink, hatter));
            sc2.AddScenarioStep(new ScenarioStep(drink, cat));
            var q2 = new ScenarioAlwaysExecutableQuery(sc2);


            var r1 = q1.Evaluate(world);
            var r2 = q2.Evaluate(world);

            Assert.AreEqual(r1, false); // elixir może się skończyć na alicji, wtedy (drink,rabbit) nie przywróci ciastka
            Assert.AreEqual(r2, true);
        }

        [TestMethod]
        public void EverExecutableQuery()
        {
            world = CreateITWorld();

            var sc1 = new Scenario();
            sc1.AddScenarioStep(new ScenarioStep(eat, alice));
            sc1.AddScenarioStep(new ScenarioStep(drink, alice));
            sc1.AddScenarioStep(new ScenarioStep(drink, rabbit));
            sc1.AddScenarioStep(new ScenarioStep(eat, alice));
            var q1 = new ScenarioEverExecutableQuery(sc1);

            var sc2 = new Scenario();
            sc2.AddScenarioStep(new ScenarioStep(eat, alice));
            sc2.AddScenarioStep(new ScenarioStep(eat, alice));
            var q2 = new ScenarioEverExecutableQuery(sc2);


            var r1 = q1.Evaluate(world);
            var r2 = q2.Evaluate(world);

            Assert.AreEqual(r1, true); // elixir może się nie skończyć
            Assert.AreEqual(r2, false);
        }

        #endregion

        #region Q2

        [TestMethod]
        public void AlwaysAccessibleWhenQuery()
        {
            world = CreateITWorld();

            var sc1 = new Scenario();
            sc1.AddScenarioStep(new ScenarioStep(eat, alice));
            var q1 = new AccessibleAlwaysScenarioQuery(new True(), cakeExists, sc1);

            var sc2 = new Scenario();
            sc2.AddScenarioStep(new ScenarioStep(drink, alice));
            var q2 = new AccessibleAlwaysScenarioQuery(new True(), new Negation(elixirExists), sc2);

            var r1 = q1.Evaluate(world);
            var r2 = q2.Evaluate(world);
            Assert.AreEqual(r1, true);
            Assert.AreEqual(r2, false); // po wykonaniu sc2 elixir moze istniec, i nie da sie zawsze zrobic zeby go nie bylo
        }


        [TestMethod]
        public void EverAccessibleWhenQuery()
        {
            world = CreateITWorld();

            var sc1 = new Scenario();
            sc1.AddScenarioStep(new ScenarioStep(eat, alice));
            var q1 = new AccessibleAlwaysScenarioQuery(new True(), cakeExists, sc1);

            var sc3 = new Scenario();
            sc3.AddScenarioStep(new ScenarioStep(eat, alice));
            sc3.AddScenarioStep(new ScenarioStep(eat, alice));
            var q3 = new AccessibleAlwaysScenarioQuery(new True(), new Negation(elixirExists), sc3);

            var r1 = q1.Evaluate(world);
            var r3 = q3.Evaluate(world);
            Assert.AreEqual(r1, true);
            Assert.AreEqual(r3, false); // sc3 jest niewykonalne
        }


        //[TestMethod]
        //public void TypicallyAccessibleWhenQuery()
        //{
            
        //}

        #endregion

        #region Q3

        [TestMethod]
        public void AlwaysAccessibleQuery()
        {
            world = CreateITWorld();

            var q1 = new AccessibleAlwaysQuery(new True(), catVisible);
            var q2 = new AccessibleAlwaysQuery(new True(), new Negation(elixirExists));
            var q3 = new AccessibleAlwaysQuery(new True(), new Negation(cakeExists));

            var r1 = q1.Evaluate(world);
            var r2 = q2.Evaluate(world);
            var r3 = q3.Evaluate(world);
            Assert.AreEqual(r1, false);
            Assert.AreEqual(r2, false);
            Assert.AreEqual(r3, true);
        }


        [TestMethod]
        public void EverAccessibleQuery()
        {
            world = CreateITWorld();

            var q1 = new AccessibleEverQuery(new True(), catVisible);
            var q2 = new AccessibleEverQuery(new True(), new Negation(elixirExists));
            var q3 = new AccessibleEverQuery(new True(), new Negation(cakeExists));

            var r1 = q1.Evaluate(world);
            var r2 = q2.Evaluate(world);
            var r3 = q3.Evaluate(world);
            Assert.AreEqual(r1, true);
            Assert.AreEqual(r2, true);
            Assert.AreEqual(r3, true);
        }


        [TestMethod]
        public void TypicallyAccessibleQuery()
        {
            world = CreateITWorld();

            var q1 = new AccessibleTypicallyQuery(new True(), catVisible);
            var q2 = new AccessibleTypicallyQuery(new True(), new Negation(elixirExists));
            var q3 = new AccessibleTypicallyQuery(new True(), new Negation(cakeExists));

            var r1 = q1.Evaluate(world);
            var r2 = q2.Evaluate(world);
            var r3 = q3.Evaluate(world);
            Assert.AreEqual(r1, true);
            Assert.AreEqual(r2, false);
            Assert.AreEqual(r3, true);
        }

        #endregion

        #region Q4

        [TestMethod]
        public void AlwaysPartakesQuery()
        {
            world = CreateITWorld();

            var sc1 = new Scenario();
            sc1.AddScenarioStep(new ScenarioStep(eat, alice));
            var q1 = new ActorAlwaysPartakesQuery(alice, sc1);

            var sc2 = new Scenario();
            sc2.AddScenarioStep(new ScenarioStep(eat, alice));
            var q2 = new ActorAlwaysPartakesQuery(hatter, sc2);

            var sc3 = new Scenario();
            sc3.AddScenarioStep(new ScenarioStep(eat, alice));
            sc3.AddScenarioStep(new ScenarioStep(eat, alice));
            var q3 = new ActorAlwaysPartakesQuery(alice, sc3);

            var sc4 = new Scenario();
            sc4.AddScenarioStep(new ScenarioStep(eat, alice));
            sc4.AddScenarioStep(new ScenarioStep(drink, rabbit));
            sc4.AddScenarioStep(new ScenarioStep(eat, alice));
            var q4 = new ActorAlwaysPartakesQuery(alice, sc4);


            var r1 = q1.Evaluate(world);
            var r2 = q2.Evaluate(world);
            var r3 = q3.Evaluate(world);
            var r4 = q4.Evaluate(world);
            
            Assert.AreEqual(r1, true);
            Assert.AreEqual(r2, false);
            Assert.AreEqual(r3, false);
            Assert.AreEqual(r4, true);
        }

        [TestMethod]
        public void EverPartakesQuery()
        {
            world = CreateITWorld();

            var sc1 = new Scenario();
            sc1.AddScenarioStep(new ScenarioStep(eat, alice));
            var q1 = new ActorEverPartakesQuery(alice, sc1);

            var sc2 = new Scenario();
            sc2.AddScenarioStep(new ScenarioStep(eat, alice));
            var q2 = new ActorEverPartakesQuery(hatter, sc2);

            var sc3 = new Scenario();
            sc3.AddScenarioStep(new ScenarioStep(eat, alice));
            sc3.AddScenarioStep(new ScenarioStep(eat, alice));
            var q3 = new ActorEverPartakesQuery(alice, sc3);

            var sc4 = new Scenario();
            sc4.AddScenarioStep(new ScenarioStep(eat, alice));
            sc4.AddScenarioStep(new ScenarioStep(drink, rabbit));
            sc4.AddScenarioStep(new ScenarioStep(eat, alice));
            var q4 = new ActorEverPartakesQuery(alice, sc4);


            var r1 = q1.Evaluate(world);
            var r2 = q2.Evaluate(world);
            var r3 = q3.Evaluate(world);
            var r4 = q4.Evaluate(world);

            Assert.AreEqual(r1, true);
            Assert.AreEqual(r2, false);
            Assert.AreEqual(r3, false);
            Assert.AreEqual(r4, true);
        }

        #endregion

        #region Q5


        [TestMethod]
        public void AlwaysAfterQuery()
        {
            world = CreateITWorld();

            var sc1 = new Scenario();
            sc1.AddScenarioStep(new ScenarioStep(eat, alice));
            var q1 = new AfterScenarioAlwaysQuery(new True(), new Negation(cakeExists), sc1);

            var sc2 = new Scenario();
            sc2.AddScenarioStep(new ScenarioStep(drink, alice));
            var q2 = new AfterScenarioAlwaysQuery(new True(), new Negation(elixirExists), sc2);


            var r1 = q1.Evaluate(world);
            var r2 = q2.Evaluate(world);

            Assert.AreEqual(r1, true); 
            Assert.AreEqual(r2, false);
        }


        [TestMethod]
        public void EverAfterQuery()
        {
            world = CreateITWorld();

            var sc1 = new Scenario();
            sc1.AddScenarioStep(new ScenarioStep(eat, alice));
            var q1 = new AfterScenarioEverQuery(new True(), cakeExists, sc1);

            var sc2 = new Scenario();
            sc2.AddScenarioStep(new ScenarioStep(drink, alice));
            var q2 = new AfterScenarioEverQuery(new True(), new Negation(elixirExists), sc2);


            var r1 = q1.Evaluate(world);
            var r2 = q2.Evaluate(world);

            Assert.AreEqual(r1, false);
            Assert.AreEqual(r2, true);
        }


        [TestMethod]
        public void TypicallyAfterQuery()
        {
            world = CreateITWorld();

            var sc1 = new Scenario();
            sc1.AddScenarioStep(new ScenarioStep(drink, cat));
            var q1 = new AfterScenarioTypicallyQuery(new True(), catVisible, sc1);

            var sc2 = new Scenario();
            sc2.AddScenarioStep(new ScenarioStep(drink, hatter));
            sc2.AddScenarioStep(new ScenarioStep(eat, hatter));
            var q2 = new AfterScenarioTypicallyQuery(new True(), new Negation(hatterMad), sc2);


            var r1 = q1.Evaluate(world);
            var r2 = q2.Evaluate(world);

            Assert.AreEqual(r1, true);
            Assert.AreEqual(r2, true);
        }

        #endregion

    }
}
