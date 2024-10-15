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
            double y = 4, x = 9;
            Assert.AreEqual(8.822, ds.Calculate(x, y));
        }
    }
}