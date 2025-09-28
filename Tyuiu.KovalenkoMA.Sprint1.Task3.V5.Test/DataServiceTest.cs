using Tyuiu.KovalenkoMA.Sprint1.Task3.V5.Lib;
namespace Tyuiu.KovalenkoMA.Sprint1.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 120;
            double b = 3.5;
            var res = ds.DistanceLength(a, b);
            Assert.AreEqual(420, res);
        }
    }
}
