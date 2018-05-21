namespace Adapter
{
    /// <summary>
    /// Interface for the car service adaptare.
    /// This interface is an example of the use of adapter pattern.
    /// The format required is a string, so the implementation will convert the result to string.
    /// </summary>
    public interface ICarServiceAdapter
    {
        /// <summary>
        /// returns a string that contains a list of rental cars that meet a specific criteria.
        /// </summary>
        /// <param name="numberOfDoors">The number of doors required.</param>
        /// <param name="rentalPrice">The rental price required.</param>
        /// <param name="trunkCapacity">The trunk capacity.</param>
        /// <returns>A string containing the list of available cars.</returns>
        string GetRentalCar(int numberOfDoors, decimal rentalPrice, int trunkCapacity);
    }
}