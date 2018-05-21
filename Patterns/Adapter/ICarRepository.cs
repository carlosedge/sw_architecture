namespace Adapter
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for a car repository.
    /// </summary>
    public interface ICarRepository
    {
        /// <summary>
        /// Returns a list of cars that meet the spedcified search criteria.
        /// </summary>
        /// <param name="criteria">The search criteria object.</param>
        /// <returns>List of cars filtered by the criteria.</returns>
        List<Car> GetCars(CarSearchCriteria criteria);
    }
}
