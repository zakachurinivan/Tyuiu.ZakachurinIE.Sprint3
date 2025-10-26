using Tyuiu.ZakachurinIE.Sprint3.Task3.V7.Lib;

namespace Tyuiu.ZakachurinIE.Sprint3.Task3.V7
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Варинат #7                                                              *");
            Console.WriteLine("* Выполнил: Закачурин Иван Евгеньевич | ИБКСб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы g на цифру 4                      *");
            Console.WriteLine("*                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: строка                                                 *");
            Console.WriteLine(ds.ReplaceCharOnNum("gft hggt ntg", 'g', '4'));
        }
    }
}