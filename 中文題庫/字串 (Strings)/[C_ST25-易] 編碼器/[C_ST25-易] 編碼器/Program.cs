using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST25_易__編碼器
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = Console.ReadLine();
            string zero = Console.ReadLine();
            Console.WriteLine(ip+"\n"+zero);
            string str = "s";
            int x = int.Parse(ip.Substring(1));
            if (x > 26) x %= 26;
            while (x < 0) x += 26;
            while (str != "")
            {
                string sub = ip.Substring(0, 1);
                if (zero == "1")
                {
                    if (sub == "+") sub = "-";
                    else sub = "+";
                }
                str = Console.ReadLine();
                char[] ASC = str.ToCharArray();
                switch (sub)
                {
                    case "-":
                        for (int i = 0; i < ASC.Length; i++)
                        {
                            if ((ASC[i] < 'a' || ASC[i] > 'z') && (ASC[i] < 'A' || ASC[i] > 'Z')) Console.Write(ASC[i]);
                            else if (ASC[i] >= 'a' && ASC[i] <= 'z')
                            {
                                if (ASC[i] - x < 'a') Console.Write((char)(123 - (x - (ASC[i] - 97))));
                                else Console.Write((char)(ASC[i] - x));
                            }
                            else
                            {
                                if (ASC[i] - x < 'A') Console.Write((char)(91 - (x - (ASC[i] - 65))));
                                else Console.Write((char)(ASC[i] - x));
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "+":
                        for(int i =0;i<ASC.Length; i++)
                        {
                            if ((ASC[i] < 'a' || ASC[i] > 'z') && (ASC[i] < 'A' || ASC[i] > 'Z')) Console.Write(ASC[i]);
                            else if (ASC[i] >= 'a' && ASC[i] <= 'z')
                            {
                                if (ASC[i] + x > 'z') Console.Write((char)(96+(x-(122-ASC[i]))));
                                else Console.Write((char)(ASC[i] + x));
                            }
                            else
                            {
                                if (ASC[i] + x > 'Z') Console.Write((char)(64 + (x - (90 -ASC[i]))));
                                else Console.Write((char)(ASC[i] + x));
                            }
                        }
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}