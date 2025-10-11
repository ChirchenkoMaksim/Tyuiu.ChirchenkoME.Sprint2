using Tyuiu.ChirchenkoME.Sprint2.Task6.V6.Lib;
namespace Tyuiu.ChirchenkoME.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCardName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Шестерка пик", ds.FindCardNameAndValue(1, 6));
            Assert.AreEqual("Дама треф", ds.FindCardNameAndValue(2, 12));
            Assert.AreEqual("Туз бубен", ds.FindCardNameAndValue(3, 14));
            Assert.AreEqual("Валет червей", ds.FindCardNameAndValue(4, 11));
            Assert.AreEqual("Десятка пик", ds.FindCardNameAndValue(1, 10));
        }
    }
}