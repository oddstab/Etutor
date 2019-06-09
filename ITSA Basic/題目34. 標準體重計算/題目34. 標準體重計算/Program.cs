using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 題目34.標準體重計算
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] t = Console.ReadLine().Split(' ');
                switch (t[1])
                {
                    case "1":
                        Console.WriteLine(((double.Parse(t[0]) - 80) * 0.7).ToString("f1"));
                        break;
                    case "2":
                        Console.WriteLine(((double.Parse(t[0]) - 70) * 0.6).ToString("f1"));
                        break;
                }
            }           
        }
    }
}
