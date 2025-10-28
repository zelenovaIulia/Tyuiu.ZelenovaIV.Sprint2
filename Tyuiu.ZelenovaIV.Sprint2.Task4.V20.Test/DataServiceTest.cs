using Tyuiu.ZelenovaIV.Sprint2.Task4.V20.Lib;

namespace Tyuiu.ZelenovaIV.Sprint2.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 199;
            double res = ds.Calculate(x, y);
            double wait = 24.995;
            Assert.AreEqual(wait, res);
        }
    }
}
