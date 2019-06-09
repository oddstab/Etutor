using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = Console.ReadLine();
            List<int> Data = new List<int>();
            for (int i = 0; i < ip.Length; i++)
            {
                for (int j = 1; j <= ip.Length - i; j++)
                {
                    int Yes = int.Parse(ip.Substring(i, j));
                    if (Pnum(Yes)) Data.Add(Yes);
                }
            }
            int[] prime = Data.ToArray();
            Array.Sort(prime);
            
            if (Data.Count == 0) Console.WriteLine("No prime found");
            else Console.WriteLine(prime[prime.Length - 1]);
            Console.ReadKey();
        }
        static bool Pnum(decimal x)
        {
            if (x == 1) return false;
            if (x == 2) return true;
            if (x % 2 == 0) return false;
            for (int i = 3; i <= Math.Pow((double)x, 1.0 / 2.0); i += 2)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
    }
}
