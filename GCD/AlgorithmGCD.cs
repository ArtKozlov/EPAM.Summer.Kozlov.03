using System;
using System.Diagnostics;

namespace GCD
{
    public static class AlgorithmGCD
    {

        private static int DelegateMethod(Func<int, int, int> GCD, out long runTime, params int[] arrayOfNumbers)
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
        /// This method is the GCD of two numbers and displays the run-time program.
        /// </summary>
        /// <param name="runTime">the run-time program.</param>
        /// <returns>GCD of numbers.</returns>
        public static int GetGCD(out long runTime, int firstNumber, int secondNumber) 
            => DelegateMethod(CalculateGCD, out runTime,firstNumber, secondNumber);

        /// <summary>
        /// This method is the GCD of three numbers and displays the run-time program.
        /// </summary>
        /// <param name="runTime">the run-time program.</param>
        /// <returns>GCD of numbers.</returns>
        public static int GetGCD(out long runTime, int firstNumber, int secondNumber, int thirdNumber) 
            => DelegateMethod(CalculateGCD, out runTime, firstNumber, secondNumber, thirdNumber);

        /// <summary>
        /// This method is the GCD of numbers and displays the run-time program.
        /// </summary>
        /// <param name="runTime">the run-time program.</param>
        /// <returns>GCD of numbers.</returns>
        public static int GetGCD(out long runTime, params int[] arrayOfNumbers)
            => DelegateMethod(CalculateGCD, out runTime, arrayOfNumbers);


        #region Get Stein GCD

        /// <summary>
        /// This method is the GCD of two numbers binary and displays the run-time program.
        /// </summary>
        /// <param name="runTime">the run-time program.</param>
        /// <returns>GCD of numbers.</returns>
        public static int GetSteinGCD(out long runTime, int firstNumber, int secondNumber)
            => DelegateMethod(CalculateSteinGCD, out runTime, firstNumber, secondNumber);
        /// <summary>
        /// This method is the GCD of three numbers binary and displays the run-time program.
        /// </summary>
        /// <param name="runTime">the run-time program.</param>
        /// <returns>GCD of numbers.</returns>
        public static int GetSteinGCD(out long runTime, int firstNumber, int secondNumber, int thirdNumber)
            => DelegateMethod(CalculateSteinGCD, out runTime, firstNumber, secondNumber, thirdNumber);
        /// <summary>
        /// This method is the GCD of numbers binary and displays the run-time program.
        /// </summary>
        /// <param name="runTime">the run-time program.</param>
        /// <returns>GCD of numbers.</returns>
        public static int GetSteinGCD(out long runTime, params int[] arrayOfNumbers)
            => DelegateMethod(CalculateSteinGCD, out runTime, arrayOfNumbers);

        #endregion

        private static int CalculateGCD(int firstNumber, int secondNumber)
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

        private static int CalculateSteinGCD(int firstNumber, int secondNumber)
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
