namespace Module2_Practice2.Animals.Mammals
{
    public class Primate : Mammal
    {
        public Primate(string name, int populationNumber, int lifespan)
            : base(name, hasFur: true, populationNumber, lifespan, continents: new string[] { "South America", "Asia", "Africa" })
        {
        }

        protected override string PopulationInfo => $"Population: {PopulationNumber} monkeys";
    }
}
