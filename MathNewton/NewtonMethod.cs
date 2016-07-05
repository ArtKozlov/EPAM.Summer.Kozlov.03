using System;


namespace MathNewton
{
    public class NewtonMethod
    {
        /// <summary>
        /// This method is the root of a certain degree of number.
        /// </summary>
        /// <param name="number">the number of which is the degree of.</param>
        /// <param name="power">root level.</param>
        /// <param name="e">the accuracy of determining the number of.</param>
        /// <returns>root of number./returns>
        public static double Sqrt(double number, int power, double e)
        {
            double rootPref = 0;
            double rootNext = 1;

            if (number <= 0 && power%2!=0 || e <= 0 || e > 1)
            {
                throw new Exception("Invalid function arguments!");
            }

            while (Math.Abs(rootNext - rootPref) >= e)
            {
                rootPref = rootNext;
                rootNext = (1.0 / power) * ((power - 1) * rootPref + number / Math.Pow(rootPref, power - 1));

            }

            return rootNext;
        }

    }
}
