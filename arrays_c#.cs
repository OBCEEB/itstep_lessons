using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarr1_1;
            myarr1_1 = new int[4];
            myarr1_1[0] = 1;
            myarr1_1[1] = 4;
            myarr1_1[2] = 3;
            myarr1_1[3] = 6;
            int[] myarr1_2 = new int[4] { 1, 4, 3, 6 };
            int[] myarr1_3 = new int[] { 1, 4, 3, 6 };
            int[] myarr1_4 = new[] { 1, 4, 3, 60};
            int[] myarr1_5 = { 1, 4, 3, 6 };
            
            foreach(int n in myarr1_4)
            {
                Console.WriteLine("{0}",n);
            }
            Console.WriteLine("elem num {0}", myarr1_5.Count());
            Console.WriteLine("first elem {0}", myarr1_5.ElementAt(0));
            Console.WriteLine("type {0}", myarr1_5.GetType());
            Console.WriteLine("third {0}", myarr1_5.GetValue(2));
            Console.WriteLine("first {0}", myarr1_5.First());
            Console.WriteLine("last {0}", myarr1_5.Last());
            Console.WriteLine("len {0}", myarr1_5.Length);
            Console.WriteLine("max {0}", myarr1_5.Max());
            Console.WriteLine("min {0}", myarr1_5.Min());
            Console.WriteLine("rank {0}", myarr1_5.Rank);
            Console.ReadKey();
        }
    }
}
