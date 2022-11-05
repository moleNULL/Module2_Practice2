namespace Module2_Practice2.Animals.Birds
{
    public class Marabou : Bird
    {
        public Marabou(string name, int populationNumber, int lifespan)
            : base(name, canFly: true, populationNumber, lifespan, continents: new string[] { "Africa" })
        {
        }
    }
}
