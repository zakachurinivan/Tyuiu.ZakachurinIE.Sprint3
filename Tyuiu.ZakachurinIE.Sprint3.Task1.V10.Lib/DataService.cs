using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZakachurinIE.Sprint3.Task1.V10.Lib
{
    public class DataService : ISprint3Task1V10
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double res = 0;
            ;
            while (startValue < stopValue)
            {
                res = res + Math.Pow((1 / (startValue + Math.Pow(value, startValue))), startValue);
                startValue++;
            }
            return Math.Round(res,3);
            
        }
    }
}
