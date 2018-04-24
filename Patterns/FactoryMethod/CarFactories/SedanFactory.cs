namespace FactoryMethod.CarFactories
{
    using FactoryMethod.Cars;

    /// <summary>
    /// Class for creating sedan cars
    /// </summary>
    internal class SedanFactory : ICarFactory
    {
        /// </inheritdoc>
        public ICar Create()
        {
            return new SedanCar();
        }
    }
}
