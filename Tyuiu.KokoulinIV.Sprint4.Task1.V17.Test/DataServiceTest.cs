using Tyuiu.KokoulinIV.Sprint4.Task1.V17.Lib;
namespace Tyuiu.KokoulinIV.Sprint4.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 1, 7, 6, 3, 2, 5, 7, 6, 7, 6, 5, 4, 7, 6 };
            int wail = 30;
            int resArray;
            resArray = ds.Calculate(array);
            Assert.AreEqual(wail, resArray);
        }
    }
}