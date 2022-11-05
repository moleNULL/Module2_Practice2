namespace Module2_Practice2.Animals
{
    public abstract class Animal
    {
        // protected Properties is used to allow user to modify values ONLY through contructor
        protected abstract string Name { get; set; }
        protected abstract int PopulationNumber { get; set; }
        protected abstract int Lifespan { get; set; }
        protected abstract string[] Continents { get; set; }

        // protected Properties to be used in PrintInfo() to reduce usage of
        // the same code in override methods | most common Properties are implemented
        protected abstract string NameInfo { get; }
        protected abstract string PopulationInfo { get; }
        protected string LifespanInfo => $"Lifespan: {Lifespan} years";
        protected string ContinentsInfo
        {
            get
            {
                return (Continents.Length == 1 ? "Continent of origin: " : "Continents of origin: ")
                        + string.Join(", ", Continents);
            }
        }

        public abstract void PrintInfo(IPrinter printer);
    }
}
