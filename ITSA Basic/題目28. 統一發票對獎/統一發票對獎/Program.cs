using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 統一發票對獎
{
    class Program
    {
        public static string[] einvoice;
        public static int[] C;
        public static int[] SS = { 2000000, 200000, 40000, 10000, 4000, 1000, 200 };
        static void Main(string[] args)
        {
            while (true)
            {
                C = new int[7];
                einvoice = new string[4];
                for (int i = 0; i < 4; i++) einvoice[i] = Console.ReadLine();
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    TotalMoney(Console.ReadLine());
                }
                string str = C[6] + " " + C[5] + " " + C[4] + " " + C[3] + " " + C[2] + " " + C[1] + " " + C[0];
                Console.WriteLine(str);
                Console.WriteLine(mo(str));
            }
        }
        static void TotalMoney(string M)
        {
            int Money = 0;
            if (M == einvoice[0]) { C[6]++; return; }//四個都跑完 在比較金額 return最大的回去
            for (int P = 1; P < 4; P++)             // if $$小於之前的或一樣就不取代 ，如果大於原來$$就取代
                                                    // ex. 10000 > 200 取代 
            {
                if (M == einvoice[P]) { C[5]++; return; }
                for (int j = 1, a = 4; j < 6; j++, a--)
                {
                    if (M.Substring(j) == einvoice[P].Substring(j))
                    {
                        Money = Money < SS[j + 1] ? SS[j + 1] : Money;
                    }
                }
            }
            int[] QQ = { 200, 1000, 4000, 10000, 40000 };
            for (int i = 0; i <= 4; i++)
            {
                if (Money == QQ[i]) { C[i]++; return; }
            }

            // c6 c5  c4 c3 c2 c1 c0
            // 2m 20w 4w 1w 4k 1k 200
        }
        static int mo(string x)
        {
            int sum = 0;
            int[] MWK = new int[7];
            int[] Twohudery = { 2000000, 200000, 40000, 10000, 4000, 1000, 200 };
            for (int i = 0, o = 0; i < x.Length; i += 2, o++) MWK[o] = int.Parse(x.Substring(i, 1));
            for (int i = 0; i < 7; i++)
            {
                sum += MWK[i] * Twohudery[i];
            }
            return sum;
        }
    }
}