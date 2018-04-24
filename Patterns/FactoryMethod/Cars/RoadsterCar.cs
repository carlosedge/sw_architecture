namespace FactoryMethod.Cars
{
    /// <summary>
    /// Implementation of a roadster: a convertible car with two doors.
    /// </summary>
    internal class RoadsterCar : ICar
    {
        /// <inheritdoc />
        public int GetNumberOfDoors()
        {
            return 2;
        }
    }
}
