using Tyuiu.ZakachurinIE.Sprint3.Task0.V6.Lib;

namespace Tyuiu.ZakachurinIE.Sprint3.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidChet()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 15;
            var res = ds.GetMultiplySeries(x, y);
            Assert.AreEqual(0.001,res);
        }
    }
}
