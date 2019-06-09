using System;
class Program
{
    static void Main(string[] args)
    {
        string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        for (int f = 0; f < 5; f++)
        {
            try
            {            
                string s = DateTime.Parse(Console.ReadLine()).ToShortDateString(), m = "";
                for (int i = 1;i<=12 ;i++)
                    if (s.Split('/')[1] == i.ToString()) m = month[i - 1];
                string[] t = s.Split('/');
                Console.WriteLine(s);
                Console.WriteLine(t[0]);
                Console.WriteLine(t[1]);
                Console.WriteLine(t[2]);

                //Console.WriteLine(m + " " + d + ", " + y);
            }
            catch
            {
                Console.WriteLine("false");
            }
        }
    }
}