namespace AbstractFactory.Bikes
{
    internal class Superbike : IBike
    {
        /// <summary>
        /// Class for Superbikes.
        /// </summary>
        public string GetMaximunEngineDisplacement()
        {
            return "Up to 1200 cm3";
        }
    }
}
