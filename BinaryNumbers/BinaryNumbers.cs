using System;
using System.Linq;
using System.Text;

namespace BinaryNumbers
{
    internal class BinaryNumbers
    {
        
        static void Main(String[] args)
        {
            int n = -1;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                PrintUsageInstructionsAndExit();
            }
            StringBuilder sb = new StringBuilder();
            while(n > 0) {
                sb.Insert(0, (byte) n % 2);
                n /= 2;
            }
            String binaryNumber = sb.ToString();
            Console.WriteLine(binaryNumber);
            var splitByOnes = binaryNumber.Split('0');
            Console.WriteLine(splitByOnes.Max(consecutiveOnes => consecutiveOnes.Length));
        }

        private static void PrintUsageInstructionsAndExit()
        {
            StringBuilder sb = new StringBuilder("Usage: <Number To Convert to Binary>\n");
            sb.Append("e.g:\n999999\n");
            sb.Append("NOTE: Number of must be within 1 & 1000000");
            Console.WriteLine(sb.ToString());
            Environment.Exit(1);
        }
        
    }
    
}
