namespace Decorator
{
    using Decorator.CarShops;    

    /// <summary>
    /// This service class is an example of the use of the decorator pattern.
    /// The carShop implementation (should be injected in constructor) has been decorated by another implementation.
    /// </summary>
    public class CarShopService
    {
        /// <summary>
        /// The car shop implementation.
        /// </summary>
        private ICarShop carShop = new CustomizedCarShop(new StockCarShop());

        /// <summary>
        /// Returns a car.
        /// </summary>
        /// <returns>The car.</returns>
        public Car BuildCar()
        {
            return this.carShop.CreateCar();
        }
    }
}
