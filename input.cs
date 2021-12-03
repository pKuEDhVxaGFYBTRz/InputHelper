using System;
using System.Collections.Generic;
using System.Text;

// major.minor.patch
// version 2.0.2

namespace Input
{
    class Input
    {
        // input int values
        public static int InputInt(string prompt, string err = "invalid input", int maxValue = Int32.MaxValue, int minValue = Int32.MinValue)
        {
            int input;

            while (true)
            {
                Console.WriteLine(prompt);

                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine(err);
                    continue;
                }

                if ((input < minValue) || (input > maxValue))
                {
                    Console.WriteLine(err);
                    continue;
                }

                return input;
            }
        }

        // input string values
        public static string InputStr(string prompt, string err = "invalid input")
        {
            while (true)
            {
                Console.WriteLine(prompt);

                try
                {
                    return Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine(err);
                }
            }
        }

        // yes/no prompt
        public static bool InputYesNo(string prompt, string err = "invalid input", string append = " (y/n)")
        {
            string input;

            while (true)
            {
                Console.WriteLine(prompt + append);
                input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    return true;
                }

                if (input == "n")
                {
                    return false;
                }

                Console.WriteLine(err);
            }

        }
    }
}
