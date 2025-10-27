using Tyuiu.ZakachurinIE.Sprint3.Task7.V14.Lib;

namespace Tyuiu.ZakachurinIE.Sprint3.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт # 3 | Выполнил: Закачурин И. Е. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Варинат #14                                                             *");
            Console.WriteLine("* Выполнил: Закачурин Иван Евгеньевич | ИБКСб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Вывести таблицу значений функции                                        *");
            Console.WriteLine("*                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт" + startValue);
            Console.WriteLine("Конец" + stopValue);
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("Результат");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("      x    |     f(x)  ");
            Console.WriteLine("+----------+----------+");
            for (int i = 0;i <= len-1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,6:f2}   |", startValue, res[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}