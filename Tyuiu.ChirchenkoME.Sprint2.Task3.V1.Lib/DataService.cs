using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChirchenkoME.Sprint2.Task3.V1.Lib
{
    public class DataService : ISprint2Task3V1
    {
        public double Calculate(double x)
        {
            double y;
            if (x > 0)
            {
                y = (Math.Exp(x)) - (12 * x) + Math.Cos(x);
            }
            else if (x == 2)
            {
                y = x + (15 / x);
            }
            else if (x >= -5 && x <= 3)
            {
                y = x + (10 * x) - (1 / x);
            }
            else
            {
                y = x + (10 * x) - (1 / (Math.Pow(x, 3) + 3));
            }

            y = Math.Round(y, 3);
            return y;
        }
    }
}