namespace Builder.CarBuilders
{
    public class CarBuilder : ICarBuilder
    {
        /// <summary>
        /// Car object used for creation.
        /// </summary>
        private Car car;
        
        /// </inheritdoc>
        public Car Build()
        {
            return this.car;
        }

        /// </inheritdoc>
        public ICarBuilder WithDoors(int number)
        {
            this.car.NumberOfDoors = number;
            return this;
        }

        /// </inheritdoc>
        public ICarBuilder CreateCar(Engine engine)
        {
            this.car = new Car { Engine = engine };
            return this;
        }

        /// </inheritdoc>
        public ICarBuilder WithExtra(string description)
        {
            this.car.AddXtra(description);
            return this;
        }

        /// </inheritdoc>
        public ICarBuilder WithRimsSize(int size)
        {
            this.car.Rimsize = size;
            return this;
        }

        /// </inheritdoc>
        public ICarBuilder WithTrunkCapacity(int litres)
        {
            this.car.TrunkCapacity = litres;
            return this;
        }
    }
}
