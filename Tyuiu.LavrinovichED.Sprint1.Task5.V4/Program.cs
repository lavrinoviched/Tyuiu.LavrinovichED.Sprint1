//ЗАДАНИЕ
//Написать программу, которая решает следующую задачу:
//Идет k-я секунда суток. Опередлить, сколько полных часов (h) прошло к этому моменту.

using Tyuiu.LavrinovichED.Sprint1.Task5.V4.Lib; 

namespace Tyuiu.LavrinovichED.Sprint1.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                                               *");
            Console.WriteLine("* Задание #5                                                                               *");
            Console.WriteLine("* Вариант #4                                                                               *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать консольную программу, которая решает следующую задачу:                          *");
            Console.WriteLine("* Идёт k-я секунда суток. Оппределить, сколько полных часов (h)                            *");
            Console.WriteLine("* прошло к этому моменту.                                                                  *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Введете количество секунд: "); 
            int time = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                                *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine(ds.SecondsToHours(time)); 
            Console.ReadKey(); 
        }
    }
}
