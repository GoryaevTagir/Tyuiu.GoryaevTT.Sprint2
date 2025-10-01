using Tyuiu.GoryaevTT.Sprint2.Task0.V18.Lib;
namespace Tyuiu.GoryaevTT.Sprint2.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckTask0()
        {
            int x = 5105;
            int y = 475;
            bool[] top = new bool[] {false, true, true, true, true, false};
            DataService ds = new DataService();
            bool[] res = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(top, res);
        }
    }
}
