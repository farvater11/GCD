using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
	//TEST FOR GIT
	// TEST FOR GIT 2
    class Program
    {
        static int iteration;
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int c = a % b; // a mod b
                Console.WriteLine(
                    string.Format("{0}", a.ToString().PadLeft(6, ' '))
                    + "  mod  " + 
                    string.Format("{0}", b.ToString().PadRight(6, ' '))
                    + " = " +
                    string.Format("{0}", c.ToString().PadRight(6, ' '))
                    );
                if(c != 0)
                {
                    Console.WriteLine("        ____/        / ");
                    Console.WriteLine("       /      ______/ ");
                    Console.WriteLine("      /      / ");

                }
                a = b;           
                b = c;
                iteration++;
            }
            return Math.Abs(a);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("==== GCD finding ====");
            Console.Write("Input 1st number: ");
            string a = Console.ReadLine();
            Console.Write("Input 2nd number: ");
            string b = Console.ReadLine();
            Console.WriteLine("\n==== Calculation ====");
            int res = GCD(int.Parse(a), int.Parse(b));

            Console.WriteLine("\n==== Result ====");
            Console.WriteLine("Number of iterations = " + iteration.ToString());
            Console.WriteLine("GCD (" + a + ","+ b +") = " + res.ToString());
            Console.ReadKey();
        }
    }
}
