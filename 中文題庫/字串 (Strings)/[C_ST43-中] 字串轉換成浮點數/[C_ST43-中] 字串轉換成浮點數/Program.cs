using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST43_中__字串轉換成浮點數
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                while (true)
                {
                    string str = Console.ReadLine().ToUpper();
                    if (str.Substring(0, 1) != "-")
                    {
                        Console.WriteLine(Convert.ToDouble(str));

                    }
                    else
                    {
                        // -0.00001234 則表示為 -1.234e-5
                        //-1.2345e6
                        str = str.Replace("+", "");
                        str = str.Replace("-", "");
                        string zero = "";
                        string integer = "";
                        int Eindex = str.IndexOf("E");
                        if (Eindex == -1) Console.WriteLine("-" + Convert.ToDouble(str));
                        else
                        {
                            zero = zero.PadLeft(int.Parse(str.Substring(Eindex + 1)), '0');
                            integer = str.Substring(0, Eindex).Replace(".", "");
                            Console.WriteLine(zero.Insert(0, "-").Insert(2, ".") + integer);
                        }
                    }
                }
            }
        }
    }
}
