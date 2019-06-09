using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_SO25_易__判斷序列是否經過排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int g = 0; g < n; g++)
            {
                string str = Console.ReadLine();
                string[] input = str.Split(',');
                string asc = "";
                string desc = "";
                int[] DA = new int[input.Length];
                for (int i = 0; i < input.Length; i++){
                    DA[i] = int.Parse(input[i]);
                }
                Array.Sort(DA);
                for(int i = 0;i<DA.Length; i++){
                    asc += DA[i];
                }
                Array.Reverse(DA);
                for(int i = 0;i<DA.Length; i++) {
                    desc += DA[i];
                }
                if (asc == str.Replace(",", "")) Console.WriteLine("ASC");
                else if (desc == str.Replace(",", "")) Console.WriteLine("DESC");
                else Console.WriteLine("NOON");
            }
        }
    }
}