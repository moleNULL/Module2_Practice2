namespace Module2_Practice2.Animals.Mammals
{
    public class Panthera : Mammal
    {
        private readonly bool _canRoar;
        public Panthera(string name, int populationNumber, int lifespan, Continent[] continents)
            : base(name, hasFur: true, populationNumber, lifespan, continents)
        {
            _canRoar = true;
        }

        protected string CanRoarInfo => $"CanRoar: {_canRoar}";
    }
}
