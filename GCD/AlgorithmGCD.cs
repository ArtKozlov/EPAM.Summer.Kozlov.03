using System;
using System.Diagnostics;

namespace GCD
{
    public static class AlgorithmGCD
    {
        public delegate int Calculator(int lhs, int rhs);
        /// <summary>
        /// This method is the GCD of two numbers and displays the run-time program.
        /// </summary>
        /// <param name="runTime">the run-time program.</param>
        /// <returns>GCD of numbers./returns>
        public static int GetGCD(Calculator GCD, out long runTime, int firstNumber, int secondNumber)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int result = GCD(firstNumber, secondNumber);
            stopWatch.Stop();
            runTime = stopWatch.ElapsedTicks;
            return result;

        }

        /// <summary>
        /// This method is the GCD of three numbers and displays the run-time program.
        /// </summary>
        /// <param name="runTime">the run-time program.</param>
        /// <returns>GCD of numbers./returns>
        public static int GetGCD(Calculator GCD, out long runTime, int firstNumber, int secondNumber, int thirdNumber)
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
        /// This method is the GCD of numbers and displays the run-time program.
        /// </summary>
        /// <param name="runTime">the run-time program.</param>
        /// <returns>GCD of numbers./returns>
        public static int GetGCD(Calculator GCD, out long runTime, params int[] arrayOfNumbers)
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


        public static int CalculateGCD(int firstNumber, int secondNumber)
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
                return CalculateGCD(secondNumber, firstNumber % secondNumber);
            }
            
            return Math.Abs(secondNumber);
        }
#region Get Stein GCD
        /*
        /// <summary>
        /// This method is the GCD of two numbers binary and displays the run-time program.
        /// </summary>
        /// <param name="runTime">the run-time program.</param>
        /// <returns>GCD of numbers./returns>
        public static int GetSteinGCD(out long runTime, int firstNumber, int secondNumber)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int result = CalculateSteinGCD(firstNumber, secondNumber);
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
            firstNumber = CalculateSteinGCD(firstNumber, secondNumber);
            int result = CalculateSteinGCD(firstNumber, thirdNumber);
            stopWatch.Stop();
            runTime = stopWatch.ElapsedTicks;
            return result;
        }
        public static int GetSteinGCD(out long runTime, params int[] arrayOfNumbers)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int result = arrayOfNumbers[0];
            for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
            {
                result = CalculateSteinGCD(result, arrayOfNumbers[i++]);
            }
            stopWatch.Stop();
            runTime = stopWatch.ElapsedTicks;
            return result;
        }
        */
#endregion
        public static int CalculateSteinGCD(int firstNumber, int secondNumber)
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
                return 2 * CalculateSteinGCD(firstNumber / 2, secondNumber / 2);
            }
            if ((firstNumber % 2 == 0) && (secondNumber % 2 != 0))
            {
                return CalculateSteinGCD(firstNumber / 2, secondNumber);
            }
            if ((firstNumber % 2 != 0) && (secondNumber % 2 == 0))
            {
                return CalculateSteinGCD(firstNumber, secondNumber / 2);
            }
            return CalculateSteinGCD(secondNumber, Math.Abs(firstNumber - secondNumber));
        }

    }
}
