//using System;
//using KR.Main.Engine;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using KR.Main.Entities.Queries;
//using KR.Main.Entities.Conditions;
//using KR.Main.Entities;

//namespace KR.Test
//{
//    [TestClass]
//    public class AccessibleQueriesScenarioTest :AccessibleQueriesTest
//    {
//        private Scenario codeBillScenario;
//        private Scenario debugScenario;

//        public AccessibleQueriesScenarioTest()
//        {
//            world = CreateITWorld();
//            debugScenario = new Scenario();
//            debugScenario.AddScenarioStep(new ScenarioStep(refactor, Fred));
//            debugScenario.AddScenarioStep(new ScenarioStep(debug, Bill));
//            codeBillScenario = new Scenario();
//            codeBillScenario.AddScenarioStep(new ScenarioStep(debug, Fred));
//            codeBillScenario.AddScenarioStep(new ScenarioStep(code, Bill));
//        }
//        [TestMethod]
//        public void AccessibleAlwaysScenarioQuery()
//        {
//            var q1 = new AccessibleAlwaysScenarioQuery(new True(), cm, debugScenario);
//            var q2 = new AccessibleAlwaysScenarioQuery(new True(), cc, codeBillScenario);

//            var r1 = q1.Evaluate(world);
//            var r2 = q2.Evaluate(world);

//            Assert.AreEqual(r1, true);
//            Assert.AreEqual(r2, false);
//        }

//        [TestMethod]
//        public void AccessibleEverScenarioQuery()
//        {
//            var q1 = new AccessibleEverScenarioQuery(new True(), new Negation(cm), codeBillScenario);
//            var q2 = new AccessibleEverScenarioQuery(new True(), new Negation(cm), debugScenario);

//            var r1 = q1.Evaluate(world);
//            var r2 = q2.Evaluate(world);

//            Assert.AreEqual(r1, true);
//            Assert.AreEqual(r2, false);
//        }

//        [TestMethod]
//        public void AccessibleTypicallyScenarioQuery()
//        {
//            var q1 = new AccessibleAlwaysScenarioQuery(new True(), cm, debugScenario);
//            var q2 = new AccessibleAlwaysScenarioQuery(new True(), cc, codeBillScenario);

//            var r1 = q1.Evaluate(world);
//            var r2 = q2.Evaluate(world);

//            Assert.AreEqual(r1, true);
//            Assert.AreEqual(r2, false);
//        }
//    }
//}
