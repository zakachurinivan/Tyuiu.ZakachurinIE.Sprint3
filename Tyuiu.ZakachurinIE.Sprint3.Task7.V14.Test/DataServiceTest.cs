using Tyuiu.ZakachurinIE.Sprint3.Task7.V14.Lib;

namespace Tyuiu.ZakachurinIE.Sprint3.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = -5;
            int y = 5;
            int len = y - x + 1;

            double[] wait;
            wait = new double[len];
            wait[0] = -19.62;
            wait[1] = -17.12;
            wait[2] = -18.15;
            wait[3] = -63.13;
            wait[4] = -24.92;
            wait[5] = -5;
            wait[6] = -1.46;
            wait[7] = 1.57;
            wait[8] = 6.38;
            wait[9] = 32.78;
            wait[10] = 225.11;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(x, y);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
