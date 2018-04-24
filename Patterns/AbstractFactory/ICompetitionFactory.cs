namespace AbstractFactory
{
    internal interface ICompetitionFactory
    {
        ICar CreateCar();
        IBike CreateBike();
    }
}
