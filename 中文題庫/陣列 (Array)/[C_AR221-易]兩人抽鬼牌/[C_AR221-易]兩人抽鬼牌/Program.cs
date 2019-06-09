using System;
using System.Collections;
using System.Linq;

class Etutor
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int g = 0; g < n; g++)
        {
            ArrayList player1 = new ArrayList(Console.ReadLine().Split());
            ArrayList player2 = P2(player1);
            Console.WriteLine();
            card(player1);
            card(player2);

            for (int i = 0; i < player2.Count; i++)
                Console.Write(player2[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < player1.Count; i++)
                Console.Write(player1[i] + " ");
            Console.WriteLine();




        }
    }
    static ArrayList P2(ArrayList x)
    {
        ArrayList total = new ArrayList
        {
            "A","A","A","A","2","2","2","2","3","3","3","3","4","4","4","4","5","5","5","5",
            "6","6","6","6","7","7","7","7","8","8","8","8","9","9","9","9","10","10","10","10",
            "J","J","J","J","Q","Q","Q","Q","K","K","K","K","*"
        };
        for (int i = 0; i < x.Count; i++)
        {
            int index = total.IndexOf(x[i]);
            if (index != -1)
                total.Remove(total[index]);
        }
        return total;
    }
    static void card(ArrayList x)
    {
        ArrayList New = new ArrayList();

    }
}