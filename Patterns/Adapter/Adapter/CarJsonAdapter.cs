namespace Adapter.Adapter
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Implementation of the Car service adapter.
    /// This class will adapt the input and output of the repository used to the required by the service.
    /// In this case the result is converted to string by using JSON format.
    /// </summary>
    public class CarJsonAdapter : ICarServiceAdapter
    {
        private ICarRepository carRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarJsonAdapter"/> class.
        /// </summary>
        /// <param name="carRepository">The repository.</param>
        public CarJsonAdapter(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        /// <inheritdoc></inheritdoc>
        public string GetRentalCar( int numberOfDoors, decimal rentalPrice, int trunkCapacity)
        {
            CarSearchCriteria criteria = new CarSearchCriteria
            {
                NumberOfDoors = numberOfDoors,
                RentalPrice = rentalPrice,
                TrunkCapacity = trunkCapacity
            };

            List<Car> result = this.carRepository.GetCars(criteria);

            return result != null 
                ? JsonConvert.SerializeObject(result)
                : string.Empty;
        }
    }
}
