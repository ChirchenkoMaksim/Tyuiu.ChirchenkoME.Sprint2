using Tyuiu.ChirchenkoME.Sprint2.Task7.V14.Lib;
namespace Tyuiu.ChirchenkoME.Sprint2.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Чирченко М Е | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Чирченко М Е | ИСПб-25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает исходные данные (вещественные   *");
            Console.WriteLine("* значения) и вычисляет, находится ли точка с координатами X,Y            *");
            Console.WriteLine("* в заштрихованной области.                                               *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите координату X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool isInArea = ds.CheckDotInShadedArea(x, y);

            if (isInArea)
                Console.WriteLine($"Точка ({x}, {y}) находится в заштрихованной области.");
            else
                Console.WriteLine($"Точка ({x}, {y}) не находится в заштрихованной области.");

            Console.ReadKey();
        }
    }
}