using Tyuiu.SlokvaGA.Sprint4.Task2.V30.Lib;

namespace Tyuiu.SlokvaGA.Sprint4.Task2.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 3, 6, 5, 2, 7, 7, 4, 5, 2, 6, 3 };
            int res = ds.Calculate(numsArray);
            int wait = 11025;
            Assert.AreEqual(wait, res);
        }
    }
}