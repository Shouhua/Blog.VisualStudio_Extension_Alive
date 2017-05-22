namespace Service
{
    public sealed class CalculatorService
    {
        public int Sum(int augend, int addend)
        {
            return augend + addend;
        }

        public int Diffrence(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Product(int mulitplicand, int multiplier)
        {
            return mulitplicand * multiplier;
        }

        public int Quotient(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public int Remainder(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                return dividend;
            }

            return dividend % divisor;
        }
    }
}