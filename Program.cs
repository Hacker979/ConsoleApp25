using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        // Заполнить одномерный массив случайным образом и вывести на экран с использованием цикла foreach.
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] mass = new int[5];
            for (int i = 0; i < mass.Length; i++)
                mass[i] = rand.Next(1,10);
            foreach (int i in mass)
                Console.Write(i + " ");
        }
    }
}
