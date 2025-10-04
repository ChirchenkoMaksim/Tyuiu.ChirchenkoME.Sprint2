using Tyuiu.ChirchenkoME.Sprint2.Task2.V16.Lib;

namespace Tyuiu.ChirchenkoME.Sprint2.Task2.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);

        }
    }
}
