using Tyuiu.ZakachurinIE.Sprint3.Task6.V14.Lib;

namespace Tyuiu.ZakachurinIE.Sprint3.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт # 3 | Выполнил: Закачурин И. Е. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Варинат #7                                                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Выполнил: Закачурин Иван Евгеньевич | ИБКСб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет количество всех делителей больше 5     *");
            Console.WriteLine("*                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: строка                            *");
            Console.WriteLine(ds.GetSumTheDivisors(7, 16));
        }
    }
}