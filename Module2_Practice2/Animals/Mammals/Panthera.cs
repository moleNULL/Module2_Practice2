namespace Module2_Practice2.Animals.Mammals
{
    public class Panthera : Mammal
    {
        private readonly bool _canRoar;
        public Panthera(string name, int populationNumber, int lifespan)
            : base(name, hasFur: true, populationNumber, lifespan, continents: new string[] { "Africa" })
        {
            _canRoar = true;
        }

        protected string CanRoarInfo => $"CanRoar: {_canRoar}";
    }
}
