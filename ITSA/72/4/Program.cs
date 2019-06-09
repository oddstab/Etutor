using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    List<string> data = new List<string>();
                    string p = Console.ReadLine().ToLower();
                    int p_len = p.Length;
                    int n = int.Parse(Console.ReadLine());
                    string S = Console.ReadLine();
                    string content = Console.ReadLine();

                    int default_search = 0;
                    int index = 0;


                    while (true)
                    {

                        int start_index = content.ToLower().IndexOf(p, default_search);

                        string temp_L = content.Substring(0, start_index - 1);
                        string temp_R = content.Substring(start_index + p_len + 1);

                        string[] Larr = temp_L.Split();
                        Array.Reverse(Larr);
                        string larr = "";

                        int test = Larr.Length > n ? n : Larr.Length;
                        try//左邊
                        {
                            for (int i = test-1; i >= 0; i--)
                                larr += Larr[i] + " ";
                        }
                        catch { }
                        

                        string[] Rarr = temp_R.Split();
                        string rarr = "";
                        try
                        {
                            for (int i = 0; i < n; i++)
                                rarr += Rarr[i] + " ";
                        }
                        catch { }
                        data.Add((larr.ToLower() + p.ToUpper() + " " + rarr.ToLower()).Trim());

                        Console.WriteLine(data[index]);
                        index++;
                        //Console.WriteLine(temp_L);
                        //Console.WriteLine(temp_R + "\n");

                        default_search += start_index + p_len;
                    }

                }
                catch
                {
                    break;
                }
            }
        }
    }
}
