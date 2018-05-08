using ChainOfResponsability.InsuranceContract;

namespace ChainOfResponsability
{
    /// <summary>
    /// Example of a car insurance selector based on the change of responsability pattern.
    /// The insurance modes will be analyzed in the order of the chain.
    /// Each one checks different fields of the car info data object.
    /// If one of them meets the conditions, it will return the result and the remaining ones will not be executed.
    /// </summary>
    public class CarAssuranceService
    {
        public InsuranceResult GetInsuranceResult(CarInfo info)
        {
            IInsuranceContract comprhensiveInsurance = new ComprehensiveInsuranceContract(1000, 4000);
            IInsuranceContract franchiseInsurance = new WithFranchiseInsuranceContract(6000);
            IInsuranceContract regularInsurance = new RegularInsuranceContract(1000);

            // Specify the order of the chain of responsability. The default implementation avoids to define the next for the last one.
            comprhensiveInsurance.RegisterNext(franchiseInsurance);
            franchiseInsurance.RegisterNext(regularInsurance);

            return comprhensiveInsurance.GetInsuranceContract(info);
        }
    }
}
