using Tyuiu.ZakachurinIE.Sprint3.Task5.V15.Lib;

namespace Tyuiu.ZakachurinIE.Sprint3.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 1;
            int z = 1;
            int n = 3;
            int m = 10;
            var res = ds.GetSumSumSeries(x, y, z, n, m);
            Assert.AreEqual(548.732, res);
        }
    }
}
