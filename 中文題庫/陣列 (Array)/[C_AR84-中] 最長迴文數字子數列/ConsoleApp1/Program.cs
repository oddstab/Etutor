using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine(),temp;
        List<string> A = new List<string>();
        List<string> verylong = new List<string>();
        for (int i = 0; i < str.Length; i++)
            for (int j = 1; j < str.Length - i + 1; j++)
            {
                temp = str.Substring(i, j);
                if (Palindrome(temp)) A.Add(temp);
            }
        for (int i = 0; i < A.Count - 1; i++)
            for (int j = 1; j < A.Count - i; j++)
            {
                if (int.Parse(A[j - 1]) < int.Parse(A[j]))
                {
                    temp = A[j - 1];
                    A[j - 1] = A[j];
                    A[j] = temp;
                }
            }
        if (A.Count == 1) Console.WriteLine(A[0]);
        else
        {
            int maxlen = A[0].Length;
            for (int i = 0; ; i++)
            {
                if (A[i].Length == maxlen) verylong.Add(A[i]);
                else
                {
                    Console.WriteLine(verylong[verylong.Count - 1]);
                    break;
                }
            }
        }
    }
    static bool Palindrome(string m)
    {
        char[] x = m.ToCharArray();
        Array.Reverse(x);
        if (m.Length == 1) return false;
        if (new string(x) == m) return true;
        else return false;
    }
}