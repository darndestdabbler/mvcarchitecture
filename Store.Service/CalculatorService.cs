namespace Store.Service
{
    public interface ICalculatorService
    {
        decimal Add(decimal left, decimal right);
        decimal Subtract(decimal left, decimal right);
    }

    public class CalculatorService : ICalculatorService
    {
        public decimal Add(decimal left, decimal right)
        {
            return left + right;
        }

        public decimal Subtract(decimal left, decimal right)
        {
            return left - right;
        }
    }
}
