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
    public class LampTest
    {
        [TestMethod]
        public void LightLampTest()
        {
            var domain = new Domain();
            var tom = new Actor("Tom");
            var lighted = new Fluent("lighted");
            var broken = new Fluent("broken");
            var turnOn = new Action("TurnOn");
            var turnOff = new Action("TurnOff");
            var throwDown = new Action("ThrowDown");
            var world = World.Instance;
            world.SetActions(new List<Action> { turnOn, turnOff, throwDown });
            world.SetFluents(new List<Fluent> { lighted, broken });
            world.SetActors(new List<Actor> { tom });
            domain.AddInitiallyClause(new Initially(new Conjunction(new Negation(broken), lighted)));
            domain.AddTypicallyCausesClause(new TypicallyCauses(throwDown, false, new List<Actor> { tom }, broken));
            domain.AddCausesClause(new Causes(turnOn, false, new List<Actor> { tom }, lighted));
            domain.AddCausesClause(new Causes(turnOff, false, new List<Actor> { tom }, new Negation(lighted)));
            domain.AddAlwaysClause(new Always(new Implication(lighted, new Negation(broken))));
            domain.AddPreservesClause(new Preserves(turnOn, false, new List<Actor> { tom }, broken, null));
            world.SetDomain(domain);
            world.Build();
            var scenario = new Scenario();
            scenario.AddScenarioStep(new ScenarioStep(throwDown, tom));
            scenario.AddScenarioStep(new ScenarioStep(turnOn, tom));

            var ever = new AccessibleEverScenarioQuery(new Conjunction(new Negation(broken), lighted), lighted, scenario);
            var resultEver = ever.Evaluate(world);

            var typically = new AccessibleTypicallyScenarioQuery(new Conjunction(new Negation(broken), lighted), lighted, scenario);
            var resultTypically = typically.Evaluate(world);

            var always = new AccessibleAlwaysScenarioQuery(new Conjunction(new Negation(broken), lighted), lighted, scenario);
            var resultAlways = always.Evaluate(world);

            Assert.AreEqual(resultEver, true);
            Assert.AreEqual(resultTypically, false);
            Assert.AreEqual(resultAlways, false);
        }
    }
}
