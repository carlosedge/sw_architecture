namespace FactoryMethod.Cars
{
    /// <summary>
    /// Implementation of a sedan car: a car with four doors (the trunk is not a door!).
    /// </summary>
    internal class SedanCar : ICar
    {
        /// <inheritdoc />
        public int GetNumberOfDoors()
        {
            return 4;
        }
    }
}
