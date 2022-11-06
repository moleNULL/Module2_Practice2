namespace Module2_Practice2.Animals.Birds
{
    public class AfricanMarabou : Marabou, IAnimalExtendedInfo
    {
        private readonly string _plumage;

        public AfricanMarabou(int populationNumber)
            : base(name: "African Marabou", populationNumber, lifespan: 25)
        {
            ConservationStatus = ConservationStatus.NearThreatened;
            AnimalOrder = AnimalOrder.Carnivore;

            _plumage = "pink, grey and black";
        }

        public ConservationStatus ConservationStatus { get; init; }
        public AnimalOrder AnimalOrder { get; init; }

        public string ConservationStatusInfo => $"ConservationStatus: {ConservationStatus}";
        public string AnimalOrderInfo => $"AnimalOrder: {AnimalOrder}";
        protected string PlumageInfo => $"Plumage: {_plumage}";

        public override void PrintInfo(IPrinter printer)
        {
            string separtor = " | ";
            var infoStrings = new string[] { NameInfo, PlumageInfo, CanFlyInfo, PopulationInfo, LifespanInfo, AnimalOrderInfo, ConservationStatusInfo, ContinentsInfo };

            string info = string.Join(separtor, infoStrings);

            printer.Print(info);
        }
    }
}
