using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            int[] mas = new int[a];
            while (a > c)
            {
                Console.WriteLine("Вводите значения для массива (цифры): ");
                int b = Convert.ToInt32(Console.ReadLine());
                mas[c] = b;
                c++;
            }
            Console.WriteLine("Выводим значения массива: ");
            foreach (int i in mas)
            {
                Console.WriteLine(i);
            }
        }
    }
}
