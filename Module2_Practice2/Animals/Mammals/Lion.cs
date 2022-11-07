namespace Module2_Practice2.Animals.Mammals
{
    public class Lion : Panthera, IAnimalExtendedInfo
    {
        public Lion(int populationNumber)
            : base(name: "Lion", populationNumber, lifespan: 15, continents: new Continent[] { Continent.Africa })
        {
            ConservationStatus = ConservationStatus.InSafe;
            AnimalOrder = AnimalOrder.Carnivore;
        }

        public ConservationStatus ConservationStatus { get; init; }
        public AnimalOrder AnimalOrder { get; init; }

        public string ConservationStatusInfo => $"ConservationStatus: {ConservationStatus}";
        public string AnimalOrderInfo => $"AnimalOrder: {AnimalOrder}";

        protected override string PopulationInfo => $"Population: {PopulationNumber} lions";

        public override string GetDescription()
        {
            string separtor = " | ";
            var infoStrings = new string[] { NameInfo, CanRoarInfo, PopulationInfo, LifespanInfo, AnimalOrderInfo, ConservationStatusInfo, ContinentsInfo };

            string info = string.Join(separtor, infoStrings);

            return info;
        }
    }
}
