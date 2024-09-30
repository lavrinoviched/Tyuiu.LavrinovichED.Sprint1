using Tyuiu.LavrinovichED.Sprint1.Task3.V7.Lib; 

namespace Tyuiu.LavrinovichED.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double verst = 100;
            double x = 106.68;
            var res = ds.VerstsToKilometers(verst);
            Assert.AreEqual(x, res);
        }
    }
}