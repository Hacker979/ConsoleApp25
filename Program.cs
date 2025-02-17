using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        // Заполнить одномерный массив соответствующими индексами и вывести с использованием цикла foreach.
        static void Main(string[] args)
        {
            int[] mass = new int[5];
            for (int i = 0; i < mass.Length; i++)
                mass[i] = i;
            foreach (int i in mass)
                Console.Write(i + " ");
        }
    }
}
