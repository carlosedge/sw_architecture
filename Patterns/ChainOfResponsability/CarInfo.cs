using System;

namespace ChainOfResponsability
{
    /// <summary>
    /// Class provided with the car information needed to create an insurance contract.
    /// </summary>
    public class CarInfo
    {
        /// <summary>
        /// Gets or sets the car price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the date of purchase.
        /// </summary>
        public DateTime PurchaseDate { get; set; }

        /// <summary>
        /// Gets or sets the date of birth of the driver.
        /// </summary>
        public DateTime DriverDateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the date of the driver license.
        /// </summary>
        public DateTime DriverLicenseDate { get; set; }
    }
}
