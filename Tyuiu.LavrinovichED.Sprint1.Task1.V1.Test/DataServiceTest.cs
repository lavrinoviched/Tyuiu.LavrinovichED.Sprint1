using Tyuiu.LavrinovichED.Sprint1.Task1.V1.Lib; 

namespace Tyuiu.LavrinovichED.Sprint1.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 9.0; 
            double y = 3.0;
            double a = 2.0;
            var res = ds.Calculate(x, y, a); 
            Assert.AreEqual(54,5, res); 

        }
    }
}