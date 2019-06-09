using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 複數運算
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int ip = int.Parse(Console.ReadLine());
                string[] sp = new string[5];
                int[] spint = new int[4];
                for (int i = 0; i < ip; i++)
                {
                    sp = Console.ReadLine().Split(' ');
                    for (int k = 0;  k <4; k++)
                    {
                        spint[k] = int.Parse(sp[k+1]);
                    }
                          /*   spint[0] A
                                spint[1] B
                                spint[2] C
                                spint[3] D  */
                    switch (sp[0])
                    {
                        case "+"://                           (a+c)           +         (b+d)
                            Console.WriteLine((spint[0] + spint[2]) + " " + (spint[1] + spint[3]));
                            break;
                        case "-"://                            (a-c)            +         (b-d)
                            Console.WriteLine((spint[0] - spint[2]) + " " + (spint[1] - spint[3]));
                        break;
                        case "*":                       //(A*C)-(B*D)         (B*C)+(A*D)
                            Console.WriteLine((spint[0] * spint[2]) - (spint[1] * spint[3])+ " " +(  ((spint[1] * spint[2])+ (spint[0] * spint[3]))));
                            break;
                    }
                }
            }
        }
    }
}
