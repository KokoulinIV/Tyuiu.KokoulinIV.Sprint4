using Tyuiu.KokoulinIV.Sprint4.Task2.V26.Lib;
namespace Tyuiu.KokoulinIV.Sprint4.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 1, 1, 1, 1, 1, 1, 5, 1, 4, 8, 5, 4, 2, 6 };
            int wail = 25;
            int resArray;
            resArray = ds.Calculate(array);
            Assert.AreEqual(wail, resArray);
        }
    }
}