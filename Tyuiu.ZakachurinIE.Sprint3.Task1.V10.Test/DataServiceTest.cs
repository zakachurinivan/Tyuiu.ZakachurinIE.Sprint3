using Tyuiu.ZakachurinIE.Sprint3.Task1.V10.Lib;

namespace Tyuiu.ZakachurinIE.Sprint3.Task1.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 5;
            int y = 1;
            int z = 17;
            double res = ds.GetSumSeries(value, y, z);
            Assert.AreEqual(0.168, res);
        }
    }
}
