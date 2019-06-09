using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST60_中__解密碼
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string ip = Console.ReadLine().Replace("\\n", " ");
                string temp = "";
                bool Yesint = false;

                List<int> Password = new List<int>();
                for (int i = 0; i < ip.Length; i++)
                {
                    if (Isint(ip.Substring(i, 1)) == true)
                    {
                        temp += ip.Substring(i, 1);
                        Yesint = true;
                        if (i != ip.Length - 1)
                        {
                            continue;
                        }
                    }
                    if (Yesint == true)
                    {
                        temp = Reverse(temp);
                        Password.Add(int.Parse(temp));
                        temp = "";
                        Yesint = false;
                    }
                }
                Console.WriteLine(Password.Sum());
            }           
        }
        static bool Isint(string m)
        {
            try
            {
                int.Parse(m);
                return true;
            }
            catch
            {
                return false;
            }
        }
        static string Reverse(string x)
        {
            if (x.Length == 1) return x;
            else
            {
                char[] t = x.ToCharArray();
                Array.Reverse(t);
                return new string(t);
            }
        }
    }
}