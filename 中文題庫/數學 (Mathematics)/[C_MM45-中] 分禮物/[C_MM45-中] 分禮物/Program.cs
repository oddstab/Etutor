using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] people = new string[n];
        string[] gift = new string[n];
        string[] mol = new string[n];

        for (int i = 0; i < n; i++)
        {
            string[] temp = Console.ReadLine().Split();
            people[i] = temp[0];
            gift[i] = temp[1];
            mol[i] = temp[1];
        }
        Console.WriteLine(n);
        Pfun(mol, people, gift, 0);
        Console.Read();
    }
    static void Pfun(string[] mol, string[] people, string[] gift, int pos)
    {
        if (pos == (gift.Length - 1))
        {
            for (int i = 0;i<mol.Length; i++)
                if (mol[i] == gift[i]) return;
            for (int i = 0;i<gift.Length; i++)
            {
                Console.Write(people[i] + " " + gift[i]);
                if (i != gift.Length - 1)
                    Console.Write(",");
            }
            Console.WriteLine();
        }
        else
        {
            for (int j = pos;j<gift.Length; j++)
            {
                swap(gift, pos, j);
                Pfun2(mol, people, gift, pos + 1);
                swap(gift, pos, j);
            }
        }
    }
    static void Pfun2(string[] mol, string[] people, string[] gift, int pos)
    {
        if (pos == (gift.Length - 1))
        {
            for (int i = 0; i < mol.Length; i++)
                if (mol[i] == gift[i]) return;
            for (int i = 0; i < gift.Length; i++)
            {
                Console.Write(people[i] + " " + gift[i]);
                if (i != gift.Length - 1)
                    Console.Write(",");
            }
            Console.WriteLine();
        }
        else
        {
            for (int j = pos; j < gift.Length; j++)
            {
                swap(gift, pos, j);
                Pfun3(mol, people, gift, pos + 1);
                swap(gift, pos, j);
            }
        }
    }
    static void Pfun3(string[] mol, string[] people, string[] gift, int pos)
    {
        if (pos == (gift.Length - 1))
        {
            for (int i = 0; i < mol.Length; i++)
                if (mol[i] == gift[i]) return;
            for (int i = 0; i < gift.Length; i++)
            {
                Console.Write(people[i] + " " + gift[i]);
                if (i != gift.Length - 1)
                    Console.Write(",");
            }
            Console.WriteLine();
        }
        else
        {
            for (int j = pos; j < gift.Length; j++)
            {
                swap(gift, pos, j);
                Pfun(mol, people, gift, pos + 1);
                swap(gift, pos, j);
            }
        }
    }
    static void Pfun4(string[] mol, string[] people, string[] gift, int pos)
    {
        if (pos == (gift.Length - 1))
        {
            for (int i = 0; i < mol.Length; i++)
                if (mol[i] == gift[i]) return;
            for (int i = 0; i < gift.Length; i++)
            {
                Console.Write(people[i] + " " + gift[i]);
                if (i != gift.Length - 1)
                    Console.Write(",");
            }
            Console.WriteLine();
        }
        else
        {
            for (int j = pos; j < gift.Length; j++)
            {
                swap(gift, pos, j);
                Pfun4(mol, people, gift, pos + 1);
                swap(gift, pos, j);
            }
        }
    }
    static void swap(string[] arr ,int i , int j)
    {
        string temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}