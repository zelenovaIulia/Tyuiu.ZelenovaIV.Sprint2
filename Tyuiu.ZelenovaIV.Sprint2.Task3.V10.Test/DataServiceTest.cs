using Tyuiu.ZelenovaIV.Sprint2.Task3.V10.Lib;

namespace Tyuiu.ZelenovaIV.Sprint2.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            Assert.AreEqual(-1, ds.Calculate(0));
            Assert.AreEqual(0.167, ds.Calculate(-1));
            Assert.AreEqual(-1099.99, ds.Calculate(-100));
        }
    }
}
