using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        public static bool IsPrime(int a)//метод который определяет является ли число простым или нет
        {
            for (int i = 2; i<=Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }
          

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");//чтобы прочитать с файла "input"
            string s = sr.ReadToEnd();//считываем все входные данные из текущей позиции до конца строки
            sr.Close();

            string[] str = s.Split();//считываем каждый элемент строки как отдельный член массива
            int[] arr = new int[100000];//создаем новый массив
            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = int.Parse(str[i]);//превращаем каждый элемент массива со string в integer
            }
            
            StreamWriter sw = new StreamWriter("output.txt");//создаем output файл для того чтобы написать в нем
            for (int i = 0; i < str.Length; i++)
            {
                if (IsPrime(arr[i]))//вызываем метод для проверки является ли данное число простым или нет
                    sw.Write(arr[i] + " ");//если число простое,то запишем его в output файл
            }
                sw.Close();  
            Console.ReadKey();
        }
    }
}
