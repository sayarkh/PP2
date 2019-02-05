using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//создаем новую переменную int и считываем ее со строки 
            int[] a = new int[n];//создаем новый массив int
            string[] arr = Console.ReadLine().Split();//считываем каждый элемент строки с пробелом
            for (int i = 0; i < n; i++)//пробегаемся от одного до n
            {
                a[i] = int.Parse(arr[i]);//превращаем каждый элемент массива  в integer
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " " + a[i] + " ");//выводим каждый элемент массива по два раза
            }
        }
    }
}
