using System;
using NUnit.Framework;
using static Task03.BinaryOperation;


namespace Task03.NUnitTests
{
    public class BinaryOperationTests
    {
        [TestCase(20, 2, 2, 3, Result = 28)]
        [TestCase(20, 4, 0, 3, Result = 20)]
        [TestCase(20, 10, 5, 7, Result = 84)]
        [TestCase(20, 1, 1, 3, Result = 22)]
        public int InsertBinaryNumber_Positive(int firstNum, int secondNum, int firstBit, int lastBit)
        {
            return InsertBinaryNumber(firstNum, secondNum, firstBit, lastBit);
        }

        [TestCase(20, 2, -5, 3, ExpectedException = typeof(ArgumentException))]
        [TestCase(20, 4, 33, 3, ExpectedException = typeof(ArgumentException))]
        [TestCase(20, 10, 5, 90, ExpectedException = typeof(ArgumentException))]
        [TestCase(20, 1, 1, -10, ExpectedException = typeof(ArgumentException))]
        public int InsertBinaryNumber_Negative(int firstNum, int secondNum, int firstBit, int lastBit)
        {
            return InsertBinaryNumber(firstNum, secondNum, firstBit, lastBit);
        }
    }
}
