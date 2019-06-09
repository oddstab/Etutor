using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<string> data = new List<string>();
        List<int> dInt = new List<int>();
        string input = Console.ReadLine(), temp;
        for (int i = 0; i < input.Length; i++)
            for (int j = 1; j < input.Length - i + 1; j++)
            {
                temp = input.Substring(i, j);
                if (Palindrome(temp)) data.Add(temp);
            }
        for (int i = 0; i < data.Count; i++)
            for (int j = 1; j < data.Count - i; j++)
            {
                if (int.Parse(data[j - 1]) > int.Parse(data[j]))
                {
                    temp = data[j - 1];
                    data[j - 1] = data[j];
                    data[j] = temp;
                }
            }
        if (data.Count == 1) Console.WriteLine(data[0]);
        else
        {
            int mLen = data[data.Count - 1].Length;
            for (int i = 0; i < data.Count;)
            {
                if (data[i].Length != mLen) data.RemoveAt(i);
                else i++;
            }
                
            for (int i = 0; i < data.Count; i++)
            {
                int sum = 0;
                for (int j = 0; j < mLen; j++)
                    sum += int.Parse(data[i][j].ToString());
                dInt.Add(sum);
            }
            for (int i = 0; i < data.Count; i++)
                for (int j = 1; j < data.Count - i; j++)
                {
                    if (dInt[j-1] > dInt[j])
                    {
                        temp = data[j - 1];
                        data[j - 1] = data[j];
                        data[j] = temp;

                        int tt = dInt[j - 1];
                        dInt[j - 1] = dInt[j];
                        dInt[j] = tt;
                    }
                }
            Console.WriteLine(data[0]);
        }
    }
    static bool Palindrome(string m)
    {
        if (m.Length <= 1) return false;
        char[] x = m.ToCharArray();
        Array.Reverse(x);
        if (new string(x) == m) return true;
        else return false;
    }
}