using System;
using static GCD.AlgorithmGCD;
using NUnit.Framework;


namespace GCD.NUnitTests
{
    public class AlgorithmGCDNUnitTests
    {
        [TestCase(1, 1, 1, 1)]
        [TestCase(0, 100, 0, 0)]
        [TestCase(99, 0, 0, 0)]
        [TestCase(101, 101, 101, 101)]

        [TestCase(78, 294, 570, 36)]
        public void GCDTest(int firstNumber, int secondNumber, int thirdNumber, int forthNumber)
        {
            long time;
            GetGCD(out time, firstNumber, secondNumber);
            GetGCD(out time, firstNumber, secondNumber, thirdNumber);
            GetGCD(out time, firstNumber, secondNumber, thirdNumber, forthNumber);
        }


        [TestCase(1, 1, 1, 1)]
        [TestCase(0, 100, 0, 0)]
        [TestCase(99, 0, 0, 0)]
        [TestCase(101, 101, 101, 101)]
        [TestCase(78, 294, 570, 36)]
        public void SteinGCDTest(int firstNumber, int secondNumber, int thirdNumber, int forthNumber)
        {
            long time;
            GetSteinGCD(out time, firstNumber, secondNumber);
            GetSteinGCD(out time, firstNumber, secondNumber, thirdNumber);
            GetSteinGCD(out time, firstNumber, secondNumber, thirdNumber, forthNumber);
        }
    }
}
