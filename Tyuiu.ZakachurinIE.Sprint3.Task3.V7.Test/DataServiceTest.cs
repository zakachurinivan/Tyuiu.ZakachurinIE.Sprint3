using Tyuiu.ZakachurinIE.Sprint3.Task3.V7.Lib;

namespace Tyuiu.ZakachurinIE.Sprint3.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string n = "gft hggt ntg";
            char a = 'g';
            char b = '4';
            var res = ds.ReplaceCharOnNum(n, a, b);
            Assert.AreEqual("4ft h44t nt4", res);
        }
    }
}
