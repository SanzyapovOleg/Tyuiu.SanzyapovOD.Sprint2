using Tyuiu.SanzyapovOD.Sprint2.Task4.V12.Lib;
namespace Tyuiu.SanzyapovOD.Sprint2.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double y = 1, x = 1;
            Assert.AreEqual(23.618, ds.Calculate(x, y));
        }
    }
}