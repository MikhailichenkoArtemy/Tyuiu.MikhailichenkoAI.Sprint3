using Tyuiu.MikhailichenkoAI.Sprint3.Task0.V17.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint3.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10; 

            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = -0.709; 
            Assert.AreEqual(wait, res);
        }
    }
}