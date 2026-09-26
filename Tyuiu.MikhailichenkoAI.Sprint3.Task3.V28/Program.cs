using Tyuiu.MikhailichenkoAI.Sprint3.Task3.V28.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint3.Task3.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Михайличенко А. И. | ИИПБ26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Михайличенко А. И.                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву r в строке:              *");
            Console.WriteLine("* f35hyt t4j 3gkg45                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "f35hyt t4j 3gkg45";
            char item = 'r';

            Console.WriteLine($"Исходная строка: {value}");
            Console.WriteLine($"Символ для замены: {item}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.ReplaceNumOnChar(value, item);

            Console.WriteLine($"Итоговая строка: {res}");

            Console.ReadKey();
        }
    }
}
