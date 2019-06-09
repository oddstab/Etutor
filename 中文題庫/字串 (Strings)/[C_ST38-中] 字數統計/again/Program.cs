using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace again
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = "";
            string Input;
            int Cou = 0;
            do
            {
                Input = Console.ReadLine();
                ip += Input + " ";
                Cou++;

            } while (Input != "" && Cou != 4);
            List<string> Split = new List<string>();
            List<string> Repeat = new List<string>();
            string str = ""; char sub = ' ';
            for (int i = 0, a = 0; i < ip.Length; i++)
            {
                sub = Convert.ToChar(ip.Substring(i, 1));
                if ((sub >= 65 && sub <= 90) || (sub >= 97 && sub <= 122) || (sub >= 48 && sub <= 57))
                {
                    str += sub.ToString();
                    if (i != ip.Length - 1) continue;
                }
                if (str == "") continue;
                Split.Add(str);
                str = "";
                a++;
            }
            int c = 0;
            for (int i = 0; i < Split.Count; i++)
            {
                c = 0;
                if (Repeat.Contains(Split[i].ToLower())) continue;
                for (int j = 0; j < Split.Count; j++)
                {
                    if (Split[i].ToLower() == Split[j].ToLower()) c++;
                }
                Console.WriteLine(Split[i] + " : " + c);
                Repeat.Add(Split[i].ToLower());
            }
        }
    }
}