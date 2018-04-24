using AbstractFactory.Bikes;
using AbstractFactory.Cars;

namespace AbstractFactory.CompetitionFactories
{
    /// <summary>
    /// Factory used for cars and bikes that comes from production models.
    /// </summary>
    internal class ProductionFactory : ICompetitionFactory
    {
        public IBike CreateBike()
        {
            return new Superbike();
        }

        public ICar CreateCar()
        {
            return new GT();
        }
    }
}
