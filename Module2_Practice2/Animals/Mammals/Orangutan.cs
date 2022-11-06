namespace Module2_Practice2.Animals.Mammals
{
    public class Orangutan : Primate
    {
        private readonly string _furColor;
        public Orangutan(string name, int populationNumber)
            : base(name, populationNumber, lifespan: 38, continents: new Continent[] { Continent.Asia })
        {
            _furColor = "red";
        }

        protected string FurColorInfo => $"FurColor: {_furColor}";

        public override void PrintInfo(IPrinter printer)
        {
            string separtor = " | ";
            var infoStrings = new string[] { NameInfo, FurColorInfo, PopulationInfo, LifespanInfo, ContinentsInfo };

            string info = string.Join(separtor, infoStrings);

            printer.Print(info);
        }
    }
}
