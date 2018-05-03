namespace Singleton
{
    /// <summary>
    /// This class has an example of the singleton pattern.
    /// Note that the class is sealed to avoid inheritance.
    /// </summary>
    public sealed class TrafficInfoService
    {
        /// <summary>
        /// The instance initialized directly to be thread safe.
        /// </summary>
        private static readonly TrafficInfoService instance = new TrafficInfoService();

        /// <summary>
        /// Private constructor to avoid the instanciation from outside.
        /// </summary>
        private TrafficInfoService() { }

        /// <summary>
        /// Returns the only instance allowed of this class. 
        /// </summary>
        public static TrafficInfoService Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// Returns the traffic info status
        /// </summary>
        /// <returns>The traffic info report.</returns>
        public string GetTrafficInfo()
        {
            return "Traffic info report goes here.";
        }
    }
}
