using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_ST35_易__抱怨值問題
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                str = str.Replace(" ","");
                string[] SP = str.Split(',');
                int sum = 0;
                for(int i = 1;i<SP.Length; i++)
                {
                    for(int j =0;j<SP.Length-i; j++)
                    {
                        if (int.Parse(SP[SP.Length - i]) < int.Parse(SP[j])) sum++;
                    }
                }
                Console.WriteLine("Complaint ="+sum);
            }
        }
    }
}
