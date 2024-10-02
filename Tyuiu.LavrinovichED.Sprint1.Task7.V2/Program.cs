//Написать программу, которая вычисляет математическое выражение
//по исходным значениям данных, вводимых пользователям
//       sin x + cos y
//  z = -------------- tg xy
//       cos x - sin y 

using Tyuiu.LavrinovichED.Sprint1.Task7.V2.Lib; 

namespace Tyuiu.LavrinovichED.Sprint1.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                *");
            Console.WriteLine("* Тема: Работа со строками класс String                                                    *");
            Console.WriteLine("* Задание #7                                                                               *");
            Console.WriteLine("* Вариант #2                                                                               *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение                           *");
            Console.WriteLine("* По исходнымм значениям данных, вводимых пользователем                                    *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine(" Введите значение X = "); 
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Введите значение Y = "); 
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                                *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y)); 
            Console.ReadKey(); 
        }
    }
}
