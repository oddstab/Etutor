using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string[] dictionary = Console.ReadLine().Trim().Split();
            string[,] ans = new string[10000, 2];
            int range = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            //string[] temp = str.Replace(",", "").Replace(".", "").Split(' ');
            string[] temp = str.Split(',', ' ', '.');

            string output = "";
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != "" && char.IsLetter(temp[i][0]))
                {
                    for (int j = 0; j < dictionary.Length; j++)
                    {
                        if (!dictionary.Contains(temp[i]))
                        {
                            if (SubLen(temp[i], dictionary[j]) <= range)
                                output += dictionary[j] + ", ";
                        }
                        else break;
                    }
                    if (output.Length != 0)
                    {
                        ans[i, 0] = temp[i];
                        ans[i, 1] = "(" + output.TrimEnd().TrimEnd(',') + ")";
                    }
                    output = "";
                }
            }
            for (int i = 0; i < 10000; i++)
            {
                if (ans[i, 0] != null)
                {
                    int index = str.IndexOf(ans[i, 0]) + ans[i, 0].Length;
                    str = str.Insert(index, ans[i, 1]);
                    int bracket = str.IndexOf(")");
                    Console.Write(str.Substring(0, bracket + 1));
                    str = str.Substring(bracket + 1);
                }
            }
            Console.WriteLine(str);
        }
    }
    static int SubLen(string str, string str2)//算出差異度 
    {
        str = str.ToLower();
        str2 = str2.ToLower();
        string Max = "";
        for (int i = 0; i < str.Length; i++)
        {
            string temp1 = str.Substring(i);
            for (int j = temp1.Length; j >= 0; j--)
            {
                string temp2 = temp1.Substring(0, j);
                if (str2.IndexOf(temp2) != -1 && temp2.Length > Max.Length)
                {
                    //Console.WriteLine(temp2); 
                    Max = temp2;
                }
            }
        }
        return Math.Max(str.Length, str2.Length) - Max.Length;
    }
}