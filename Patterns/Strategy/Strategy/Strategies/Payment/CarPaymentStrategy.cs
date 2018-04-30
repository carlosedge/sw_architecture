namespace Strategy.Strategies.Payment
{
    /// <summary>
    /// Implementation of the car return payment strategy.
    /// </summary>
    internal class CarPaymentStrategy : IPaymentStrategy
    {
        /// <summary>
        /// Cardee information
        /// </summary>
        private string carInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarPaymentStrategy"></see> class.
        /// </summary>
        /// <param name="carInfo"></param>
        public CarPaymentStrategy(string carInfo)
        {
            this.carInfo = carInfo;
        }

        public bool AcceptPayment(decimal amount)
        {
            // Do some check and operations with the car in exchange.
            // It will return true if the operation success. Otherwise will return false...
            return true;
        }
    }
}
