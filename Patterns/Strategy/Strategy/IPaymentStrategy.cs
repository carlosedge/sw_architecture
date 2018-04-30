namespace Strategy
{
    /// <summary>
    /// Interface for the payment strategy. Implementation can be used to generate different strategies for payment.
    /// </summary>
    public interface IPaymentStrategy
    {
        /// <summary>
        /// Accepts a payment with the specified amount.
        /// </summary>
        /// <param name="amount">Amount of the payment.</param>
        /// <returns>True if operation succeded. False otherwise.</returns>
        bool AcceptPayment(decimal amount);
    }
}
