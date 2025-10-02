using Tyuiu.GoryaevTT.Sprint2.Task2.V9.Lib;
namespace Tyuiu.GoryaevTT.Sprint2.Task2.V9.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int a = 1;
            int b = 1;
            bool res = ds.CheckDotInShadedArea(a, b);
            Assert.AreEqual(false,res);
        }
    }
}
