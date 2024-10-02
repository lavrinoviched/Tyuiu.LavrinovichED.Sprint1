using Tyuiu.LavrinovichED.Sprint1.Task7.V2.Lib; 

namespace Tyuiu.LavrinovichED.Sprint1.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = -0.085;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}