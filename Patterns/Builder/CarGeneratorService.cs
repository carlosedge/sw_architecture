namespace Builder
{
    using System;
    using System.Collections.Generic;

    public class CarGeneratorService
    {
        /// <summary>
        /// CarBuilder instance.
        /// </summary>
        private ICarBuilder carBuilder;

        /// <summary>
        /// List of seats type.
        /// </summary>
        private List<string> seatsType = new List<string> { "fabric", "leather", "alcantara" };

        /// <summary>
        /// List of interior colors.
        /// </summary>
        private List<string> interiorColor = new List<string> { "black", "white", "red" };

        /// <summary>
        /// Initializes a new instance of the <see cref="CarGeneratorService"/> class.
        /// </summary>
        /// <param name="carBuilder">The car builder.</param>
        public CarGeneratorService(ICarBuilder carBuilder)
        {
            this.carBuilder = carBuilder;
        }

        /// <summary>
        /// Returns a Random generated car.
        /// </summary>
        /// <returns>The car.</returns>
        public Car GenerateNewCar()
        {
            Random random = new Random();

            return this.carBuilder.CreateCar(new Engine
            {
                EngineDisplacement = random.Next(800, 5000),
                MaxRpm = random.Next(4000, 10000)
            }
            )
            .WithDoors(random.Next(1, 5))
            .WithRimsSize(random.Next(15, 18))
            .WithTrunkCapacity(random.Next(0, 1300))
            .WithExtra($"{seatsType[random.Next(1, 3)]} seats.")
            .WithExtra($"{interiorColor[random.Next(1, 3)]} interior.")
            .WithExtra($"{random.Next(1, 3)} speakers audio system.")
            .Build();
        }

        
    }
}
