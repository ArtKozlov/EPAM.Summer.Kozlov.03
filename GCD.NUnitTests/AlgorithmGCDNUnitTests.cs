using System;
using static GCD.AlgorithmGCD;
using NUnit.Framework;


namespace GCD.NUnitTests
{
    public class AlgorithmGCDNUnitTests
    {
        [TestCase(1, 1, 1, 0, Result = 1)]
        [TestCase(99, 0, 0, 0, Result = 99)]
        [TestCase(101, 101, 101, 101, Result = 101)]
        [TestCase(78, 294, 570, 36, Result = 6)]
        public int GCDTest(int firstNumber, int secondNumber, int thirdNumber, int forthNumber)
        {
            long time;
            GetGCD(CalculateGCD, out time, firstNumber, secondNumber);
            GetGCD(CalculateGCD, out time, firstNumber, secondNumber, thirdNumber);
            return GetGCD(CalculateGCD, out time, firstNumber, secondNumber, thirdNumber, forthNumber);
        }


        [TestCase(1, 1, 1, 1, Result = 1)]
        [TestCase(99, 0, 0, 0, Result = 99)]
        [TestCase(101, 101, 101, 101, Result = 101)]
        [TestCase(78, 294, 570, 36, Result = 6)]
        public int SteinGCDTest(int firstNumber, int secondNumber, int thirdNumber, int forthNumber)
        {
            long time;
            GetGCD(CalculateSteinGCD, out time, firstNumber, secondNumber);
            GetGCD(CalculateSteinGCD, out time, firstNumber, secondNumber, thirdNumber);
            return GetGCD(CalculateSteinGCD, out time, firstNumber, secondNumber, thirdNumber, forthNumber);
        }
    }
}
