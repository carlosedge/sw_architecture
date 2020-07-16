namespace Adapter.Adapter
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Implementation of the Car service adapter.
    /// This class will adapt the input and output of the repository used to the required by the service.
    /// In this case the result is converted to string by using JSON format.
    /// </summary>
    public class CarJsonAdapter : ICarServiceAdapter
    {

        /// <inheritdoc></inheritdoc>
        public string GetRentalCar(List<Car> cars)
        {          
            return cars != null 
                ? JsonConvert.SerializeObject(cars)
                : string.Empty;
        }
    }
}
