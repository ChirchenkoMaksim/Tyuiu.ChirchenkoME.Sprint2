using Tyuiu.ChirchenkoME.Sprint2.Task6.V6.Lib;

namespace Tyuiu.ChirchenkoME.Sprint2.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Чирченко М Е | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Чирченко М Е | ИСПб-25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращённую форму записи         *");
            Console.WriteLine("* оператора switch, вычисляет требуемое значение и возвращает результат.  *");
            Console.WriteLine("* Масти игральных карт: пик=1, трефы=2, бубны=3, червы=4.                 *");
            Console.WriteLine("* Достоинства: валет=11, дама=12, король=13, туз=14, остальные — по номеру*");
            Console.WriteLine("* По заданным m (масть) и k (достоинство) определить полное название карты*");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер масти (1-4): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите номер достоинства (6-14): ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string cardName = ds.FindCardNameAndValue(m, k);

            Console.WriteLine($"Полное название карты: {cardName}");

            Console.ReadKey();
        }
    }
}