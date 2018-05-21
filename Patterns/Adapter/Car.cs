using System;
using System.Collections.Generic;

namespace Adapter
{
    /// <summary>
    /// Class that defines a car 
    /// This is a class for example purposes. 
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        internal Car()
        {

        }

        /// <summary>
        /// The list of extras.
        /// </summary>
        private List<string> extrasList = new List<string>();

        /// <summary>
        /// Returns the engine
        /// </summary>
        /// <returns></returns>
        public Engine Engine { get; internal set; }

        /// <summary>
        /// Returns the number of doors.
        /// </summary>
        /// <returns></returns>
        public int NumberOfDoors { get; internal set; }

        /// <summary>
        /// Returns the price of the car.
        /// </summary>
        /// <returns>Size in inches.</returns>
        public decimal RentalPrice { get; internal set; }

        /// <summary>
        /// Returns the capacity of the trunk.
        /// </summary>
        /// <returns>Capacity in litres.</returns>
        public int TrunkCapacity { get; internal set; }

        /// <summary>
        /// Adds a new extra to the car.
        /// </summary>
        /// <param name="description">Description of the extra.</param>
        internal void AddXtra(string description)
        {
            extrasList.Add(description);
        }

        /// <summary>
        /// Returns the information about the extra equipement.
        /// </summary>
        /// <returns>Information.</returns>
        public string GetXtrasInfo()
        {
            return String.Join(Environment.NewLine, extrasList);
        }
    }
}
