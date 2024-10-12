using Tyuiu.SanzyapovOD.Sprint2.Task0.V12.Lib;
namespace Tyuiu.SanzyapovOD.Sprint2.Task0.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Санзяпов О. Д. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнений                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Санзяпов Олег Дмитриевич| ИСТНб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последов*");
            Console.WriteLine("* ательность операций не должна нарушаться) и арифметических выражений, ко*");
            Console.WriteLine("* торая вернет логическую последовательность(массив): (True, False, True, *");
            Console.WriteLine("* False, True, False), при x = 1095, y = 475                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            var result = ds.GetCompareOperations(1095, 475);
            var s = "";
            foreach (var res in result)
            {
                s += " " + res.ToString();
            }
            Console.WriteLine(s.Substring(1));
            Console.ReadKey();
        }
    }
}
