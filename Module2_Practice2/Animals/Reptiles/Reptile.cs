namespace Module2_Practice2.Animals.Reptiles
{
    public class Reptile : Animal
    {
        public Reptile(string name, bool canSwim, int populationNumber, int lifespan, Continent[] continents)
        {
            Name = name;
            CanSwim = canSwim;
            PopulationNumber = populationNumber;
            Lifespan = lifespan;
            Continents = continents;
        }

        public override string Name { get; set; }
        public bool CanSwim { get; set; }
        public override int PopulationNumber { get; set; }
        public override int Lifespan { get; set; }
        public override Continent[] Continents { get; set; }

        protected override string NameInfo => $"Reptile: {Name}";
        protected string CanSwimInfo => $"CanSwim: {CanSwim}";
        protected override string PopulationInfo => $"Population: {PopulationNumber} reptiles";

        public override string GetDescription()
        {
            string separtor = " | ";
            var infoStrings = new string[] { NameInfo, CanSwimInfo, PopulationInfo, LifespanInfo, ContinentsInfo };

            string info = string.Join(separtor, infoStrings);

            return info;
        }
    }
}
