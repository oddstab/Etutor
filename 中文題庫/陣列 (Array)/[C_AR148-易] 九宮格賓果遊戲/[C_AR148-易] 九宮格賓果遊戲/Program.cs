using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_AR148_易__九宮格賓果遊戲
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = "";
            do
            {
                ip = "";
                string[] Player1 = Console.ReadLine().Split();
                string[] Player2 = Console.ReadLine().Split();
                string[] Ans = Console.ReadLine().Split();

                for (int i = 0; i < 3; i++)
                {
                    string sub = Ans[i];
                    int index1 = Array.IndexOf(Player1, sub);
                    int index2 = Array.IndexOf(Player2, sub);
                    Player1[index1] = "#";
                    Player2[index2] = "#";
                }
                bool p1 = Bingo(Player1);
                bool p2 = Bingo(Player2);
                if (p1 && p2) Console.WriteLine("Draw");
                else if (p1) Console.WriteLine("Player1 wins");
                else if (p2) Console.WriteLine("Player2 wins");
                ip = Console.ReadLine();
            } while (ip != "-1");
        }
        static bool Bingo(string[] Per)
        {
            string a = "###";
            //row
            for (int i = 0; i < 9; i += 3)
            {
                if (Per[i] + Per[i + 1] + Per[i + 2] == a) return true;
            }
            //column
            for (int i = 0; i < 3; i++)
            {
                if (Per[i] + Per[i + 3] + Per[i + 6] == a) return true;
            }
            if (Per[0] + Per[4] + Per[8] == a) return true;
            if (Per[2] + Per[4] + Per[6] == a) return true;
            return false;
        }
    }
}