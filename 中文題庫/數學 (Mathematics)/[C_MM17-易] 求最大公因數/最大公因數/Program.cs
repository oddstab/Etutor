using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
  
namespace 最大公因數V2  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            while (true)  
            {  
                string[] o = Console.ReadLine().Split(' ');  
                int G1 = int.Parse(o[0]);  
                int G2 = int.Parse(o[1]);  
                int GC = 0;  
                if (G1 < 0) G1 = -G1;  
                if (G2 < 0) G2 = -G2;  
                while (G2 != 0)  
                {  
                    GC = G2;  
                    G2 = G1 % G2;  
                    G1 = GC;  
                }  
                Console.WriteLine(G1);  
            }  
        }  
    }  
}  