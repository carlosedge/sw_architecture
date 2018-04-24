namespace FactoryMethod
{
    /// <summary>
    /// This class is a service that test the factory method pattern.
    /// </summary>
    internal class CarService
    {
        ICarFactory defaultCarFactory;

        /// <summary>
        /// Creates a new instance of the <see cref="CarService"/> class.
        /// </summary>
        /// <param name="defaultCarFactory">The default car factory.</param>
        public CarService(ICarFactory defaultCarFactory)
        {
            this.defaultCarFactory = defaultCarFactory;
        }        

        /// <summary>
        /// Creates a car based in the default car factory.
        /// </summary>
        /// <returns></returns>
        public ICar Create()
        {
            return this.defaultCarFactory.Create();
        }

        /// <summary>
        /// Creates a car based in the car factory specified.
        /// </summary>
        /// <param name="carFactory">Factory used for creating the car.</param>
        /// <returns>The new car.</returns>
        public ICar Create(ICarFactory carFactory)
        {
            return carFactory.Create();
        }
    }
}
