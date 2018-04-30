namespace Strategy.Strategies.Payment
{
    /// <summary>
    /// Implementation of the bank account payment strategy.
    /// </summary>
    internal class BankTransferPaymentStrategy : IPaymentStrategy
    {
        /// <summary>
        /// Cardee information
        /// </summary>
        private string bankAccountDetails;

        /// <summary>
        /// Initializes a new instance of the <see cref="BankTransferPaymentStrategy"></see> class.
        /// </summary>
        /// <param name="bankAccountDetails"></param>
        public BankTransferPaymentStrategy(string bankAccountDetails)
        {
            this.bankAccountDetails = bankAccountDetails;
        }

        public bool AcceptPayment(decimal amount)
        {
            // Do some check with bank account info...
            // It will return true if the operation success. Otherwise will return false...
            return true;
        }
    }
}
