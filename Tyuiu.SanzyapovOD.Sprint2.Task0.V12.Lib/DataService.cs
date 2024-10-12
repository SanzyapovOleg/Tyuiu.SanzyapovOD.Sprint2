using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SanzyapovOD.Sprint2.Task0.V12.Lib
{
    public class DataService : ISprint2Task0V12
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result;
            result = new bool[6];
            if (x == 1095)
            {
                result[0] = true;
            }

            if (y != 1095)
            {
                result[1] = false;
            }

            if (y < x)
            {
                result[2] = true;
            }

            if (x > y)
            {
                result[3] = false;
            }

            if (y <= x)
            {
                result[4] = true;
            }

            if (x >= y)
            {
                result[5] = false;
            }

            return result;
        }
    }
}
