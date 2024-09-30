using Tyuiu.LavrinovichED.Sprint1.Task4.V18.Lib; 

namespace Tyuiu.LavrinovichED.Sprint1.Task4.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                *");
            Console.WriteLine("* Тема: Class Math                                                                         *");
            Console.WriteLine("* Задание #4                                                                               *");
            Console.WriteLine("* Вариант #18                                                                              *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать консольную программу, которая запришивает у пользователя исходные данные,       *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                              *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            int x, y;
            Console.WriteLine("Введите значение x = ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y = ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                                *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("√3 + x / (xy)² = " + ds.Calculate(x, y)); 

            Console.ReadLine();
        }
    }
}
