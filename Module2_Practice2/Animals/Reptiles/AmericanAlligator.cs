namespace Module2_Practice2.Animals.Reptiles
{
    public class AmericanAlligator : Crocodile, IAnimalExtendedInfo
    {
        private WaterType _waterType;

        public AmericanAlligator(int populationNumber)
            : base(name: "American Alligator", populationNumber, lifespan: 40, continents: new Continent[] { Continent.NorthAmerica })
        {
            ConservationStatus = ConservationStatus.InSafe;
            AnimalOrder = AnimalOrder.Carnivore;

            _waterType = WaterType.SaltWater;
        }

        public ConservationStatus ConservationStatus { get; init; }
        public AnimalOrder AnimalOrder { get; init; }

        public string ConservationStatusInfo => $"ConservationStatus: {ConservationStatus}";
        public string AnimalOrderInfo => $"AnimalOrder: {AnimalOrder}";

        protected string WaterTypeInfo => $"WaterType: {_waterType}";
        protected override string PopulationInfo => $"Population: {PopulationNumber} alligators";

        public override string GetDescription()
        {
            string separtor = " | ";
            var infoStrings = new string[] { NameInfo, CanSwimInfo, WaterTypeInfo, PopulationInfo, LifespanInfo, AnimalOrderInfo, ConservationStatusInfo, ContinentsInfo };

            string info = string.Join(separtor, infoStrings);

            return info;
        }
    }
}
