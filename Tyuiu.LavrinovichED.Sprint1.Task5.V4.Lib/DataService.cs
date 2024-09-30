using tyuiu.cources.programming.interfaces.Sprint1; 

namespace Tyuiu.LavrinovichED.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int time)
        {
            int res = time / 4419; 
            return res; 
        }
    }
}
