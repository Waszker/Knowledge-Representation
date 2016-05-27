using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using KR.Main.Engine;
using KR.Main.Entities;
using KR.Main.Entities.Conditions;
using KR.Main.Entities.Statements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Action = KR.Main.Entities.Action;

namespace KR.Test
{
    [TestClass]
    public class ResN_ResAb_tests
    {
        private readonly IEqualityComparer<State> _stateComparer = new State.StateComparer();

        private void AssertResSetsEqual(ISet<State> a, ISet<State> b)
        {
            Assert.IsTrue(a.Count == b.Count);
            foreach (var state in a)
                Assert.IsTrue(b.Contains(state, _stateComparer));
        }

        [TestMethod]
        public void Simple_ResN_ResAb()
        {
            var world = World.Instance;

            var eatAction = new Action("Eat");
            world.SetActions(new List<Action>() { eatAction });

            var hatterActor = new Actor("Hatter");
            world.SetActors(new List<Actor>() { hatterActor });

            var hatterMadFluent = new Fluent("hatterMad");
            var cakeExistsFluent = new Fluent("cakeExists");
            world.SetFluents(new List<Fluent>() { hatterMadFluent, cakeExistsFluent });

            var domain = new Domain();

            var initially = new Initially(new Conjunction(cakeExistsFluent, new Negation(hatterMadFluent)));
            domain.AddInitiallyClause(initially);

            var eatTypicallyCauses = new TypicallyCauses(eatAction, false, new List<Actor>() { hatterActor }, new Negation(hatterMadFluent), hatterMadFluent);
            domain.AddTypicallyCausesClause(eatTypicallyCauses);

            var impossible = new Impossible(eatAction, false, new List<Actor>() { hatterActor }, new Negation(cakeExistsFluent));
            domain.AddImpossibleClause(impossible);

            var eatCauses = new Causes(eatAction, false, new List<Actor>() { hatterActor }, new Negation(cakeExistsFluent), null);
            domain.AddCausesClause(eatCauses);

            world.SetDomain(domain);
            world.Build();



            var allStates = world.GetStates();
            var allEdges = world.GetEdges();

        }

        [TestMethod]
        public void Alice_ResN_ResAb()
        {
            var world = World.Instance;

            var drinkAction = new Action("Drink");
            var eatAction = new Action("Eat");
            world.SetActions(new List<Action>() { drinkAction, eatAction });

            var hatterActor = new Actor("Hatter");
            world.SetActors(new List<Actor>() { hatterActor });

            var hatterMadFluent = new Fluent("hatterMad");
            var cakeExistsFluent = new Fluent("cakeExists");
            var elixirExistsFluent = new Fluent("elixirExists");
            world.SetFluents(new List<Fluent>() { hatterMadFluent, cakeExistsFluent, elixirExistsFluent });

            var domain = new Domain();

            var initially = new Initially(new Conjunction(new Negation(hatterMadFluent), new Conjunction(cakeExistsFluent, elixirExistsFluent)));
            domain.AddInitiallyClause(initially);

            var drinkCauses = new Causes(drinkAction, false, new List<Actor>() { hatterActor }, hatterMadFluent, elixirExistsFluent);
            domain.AddCausesClause(drinkCauses);

            var eatTypicallyCauses = new TypicallyCauses(eatAction, false, new List<Actor>() { hatterActor }, new Negation(hatterMadFluent), hatterMadFluent);
            domain.AddTypicallyCausesClause(eatTypicallyCauses);

            var impossible = new Impossible(eatAction, false, new List<Actor>() { hatterActor }, new Negation(cakeExistsFluent));
            domain.AddImpossibleClause(impossible);

            var drinkReleases = new Releases(drinkAction, false, new List<Actor>() { hatterActor }, elixirExistsFluent, elixirExistsFluent);
            domain.AddReleasesClause(drinkReleases);

            var eatCauses = new Causes(eatAction, false, new List<Actor>() { hatterActor }, new Negation(cakeExistsFluent), null);
            domain.AddCausesClause(eatCauses);

            world.SetDomain(domain);
            world.Build();



            var allStates = world.GetStates();
            var allEdges = world.GetEdges();

            Assert.AreEqual(8, allStates.Count);
            Assert.AreEqual(18, allEdges.Count);
        }

        [TestMethod]
        public void Blowfish()
        {
            World world = World.Instance;

            var puffedUpFluent = new Fluent("Puffed up");
            var inflateAction = new Action("Inflate");
            var deflateAction = new Action("Deflate");
            var blowfishActor = new Actor("Blowfish");

            var domain = new Domain();
            domain.AddInitiallyClause(new Initially(puffedUpFluent));
            domain.AddCausesClause(new Causes(inflateAction, false, new List<Actor> { blowfishActor }, puffedUpFluent));
            domain.AddCausesClause(new Causes(deflateAction, false, new List<Actor> { blowfishActor }, new Negation(puffedUpFluent)));

            world.SetFluents(new List<Fluent> { puffedUpFluent });
            world.SetActions(new List<Action> { inflateAction, deflateAction });
            world.SetActors(new List<Actor> { blowfishActor });
            world.SetDomain(domain);

            Assert.IsTrue(world.Build());

            State state0 = new State(new List<Fluent> { puffedUpFluent }, new List<bool> { true });
            State state1 = new State(new List<Fluent> { puffedUpFluent }, new List<bool> { false });

            ISet<State> expectedResN, expectedResAb, actualResN, actualResAb;

            // inflate; blowfish; puffedUp
            expectedResN = new HashSet<State> { state0 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(inflateAction, blowfishActor, state0, false);
            actualResAb = world.GetStates(inflateAction, blowfishActor, state0, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // inflate; blowfish; -puffedUp
            expectedResN = new HashSet<State> { state0 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(inflateAction, blowfishActor, state1, false);
            actualResAb = world.GetStates(inflateAction, blowfishActor, state1, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // deflate; blowfish; puffedUp
            expectedResN = new HashSet<State> { state1 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(deflateAction, blowfishActor, state0, false);
            actualResAb = world.GetStates(deflateAction, blowfishActor, state0, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // deflate; blowfish; -puffedUp
            expectedResN = new HashSet<State> { state1 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(deflateAction, blowfishActor, state1, false);
            actualResAb = world.GetStates(deflateAction, blowfishActor, state1, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);
        }

        [TestMethod]
        public void CookingJohn()
        {
            World world = World.Instance;

            var hungryFluent = new Fluent("Hungry");
            var hasMealFluent = new Fluent("Has meal");
            var cookAction = new Action("Cook");
            var eatAction = new Action("Eat");
            var johnActor = new Actor("John");

            var domain = new Domain();
            domain.AddInitiallyClause(new Initially(new Conjunction(hungryFluent, new Negation(hasMealFluent))));
            domain.AddImpossibleClause(new Impossible(eatAction, false, new List<Actor> { johnActor }, new Negation(hasMealFluent)));
            domain.AddTypicallyCausesClause(new TypicallyCauses(cookAction, false, new List<Actor> { johnActor }, hasMealFluent));
            domain.AddCausesClause(new Causes(eatAction, false, new List<Actor> { johnActor }, new Negation(hasMealFluent)));
            domain.AddReleasesClause(new Releases(eatAction, false, new List<Actor> { johnActor }, hungryFluent, hungryFluent));

            world.SetActors(new List<Actor> { johnActor });
            world.SetFluents(new List<Fluent> { hungryFluent, hasMealFluent });
            world.SetActions(new List<Action> { cookAction, eatAction });
            world.SetDomain(domain);

            Assert.IsTrue(world.Build());

            State state0 = new State(new List<Fluent> { hungryFluent, hasMealFluent }, new List<bool> { true, false });
            State state1 = new State(new List<Fluent> { hungryFluent, hasMealFluent }, new List<bool> { true, true });
            State state2 = new State(new List<Fluent> { hungryFluent, hasMealFluent }, new List<bool> { false, true });
            State state3 = new State(new List<Fluent> { hungryFluent, hasMealFluent }, new List<bool> { false, false });

            ISet<State> expectedResN, expectedResAb, actualResN, actualResAb;

            // cook; john; hungry & -hasMeal
            expectedResN = new HashSet<State> { state1 };
            expectedResAb = new HashSet<State> { state0 };
            actualResN = world.GetStates(cookAction, johnActor, state0, false);
            actualResAb = world.GetStates(cookAction, johnActor, state0, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // cook; john; hungry & hasMeal
            expectedResN = new HashSet<State> { state1 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(cookAction, johnActor, state1, false);
            actualResAb = world.GetStates(cookAction, johnActor, state1, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // cook; john; -hungry & hasMeal
            expectedResN = new HashSet<State> { state2 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(cookAction, johnActor, state2, false);
            actualResAb = world.GetStates(cookAction, johnActor, state2, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // cook; john; -hungry & -hasMeal
            expectedResN = new HashSet<State> { state2 };
            expectedResAb = new HashSet<State> { state3 };
            actualResN = world.GetStates(cookAction, johnActor, state3, false);
            actualResAb = world.GetStates(cookAction, johnActor, state3, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // eat; john; hungry & -hasMeal
            expectedResN = new HashSet<State> { };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(eatAction, johnActor, state0, false);
            actualResAb = world.GetStates(eatAction, johnActor, state0, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // eat; john; hungry & hasMeal
            expectedResN = new HashSet<State> { state0, state3 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(eatAction, johnActor, state1, false);
            actualResAb = world.GetStates(eatAction, johnActor, state1, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // eat; john; -hungry & hasMeal
            expectedResN = new HashSet<State> { state3 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(eatAction, johnActor, state2, false);
            actualResAb = world.GetStates(eatAction, johnActor, state2, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // eat; john; -hungry & -hasMeal
            expectedResN = new HashSet<State> { };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(eatAction, johnActor, state3, false);
            actualResAb = world.GetStates(eatAction, johnActor, state3, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);
        }
    }
}
