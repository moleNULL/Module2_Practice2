namespace Module2_Practice2.Animals.Mammals
{
    public class Primate : Mammal
    {
        public Primate(string name, int populationNumber, int lifespan, Continent[] continents)
            : base(name, hasFur: true, populationNumber, lifespan, continents)
        {
        }

        protected override string PopulationInfo => $"Population: {PopulationNumber} monkeys";
    }
}
