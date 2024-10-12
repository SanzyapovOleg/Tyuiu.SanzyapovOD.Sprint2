using Tyuiu.SanzyapovOD.Sprint2.Task0.V12.Lib;
namespace Tyuiu.SanzyapovOD.Sprint2.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.GetCompareOperations(1095, 475)[0]);
        }
    }
}