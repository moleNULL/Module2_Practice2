namespace Module2_Practice2.Animals.Birds
{
    public class SomaliOstrich : Osrtich
    {
        private readonly string _plumageMale;
        private readonly string _plumageFemale;
        public SomaliOstrich(int populationNumber)
            : base(name: "Somali Ostrich", populationNumber, lifeSpan: 65)
        {
            ConservationStatus = ConservationStatus.Endangered;
            AnimalOrder = AnimalOrder.Herbivore;

            _plumageMale = "black and grey";
            _plumageFemale = "brown";
        }

        public ConservationStatus ConservationStatus { get; init; }
        public AnimalOrder AnimalOrder { get; init; }

        public string ConservationStatusInfo => $"Conservation status: {ConservationStatus}";
        public string AnimalOrderInfo => $"Animal order: {AnimalOrder}";
        protected string PlumageInfo => $"Plumage: male - {_plumageMale}, female - {_plumageFemale}";

        public override void PrintInfo(IPrinter printer)
        {
            string separtor = " | ";
            var infoStrings = new string[] { NameInfo, PlumageInfo, CanFlyInfo, PopulationInfo, LifespanInfo, AnimalOrderInfo, ConservationStatusInfo, ContinentsInfo };

            string info = string.Join(separtor, infoStrings);

            printer.Print(info);
        }
    }
}
