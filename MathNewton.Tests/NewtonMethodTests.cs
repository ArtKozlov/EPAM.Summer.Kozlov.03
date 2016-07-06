using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static MathNewton.NewtonMethod;

namespace MathNewton.Tests
{
    [TestClass()]
    public class NewtonMethodTests
    {
        public TestContext TestContext { get; set; }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\TestCases.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("MathNewton.Tests\\TestCases.xml")]

        [TestMethod]
        public void SqrtTest()
        {
            var number = Convert.ToDouble(TestContext.DataRow["number"]);
            var power = Convert.ToInt32(TestContext.DataRow["power"]);
            var exp = Convert.ToDouble(TestContext.DataRow["exp"]);
            var actual = Sqrt(number,power,exp);
            var expected = Convert.ToDouble(TestContext.DataRow["ExpectedResult"]);

            Assert.AreEqual(expected, actual);
        }

         [TestMethod]
         public void SqrtExeptionTest()
         {
             var number = Convert.ToDouble(TestContext.DataRow["number"]);
             var power = Convert.ToInt32(TestContext.DataRow["power"]);
             var exp = Convert.ToDouble(TestContext.DataRow["exp"]);
             var actual = Convert.ToString(NewtonMethod.Sqrt(number, power, exp));
             var expected = Convert.ToString(TestContext.DataRow["ExpectedResult"]);

             Assert.AreEqual(expected, actual);
         }
         
    }
}
