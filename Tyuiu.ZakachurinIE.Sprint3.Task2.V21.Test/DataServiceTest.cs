using Tyuiu.ZakachurinIE.Sprint3.Task2.V21.Lib;

namespace Tyuiu.ZakachurinIE.Sprint3.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.5;
            int y = 1;
            int z = 10;
            var res = ds.GetSumSeries(x, y, z);
            Assert.AreEqual(0.298, res);
        }
    }
}
