namespace Module2_Practice2.Animals.Reptiles
{
    public class Crocodile : Reptile
    {
        public Crocodile(string name, int populationNumber, int lifespan, Continent[] continents)
            : base(name, canSwim: true, populationNumber, lifespan, continents)
        {
        }

        protected override string PopulationInfo => $"Population: {PopulationNumber} crocodiles";
    }
}
