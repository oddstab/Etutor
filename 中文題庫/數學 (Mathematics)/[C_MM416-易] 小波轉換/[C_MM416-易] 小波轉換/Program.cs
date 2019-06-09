using System;
class Program
{
    static int len , temp;
    static void Main(string[] args)
    {
        len = int.Parse(Console.ReadLine());
        int a = 0, b = 9;
        int tran = int.Parse(Console.ReadLine());
        int[,] shiauPo = new int[len, len];
        for (int i = 0; i < len; i++)
        {
            string[] s = Console.ReadLine().Split();
            for (int j = 0; j < len; j++)
                shiauPo[i, j] = int.Parse(s[j]);
        }
        for (int i = 1; i <= tran; i++)
            shiauPo = horizontal(shiauPo, i);
        for (int i = 0; i < len; i++)
            for (int j = 0; j < len; j++)
                Console.Write(shiauPo[i, j] + (j != len - 1 ? " " : "\n"));
    }
    static int[,] horizontal(int[,] shiauPo, int oe) // Oe = Odd & Even 利用奇偶數判斷 vertical or horizontal
    {
        int[,] newPo = new int[len, len];
        for (int i = 0; i < len; i++)
        {
            int k = 0, j = 0;
            for (; j < len / 2; j++)//前半部
            {
                temp = 0;
                for (int add = 0; add < 2; k++, add++) //左右兩值相加
                    temp += oe % 2 == 0 ? shiauPo[k, i] : shiauPo[i, k];
                if (oe % 2 == 0) newPo[j, i] = temp;
                else newPo[i, j] = temp;
            }
            for (k = 0; j < len; j++)//後半部
            {
                temp = oe % 2 == 0 ? shiauPo[k++, i] : shiauPo[i, k++];
                for (int div = 1; div < 2; k++, div++) //左右兩值相減
                    temp -= oe % 2 == 0 ? shiauPo[k, i] : shiauPo[i, k];
                if (oe % 2 == 0) newPo[j, i] = temp;
                else newPo[i, j] = temp;
            }
        }
        return newPo;
    }
}