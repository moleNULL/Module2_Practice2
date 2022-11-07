namespace Module2_Practice2.Animals
{
    public abstract class Animal
    {
        // protected Properties is used to allow user to modify values ONLY through contructor
        public abstract string Name { get; set; }
        public abstract int PopulationNumber { get; set; }
        public abstract int Lifespan { get; set; }
        public abstract Continent[] Continents { get; set; }

        // protected Properties to be used in PrintInfo() to reduce usage of
        // the same code in override methods | most common Properties are implemented
        protected abstract string NameInfo { get; }
        protected abstract string PopulationInfo { get; }
        protected string LifespanInfo => $"Lifespan: {Lifespan} years";
        protected string ContinentsInfo
        {
            get
            {
                return (Continents.Length == 1 ? "Continent" : "Continents") + " of habitation: "
                + string.Join(", ", Continents);
            }
        }

        // Get information about an animal to print it later
        // on different Printers (IPrinter)
        public abstract string GetDescription();
    }
}
