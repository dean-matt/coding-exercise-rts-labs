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

        static Dictionary<string, int> aboveBelow(int[] integers, int value)
        {
            return new Dictionary<string, int>();
        }
    }
}