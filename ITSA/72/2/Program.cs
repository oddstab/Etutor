using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    bool flag = true;
                    int[] count = new int[11200];
                    string[] data = Console.ReadLine().Split();
                    int len = data.Length;

                    for (int i = 0; i < len; i++)
                        count[int.Parse(data[i])]++;

                    for (int i = 0; i < count.Length; i++)
                    {
                        if (count[i] > (len / 2))
                        {
                            flag = false;
                            Console.WriteLine(i);
                            break;
                        }
                    }
                    Console.Write(flag?"n/a\n":"");
                }
                catch
                {
                    break;
                }
            }
        }
    }
}
