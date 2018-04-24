namespace AbstractFactory.Cars
{
    internal class FormulaOne : ICar
    {
        /// <summary>
        /// Class for F1 cars.
        /// </summary>
        public string GetWingConfiguration()
        {
            return "Adjustable front and rear wings";
        }
    }
}
