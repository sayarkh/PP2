using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program // рекурсивный метод проверки строки на палиндром 
    {
        public static bool Palindrometest(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)//пробегаемся от 0-го элемента строки до середины
                if (s[i] != s[s.Length - i - 1])//если соответствующие элементы не равны
                    return false; //значит значение неверное
            return true; //в противном случае верное
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");//чтобы прочитать с файла "input"
            String s = sr.ReadToEnd();//считываем все входные данные из текущей позиции до конца строки
            if (Palindrometest(s))//вызываем метод для проверки является ли данная строка палиндромом или нет
                Console.WriteLine("Yes");//если строка палиндром,то выведем "Yes";
            else
                Console.WriteLine("No");//если строка не является палиндромом ,то выведем "No";
            sr.Close();//
        }
    }
}
