namespace FactoryMethod
{
    /// <summary>
    /// Interface to define a car 
    /// This is a very simple interface for example purposes. 
    /// It only has a method to get the number of doors the car has.
    /// </summary>
    internal interface ICar
    {
        /// <summary>
        /// Returns the number of doors
        /// </summary>
        /// <returns></returns>
        int GetNumberOfDoors();        
    }
}
