using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_MM24計算薪水
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] imput = Console.ReadLine().Split(' ');
                double salary = double.Parse(imput[0]);//時數
                int time_pay = int.Parse(imput[1]);//時薪
                double totale, already, end;

                if ((salary >60)&&(salary<=120))//在61~120之間
                {
                     totale =60* time_pay;//先把第一份薪水算出來 ex 5700
                     already = salary - 60; //超過60的剩下的數 所以-60
                     end = already * (time_pay * 1.33);//大於60小於120的從這裡算
                    Console.WriteLine((totale + end).ToString("##.0"));
                }
                else if (salary<=60)//少於60hr
                {
                    totale = salary * time_pay;
                    Console.WriteLine(totale.ToString("##.0"));
                }
                else if (salary>120)
                {
                    double threesalary = (salary - 120) * time_pay * 1.66;//121後面
                    totale = 60 * time_pay;//60 
                    end = 60 * (time_pay * 1.33);//大於60小於120的從這裡算
                    Console.WriteLine((threesalary+totale+end).ToString("##.0"));
                }
                Console.ReadKey();
            }
        }
    }
}
