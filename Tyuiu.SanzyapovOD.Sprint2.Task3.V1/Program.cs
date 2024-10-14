using Tyuiu.SanzyapovOD.Sprint2.Task3.V1.Lib;
namespace Tyuiu.SanzyapovOD.Sprint2.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Санзяпов О. Д. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Санзяпов Олег Дмитриевич| ИСТНб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Написать программу, которая вычисляет требуемое значение       *");
            Console.WriteLine("* функции Y с использованием вложенных оператор if-else, где пользователь *");
            Console.WriteLine("* вводит значение переменной X с клавиатуры. Округлить полученное         *");
            Console.WriteLine("* значение до трех знаков после запятой;                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите число x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x));
            Console.ReadKey();
        }
    }
}
