using System;
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine().ToLower();
        string keyword = "!@#$%^&*()_++`1234567890-=={}||qwertyuiop[]\\\\:\"\"asdfghjkl;''<>??zxcvbnm,.//";
        int len_i = input.Length, len_key = keyword.Length;
        for (int i = 0; i < len_i; i++)
        {
            for (int j = 0;j<len_key; j++)
            {
                if (input[i]==' ')
                {
                    Console.Write(' ');
                    break;
                }
                else if (input[i] == keyword[j])
                {
                    Console.Write(keyword[j+1]);
                    break;
                }
            }
        }
        Console.WriteLine();
    }
}