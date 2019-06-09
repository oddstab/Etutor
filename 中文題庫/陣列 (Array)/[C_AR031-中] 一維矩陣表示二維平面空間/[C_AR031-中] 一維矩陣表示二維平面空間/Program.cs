using System;
class Program
{
    static void Main(string[] args)
    {
        string o, str;
        int n = int.Parse(Console.ReadLine()), pos = int.Parse(Console.ReadLine()); ;
        string[] oneD = new string[n * n];
        int[] posArr = new int[8];
        char prefix = 'A';
        for (int i = 1, c = 1; i <= n * n; i++, c++)
        {
            oneD[i - 1] = (i % n == 0 ? prefix++ : prefix) + c.ToString();
            //Console.Write(oneD[i - 1] + $"[{(i - 1).ToString("00")}]" + (i % n == 0 && i != n * n ? "\n" : " "));
            if (i % n == 0) c = 0;
        }
        //左上
        int Ltop = pos - n - 1 < 0 ? -1 : pos - n - 1;
        o = ((char)(oneD[pos][0] - 1)).ToString();
        str = o + (char)(oneD[pos][1] - 1);
        if (Ltop != -1 && oneD[Ltop] == str)
            posArr[0] = Ltop;
        else
            posArr[0] = -1;
        //上
        posArr[1] = pos - n < 0 ? -1 : pos - n;
        //右上
        int Rtop = pos - n + 1 < 0 ? -1 : pos - n + 1;
        str = o + (char)(oneD[pos][1] + 1);
        if (Rtop != -1 && oneD[Rtop] == str)
            posArr[2] = Rtop;
        else
            posArr[2] = -1;
        //右
        int R = pos + 1;
        str = oneD[pos][0].ToString() + (char)(oneD[pos][1] + 1);
        if (R < n * n && oneD[R] == str)
            posArr[3] = R;
        else
            posArr[3] = -1;
        //右下
        int Lr = pos + n + 1;
        str = ((char)(oneD[pos][0] + 1)).ToString() + (char)(oneD[pos][1] + 1);
        if (Lr < n * n && oneD[Lr] == str)
            posArr[4] = Lr;
        else
            posArr[4] = -1;
        //下
        posArr[5] = pos + n >= n * n ? -1 : pos + n;
        //左下
        int Ll = pos + n - 1;
        str = ((char)(oneD[pos][0] + 1)).ToString() + (char)(oneD[pos][1] - 1);
        if (Ll < n * n && oneD[Ll] == str)
            posArr[6] = Ll;
        else
            posArr[6] = -1;
        //左
        int L = pos - 1;
        str = oneD[pos][0].ToString() + (char)(oneD[pos][1] - 1);
        if (L >= 0 && oneD[L] == str)
            posArr[7] = L;
        else
            posArr[7] = -1;
        Console.WriteLine(string.Join(" ", posArr)+" ");
        for (int i = 0; i < 8; i++)
            Console.Write((posArr[i] == -1 ? "-1" : oneD[posArr[i]]) + (i == 7 ? " \n" : " "));
    }
}