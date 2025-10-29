using Tyuiu.ZelenovaIV.Sprint2.Task5.V2.Lib;

namespace Tyuiu.ZelenovaIV.Sprint2.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var ds = new DataService();
            Assert.AreEqual(ds.FindMonthSeason(1), "зима");
        }
        [TestMethod]
        public void ValidExpression2()
        {
            var ds = new DataService();
            Assert.AreEqual(ds.FindMonthSeason(5), "весна");
        }
    }
}
