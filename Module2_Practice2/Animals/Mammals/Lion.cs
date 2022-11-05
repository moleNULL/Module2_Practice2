namespace Module2_Practice2.Animals.Mammals
{
    public class Lion : Panthera, IAnimalExtendedInfo
    {
        public Lion(int populationNumber)
            : base(name: "Lion", populationNumber, lifespan: 15)
        {
            ConservationStatus = ConservationStatus.InSafe;
            AnimalOrder = AnimalOrder.Carnivore;
        }

        public ConservationStatus ConservationStatus { get; init; }
        public AnimalOrder AnimalOrder { get; init; }

        public string ConservationStatusInfo => $"Conservation status: {ConservationStatus}";
        public string AnimalOrderInfo => $"Animal order: {AnimalOrder}";

        protected override string PopulationInfo => $"Population: {PopulationNumber} lions";

        public override void PrintInfo(IPrinter printer)
        {
            string separtor = " | ";
            var infoStrings = new string[] { NameInfo, CanRoarInfo, PopulationInfo, LifespanInfo, AnimalOrderInfo, ConservationStatusInfo, ContinentsInfo };

            string info = string.Join(separtor, infoStrings);

            printer.Print(info);
        }
    }
}
