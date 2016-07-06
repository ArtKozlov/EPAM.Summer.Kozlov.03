using System;
using static MathNewton.NewtonMethod;
using NUnit.Framework;

namespace MathNewton.NUnitTests
{
    public class NewtonMethodNUnitTests
    {
        [TestCase(16,2,0.01)]
        [TestCase(16, 2, 0.000000001)]
        [TestCase(16, 0, 0.01)]
        [TestCase(16, 3, 0.01)]
        public double SqrtTest(double number, int power, double e)
        {
            return Sqrt(number,power,e);
        }

        [TestCase(-16, 3, 0.01)]
        [TestCase(16, 3, 2)]
        [TestCase(16, 3, -1)]
        public void SqrtExeptionTest(double number, int power, double e)
        {
            Assert.Throws<Exception>(() => Sqrt(number, power, e));
        }
    }
}
