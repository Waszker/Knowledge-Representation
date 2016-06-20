using System.Collections.Generic;
using KR.Main.Engine;
using KR.Main.Entities;
using KR.Main.Entities.Conditions;
using KR.Main.Entities.Queries;
using KR.Main.Entities.Statements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KR.Test
{
    [TestClass]
    public class NeroTests
    {
        private readonly World _world = World.Instance;
        private Scenario _drinkRestTorchScenario;

        private ICondition _accessibleQueryPi;
        private ICondition _accessibleQueryGamma;

        public NeroTests()
        {
            var burnedFluent = new Fluent("burned");
            var entertainedFluent = new Fluent("entertained");
            var neroActor = new Actor("Nero");
            var drinkAction = new Action("Drink");
            var torchAction = new Action("Torch");
            var restAction = new Action("Rest");

            var domain = new Domain();
            domain.AddInitiallyClause(new Initially(new Conjunction(new Negation(burnedFluent), new Negation(entertainedFluent))));
            domain.AddReleasesClause(new Releases(drinkAction, false, new List<Actor> { neroActor }, entertainedFluent, new Negation(entertainedFluent)));
            domain.AddTypicallyCausesClause(new TypicallyCauses(torchAction, false, new List<Actor> { neroActor }, entertainedFluent));
            domain.AddCausesClause(new Causes(torchAction, false, new List<Actor> { neroActor }, burnedFluent));
            domain.AddCausesClause(new Causes(restAction, false, new List<Actor> { neroActor }, new Negation(entertainedFluent)));
            domain.AddImpossibleClause(new Impossible(torchAction, false, new List<Actor> { neroActor }, burnedFluent));

            _world.SetActors(new List<Actor> { neroActor });
            _world.SetActions(new List<Action> { drinkAction, torchAction, restAction });
            _world.SetFluents(new List<Fluent> { burnedFluent, entertainedFluent });
            _world.SetDomain(domain);

            _world.Build();



            _drinkRestTorchScenario = new Scenario();
            _drinkRestTorchScenario.AddScenarioStep(new ScenarioStep(drinkAction, neroActor));
            _drinkRestTorchScenario.AddScenarioStep(new ScenarioStep(restAction, neroActor));
            _drinkRestTorchScenario.AddScenarioStep(new ScenarioStep(torchAction, neroActor));

            _accessibleQueryGamma = new Negation(burnedFluent);
            _accessibleQueryPi = null;
        }

        [TestMethod]
        public void NeroEverExecutableQuery()
        {
            var query = new ScenarioEverExecutableQuery(_drinkRestTorchScenario);
            Assert.IsTrue(query.Evaluate(_world));
        }

        [TestMethod]
        public void NeroAlwaysExecutableQuery()
        {
            var query = new ScenarioAlwaysExecutableQuery(_drinkRestTorchScenario);
            Assert.IsTrue(query.Evaluate(_world));
        }

        [TestMethod]
        public void NeroEverAccessibleQuery()
        {
            var query = new AccessibleEverScenarioQuery(_accessibleQueryPi, _accessibleQueryGamma, _drinkRestTorchScenario);
            Assert.IsFalse(query.Evaluate(_world));
        }

        [TestMethod]
        public void NeroAlwaysAccessibleQuery()
        {
            var query = new AccessibleAlwaysScenarioQuery(_accessibleQueryPi, _accessibleQueryGamma, _drinkRestTorchScenario);
            Assert.IsFalse(query.Evaluate(_world));
        }

        [TestMethod]
        public void NeroTypicallyAccessibleQuery()
        {
            var query = new AccessibleTypicallyScenarioQuery(_accessibleQueryPi, _accessibleQueryGamma, _drinkRestTorchScenario);
            Assert.IsFalse(query.Evaluate(_world));
        }
    }
}
