using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZakachurinIE.Sprint3.Task3.V7.Lib
{
    public class DataService : ISprint3Task3V7
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            foreach (char n in value)
            {
                if (n == replaceable)
                {
                    value = value.Replace(n, replacement);
                }


            }
            return value;
        }
    }
}
