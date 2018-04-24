namespace AbstractFactory
{
    /// <summary>
    /// This class is a sservice that tests the abstract factory pattern.
    /// We have two types of interfaces, and we want to create a specific implementation of each one by using one concrete factory.
    /// Each implementation of the factory interface will create specific objects.
    /// </summary>
    internal class CompetitionService
    {
        private ICompetitionFactory competitionFactory;

        /// <summary>
        /// Creates a new instance of the <see cref="CompetitionService"/> class.
        /// </summary>
        /// <param name="competitionFactory">The competition factory implementation used.</param>
        public CompetitionService(ICompetitionFactory competitionFactory)
        {
            this.competitionFactory = competitionFactory;
        }

        /// <summary>
        /// Returns the car available for the competition.
        /// </summary>
        /// <returns>The car object.</returns>
        ICar GetCar()
        {
            return this.competitionFactory.CreateCar();
        }

        /// <summary>
        /// Returns the bike available for the competition.
        /// </summary>
        /// <returns>The bike object.</returns>
        IBike GetBike()
        {
            return this.competitionFactory.CreateBike();
        }
    }
}
