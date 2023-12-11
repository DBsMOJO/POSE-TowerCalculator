/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3.ACIF
 *--------------------------------------------------------------
 *              Daniel Binder, 27.11.2023
 *--------------------------------------------------------------
 * Description:
 * A program that based on an input Generate pyramid of numbers
 *--------------------------------------------------------------
*/

using System;

namespace TowerCalculator
{
    class Program
    {
        public static void Main()
        {
            string input;
            long runner;

            // Entry
            Console.Clear();
            Console.WriteLine("Pyramid of Numbers");
            Console.WriteLine("==================");

            do
            {
                // Input
                Console.WriteLine();
                Console.Write("Please enter number: ");
                input = Console.ReadLine();
                Console.WriteLine();
                runner = Convert.ToInt64(input);

                // Process, Output
                if (runner != 0)
                {
                    for (int i = 2; i <= 9; ++i)
                    {
                        Console.Write("{0} * {1} = ", runner, i);
                        runner *= i;
                        Console.WriteLine("{0}", runner);
                    }
                    for (int i = 2; i <= 9; ++i)
                    {
                        Console.Write("{0} / {1} = ", runner, i);
                        runner /= i;
                        Console.WriteLine("{0}", runner);
                    }
                }
            } while (runner != 0);
        }
    }
}
