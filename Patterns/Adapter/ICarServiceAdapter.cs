using System.Collections.Generic;

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
        /// returns a string that contains a list of rental cars .
        /// </summary>
        /// <param name="cars">The car list.</param>
        /// <returns>The car list in string format.</returns>
        string GetRentalCar(List<Car> cars);
    }
}