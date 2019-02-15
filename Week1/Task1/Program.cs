using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//создаем новую переменную int и считываем ее со строки 
            int[] a = new int[n];//создаем новый массив 
            string[] arr = Console.ReadLine().Split();//считываем каждый элемент строки с пробелом
            for (int i = 0; i < n; i++)//пробегаемся по массиву
            {
                a[i] = int.Parse(arr[i]);//превращаем каждый элемент массива  в integer
            }
            int prime = 0;//создаем новую переменную и приравниваем к нулю;
            for (int i = 0; i < n; i++)
            {
                int s = 0;//создаем новую переменную 
                for (int j = 1; j <= a[i]; j++)//пробегаемся от 1 до самого числа, чтобы найти делителей данного числа
                {
                    if (a[i] % j == 0)
                    {
                        s++;
                    }//если число делится без остатков, то увеличиваем переменную s на 1
                }
                if (s == 2)
                {
                    prime++;
                }//если количество делителей равно 2, то число является простым, поэтому увеличиваем переменную prime на 1
            }
            Console.WriteLine(prime);//выводим общее количество простых чисел
            for (int i = 0; i < n; i++)
            {
                int s = 0;//создаем новую переменную
                for (int j = 1; j <= a[i]; j++)//пробегаемся от 1 до самого числа, чтобы найти делителей данного числа
                {
                    if (a[i] % j == 0)
                    {
                        s++;
                    }//если число делится без остатков, то увеличиваем переменную k на 1
                }
                if (s == 2)
                {
                    Console.Write(arr[i] + " ");
                }//если количество делителей равно 2, то число является простым и выводим это число
            }
        }
    }
}
