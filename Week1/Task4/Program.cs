using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());//создаем новую переменную int и считываем ее со строки
            for (int i = 0; i < width; i++) // пробегаемся от нуля до n  
            {
                for (int j = 0; j < i + 1; j++) //так как счет начинается с нуля, пробегаемся от нуля до i+1
                {
                    Console.Write("[*]"); // выводим [*] 
                }
                Console.WriteLine();// каждый ряд [*] начинаем с новой строки
            }
        }
    }
}
