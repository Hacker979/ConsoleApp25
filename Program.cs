using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        // Выполнить инициализацию одномерного массива с использованием конструктора без указания значений элементов и вывести на экран.
        static void Main(string[] args)
        {
            int[] mass = new int[5];
            foreach (int i in mass)
                Console.Write(i + " ");
        }
    }
}
