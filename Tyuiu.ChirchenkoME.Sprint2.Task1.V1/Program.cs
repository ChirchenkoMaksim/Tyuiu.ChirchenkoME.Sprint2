using Tyuiu.ChirchenkoME.Sprint2.Task1.V1.Lib;

DataService ds = new();

Console.Title = "Спринт #2 | Выполнил: Чирченко М Е | ИСПБ-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Логические операции                                               *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Чирченко М Е | ИСПБ-25-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений и логических операций          *");
Console.WriteLine("* (|, &, ||, &&, !, ^), а также арифметических выражений, которая         *");
Console.WriteLine("* вернет логическую последовательность (массив): (T, F, T, F, T, F),      *");
Console.WriteLine("* при a = 119, b = 196, c = 134, d = 327                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int a = 119, b = 196, c = 134, d = 327;
bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);

Console.WriteLine("A = " + a);
Console.WriteLine("B = " + b);
Console.WriteLine("C = " + c);
Console.WriteLine("D = " + d);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadLine();
