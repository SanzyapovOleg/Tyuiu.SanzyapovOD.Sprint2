using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SanzyapovOD.Sprint2.Task4.V12.Lib
{
    public class DataService : ISprint2Task4V12
    {
        public double Calculate(double x, double y)
        {
            double z;
            z = (Math.Sqrt(x) > (y * 2) ? Math.Pow(7 + (2 / y * y), x) : (3 * Math.Pow(x, 2) - Math.Cos(y * y) + 10)) / (Math.Pow(y, 2) - Math.Sin(x * x) + 12);
            return Math.Round((z), 3);
        }
    }
}
