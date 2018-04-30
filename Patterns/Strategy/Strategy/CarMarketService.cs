namespace Strategy
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class for buying cars. This class is an example of the Strategy pattern.
    /// The class uses different strategies of payment an insurance implementations. These are injected in the constructor.
    /// For the payments strategy, multiple implementations are accepted.
    /// </summary>
    public class CarMarketService
    {
        private ICarInsuranceStrategy insuranceStrategy;
        private IEnumerable<IPaymentStrategy> paymentStrategies;

        /// <summary>
        /// Initializes a new instance of <see cref="CarMarketService"/> class.
        /// </summary>
        /// <param name="insuranceStrategy"></param>
        /// <param name="paymentStrategies"></param>
        public CarMarketService(ICarInsuranceStrategy insuranceStrategy, IEnumerable<IPaymentStrategy> paymentStrategies)
        {
            this.insuranceStrategy = insuranceStrategy ?? throw new ArgumentException(nameof(insuranceStrategy));
            this.paymentStrategies = paymentStrategies ?? throw new ArgumentException(nameof(paymentStrategies));
        }

        /// <summary>
        /// Buys a car using the the insurance type and the payment strategies.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool BuyCar(decimal amount)
        {
            if (!this.insuranceStrategy.CreateInsuranceContract())
                return false;

            foreach (var strategy in this.paymentStrategies )
            {
                if (strategy.AcceptPayment(amount))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
