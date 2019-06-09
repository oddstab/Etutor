using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigIntger
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                decimal sort = decimal.Parse(Console.ReadLine());
                for (decimal G = 1; G <= sort; G++)
                {
                    string[] N = Console.ReadLine().Split(' ');
                    string NA = N[0];
                    string NB = N[1];
                    int carry = 0;
                    int len = Math.Max(NA.Length, NB.Length);
                    string[] A = new string[len];
                    string[] B = new string[len];
                    int[] R = new int[len + 1];
                    string BigInt = "";
                    for (int i = 0, r = NA.Length - 1; i < NA.Length; i++, r--) A[i] = NA.Substring(r, 1);
                    for (int i = 0, r = NB.Length - 1; i < NB.Length; i++, r--) B[i] = NB.Substring(r, 1);
                    for (int i = 0; i < len; i++)
                    {
                        if (A[i] == null)
                        {
                            R[i] = (int.Parse(B[i]) + carry) % 10;
                            carry = (int.Parse(B[i]) + carry) / 10;
                            continue;
                        }
                        if (B[i] == null)
                        {
                            R[i] = (int.Parse(A[i]) + carry) % 10;
                            carry = (int.Parse(A[i]) + carry) / 10;
                            continue;
                        }
                        R[i] = (int.Parse(A[i]) + int.Parse(B[i]) + carry) % 10;
                        carry = (int.Parse(A[i]) + int.Parse(B[i]) + carry) / 10;
                    }
                    R[len] = carry;
                    for (int i = R.Length - 1; i >= 0; i--)
                    {
                        BigInt += R[i];
                    }
                    Console.WriteLine(BigInt.Substring(0, 1) == "0" ? BigInt.Substring(1, BigInt.Length - 1) : BigInt);
                }
            }
        }
    }
}