using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ChirchenkoME.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {   
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool inCircle = (x * x + y * y) <= 1.0;
            bool belowXAxis = y <= 0;
            bool betweenLines = y >= -Math.Abs(x);

            return inCircle && belowXAxis && betweenLines;
        }
    }
}