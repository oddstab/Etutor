using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身分證驗證V2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string jxx = Console.ReadLine();//J123456789
                int[] abcint = new int[26];//英文對應數字
                for (int i = 0, abint = 10; i < 26; i++, abint++) abcint[i] = abint;//身分證對應數字 >> 10....35
                string[] abc = {"A","B", "C", "D", "E", "F", "G", "H","J", "K", "L", "M",
                                "N","P", "Q", "R", "S", "T", "U", "V", "X"
                                ,"Y","W","Z","I","O"};
                int[] n = new int[9], X = new int[2];//J"(123456789)"
                int FirstEng = 0, P = 1;

                for (int i = 0; i < 26; i++)
                {
                    if (jxx.Substring(0, 1) == abc[i]) FirstEng = abcint[i];
                }

                X[0] = int.Parse(FirstEng.ToString().Substring(0, 1));//EX.1
                X[1] = int.Parse(FirstEng.ToString().Substring(1));   //EX.8
                for (int i = 0; i < 9; i++)
                {
                    n[i] = int.Parse(jxx.Substring(i + 1, 1));//拆出9個數字 開始verify
                }
                P = X[0] + (9 * X[1]) + (8 * n[0]) + (7 * n[1]) + (6 * n[2]) + (5 * n[3]) + (4 * n[4]) + (3 * n[5]) + (2 * n[6]) + n[7] + n[8];
                if (P % 10 == 0) Console.WriteLine("Yes");
                else Console.WriteLine("No");
            }
        }
    }
}
