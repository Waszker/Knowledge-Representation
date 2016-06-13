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
    public class ResSetsTests
    {
        private readonly IEqualityComparer<State> _stateComparer = new State.StateComparer();

        private void AssertResSetsEqual(ISet<State> a, ISet<State> b)
        {
            Assert.IsTrue(a.Count == b.Count);
            foreach (var state in a)
                Assert.IsTrue(b.Contains(state, _stateComparer));
        }

        [TestMethod]
        public void Alice()
        {
            World world = World.Instance;

            var hatterActor = new Actor("Hatter");
            var drinkAction = new Action("Drink");
            var eatAction = new Action("Eat");
            var hatterMadFluent = new Fluent("hatterMad");
            var cakeExistsFluent = new Fluent("cakeExists");
            var elixirExistsFluent = new Fluent("elixirExists");
            var fluentList = new List<Fluent> { hatterMadFluent, cakeExistsFluent, elixirExistsFluent };

            var domain = new Domain();
            var initially1 = new Initially(new Conjunction(new Negation(hatterMadFluent), cakeExistsFluent, elixirExistsFluent));
            var causes1 = new Causes(drinkAction, false, new List<Actor> { hatterActor }, hatterMadFluent, elixirExistsFluent);
            var causes2 = new Causes(eatAction, false, new List<Actor> { hatterActor }, new Negation(cakeExistsFluent));
            var tCauses1 = new TypicallyCauses(eatAction, false, new List<Actor> { hatterActor }, new Negation(hatterMadFluent), hatterMadFluent);
            var impossible1 = new Impossible(eatAction, false, new List<Actor> { hatterActor }, new Negation(cakeExistsFluent));
            var releases1 = new Releases(drinkAction, false, new List<Actor> { hatterActor }, elixirExistsFluent, elixirExistsFluent);
            domain.AddInitiallyClause(initially1);
            domain.AddCausesClause(causes1);
            domain.AddTypicallyCausesClause(tCauses1);
            domain.AddImpossibleClause(impossible1);
            domain.AddReleasesClause(releases1);
            domain.AddCausesClause(causes2);

            world.SetActions(new List<Action> { drinkAction, eatAction });
            world.SetActors(new List<Actor> { hatterActor });
            world.SetFluents(fluentList);
            world.SetDomain(domain);

            Assert.IsTrue(world.Build());

            State state0 = new State(fluentList, new List<bool> { false, true, true });
            State state1 = new State(fluentList, new List<bool> { true, true, true });
            State state2 = new State(fluentList, new List<bool> { true, false, true });
            State state3 = new State(fluentList, new List<bool> { false, false, true });
            State state4 = new State(fluentList, new List<bool> { true, false, false });
            State state5 = new State(fluentList, new List<bool> { true, true, false });
            State state6 = new State(fluentList, new List<bool> { false, true, false });
            State state7 = new State(fluentList, new List<bool> { false, false, false });

            ISet<State> expectedResN, expectedResAb, actualResN, actualResAb;

            // drink; hatter; -hatterMad & cakeExists & elixirExists
            expectedResN = new HashSet<State> { state1, state5 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(drinkAction, hatterActor, state0, false);
            actualResAb = world.GetStates(drinkAction, hatterActor, state0, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // drink; hatter; hatterMad & cakeExists & elixirExists
            expectedResN = new HashSet<State> { state1, state5 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(drinkAction, hatterActor, state1, false);
            actualResAb = world.GetStates(drinkAction, hatterActor, state1, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // drink; hatter; hatterMad & -cakeExists & elixirExists
            expectedResN = new HashSet<State> { state2, state4 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(drinkAction, hatterActor, state2, false);
            actualResAb = world.GetStates(drinkAction, hatterActor, state2, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // drink; hatter; -hatterMad & -cakeExists & elixirExists
            expectedResN = new HashSet<State> { state2, state4 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(drinkAction, hatterActor, state3, false);
            actualResAb = world.GetStates(drinkAction, hatterActor, state3, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // drink; hatter; hatterMad & -cakeExists & -elixirExists
            expectedResN = new HashSet<State> { state4 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(drinkAction, hatterActor, state4, false);
            actualResAb = world.GetStates(drinkAction, hatterActor, state4, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // drink; hatter; hatterMad & cakeExists & -elixirExists
            expectedResN = new HashSet<State> { state5 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(drinkAction, hatterActor, state5, false);
            actualResAb = world.GetStates(drinkAction, hatterActor, state5, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // drink; hatter; -hatterMad & cakeExists & -elixirExists
            expectedResN = new HashSet<State> { state6 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(drinkAction, hatterActor, state6, false);
            actualResAb = world.GetStates(drinkAction, hatterActor, state6, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // drink; hatter; -hatterMad & -cakeExists & -elixirExists
            expectedResN = new HashSet<State> { state7 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(drinkAction, hatterActor, state7, false);
            actualResAb = world.GetStates(drinkAction, hatterActor, state7, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // eat; hatter; -hatterMad & cakeExists & elixirExists
            expectedResN = new HashSet<State> { state3 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(eatAction, hatterActor, state0, false);
            actualResAb = world.GetStates(eatAction, hatterActor, state0, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // eat; hatter; hatterMad & cakeExists & elixirExists
            expectedResN = new HashSet<State> { state3 };
            expectedResAb = new HashSet<State> { state2 };
            actualResN = world.GetStates(eatAction, hatterActor, state1, false);
            actualResAb = world.GetStates(eatAction, hatterActor, state1, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // eat; hatter; hatterMad & -cakeExists & elixirExists
            expectedResN = new HashSet<State> { };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(eatAction, hatterActor, state2, false);
            actualResAb = world.GetStates(eatAction, hatterActor, state2, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // eat; hatter; -hatterMad & -cakeExists & elixirExists
            expectedResN = new HashSet<State> { };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(eatAction, hatterActor, state3, false);
            actualResAb = world.GetStates(eatAction, hatterActor, state3, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // eat; hatter; hatterMad & -cakeExists & -elixirExists
            expectedResN = new HashSet<State> { };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(eatAction, hatterActor, state4, false);
            actualResAb = world.GetStates(eatAction, hatterActor, state4, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // eat; hatter; hatterMad & cakeExists & -elixirExists
            expectedResN = new HashSet<State> { state7 };
            expectedResAb = new HashSet<State> { state4 };
            actualResN = world.GetStates(eatAction, hatterActor, state5, false);
            actualResAb = world.GetStates(eatAction, hatterActor, state5, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // eat; hatter; -hatterMad & cakeExists & -elixirExists
            expectedResN = new HashSet<State> { state7 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(eatAction, hatterActor, state6, false);
            actualResAb = world.GetStates(eatAction, hatterActor, state6, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);

            // eat; hatter; -hatterMad & -cakeExists & -elixirExists
            expectedResN = new HashSet<State> { };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(eatAction, hatterActor, state7, false);
            actualResAb = world.GetStates(eatAction, hatterActor, state7, true);
            AssertResSetsEqual(expectedResN, actualResN);
            AssertResSetsEqual(expectedResAb, actualResAb);
        }

        [TestMethod]
        public void Blowfish()
        {
            World world = World.Instance;

            var inflateAction = new Action("Inflate");
            var deflateAction = new Action("Deflate");
            var blowfishActor = new Actor("Blowfish");
            var puffedUpFluent = new Fluent("puffedUp");
            var fluentList = new List<Fluent> { puffedUpFluent };

            var domain = new Domain();
            domain.AddInitiallyClause(new Initially(puffedUpFluent));
            domain.AddCausesClause(new Causes(inflateAction, false, new List<Actor> { blowfishActor }, puffedUpFluent));
            domain.AddCausesClause(new Causes(deflateAction, false, new List<Actor> { blowfishActor }, new Negation(puffedUpFluent)));

            world.SetActions(new List<Action> { inflateAction, deflateAction });
            world.SetActors(new List<Actor> { blowfishActor });
            world.SetFluents(fluentList);
            world.SetDomain(domain);

            Assert.IsTrue(world.Build());

            State state0 = new State(fluentList, new List<bool> { true });
            State state1 = new State(fluentList, new List<bool> { false });

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

            var cookAction = new Action("Cook");
            var eatAction = new Action("Eat");
            var johnActor = new Actor("John");
            var hungryFluent = new Fluent("hungry");
            var hasMealFluent = new Fluent("hasMeal");
            var fluentList = new List<Fluent> { hungryFluent, hasMealFluent };

            var domain = new Domain();
            domain.AddInitiallyClause(new Initially(new Conjunction(hungryFluent, new Negation(hasMealFluent))));
            domain.AddImpossibleClause(new Impossible(eatAction, false, new List<Actor> { johnActor }, new Negation(hasMealFluent)));
            domain.AddTypicallyCausesClause(new TypicallyCauses(cookAction, false, new List<Actor> { johnActor }, hasMealFluent));
            domain.AddCausesClause(new Causes(eatAction, false, new List<Actor> { johnActor }, new Negation(hasMealFluent)));
            domain.AddReleasesClause(new Releases(eatAction, false, new List<Actor> { johnActor }, hungryFluent, hungryFluent));

            world.SetActors(new List<Actor> { johnActor });
            world.SetActions(new List<Action> { cookAction, eatAction });
            world.SetFluents(fluentList);
            world.SetDomain(domain);

            Assert.IsTrue(world.Build());

            State state0 = new State(fluentList, new List<bool> { true, false });
            State state1 = new State(fluentList, new List<bool> { true, true });
            State state2 = new State(fluentList, new List<bool> { false, true });
            State state3 = new State(fluentList, new List<bool> { false, false });

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

        [TestMethod]
        public void OnlyAtypical()
        {
            World world = World.Instance;

            var aAction = new Action("A");
            var nonameActor = new Actor("Noname");
            var pFluent = new Fluent("p");
            var qFluent = new Fluent("q");
            var fluentList = new List<Fluent> { pFluent, qFluent };

            var domain = new Domain();
            domain.AddInitiallyClause(new Initially(new Conjunction(pFluent, qFluent)));
            domain.AddAlwaysClause(new Always(new Alternative(pFluent, qFluent)));
            domain.AddCausesClause(new Causes(aAction, false, new List<Actor> { nonameActor }, new Negation(pFluent)));
            domain.AddTypicallyCausesClause(new TypicallyCauses(aAction, false, new List<Actor> { nonameActor }, new Negation(qFluent), pFluent));

            world.SetActions(new List<Action> { aAction });
            world.SetActors(new List<Actor> { nonameActor });
            world.SetFluents(fluentList);
            world.SetDomain(domain);

            Assert.IsTrue(world.Build());

            State state0 = new State(fluentList, new List<bool> { true, true });
            State state1 = new State(fluentList, new List<bool> { true, false });
            State state2 = new State(fluentList, new List<bool> { false, true });

            ISet<State> expectedResN, expectedResAb, actualResN, actualResAb;

            // A; Noname; p & q
            expectedResN = new HashSet<State> { };
            expectedResAb = new HashSet<State> { state2 };
            actualResN = world.GetStates(aAction, nonameActor, state0, false);
            actualResAb = world.GetStates(aAction, nonameActor, state0, true);

            // A; Noname; p & -q
            expectedResN = new HashSet<State> { };
            expectedResAb = new HashSet<State> { state2 };
            actualResN = world.GetStates(aAction, nonameActor, state1, false);
            actualResAb = world.GetStates(aAction, nonameActor, state1, true);

            // A; Noname; -p & q
            expectedResN = new HashSet<State> { state2 };
            expectedResAb = new HashSet<State> { };
            actualResN = world.GetStates(aAction, nonameActor, state2, false);
            actualResAb = world.GetStates(aAction, nonameActor, state2, true);
        }
    }
}
