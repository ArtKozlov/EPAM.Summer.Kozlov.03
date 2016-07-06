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
            "D:\\Epam\\EPAM.Summer.Kozlov.03\\MathNewton.Tests\\TestDoc.xml",
            "TestCase",
            DataAccessMethod.Sequential)]

        [TestMethod]
        public void SqrtTest()
        {
            double number = Convert.ToDouble(TestContext.DataRow["number"]);
            int power = Convert.ToInt32(TestContext.DataRow["power"]);
            double exp = Convert.ToDouble(TestContext.DataRow["exp"]);
            int actual = Convert.ToInt32(Sqrt(number,power,exp));
            int expected = Convert.ToInt32(TestContext.DataRow["ExpectedResult"]);

            Assert.AreEqual(expected, actual);
        }

         [TestMethod]
         [ExpectedException(typeof(Exception))]
        public void SqrtExeptionTest()
         {
             var number = Convert.ToDouble(TestContext.DataRow["number"]);
             var power = Convert.ToInt32(TestContext.DataRow["power"]);
             var exp = Convert.ToDouble(TestContext.DataRow["exp"]);
             Sqrt(number, power, exp);
         }
         
    }
}
