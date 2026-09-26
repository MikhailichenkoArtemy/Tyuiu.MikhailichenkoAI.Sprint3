using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MikhailichenkoAI.Sprint3.Task2.V4.Lib
{
    public class DataService : ISprint3Task2V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1;
            int k = startValue;

            do
            {
                double term = Math.Pow(k / Math.Pow(Math.Sin(1), -7), -2);
                p *= term; 

                k++; 
            }
            while (k <= stopValue); 

            return Math.Round(p, 3);
        }
    }
}
