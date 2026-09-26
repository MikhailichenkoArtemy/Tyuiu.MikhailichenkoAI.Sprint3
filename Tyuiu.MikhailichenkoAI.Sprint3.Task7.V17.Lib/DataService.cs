using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MikhailichenkoAI.Sprint3.Task7.V17.Lib
{
    public class DataService : ISprint3Task7V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;

            double[] valueArray = new double[len];

            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if ((x + 1.7) == 0)
                {
                    y = 0;
                }
                else
                {
                    y = (Math.Sin(x) / (x + 1.7)) - (Math.Cos(x) * 4 * x) - 6;

                    y = Math.Round(y, 2);
                }

                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}
