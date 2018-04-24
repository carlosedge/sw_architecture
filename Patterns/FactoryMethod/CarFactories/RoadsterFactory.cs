namespace FactoryMethod.CarFactories
{
    using FactoryMethod.Cars;

    /// <summary>
    /// Class for creating roadster cars
    /// </summary>
    internal class RoadsterFactory : ICarFactory
    {
        /// </inheritdoc>
        public ICar Create()
        {
            return new RoadsterCar();
        }
    }
}
