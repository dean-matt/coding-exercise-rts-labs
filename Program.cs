using System;
using System.Collections.Generic;

namespace coding_exercise_rts_labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <= 2 && args[0].StartsWith("["))
            {
                string[] parsedArg = new string[args.Length - 1];

                for (int i = 0; i < args.Length - 1; i++)
                {
                    parsedArg[i] = args[i].Trim('[', ']', ',', ' ');
                }

                int[] integers = new int[parsedArg.Length];

                for (int i = 0; i < parsedArg.Length; i++)
                {
                    integers[i] = int.Parse(parsedArg[i]);
                }

                Dictionary<string, int> result = aboveBelow(integers, int.Parse(args[args.Length - 1]));

                Console.WriteLine("aboveBelow:");
                Console.WriteLine("{");

                foreach (KeyValuePair<string, int> pair in result)
                {
                    Console.WriteLine($"\"{pair.Key}\": {pair.Value}");
                }

                Console.WriteLine("}");
            }
            else if (args.Length == 2)
            {
                string result = stringRotation(args[0], int.Parse(args[1]));
            }
            else
            {
                Console.WriteLine($"Input was not in either of the expected formats");
            }
        }

        static Dictionary<string, int> aboveBelow(int[] array, int comparisonValue)
        {
            // How to solve:
            // - Compare the values in array to comparisonValue
            //   - Increment counters if the value is above or below comparisonValue
            //
            // Edge Cases:
            // - array conains no values that are above comparisonValue
            // - array contains no values that are below comparisonValue
            // - array contains no values that are above or below comparisonValue
            // - array contains no values
            // - array contains a single value

            Dictionary<string, int> result = new Dictionary<string, int>();

            result.Add("above", 0);
            result.Add("below", 0);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > comparisonValue)
                {
                    result["above"]++;
                }
                else if (array[i] < comparisonValue)
                {
                    result["below"]++;
                }
            }

            return result;
        }

        static string stringRotation(string value, int rotationAmount)
        {
            // How to solve:
            // - Retrieve and saved part of value to rotate
            // - Build result from saved part and original string
            //
            // Edge Cases:
            // - rotationAmount is greater than the length of the string
            // - value is null or empty
            // - value has a length of 1

            return string.Empty;
        }
    }
}