using Tyuiu.LavrinovichED.Sprint1.Task6.V10.Lib; 

namespace Tyuiu.LavrinovichED.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "����� ����� ����"; 
            DataService ds = new DataService(); 
            string res = ds.DeleteMiddleLetter( strTest );
            string wail = "���� ���� ����"; 
            Assert.AreEqual( wail, res ); 
        }
    }
}