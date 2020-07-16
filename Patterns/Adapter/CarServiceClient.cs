using Adapter.Repository;
using Adapter.Adapter;
using System.Collections.Generic;

namespace Adapter
{
    /// <summary>
    /// Example of client that uses the <see cref="ICarServiceAdapter"/> interface
    /// </summary>
    public class CarServiceClient
    {
        private ICarServiceAdapter carServiceAdapter = new CarJsonAdapter();
        private ICarRepository carRepository = new CarRepository();

        /// <summary>
        /// Returns a list of rental cars that meet the parameters.
        /// </summary>
        /// <param name="numberOfDoors">Number of doors.</param>
        /// <param name="rentalPrice">Rental price.</param>
        /// <param name="trunkCapacity">Trunk capacity.</param>
        /// <returns>List of cars in JSON format.</returns>
        public string GetRentalCars(int numberOfDoors, decimal rentalPrice, int trunkCapacity)
        {
            List<Car> cars = this.carRepository.GetCars(new CarSearchCriteria
            {
                NumberOfDoors = numberOfDoors,
                RentalPrice = rentalPrice,
                TrunkCapacity = trunkCapacity
            });
            return this.carServiceAdapter.GetRentalCar(cars);
        }
    }
}
