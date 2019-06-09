using System;

namespace _C_ST104_易__單字音節
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                if (i != 0)
                {
                    if ((word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u') && word[i - 1] != 'a' && word[i - 1] != 'e' && word[i - 1] != 'i' && word[i - 1] != 'o' && word[i - 1] != 'u')
                        c++;
                }
                else
                {
                    if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                        c++;
                }
            }
            Console.WriteLine(c);
        }
    }
}