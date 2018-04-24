namespace FactoryMethod.Cars
{
    /// <summary>
    /// Implementation of a hatchback: a car with five doors.
    /// </summary>
    internal class HatchbackCar : ICar
    {
        /// <inheritdoc />
        public int GetNumberOfDoors()
        {
            return 5;
        }
    }
}
