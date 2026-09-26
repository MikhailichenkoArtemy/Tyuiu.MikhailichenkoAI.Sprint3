using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MikhailichenkoAI.Sprint3.Task3.V28.Lib
{
    public class DataService : ISprint3Task3V28
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string result = "";

            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    result += item; 
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
