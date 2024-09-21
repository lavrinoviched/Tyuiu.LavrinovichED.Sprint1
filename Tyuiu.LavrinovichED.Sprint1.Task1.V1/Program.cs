﻿using Tyuiu.LavrinovichED.Sprint1.Task1.V1.Lib; 

//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле x/3/y+6*a
//и печатает его на экране.

namespace Tyuiu.LavrinovichED.Sprint1.Task1.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); 

            Console.Title = "Спринт #1 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                                  *");
            Console.WriteLine("* Задание #1                                                                               *");
            Console.WriteLine("* Вариант #1                                                                               *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать консольную программу, которая запришивает у пользователя исходные данные,       *");
            Console.WriteLine("* вычисляет результат по форрмуле x/3/y+6*a.                                               *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            double x, y, a;
            Console.WriteLine("Введите значение x = "); 
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y = "); 
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение a = "); 
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("********************************************************************************************"); 
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                                *"); 
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y, a)); 

            Console.ReadKey(); 
        }
    }
}
