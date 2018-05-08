using System;

namespace ChainOfResponsability.InsuranceContract
{
    /// <summary>
    /// Implements a regular insurance contract
    /// </summary>
    internal class RegularInsuranceContract : IInsuranceContract
    {
        private IInsuranceContract nextContract = new NoInsuranceContract();
        private int limitPrice;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegularInsuranceContract"></see> class.
        /// </summary>
        /// <param name="limitPrice">Limit price of the car.</param>
        public RegularInsuranceContract(int limitPrice)
        {
            this.limitPrice = limitPrice;
        }
        /// </inheritdoc>        
        public InsuranceResult GetInsuranceContract(CarInfo info)
        {
            if (info.DriverLicenseDate != null && info.Price >= this.limitPrice)
            {
                return new InsuranceResult
                {
                    HasInsurance = true,
                    Type = InsuranceType.Regular,
                    Amount = 200,
                    Franchise = Decimal.MaxValue                };
            }
            else
            {
                return this.nextContract.GetInsuranceContract(info);
            }
        }

        /// </inheritdoc>
        public void RegisterNext(IInsuranceContract nextContract)
        {
            this.nextContract = nextContract ?? throw new ArgumentNullException(nameof(IInsuranceContract));
        }
    }
}
