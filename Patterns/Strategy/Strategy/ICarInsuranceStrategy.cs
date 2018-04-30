namespace Strategy
{
    /// <summary>
    /// Interface for the insurance strategy. Implementation can be used to generate different strategies for creating an insurance contract.
    /// </summary>
    public interface ICarInsuranceStrategy
    {
        /// <summary>
        /// Generates an insurance contract and returns if it was created.
        /// </summary>
        /// <returns>True if insurance contract was created. False otherwise.</returns>
        bool CreateInsuranceContract();
    }
}
