using System;

namespace MathLibrary
{
    /// <summary>
    /// A basic Math Help Library with a couple basic math functions that are not included in the C#Math Library
    /// </summary>
    public static class MathHelper
    {

        /// <summary>
        /// Returns the factorial result of an integer
        /// </summary>
        /// <param name="n">int n</param>
        /// <returns>Returns a double as the result</returns>
        static double Factorial(int n)
        {
            double answer = n;
            for (int i = n; i > 1; i--)
            {
                answer = answer * (i - 1);
            }
            return answer;
        }

        /// <summary>
        /// Returns how many subgroups of p elements can be combined in a group of n elements. 
        /// Note: This function needs the Factorial function to work.
        /// </summary>
        /// <param name="n">Int n Group</param>
        /// <param name="p">Int p subgroup elements</param>
        /// <returns></returns>
        static double NumberOfSubGroups(int n, int p)
        {
            double answer = 0;

            answer = Factorial(n) / (Factorial(p) * Factorial(n - p));

            return answer;
        }

        /// <summary>
        /// Returns the greatest common divisor between two integers
        /// </summary>
        /// <param name="m">int m</param>
        /// <param name="h">int h</param>
        /// <returns>Returns an integer x as the greatest common divisor</returns>
        static int GreatestCommonDivisor(int m, int h)
        {
            int x = 0;

            for (int i = m; i > 0; i--)

                if (m % i == 0 && h % i == 0)
                {
                    x = i;
                    return x;
                }
            return x;
        }

        /// <summary>
        /// Returns the lowest common multiple of two integers
        /// Note: This functions requires the GreatestCommonDivisor method to work
        /// </summary>
        /// <param name="a">int a</param>
        /// <param name="b">int b</param>
        /// <returns>Returns the lowest common multiple</returns>
        static int LowestCommonMultiple(int a, int b)
        {
            int lowestCM = 0;
            int greatestComDiv = GreatestCommonDivisor(a, b);

            lowestCM = a * (b / greatestComDiv);
            return lowestCM;
        }

        /// <summary>
        /// Returns an array containing the roots of a second degree equation.
        /// Note: The array contains three numbers, the first is the number of solutions, 
        /// and the next two are the solutions. If the number of solutions is 1, the third 
        /// number will be zero and should be ignored. 
        /// </summary>
        /// <param name="a">Double a: the x² index</param>
        /// <param name="b">Double b: the x index</param>
        /// <param name="c">Double c: the alone index</param>
        /// <returns></returns>
        static double[] SecondDegreeEquation(double a, double b, double c)
        {
            double delta = 0;
            double[] result = { 0, 0, 0 };
            double temp = 0;

            delta = Math.Pow(b, 2) - (4 * a * c);

            if (delta < 0)
            {
                return result;
            }
            else if (delta == 0)
            {
                temp = -b / (2 * a);
                result[0] = 1;
                result[1] = temp;
                return result;
            }
            else if (delta > 0)
            {
                temp = (-b + Math.Sqrt(delta)) / (2 * a);
                result[0] = 2;
                result[1] = temp;
                result[2] = (-b - Math.Sqrt(delta)) / (2 * a);
                return result;
            }

            return result;
        }


    }
}
