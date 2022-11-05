namespace Module2_Practice2.Animals.Birds
{
    public class Bird : Animal
    {
        public Bird(string name, bool canFly, int populationNumber, int lifespan, string[] continents)
        {
            Name = name;
            CanFly = canFly;
            PopulationNumber = populationNumber;
            Lifespan = lifespan;
            Continents = continents;
        }

        protected override string Name { get; set; }
        protected bool CanFly { get; set; }
        protected override int PopulationNumber { get; set; }
        protected override int Lifespan { get; set; }
        protected override string[] Continents { get; set; }

        protected override string NameInfo => $"Bird: {Name}";
        protected string CanFlyInfo => $"CanFly: {CanFly}";
        protected override string PopulationInfo => $"Population: {PopulationNumber} birds";

        public override void PrintInfo(IPrinter printer)
        {
            string separtor = " | ";
            var infoStrings = new string[] { NameInfo, CanFlyInfo, PopulationInfo, LifespanInfo, ContinentsInfo };

            string info = string.Join(separtor, infoStrings);

            printer.Print(info);
        }
    }
}
