using System;
class Program
{
    public static int[,] mm;
    static void Main(string[] args)
    {
        while (true)
        {
            int c = int.Parse(Console.ReadLine());
            MagicMatrix(c);
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < c; j++)
                    Console.Write(mm[i, j] + (j != c - 1 ? " " : ""));
                Console.WriteLine();
            }
        }
    }
    static void MagicMatrix(int n)
    {
        mm = new int[n, n];
        int ass_value = 1;
        int p = n - 1;//中間值   
        int row = 0;//行   
        int column = p / 2; //起始列   
        mm[row, column] = 1;
        while (ass_value < n * n)
        {
            ass_value++;
            row--;
            column++;

            if (row < 0 & column == n)
            {
                row += 2;
                column--;
            }
            if (row < 0) row += n;
            if (column == n) column -= n;
            if (mm[row, column] != 0)
            {
                row += 2;
                column--;
            }
            mm[row, column] = ass_value;
        }
    }
}