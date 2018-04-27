namespace Builder
{
    /// <summary>
    /// Interface for a builder of cars.
    /// Note that the interface has been designed with fluent API instead of creating void methods.
    /// </summary>
    public interface ICarBuilder
    {
        /// <summary>
        /// Creates a new car for the builder.
        /// </summary>
        /// <param name="engine">The engine used.</param>
        /// <returns>The builder instance.</returns>
        ICarBuilder CreateCar(Engine engine);

        /// <summary>
        /// Sets the trunk capacity.
        /// </summary>
        /// <param name="litres">Capacity in litres.</param>
        /// <returns>The builder instance.</returns>
        ICarBuilder WithTrunkCapacity(int litres);

        /// <summary>
        /// Sets the rims size.
        /// </summary>
        /// <param name="size">The size in inches.</param>
        /// <returns>The builder instance.</returns>
        ICarBuilder WithRimsSize(int size);

        /// <summary>
        /// Includes the number of doors.
        /// </summary>
        /// <param name="number">Number of doors.</param>
        /// <returns>The builder isntance.</returns>
        ICarBuilder WithDoors(int number);

        /// <summary>
        /// Includes a new extra in the car.
        /// </summary>
        /// <param name="description">The extra description.</param>
        /// <returns>The builder instance.</returns>
        ICarBuilder WithExtra(string description);

        /// <summary>
        /// Builds the car.
        /// </summary>
        /// <returns>The car.</returns>
        Car Build();
    }
}
