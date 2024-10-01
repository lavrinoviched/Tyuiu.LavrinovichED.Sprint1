//ЗАДАНИЕ
//Написать программу:пользователь вводит текст.
//Напечатать все слова, удалив среднюю букву у  слов нечетной длины.

using Tyuiu.LavrinovichED.Sprint1.Task6.V10.Lib; 

namespace Tyuiu.LavrinovichED.Sprint1.Task6.V10
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
            Console.WriteLine("* Задание #6                                                                               *");
            Console.WriteLine("* Вариант #10                                                                              *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать консольную программу: пользователь вводит текст.                                *");
            Console.WriteLine("* Напечатать все слова, удалив среднюю букву у слов нечетной длины.                        *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("* Введите предложение:                                                                     *"); 
            string str = Console.ReadLine();

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                                *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine(ds.DeleteMiddleLetter(str)); 
            Console.ReadKey(); 
        }
    }
}
