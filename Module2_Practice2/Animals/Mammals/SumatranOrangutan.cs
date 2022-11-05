namespace Module2_Practice2.Animals.Mammals
{
    public class SumatranOrangutan : Orangutan, IAnimalExtendedInfo
    {
        private readonly string _country;
        public SumatranOrangutan(int populationNumber)
            : base(name: "Sumatran Orangutan", populationNumber)
        {
            ConservationStatus = ConservationStatus.CriticallyEndangered;
            AnimalOrder = AnimalOrder.Omnivore;
            _country = "Indonesia";

            Lifespan = 42; // change the Property that Orangutan class is responsible for
            Continents = new string[] { "Asia" }; // change the Property that Primate class is responsible for
        }

        public ConservationStatus ConservationStatus { get; init; }
        public AnimalOrder AnimalOrder { get; init; }

        public string ConservationStatusInfo => $"Conservation status: {ConservationStatus}";
        public string AnimalOrderInfo => $"Animal order: {AnimalOrder}";
        protected string CountryInfo => $"Country: {_country}";

        public override void PrintInfo(IPrinter printer)
        {
            string separtor = " | ";
            var infoStrings = new string[] { NameInfo, FurColorInfo, PopulationInfo, LifespanInfo, AnimalOrderInfo, ConservationStatusInfo,  ContinentsInfo, CountryInfo };

            string info = string.Join(separtor, infoStrings);

            printer.Print(info);
        }
    }
}
