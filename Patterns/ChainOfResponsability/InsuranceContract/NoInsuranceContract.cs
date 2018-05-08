using System;

namespace ChainOfResponsability.InsuranceContract
{
    /// <summary>
    /// The default implementation for the IInsuranceContract interface.
    /// </summary>
    internal class NoInsuranceContract : IInsuranceContract
    {
        /// </inheritdoc>        
        public InsuranceResult GetInsuranceContract(CarInfo info)
        {
            return new InsuranceResult
            {
                HasInsurance = false,
                Type = InsuranceType.NoInsurance
            };
        }

        /// </inheritdoc>
        public void RegisterNext(IInsuranceContract nextContract)
        {
            throw new InvalidOperationException("Can not set another contract after the end of chain.");
        }
    }
}
