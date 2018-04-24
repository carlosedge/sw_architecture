namespace FactoryMethod
{
    /// <summary>
    /// Interface for defining car factories.
    /// </summary>
    internal interface ICarFactory
    {
        /// <summary>
        /// Creates a new car.
        /// </summary>
        /// <returns>The new car.</returns>
        ICar Create(); 
    }
}
