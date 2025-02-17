using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        // Инициализировать одномерный массив с использованием конструктора , без указания размерности массива и без клавиатуры. 
        static void Main(string[] args)
        {
            int[] mass = {1,2,3,4,5};
            foreach (int i in mass)
                Console.Write(i + " ");
        }
    }
}
