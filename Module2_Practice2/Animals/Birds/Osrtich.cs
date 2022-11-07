namespace Module2_Practice2.Animals.Birds
{
    public class Osrtich : Bird
    {
        public Osrtich(string name, int populationNumber, int lifeSpan)
            : base(name, canFly: false, populationNumber, lifeSpan, continents: new Continent[] { Continent.Africa })
        {
        }
    }
}
