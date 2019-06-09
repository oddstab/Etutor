using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR027_中__整數集合之交集與聯集
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "1 ";
            int.Parse(a);
            List<int> A = new List<int>();
            List<int> B = new List<int>();
            List<int> AandB = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                int ip = int.Parse(Console.ReadLine().Trim());
                if (i == 3) A.Remove(ip);
                else if (i == 7) B.Remove(ip);
                else if (i < 4) A.Add(ip);
                else B.Add(ip);
            }
            A.Sort(); B.Sort();
            for (int i = 0; i < A.Count + B.Count; i++)
            {
                if (i < A.Count) Console.Write(A[i] + (i != A.Count - 1 ? "," : "\n"));
                else Console.Write(B[i - A.Count] + (i - A.Count != B.Count - 1 ? "," : "\n"));
            }
            string ta = TTAB(A);
            string tb = TTAB(B);
            Console.WriteLine(tb.Contains(ta) ? "T" : "F");
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < B.Count; j++)
                {
                    if (A[i] == B[j])
                    {
                        AandB.Add(A[i]);
                        break;
                    }
                }
            }
            if (AandB.Count == 0) Console.WriteLine("empty");
            else
            {
                for (int i = 0; i < AandB.Count; i++)
                {
                    Console.Write(AandB[i] + (i != AandB.Count - 1 ? "," : "\n"));
                }
            }           
            List<int> result = A.Union(B).ToList();
            result.Sort();
            for (int i = 0; i < result.Count; i++) Console.Write(result[i]+(i!=result.Count-1?",":"\n"));
        }
        static string TTAB(List<int> x)
        {
            string temp = "";
            for (int i = 0; i < x.Count; i++)
            {
                temp += x[i];
            }
            return temp;
        }
    }
}