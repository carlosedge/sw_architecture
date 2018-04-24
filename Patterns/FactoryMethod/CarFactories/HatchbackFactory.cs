namespace FactoryMethod.CarFactories
{
    using FactoryMethod.Cars;

    /// <summary>
    /// Class for creating roadster cars
    /// </summary>
    internal class HatchbackFactory : ICarFactory
    {
        /// </inheritdoc>
        public ICar Create()
        {
            return new HatchbackCar();
        }
    }
}
