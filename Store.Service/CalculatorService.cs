namespace Store.Service
{
    /// <summary>
    /// The arithmetic behind the calculator page: the sum and the difference of two numbers.
    /// </summary>
    public interface ICalculatorService
    {
        /// <summary>Adds two numbers.</summary>
        /// <param name="left">The first number.</param>
        /// <param name="right">The number added to it.</param>
        /// <returns>The sum of <paramref name="left"/> and <paramref name="right"/>.</returns>
        decimal Add(decimal left, decimal right);
        /// <summary>Subtracts one number from another.</summary>
        /// <param name="left">The number subtracted from.</param>
        /// <param name="right">The number subtracted.</param>
        /// <returns><paramref name="left"/> minus <paramref name="right"/>.</returns>
        decimal Subtract(decimal left, decimal right);
    }

    /// <summary>
    /// The calculator's arithmetic, registered for <see cref="ICalculatorService"/> by the
    /// web project's *Service convention.
    /// </summary>
    public class CalculatorService : ICalculatorService
    {
        /// <inheritdoc />
        public decimal Add(decimal left, decimal right)
        {
            return left + right;
        }

        /// <inheritdoc />
        public decimal Subtract(decimal left, decimal right)
        {
            return left - right;
        }
    }
}
