using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 電話費計算
{
    class Program
    {
        static void Main(string[] args)
        { 
            int oo = int.Parse(Console.ReadLine());
            if (oo <= 800) Console.WriteLine((oo*0.9).ToString("#.0"));
            if (oo > 800 && oo < 1500) Console.WriteLine(((oo*0.9)*0.9).ToString("#.0"));
            if (oo >= 1500) Console.WriteLine(((oo*0.9)*0.79).ToString("#.0"));
            Console.ReadKey();
        }
    }
}
