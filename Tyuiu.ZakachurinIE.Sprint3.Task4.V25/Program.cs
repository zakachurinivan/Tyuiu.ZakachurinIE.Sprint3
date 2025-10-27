using Tyuiu.ZakachurinIE.Sprint3.Task4.V25.Lib;

namespace Tyuiu.ZakachurinIE.Sprint3.Task4.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт # 3 | Выполнил: Закачурин И. Е. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Варинат #25                                                             *");
            Console.WriteLine("* Выполнил: Закачурин Иван Евгеньевич | ИБКСб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Использование операторов continue и break в циклах                      *");
            Console.WriteLine("*                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: формула       *");
            Console.WriteLine(ds.Calculate(-5, 5));
        }
    }
}