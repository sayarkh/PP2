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
        public static void Create()
        {
            string path = @"C:\Users\Сая Ракимгалиева\Desktop\pp2\Week2\Task4\test.txt";
            FileInfo fileInf = new FileInfo(path);
            if (!fileInf.Exists)
            {
                fileInf.Create();
            }
        }
        public static void Copy()
        {
            string path = @"C:\Users\Сая Ракимгалиева\Desktop\pp2\Week2\Task4\test.txt";
            string newPath = @"C:\Users\Сая Ракимгалиева\Desktop\pp2\Week2\Task4\test1.txt";
            FileInfo fileInf = new FileInfo(newPath);
            if (fileInf.Exists)
            {
                fileInf.MoveTo(newPath, true);
            }
        }
        public static void Del()
        {
            string newpath = @"C:\Users\Сая Ракимгалиева\Desktop\pp2\Week2\Task4";
            FileInfo fileInf = new FileInfo(newPath);
            if (fileInf.Exists)
            {
                fileInf.Delete();
            }
        }
        static void Main(string[] args)
        {
            Create();
            Copy();
            Del();


        }
    }
}
