using Tyuiu.ZakachurinIE.Sprint3.Task6.V14.Lib;

namespace Tyuiu.ZakachurinIE.Sprint3.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 7;
            int y = 16;
            var res = ds.GetSumTheDivisors(x, y);
            Assert.AreEqual(15, res);
        }
    }
}
