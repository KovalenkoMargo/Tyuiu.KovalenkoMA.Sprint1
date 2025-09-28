using Tyuiu.KovalenkoMA.Sprint1.Task4.V8.Lib;
namespace Tyuiu.KovalenkoMA.Sprint1.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 7;
            double y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.3, res);
        }
    }
}
