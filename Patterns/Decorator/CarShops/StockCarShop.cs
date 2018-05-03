namespace Decorator.CarShops
{
    /// <summary>
    /// This class a example of a car shop that creates cars based on the stock specs.
    /// </summary>
    public class StockCarShop : ICarShop
    {
        public Car CreateCar()
        {
            return new Car()
            {
                Engine = new Engine
                {
                    EngineDisplacement = 2000,
                    MaxRpm = 4000
                },
                NumberOfDoors = 5,
                Rimsize = 16,
                TrunkCapacity = 400
            };
        }
    }
}
