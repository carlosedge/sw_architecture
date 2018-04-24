namespace AbstractFactory.Cars
{
    internal class GT : ICar
    {
        /// <summary>
        /// Class for GT cars.
        /// </summary>
        public string GetWingConfiguration()
        {
            return "Only rear wing is adjustable";
        }
    }
}
