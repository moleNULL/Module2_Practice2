namespace Module2_Practice2.Animals.Birds
{
    public class Bird : Animal
    {
        public Bird(string name, bool canFly, int populationNumber, int lifespan, Continent[] continents)
        {
            Name = name;
            CanFly = canFly;
            PopulationNumber = populationNumber;
            Lifespan = lifespan;
            Continents = continents;
        }

        public override string Name { get; set; }
        public bool CanFly { get; set; }
        public override int PopulationNumber { get; set; }
        public override int Lifespan { get; set; }
        public override Continent[] Continents { get; set; }

        protected override string NameInfo => $"Bird: {Name}";
        protected string CanFlyInfo => $"CanFly: {CanFly}";
        protected override string PopulationInfo => $"Population: {PopulationNumber} birds";

        public override string GetDescription()
        {
            string separtor = " | ";
            var infoStrings = new string[] { NameInfo, CanFlyInfo, PopulationInfo, LifespanInfo, ContinentsInfo };

            string info = string.Join(separtor, infoStrings);

            return info;
        }
    }
}
