using Tyuiu.LavrinovichED.Sprint1.Task4.V18.Lib; 

namespace Tyuiu.LavrinovichED.Sprint1.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            double z = 0.011;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}