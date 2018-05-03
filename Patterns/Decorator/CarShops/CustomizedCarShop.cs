namespace Decorator.CarShops
{
    using System;

    /// <summary>
    /// This class a example of a car shop that creates customized cars modifying the stock car.
    /// </summary>
    public class CustomizedCarShop : ICarShop
    {
        /// <summary>
        /// This car shop is the class to decorate
        /// </summary>
        private ICarShop innerCarShop;

        /// <summary>
        /// Initializes a new instance of <see cref="CustomizedCarShop"/> class.
        /// </summary>
        /// <param name="innerCarShop">Inner car shop to decorate.</param>
        public CustomizedCarShop(ICarShop innerCarShop)
        {
            this.innerCarShop = innerCarShop;
        }

        /// <summary>
        /// Returns a customized car.
        /// </summary>
        /// <returns>The customized car.</returns>
        public Car CreateCar()
        {
            Car factoryCar = this.innerCarShop.CreateCar();

            factoryCar.AddXtra("Fancy lights.");
            factoryCar.AddXtra("Very noisy and annoying exhaust.");
            factoryCar.Rimsize = Convert.ToInt32(factoryCar.Rimsize * 1.2);
            factoryCar.Engine.EngineDisplacement = Convert.ToInt32(factoryCar.Engine.EngineDisplacement * 1.1);
            factoryCar.Engine.MaxRpm = Convert.ToInt32(factoryCar.Engine.MaxRpm * 1.1);

            return factoryCar;
        }
    }
}
