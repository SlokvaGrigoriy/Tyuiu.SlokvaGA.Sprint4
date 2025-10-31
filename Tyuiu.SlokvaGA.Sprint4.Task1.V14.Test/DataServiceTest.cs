using Tyuiu.SlokvaGA.Sprint4.Task1.V14.Lib;

namespace Tyuiu.SlokvaGA.Sprint4.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int wait = 18;
            int[] numsArray = { 1, 5, 3, 6, 5, 4, 8, 6, 8, 4, 2, 3, 1 };
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(wait, res);
        }
    }
}