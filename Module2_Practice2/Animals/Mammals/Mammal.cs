namespace Module2_Practice2.Animals.Mammals
{
    public class Mammal : Animal
    {
        public Mammal(string name, bool hasFur, int populationNumber, int lifespan, string[] continents)
        {
            Name = name;
            HasFur = hasFur;
            PopulationNumber = populationNumber;
            Lifespan = lifespan;
            Continents = continents;
        }

        protected override string Name { get; set; }
        protected bool HasFur { get; set; }
        protected override int PopulationNumber { get; set; }
        protected override int Lifespan { get; set; }
        protected override string[] Continents { get; set; }

        protected override string NameInfo => $"Mammal: {Name}";
        protected string HasFurInfo => $"HasFur: {HasFur}";
        protected override string PopulationInfo => $"Population: {PopulationNumber} mammals";

        public override void PrintInfo(IPrinter printer)
        {
            string separtor = " | ";
            var infoStrings = new string[] { NameInfo, HasFurInfo, PopulationInfo, LifespanInfo, ContinentsInfo };

            string info = string.Join(separtor, infoStrings);

            printer.Print(info);
        }
    }
}
