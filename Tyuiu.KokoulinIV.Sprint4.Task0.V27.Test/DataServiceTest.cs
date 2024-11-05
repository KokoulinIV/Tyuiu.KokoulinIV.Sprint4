using Tyuiu.KokoulinIV.Sprint4.Task0.V27.Lib;
namespace Tyuiu.KokoulinIV.Sprint4.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int wail = 6615;
            int resArray  ;
            resArray = ds.GetMultOddArrEl(array);
            Assert.AreEqual(wail, resArray);
        }

    }





















        //{7 ,4 ,3 ,2 ,1 ,5 ,9 ,8 ,7 ,4}
    
}