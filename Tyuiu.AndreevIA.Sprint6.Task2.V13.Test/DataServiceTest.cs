using Tyuiu.AndreevIA.Sprint6.Task2.V13.Lib;
namespace Tyuiu.AndreevIA.Sprint6.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] wait = [3.63, -11.7, -14.02, -5.24, 1.32, 0, -1.32, 5.24, 14.02, 11.7, -3.63];
            CollectionAssert.AreEqual(wait, ds.GetMassFunction(-5, 5));
        }
    }
}