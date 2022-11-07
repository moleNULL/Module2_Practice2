namespace Module2_Practice2.Animals.Reptiles
{
    public class CoastalTaipan : Snake, IAnimalExtendedInfo
    {
        public CoastalTaipan(int populationNumber)
            : base(name: "Coastal Taipan", populationNumber, lifespan: 13, isPoisonous: true, continents: new Continent[] { Continent.Australia, Continent.Asia })
        {
            ConservationStatus = ConservationStatus.NearThreatened;
            AnimalOrder = AnimalOrder.Carnivore;
        }

        public ConservationStatus ConservationStatus { get; init; }
        public AnimalOrder AnimalOrder { get; init; }

        public string ConservationStatusInfo => $"ConservationStatus: {ConservationStatus}";
        public string AnimalOrderInfo => $"AnimalOrder: {AnimalOrder}";

        public override string GetDescription()
        {
            string separtor = " | ";
            var infoStrings = new string[] { NameInfo, IsPoisonousInfo, CanSwimInfo, PopulationInfo, LifespanInfo, AnimalOrderInfo, ConservationStatusInfo, ContinentsInfo };

            string info = string.Join(separtor, infoStrings);

            return info;
        }
    }
}
