using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZakachurinIE.Sprint3.Task5.V15.Lib
{
    public class DataService : ISprint3Task5V15
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            int i,j;
            double sumSeries = 0;
            for (i=startValue1; i <= stopValue1; i++)
            {
                for (j=startValue2; j <= stopValue2; j++)
                {
                    sumSeries = sumSeries + (Math.Sin(x) + Math.Pow(j, 2) / 2);
                }
            }
            return Math.Round(sumSeries,3);
        }
    }
}
