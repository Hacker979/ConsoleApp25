using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Инициализация массива без указания значений
            int[] mass = new int[5];
            foreach (int i in mass)
                Console.Write(i + " ");
        }
    }
}
