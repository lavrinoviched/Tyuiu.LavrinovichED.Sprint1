using Tyuiu.LavrinovichED.Sprint1.Task6.V10.Lib; 

namespace Tyuiu.LavrinovichED.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Утром выпал снег"; 
            DataService ds = new DataService(); 
            string res = ds.DeleteMiddleLetter( strTest );
            string wail = "Утом выал снег"; 
            Assert.AreEqual( wail, res ); 
        }
    }
}