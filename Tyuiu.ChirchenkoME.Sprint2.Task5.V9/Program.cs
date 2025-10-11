using Tyuiu.ChirchenkoME.Sprint2.Task5.V9.Lib;

namespace Tyuiu.ChirchenkoME.Sprint2.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Чирченко М Е | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Чирченко М Е. | ИСПб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch,                 *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:         *");
            Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным n и m              *");
            Console.WriteLine("* определить дату следующего дня (принять, что n и m не характеризуют     *");
            Console.WriteLine("* 31 декабря).                                                            *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер месяца (1-12): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите число (день месяца): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string nextDate = ds.FindDateOfNextDay(m, n);

            Console.WriteLine($"Следующий день: {nextDate}");

            Console.ReadKey();
        }
    }
}