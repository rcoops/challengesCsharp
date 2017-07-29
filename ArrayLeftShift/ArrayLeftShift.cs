using System;
using System.Linq;
using System.Text;

namespace ArrayLeftShift
{
    internal class ArrayLeftShift
    {
        public static void Main(string[] args)
        {
            var arguments = Console.ReadLine()?.Split(' ');
            var input = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray();
            if (input == null || arguments == null || arguments.Length != 2)
            {
                PrintUsageInstructionsAndExit();
            }
            else
            {
                var arraySize = int.Parse(arguments[0]);
                var leftShift = int.Parse(arguments[1]);
                if(arraySize != input.Length)
                {
                    PrintUsageInstructionsAndExit();
                }
                int[] output = LeftShift(input, leftShift);
                Console.WriteLine(string.Join(" ", output));
            }
        }

        private static int[] LeftShift(int[] input, int leftShift)
        {
            int[] output = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                var adjustment = i - leftShift % input.Length;
                var newIndex = adjustment < 0 ? input.Length + adjustment : adjustment;
                output[newIndex] = input[i];
            }
            return output;
        }

        private static void PrintUsageInstructionsAndExit()
        {
            StringBuilder sb = new StringBuilder("Usage: <Array length> <Units to shift>\n");
            sb.Append("<Array elements>\ne.g:\n5 2\n1 2 3 4 5\n");
            sb.Append("NOTE: Number of elements must match length");
            Console.WriteLine(sb.ToString());
            Environment.Exit(1);
        }
        
    }
    
}
