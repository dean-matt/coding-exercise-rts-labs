using System;
using System.Collections.Generic;

namespace coding_exercise_rts_labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                return;
            }



            if (args[0].StartsWith("["))
            {
                string[] parsedArg = args[0].Trim('[', ']', ' ').Split(',');

                int[] integers = new int[parsedArg.Length];

                for (int i = 0; i < parsedArg.Length; i++)
                {
                    integers[i] = int.Parse(parsedArg[i]);
                }

                Dictionary<string, int> result = aboveBelow(integers, int.Parse(args[1]));

                Console.WriteLine("aboveBelow:");
                Console.WriteLine("{");

                foreach (KeyValuePair<string, int> pair in result)
                {
                    Console.WriteLine($"\"{pair.Key}\": {pair.Value}");
                }

                Console.WriteLine("}");
            }
        }

        static Dictionary<string, int> aboveBelow(int[] array, int comparisonValue)
        {
            // How to solve:
            // - Compare the values in array to comparisonValue
            //   - Save the value if is above or below comparisonValue
            //
            // Edge Cases:
            // - array conains no values that are above comparisonValue
            // - array contains no values that are below comparisonValue
            // - array contains no values that are above or below comparisonValue
            // - array contains no values
            // - array contains a single value

            return new Dictionary<string, int>();
        }
    }
}