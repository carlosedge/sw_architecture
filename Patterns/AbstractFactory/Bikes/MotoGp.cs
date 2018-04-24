namespace AbstractFactory.Bikes
{
    /// <summary>
    /// Class for MotoGP bikes.
    /// </summary>
    internal class MotoGp : IBike
    {
        public string GetMaximunEngineDisplacement()
        {
            return "Up to 1000 cm3";
        }
    }
}
