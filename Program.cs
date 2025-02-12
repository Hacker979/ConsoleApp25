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
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());

            //int[] mas = new int[b];
            //for (int i = 0; i < b; i++)
            //{
            //    Console.Write($"mas[{i}]=");
            //    mas[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i=0; i < mas.Length; i++)
            //{
            //    Console.WriteLine($"mas[{i}]= {mas[i]}");
            //}



            int[] mas = new int[5];
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                mas[i] = r.Next(-10, 10);
            }
            foreach (int el in mas)
            {
                Console.WriteLine($"{el}\t");
            }
            Console.Read();
        }
    }
}
