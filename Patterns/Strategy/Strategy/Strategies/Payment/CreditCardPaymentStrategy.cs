namespace Strategy.Strategies.Payment
{
    /// <summary>
    /// Implementation of the credit card payment strategy.
    /// </summary>
    internal class CreditCardPaymentStrategy : IPaymentStrategy
    {
        /// <summary>
        /// Cardee information
        /// </summary>
        private string cardInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCardPaymentStrategy"></see> class.
        /// </summary>
        /// <param name="cardInfo"></param>
        public CreditCardPaymentStrategy(string cardInfo)
        {
            this.cardInfo = cardInfo;
        }

        public bool AcceptPayment(decimal amount)
        {
            // Do some check with credit card info...
            // It will return true if the operation success. Otherwise will return false...
            return true;
        }
    }
}
