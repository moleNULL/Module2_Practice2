namespace Module2_Practice2.Animals.Reptiles
{
    public class Snake : Reptile
    {
        private bool _isPoisonous;
        public Snake(string name, int populationNumber, int lifespan, bool isPoisonous, Continent[] continents)
            : base(name, canSwim: true, populationNumber, lifespan, continents)
        {
            _isPoisonous = isPoisonous;
        }

        protected string IsPoisonousInfo => $"IsPoisonous: {_isPoisonous}";

        protected override string PopulationInfo => $"Population: {PopulationNumber} snakes";
    }
}
