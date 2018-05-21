namespace Adapter.Repository
{
    using System.Collections.Generic;
    using System.Linq;

    internal class CarRepository : ICarRepository
    {
        /// <inheritdoc></inheritdoc>
        public List<Car> GetCars(CarSearchCriteria criteria)
        {
            return this.GetDemoCars().Where(x =>
                x.NumberOfDoors >= criteria.NumberOfDoors
                && x.RentalPrice >= criteria.RentalPrice
                && x.TrunkCapacity >= criteria.TrunkCapacity).ToList();
        }

        /// <summary>
        /// Returns a predefined list of cars (for demostration).
        /// </summary>
        /// <returns>List of cars</returns>
        private List<Car> GetDemoCars()
        {
            return new List<Car>
            {
                new Car {Engine = new Engine{ EngineDisplacement = 1000, MaxRpm = 4000}, NumberOfDoors = 5 , RentalPrice = 150, TrunkCapacity = 300},
                new Car {Engine = new Engine{ EngineDisplacement = 1600, MaxRpm = 4000}, NumberOfDoors = 4 , RentalPrice = 180, TrunkCapacity = 470},
                new Car {Engine = new Engine{ EngineDisplacement = 1800, MaxRpm = 5000}, NumberOfDoors = 5 , RentalPrice = 250, TrunkCapacity = 510},
                new Car {Engine = new Engine{ EngineDisplacement = 2000, MaxRpm = 6000}, NumberOfDoors = 2 , RentalPrice = 350, TrunkCapacity = 240}
            };
        }
    }
}
