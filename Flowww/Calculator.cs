
namespace Flowww.unit_tests
{
    public class Calculator
    {
        public static float Divide(int numerator, int denominator)
        {
            if (denominator is 0)
                throw new DivideByZeroException();

            return numerator / denominator;
        }
    }
}