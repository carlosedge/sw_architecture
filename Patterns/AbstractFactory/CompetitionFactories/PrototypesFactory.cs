using AbstractFactory.Bikes;
using AbstractFactory.Cars;

namespace AbstractFactory.CompetitionFactories
{
    /// <summary>
    /// Factory used for cars and bikes prototypes.
    /// </summary>
    internal class PrototypesFactory : ICompetitionFactory
    {
        public IBike CreateBike()
        {
            return new MotoGp();
        }

        public ICar CreateCar()
        {
            return new FormulaOne();
        }
    }
}
