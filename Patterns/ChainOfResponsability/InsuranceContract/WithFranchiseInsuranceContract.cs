using System;

namespace ChainOfResponsability.InsuranceContract
{
    /// <summary>
    /// Implements a comprehensive insurance contract with franchise
    /// </summary>
    internal class WithFranchiseInsuranceContract : IInsuranceContract
    {
        private IInsuranceContract nextContract = new NoInsuranceContract();
        private int daysPurchase;

        /// <summary>
        /// Initializes a new instance of the <see cref="WithFranchiseInsuranceContract"></see> class.
        /// </summary>        
        /// <param name="daysPurchase">Limit of days from the purchase date.</param>
        public WithFranchiseInsuranceContract (int daysPurchase)
        {            
            this.daysPurchase = daysPurchase;
        }

        /// </inheritdoc>        
        public InsuranceResult GetInsuranceContract(CarInfo info)
        {
            if (info.DriverLicenseDate != null 
                && (info.PurchaseDate - DateTime.Now).TotalDays <= this.daysPurchase )
            {
                return new InsuranceResult
                {
                    HasInsurance = true,
                    Type = InsuranceType.ComprehensiveWithFranchise,
                    Amount = 1000 + (1000 * 1 / this.daysPurchase),
                    Franchise = 200
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
