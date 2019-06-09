using System;
namespace 位元計數器
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()),o = 0, q = 0; ;
            while (true) 
            {
                q = n % 2;                 
                n = n / 2;
                if (q == 1) o++;
                if (n == 1 || n == 0)
                {
                    o++;
                    break;
                }
            }            
            Console.WriteLine("The number of bits is "+o+".");
            Console.ReadKey();
        }
    }
}
