using Tyuiu.ZakachurinIE.Sprint3.Task4.V25.Lib;

namespace Tyuiu.ZakachurinIE.Sprint3.Task4.V25.Test
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
            var res = ds.Calculate(x,y);
            Assert.AreEqual(8.995,res);
        }
    }
}
