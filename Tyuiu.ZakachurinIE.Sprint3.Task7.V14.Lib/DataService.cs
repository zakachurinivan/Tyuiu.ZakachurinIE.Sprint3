using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZakachurinIE.Sprint3.Task7.V14.Lib
{
    public class DataService : ISprint3Task7V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res;
            int len = stopValue - startValue +1;
            res = new double[len];
            double y;
            int k = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = 2 * x - 4 + ((2 * x - 1) / (Math.Sin(x) + 1));
                res[k] = Math.Round(y,2);
                k++;
            }
            return res;
        }
    }
}
