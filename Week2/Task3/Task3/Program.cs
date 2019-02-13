using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    { 
     public static void PrintSpaces(int level)//метод разделения пространства по уровням линий
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write("   ");
            }
        }
        public static void Dir(DirectoryInfo dirs, int level)//метод который выведет список всех файлов и папок
        {
            foreach (FileInfo f in dirs.GetFiles())// получает список файлов из предыдущей директории   
            {
                PrintSpaces(level);//разделяет пробелами
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dirs.GetDirectories())// получает список папок из предыдущей директории
            {
                PrintSpaces(level);//разделяет пробелами
                Console.WriteLine(d.Name);
                Dir(d, level+1);//еще раз вызывает метод 
            }
        }
    static void Main(string[] args)
    {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Сая Ракимгалиева\Desktop\pp2");//выбираем каталог, с которым будем работать
            Dir(directory, 0);//вызывает метод
            Console.ReadKey();
    }
    }
}
