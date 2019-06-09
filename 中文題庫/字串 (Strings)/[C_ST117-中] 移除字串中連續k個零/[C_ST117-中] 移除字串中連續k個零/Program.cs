using System;
class Program
{
    static void Main(string[] args)
    {
        int k = int.Parse(Console.ReadLine()),count=0;
        string str = Console.ReadLine(),new_str="";
        for (int i = 0;i<str.Length; i++)
        {
            if (str[i] == '0') count++;
            else
            {
                if (count != k) new_str += str.Substring(i - count, count + 1);
                else new_str += str[i];
                count = 0;
            }
        }
        Console.WriteLine(new_str);
    }
}