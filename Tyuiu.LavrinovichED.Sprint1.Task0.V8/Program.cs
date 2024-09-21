using Tyuiu.LavrinovichED.Sprint1.Task0.V8.Lib; 

namespace Tyuiu.LavrinovichED.Sprint1.Task0.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1"; 
            Console.WriteLine("*******************************************************************************"); 
            Console.WriteLine("* Спринт #1                                                                   *"); 
            Console.WriteLine("* Тема: Базовые навыки работы C#                                              *"); 
            Console.WriteLine("* Задание #0                                                                  *"); 
            Console.WriteLine("* Вариант #8                                                                  *"); 
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                  *"); 
            Console.WriteLine("*******************************************************************************"); 
            Console.WriteLine("* УСЛОВИЕ:                                                                    *"); 
            Console.WriteLine("* Написать консольную программу в C#, которая вычисляет значение 15/2/4       *"); 
            Console.WriteLine("* печатает результат на экране                                                *"); 
            Console.WriteLine("*                                                                             *");  
            Console.WriteLine("*******************************************************************************"); 
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");  
            Console.WriteLine("*******************************************************************************"); 
            Console.WriteLine("* 15/2/4                                                                      *");  
            Console.WriteLine("*******************************************************************************"); 
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                   *"); 
            Console.WriteLine("*******************************************************************************");

            double number = 1.875;
            Console.WriteLine($"{number:F3}"); 
            Console.ReadKey();  
        }
    }
}
