using Tyuiu.ChirchenkoME.Sprint2.Task1.V1.Lib;

namespace Tyuiu.ChirchenkoME.Sprint2.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new();
            int a = 119, b = 196, c = 134, d = 327;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            bool[] wait = new bool[6] { true, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
