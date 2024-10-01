using tyuiu.cources.programming.interfaces.Sprint1; 

namespace Tyuiu.LavrinovichED.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            string[] words = value.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            foreach (string word in words)
            {
                if (word.Length % 2 != 0)
                {
                    int middleIndex = word.Length / 2;
                    result += word.Remove(middleIndex, 1) + " ";
                }
                else
                {
                    result += word + " ";
                }
            }
            return result.Trim();
        }
    }
}
