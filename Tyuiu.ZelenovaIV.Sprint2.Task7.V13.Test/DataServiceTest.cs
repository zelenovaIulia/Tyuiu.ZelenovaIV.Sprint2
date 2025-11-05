using Tyuiu.ZelenovaIV.Sprint2.Task7.V13.Lib;

namespace Tyuiu.ZelenovaIV.Sprint2.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = -1;
            double y = 0.7;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(false, res);
        }
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double x = 0.8;
            double y = 0.7;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}
