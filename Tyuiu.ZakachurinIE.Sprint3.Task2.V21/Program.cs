using Tyuiu.ZakachurinIE.Sprint3.Task2.V21.Lib;

namespace Tyuiu.ZakachurinIE.Sprint3.Task2.V21
{
    class Program
    {
        static void Main (string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт # 3 | Выполнил: Закачурин И. Е. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Варинат #21                                                             *");
            Console.WriteLine("* Выполнил: Закачурин Иван Евгеньевич | ИБКСб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do..while, которая вычисляет сумму ряда*");
            Console.WriteLine("*                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: формула");
            Console.WriteLine(ds.GetSumSeries(1.5, 1, 10));
        }
    }
}