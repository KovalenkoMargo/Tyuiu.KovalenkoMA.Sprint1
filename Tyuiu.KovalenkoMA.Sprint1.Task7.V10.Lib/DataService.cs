using System.Security.Cryptography;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KovalenkoMA.Sprint1.Task7.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        public double Calculate(double x)
        {
            double r1 = 2 * (1 / Math.Tan(3 * x));
            double r2 = Math.Log(Math.Cos(x));
            double r3 = Math.Log(1 + Math.Pow(x, 2));
            return Math.Round(r1 - r2 / r3, 3);
        }
    }
}
