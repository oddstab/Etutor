using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR106_易__李白的鳳凰臺密碼
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phoenix = new List<string>();
            List<int> pint = new List<int>();
            string ni,nj,n1,n2,nj1,sub;
            //前
            //1468+149=1260+357
            for (int i = 1000; i < 10000; i++)
            {
                ni = i.ToString();
                n1 = ni.Substring(2, 1);
                n2 = ni.Substring(3, 1);
                sub = ni.Substring(0, 2);
                for (var j = 100; j < 1000; j++)
                {
                    nj = j.ToString();
                    nj1 = nj.Substring(2, 1);
                    if (ni.Substring(0, 2) != nj.Substring(0, 2)) continue;
                    if (nj1 == n1 || nj1 == n2) continue;
                    if (sub.Contains(n1) || sub.Contains(n2)||n1==n2) continue;
                    if (ni.Contains(nj1)) continue;
                    phoenix.Add($"{ni}+{nj}");
                    pint.Add(int.Parse(ni) + int.Parse(nj));
                }
            }
            //後
            List<string> behind = new List<string>();
            List<int> bint = new List<int>();

            for(int t = 0;t<phoenix.Count; t++)
            {

                for(int i =1000;i<10000;i++)
                {
                    ni = i.ToString();
                    n1 = phoenix[t].Substring(0, 4);

                    string sn1 = n1.Substring(0, 1) + n1.Substring(2, 1);
                    string sni = ni.Substring(0, 1) + ni.Substring(2, 1);
                    if (sn1 != sni) continue;

                    string sub1 = ni.Substring(1, 1);
                    string sub2 = ni.Substring(3, 1);

                    if (n1.Contains(sub1) || n1.Contains (sub2)) continue;
                    for(int j = 100;j<999; j++)
                    {
                        string s1 = j.ToString().Substring(0, 1);
                        string s2 = j.ToString().Substring(1, 1);
                        string s3 = j.ToString().Substring(2, 1);
                        if (s1 == s2 || s1 == s3||s2==s3) continue;
                        if (ni.Contains(s1) || ni.Contains(s2) || ni.Contains(s3)) continue;
                        if (n1.Contains(s1) || n1.Contains(s2) || n1.Contains(s3)) continue;
                        Console.WriteLine(phoenix[t] +" = "+ni+"+"+j);
                    }
                }




            }



            Console.WriteLine(phoenix.Count);

            Console.ReadKey();
        }
        static bool C1_9(string m)
        {
            for (int i = 0; i < 9; i++)
            {
                if (!m.Contains(i.ToString())) return false;
            }
            return true;
        }
    }
}