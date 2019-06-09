using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.文字接龍
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int xx = int.Parse(Console.ReadLine());
                for (int i = 0; i < xx; i++)
                {
                    string n = Console.ReadLine();
                    string str = n;
                    char[] cc;
                    string display = "";
                    while (str != "")
                    {
                        if (str.Length > 1000) break;
                        switch (str.Substring(0, 1))
                        {
                            case "a":
                                display += "a";
                                str = str.Substring(1, str.Length - 1);
                                cc = str.ToCharArray();
                                Array.Reverse(cc);
                                str = new string(cc);
                                break;

                            case "b":
                                display += "b";
                                str = str.Substring(1, str.Length - 1);
                                str += str.Substring(0, str.Length);
                                break;

                            case "c": //問題出在c
                                display += "c";
                                if (str.Length == 1||str.Length==2||str.Length==3)
                                {
                                    str = "";
                                    break;
                                }
                                str = str.Remove(0,3);
                                break;

                            default:
                                display+=str.Substring(0, 1);
                                char x = Convert.ToChar(str.Substring(0, 1));
                                str = str.Substring(1, str.Length - 1);
                                break;
                        }
                    }
                    Console.WriteLine(display);
                }
            }
        }
    }
}
