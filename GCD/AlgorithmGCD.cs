using System;
using System.Diagnostics;

namespace GCD
{
    public static class AlgorithmGCD
    {
        /// <summary>
        /// This method is the GCD of two numbers and displays the run-time program.
        /// </summary>
        /// <param name="runTime">the run-time program.</param>
        /// <returns>GCD of numbers./returns>
        public static int GetGCD(out long runTime, int firstNumber, int secondNumber)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int result = GCD(firstNumber, secondNumber);
            stopWatch.Stop();
            runTime = stopWatch.ElapsedTicks;
            return result;

        }
        /// <summary>
        /// This method is the GCD of two numbers binary and displays the run-time program.
        /// </summary>
        /// <param name="runTime">the run-time program.</param>
        /// <returns>GCD of numbers./returns>
        public static int GetSteinGCD(out long runTime, int firstNumber, int secondNumber)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int result = SteinGCD(firstNumber, secondNumber);
            stopWatch.Stop();
            runTime = stopWatch.ElapsedTicks;
            return result;

        }
        /// <summary>
        /// This method is the GCD of three numbers and displays the run-time program.
        /// </summary>
        /// <param name="runTime">the run-time program.</param>
        /// <returns>GCD of numbers./returns>
        public static int GetGCD(out long runTime, int firstNumber, int secondNumber, int thirdNumber)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            firstNumber = GCD(firstNumber, secondNumber);
            int result = GCD(firstNumber, thirdNumber);
            stopWatch.Stop();
            runTime = stopWatch.ElapsedTicks;
            return result;
        }
        /// <summary>
        /// This method is the GCD of three numbers binary and displays the run-time program.
        /// </summary>
        /// <param name="runTime">the run-time program.</param>
        /// <returns>GCD of numbers./returns>
        public static int GetSteinGCD(out long runTime, int firstNumber, int secondNumber, int thirdNumber)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            firstNumber = SteinGCD(firstNumber, secondNumber);
            int result = SteinGCD(firstNumber, thirdNumber);
            stopWatch.Stop();
            runTime = stopWatch.ElapsedTicks;
            return result;
        }
        /// <summary>
        /// This method is the GCD of numbers and displays the run-time program.
        /// </summary>
        /// <param name="runTime">the run-time program.</param>
        /// <returns>GCD of numbers./returns>
        public static int GetGCD(out long runTime, params int[] arrayOfNumbers)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int result = arrayOfNumbers[0];
            for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
            {
                result = GCD(result, arrayOfNumbers[i++]);
            }
            stopWatch.Stop();
            runTime = stopWatch.ElapsedTicks;
            return result;
        }
        /// <summary>
        /// This method is the GCD of numbers binary and displays the run-time program.
        /// </summary>
        /// <param name="runTime">the run-time program.</param>
        /// <returns>GCD of numbers./returns>
        public static int GetSteinGCD(out long runTime, params int[] arrayOfNumbers)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int result = arrayOfNumbers[0];
            for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
            {
                result = SteinGCD(result, arrayOfNumbers[i++]);
            }
            stopWatch.Stop();
            runTime = stopWatch.ElapsedTicks;
            return result;
        }

        private static int GCD(int firstNumber, int secondNumber)
        {

            if (firstNumber == secondNumber)
            {
                return firstNumber;
            }

            if (firstNumber == 1 || secondNumber == 1)
            {
                return 1;
            }

            if (firstNumber == 0 && secondNumber == 0)
            {
                throw new Exception("Invalid function arguments!");
            }

            if (firstNumber == 0)
            {
                return secondNumber;
            }

            if (secondNumber == 0)
            {
                return firstNumber;
            }

            if (firstNumber % secondNumber != 0)
            {
                return GCD(secondNumber, firstNumber % secondNumber);
            }
            
            return Math.Abs(secondNumber);
        }

        private static int SteinGCD(int firstNumber, int secondNumber)
        {
            
            if (firstNumber == secondNumber)
            {
                return firstNumber;
            }
            if (firstNumber == 1 || secondNumber == 1)
            {
                return 1;
            }

            if (firstNumber == 0 && secondNumber == 0) throw new Exception("Invalid function arguments!");

            if (firstNumber == 0)
            {
                return secondNumber;
            }

            if (secondNumber == 0)
            {
                return firstNumber;
            }
            if ((firstNumber % 2 == 0) && (secondNumber % 2 == 0))
            {
                return 2 * SteinGCD(firstNumber / 2, secondNumber / 2);
            }
            if ((firstNumber % 2 == 0) && (secondNumber % 2 != 0))
            {
                return SteinGCD(firstNumber / 2, secondNumber);
            }
            if ((firstNumber % 2 != 0) && (secondNumber % 2 == 0))
            {
                return SteinGCD(firstNumber, secondNumber / 2);
            }
            return SteinGCD(secondNumber, Math.Abs(firstNumber - secondNumber));
        }

    }
}
