using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GCD;

// После рефакторинга и добавления делегатов, тесты ниже не менял. Они в нерабочем состоянии. Смотреть NUnit тесты.
namespace GCD.Tests
{
    [TestClass]
    public class AlgorithmGCDTests
    {
        [TestMethod]
        public void GCDMethodTwoNumbers()
        {
            long time;
            var firstNumber = 78;
            var secondNumber = 294;
            int expected = 6;
            int actual = AlgorithmGCD.GetGCD(out time, firstNumber, secondNumber);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GCDMethodThreeNumbers()
        {
            long time;
            var firstNumber = 78;
            var secondNumber = 294;
            var thirdNumber = 570;
            int expected = 6;
            int actual = AlgorithmGCD.GetGCD(out time, firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GCDMethodArrayNumbers()
        {
            long time;
            int[] arr = {78, 294, 570, 36};
            int expected = 6;
            int actual = AlgorithmGCD.GetGCD(out time, arr);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GCDMethodOneNumberIsNull()
        {
            long time;
            var firstNumber = 0;
            var secondNumber = 294;
            int expected = 294;
            int actual = AlgorithmGCD.GetGCD(out time, firstNumber, secondNumber);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SteinGCDMethodTwoNumbers()
        {
            long time;
            var firstNumber = 78;
            var secondNumber = 294;
            int expected = 6;
            int actual = AlgorithmGCD.GetSteinGCD(out time, firstNumber, secondNumber);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SteinGCDMethodThreeNumbers()
        {
            long time;
            var firstNumber = 78;
            var secondNumber = 294;
            var thirdNumber = 570;
            int expected = 6;
            int actual = AlgorithmGCD.GetSteinGCD(out time, firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SteinGCDMethodArrayNumbers()
        {
            long time;
            int[] arr = { 78, 294, 570, 36 };
            int expected = 6;
            int actual = AlgorithmGCD.GetSteinGCD(out time, arr);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SteinGCDMethodOneNumberIsNull()
        {
            long time;
            var firstNumber = 78;
            var secondNumber = 0;
            int expected = 78;
            int actual = AlgorithmGCD.GetSteinGCD(out time, firstNumber, secondNumber);
            Assert.AreEqual(expected, actual);
        }

    }
}
