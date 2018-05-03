namespace Decorator
{
    /// <summary>
    /// Interface for a car shop.
    /// </summary>
    public interface ICarShop
    {
        /// <summary>
        /// Returns a new car.
        /// </summary>
        /// <returns>The new car.</returns>
        Car CreateCar();
    }
}
