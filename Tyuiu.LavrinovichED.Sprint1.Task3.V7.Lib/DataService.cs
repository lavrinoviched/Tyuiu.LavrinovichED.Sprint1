using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LavrinovichED.Sprint1.Task3.V7.Lib
{
    public class DataService : ISprint1Task3V7
    {
        public double VerstsToKilometers(double verst)
        {
            var res = Math.Round(verst * 1.0668, 3);
            return res; 

        }
    }
}
