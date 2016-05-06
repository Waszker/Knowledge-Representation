using System.Collections.Generic;
using KR.Main.Engine;
using KR.Main.Entities;
using KR.Main.Entities.Conditions;
using KR.Main.Entities.Statements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KR.Test
{
    [TestClass]
    public class ResN_ResAb_tests
    {
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

            var initially = new Initially(new Conjuction(cakeExistsFluent, new Negation(hatterMadFluent)));
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

            var initially = new Initially(new Conjuction(new Negation(hatterMadFluent), new Conjuction(cakeExistsFluent, elixirExistsFluent)));
            domain.AddInitiallyClause(initially);

            var drinkCauses = new Causes(drinkAction, false, new List<Actor>() {hatterActor}, hatterMadFluent, elixirExistsFluent);
            domain.AddCausesClause(drinkCauses);

            var eatTypicallyCauses = new TypicallyCauses(eatAction, false, new List<Actor>() {hatterActor}, new Negation(hatterMadFluent), hatterMadFluent);
            domain.AddTypicallyCausesClause(eatTypicallyCauses);

            var impossible = new Impossible(eatAction, false, new List<Actor>() {hatterActor}, new Negation(cakeExistsFluent));
            domain.AddImpossibleClause(impossible);

            var drinkReleases = new Releases(drinkAction, false, new List<Actor>() {hatterActor}, elixirExistsFluent, elixirExistsFluent);
            domain.AddReleasesClause(drinkReleases);

            var eatCauses = new Causes(eatAction, false, new List<Actor>() {hatterActor}, new Negation(cakeExistsFluent), null);
            domain.AddCausesClause(eatCauses);

            world.SetDomain(domain);
            world.Build();



            var allStates = world.GetStates();
            var allEdges = world.GetEdges();

            Assert.AreEqual(8, allStates.Count);
            Assert.AreEqual(18, allEdges.Count);
        }
    }
}
