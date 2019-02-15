using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "test.txt"; // имя файла которого мы будем создавать
            string PathString = @"C:\hello"; // путь который указывает на папку в которой будет храниться  файл
            PathString = Path.Combine(PathString, fileName); //объединяет две строки в путь
            FileStream fs = File.Create(PathString); // создает новый файл
            fs.Close(); // закроет файл для того чтобы прекратить работу с файлом

            string PathString2 = @"C:\SomeDir"; //указываем на новый путь

            string destFile = System.IO.Path.Combine(PathString2, fileName); //  объединяет две строки в путь
            File.Copy(PathString, destFile, true); // скопирует файл

            File.Delete(PathString); // и удаляет первый файл
        }
    }
}
