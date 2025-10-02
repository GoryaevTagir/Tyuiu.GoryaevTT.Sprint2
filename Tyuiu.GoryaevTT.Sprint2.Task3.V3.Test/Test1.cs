using Tyuiu.GoryaevTT.Sprint2.Task3.V3.Lib;
namespace Tyuiu.GoryaevTT.Sprint2.Task3.V3.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 1;
            Class1 ds = new Class1();
            double res = ds.Calculate(x);
            Assert.AreEqual(0, res);
        }
    }
}
