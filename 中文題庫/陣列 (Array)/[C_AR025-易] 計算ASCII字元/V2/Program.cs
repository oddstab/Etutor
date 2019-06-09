using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string ip = Console.ReadLine();
                List<string> Data = new List<string>();
                List<string> d2 = new List<string>();
                int len = 0;
                for (int i = 0; i < ip.Length; i++)
                {
                    len = 0;
                    string one = ip.Substring(i, 1);
                    for (int j = 0; j < ip.Length; j++)
                    {
                        string two = ip.Substring(j, 1);
                        if (one == two) len++;
                    }
                    Data.Add((int)Convert.ToChar(one) + " " + len);
                }
                foreach (string i in Data) if (!d2.Contains(i)) d2.Add(i);
                string[] display = d2.ToArray();

                for (int i = 0; i < display.Length; i++)
                {
                    for (int j = 1; j < display.Length - i; j++)
                    {

                        int i1 = int.Parse(display[j - 1].Substring(0, display[j - 1].IndexOf(" ")));
                        int i2 = int.Parse(display[j].Substring(0, display[j].IndexOf(" ")));
                        if (i2 > i1)
                        {
                            string temp;
                            temp = display[j - 1];
                            display[j - 1] = display[j];
                            display[j] = temp;
                        }
                    }
                }
                foreach (string i in display) Console.WriteLine(i);
            }
        }
    }
}
