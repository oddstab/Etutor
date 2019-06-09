using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST91_易__英文斷詞
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] n = Console.ReadLine().ToLower().Split(' ');
                List<string> Data = new List<string>();
                string dis = "";
                for (int i = 0; i < n.Length; i++)
                {
                    if (Data.Contains(n[i])) continue;
                    Data.Add(n[i]);
                }
                for (int i = 0; i < Data.Count; i++) dis += Data[i] + " ";
                Console.WriteLine(dis.TrimEnd(' '));
            }
        }
    }
}