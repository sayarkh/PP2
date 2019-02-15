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
            string fileName = "test.txt";//имя файла который мы будем создавать
            string PathString = @"C:\hello";//путь который указывает где мы будем создать этот файл
            PathString = Path.Combine(PathString, fileName); //Объединяет две строки в путь.
            FileStream fs = File.Create(PathString);//создает файл
            fs.Close();//закрывает для того чтобы прекратить работу с файлом

            string PathString2 = @"C:\SomeDir";//путь для вставки файла

            string destFile = Path.Combine(PathString2, fileName);//oбъединяет две строки в путь
            File.Copy(PathString, destFile, true);//скопирует в указанный путь

            File.Delete(PathString);//удаляет первый файл, который мы создали
        }
    }
}
