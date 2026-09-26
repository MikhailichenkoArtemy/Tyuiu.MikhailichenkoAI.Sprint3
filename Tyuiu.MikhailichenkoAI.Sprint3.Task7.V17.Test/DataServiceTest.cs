using Tyuiu.MikhailichenkoAI.Sprint3.Task7.V17.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint3.Task7.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] wait = new double[len];
            wait[0] = -0.62;  
            wait[1] = -16.79; 
            wait[2] = -17.77; 
            wait[3] = -6.30;  
            wait[4] = -5.04;  
            wait[5] = -6.00;  
            wait[6] = -7.85;  
            wait[7] = -2.43;  
            wait[8] = 5.91;   
            wait[9] = 4.33;   
            wait[10] = -11.82;

            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
