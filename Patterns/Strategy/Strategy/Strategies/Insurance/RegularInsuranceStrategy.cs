namespace Strategy.Strategies.Insurance
{
    /// <summary>
    /// Implementation for the regular insurance strategy.
    /// </summary>
    internal class RegularInsuranceStrategy : ICarInsuranceStrategy
    {
        public bool CreateInsuranceContract()
        {
            /// As a regular insurance, it won't probably check too much...
            return true;
        }
    }
}
