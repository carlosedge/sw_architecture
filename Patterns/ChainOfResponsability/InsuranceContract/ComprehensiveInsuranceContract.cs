using System;

namespace ChainOfResponsability.InsuranceContract
{
    /// <summary>
    /// Implements a comprehensive insurance contract
    /// </summary>
    internal class ComprehensiveInsuranceContract : IInsuranceContract
    {
        private IInsuranceContract nextContract = new NoInsuranceContract();
        private int daysDriver;
        private int daysPurchase;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComprehensiveInsuranceContract"></see> class.
        /// </summary>
        /// <param name="daysDriver">Minimun days of the driver.</param>
        /// <param name="daysPurchase">Limit of days from the purchase date.</param>
        public ComprehensiveInsuranceContract(int daysDriver, int daysPurchase)
        {
            this.daysDriver = daysDriver;
            this.daysPurchase = daysPurchase;
        }

        /// </inheritdoc>        
        public InsuranceResult GetInsuranceContract(CarInfo info)
        {
            /// Note that these checks can be also refactored in another chain of responsability :-)
            if (info.DriverLicenseDate != null 
                && info.DriverDateOfBirth != null
                && ((info.DriverDateOfBirth - DateTime.Now).TotalDays >= this.daysDriver)
                && (info.PurchaseDate - DateTime.Now).TotalDays <= this.daysPurchase)
            {
                return new InsuranceResult
                {
                    HasInsurance = true,
                    Type = InsuranceType.Comprehensive,
                    Amount = 1000 + (1000 * 1 / this.daysPurchase),
                    Franchise = 0                    
                };
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
