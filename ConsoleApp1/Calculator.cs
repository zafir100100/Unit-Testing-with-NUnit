namespace ConsoleApp1
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;

        public double Sub(double a, double b) => a - b;

        public double Mul(double a, double b) => a * b;

        public double Div(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }
    }
}
