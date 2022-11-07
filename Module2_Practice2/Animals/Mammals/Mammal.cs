namespace Module2_Practice2.Animals.Mammals
{
    public class Mammal : Animal
    {
        public Mammal(string name, bool hasFur, int populationNumber, int lifespan, Continent[] continents)
        {
            Name = name;
            HasFur = hasFur;
            PopulationNumber = populationNumber;
            Lifespan = lifespan;
            Continents = continents;
        }

        public override string Name { get; set; }
        public bool HasFur { get; set; }
        public override int PopulationNumber { get; set; }
        public override int Lifespan { get; set; }
        public override Continent[] Continents { get; set; }

        protected override string NameInfo => $"Mammal: {Name}";
        protected string HasFurInfo => $"HasFur: {HasFur}";
        protected override string PopulationInfo => $"Population: {PopulationNumber} mammals";

        public override string GetDescription()
        {
            string separtor = " | ";
            var infoStrings = new string[] { NameInfo, HasFurInfo, PopulationInfo, LifespanInfo, ContinentsInfo };

            string info = string.Join(separtor, infoStrings);

            return info;
        }
    }
}
