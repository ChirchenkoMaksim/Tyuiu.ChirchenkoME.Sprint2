namespace Tyuiu.ChirchenkoME.Sprint2.Task4.V18;
using Tyuiu.ChirchenkoME.Sprint2.Task4.V18.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Чирченко М Е | ИCПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Базовые                                                           *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Чирченко М Е | ИСПБ-25-1                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x; double y;

        Console.WriteLine("введите значение (x)");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите значение (y)");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("X= " + x);
        Console.WriteLine("Y= " + y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");


        double res = ds.Calculate(x, y);

        Console.WriteLine("Значение функции = " + res);


        Console.ReadKey();


    }
}