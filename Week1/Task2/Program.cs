﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
        string name; // создаем строку под названием 
        string id; // создаем другую строку под названием 
        int Year = 1; // создаем переменную int year равный одному

        public Student(string name, string id) //  создаем конструктор с двумя параметрами name  и id
        {
            this.name = name; //
            this.id = id;     //
        }
        public void NewYear() // создаем конструктор без параметров
        {
            while (Year <= 4)
            {
                Console.WriteLine(name + " " + id + " " + Year);
                Year++;
            } // пока год обучения меньше или равен 4, то выводим имя,id и год обучения. И после каждого выода увеличиваем год на 1
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Saya Rakhymgaliyeva", "18BD110011"); // создаем нового студента и задаем начальные данные
            s1.NewYear();  //  вызываем функцию, которая выводит
        }
    }
}
