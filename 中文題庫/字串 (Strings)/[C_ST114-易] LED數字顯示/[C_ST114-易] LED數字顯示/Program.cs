using System;

namespace _C_ST114_易__LED數字顯示
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            while (true)
            {
                string s = Console.ReadLine();
                if (s == null) break;
                str += s;
            }
            while (str.Length % 8 != 0) str += "0";
            for (int i = 0, len = str.Length / 8; i < len; i++)
            {
                string temp = "";
                for (int j = 0; j < 8; j++)
                {
                    temp += str[0];
                    str = str.Remove(0, 1);
                }
                Console.WriteLine(Convert.ToInt32(temp, 2));
            }
        }
    }
}