using Tyuiu.ChirchenkoME.Sprint2.Task5.V9.Lib;
namespace Tyuiu.ChirchenkoME.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetNextDate()
        {
            DataService ds = new DataService();
            Assert.AreEqual("02.01", ds.FindDateOfNextDay(1, 1));     
            Assert.AreEqual("01.02", ds.FindDateOfNextDay(1, 31));    
            Assert.AreEqual("02.02", ds.FindDateOfNextDay(2, 1));     
            Assert.AreEqual("02.03", ds.FindDateOfNextDay(3, 1));     
            Assert.AreEqual("01.04", ds.FindDateOfNextDay(3, 31));    
            Assert.AreEqual("02.04", ds.FindDateOfNextDay(4, 1));     
            Assert.AreEqual("01.05", ds.FindDateOfNextDay(4, 30));    
        }
    }
}