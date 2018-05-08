namespace ChainOfResponsability
{
    /// <summary>
    /// Interface for the chain of responsability algorithm.
    /// Returns a insurance contract depending of the information provided.
    /// </summary>
    internal interface IInsuranceContract
    {
        /// <summary>
        /// Registers the next insurance contract to evaluate if the current one does not meet the conditions.
        /// </summary>
        /// <param name="nextContract">The <see cref="IInsuranceContract"/> contract.</param>
        void RegisterNext(IInsuranceContract nextContract);

        /// <summary>
        /// Returns the contract available based on the car information provided.
        /// </summary>
        /// <param name="info">The information object.</param>
        /// <returns>The <see cref="InsuranceResult"/> object with the result.</returns>
        InsuranceResult GetInsuranceContract(CarInfo info);
    }
}
