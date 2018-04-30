namespace Strategy.Strategies.Insurance
{
    /// <summary>
    /// Implementation for the comprehensive insurance strategy.
    /// </summary>
    internal class ComprehensiveInsuranceStrategy : ICarInsuranceStrategy
    {
        /// </inheritdoc>
        public bool CreateInsuranceContract()
        {
            // Here is some stuff to check if the person meet the conditions and bla, bla bla...
            // If conditions are not met, it obviously must return false.
            return true;
        }
    }
}
