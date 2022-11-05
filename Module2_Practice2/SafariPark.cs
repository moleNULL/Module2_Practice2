global using Module2_Practice2.Animals;
global using Module2_Practice2.Animals.Birds;
global using Module2_Practice2.Animals.Mammals;

namespace Module2_Practice2
{
    public class SafariPark
    {
        private Animal[] _animals;

        public SafariPark(Animal[] animals)
        {
            _animals = animals;
        }

        public void PrintAnimals(IPrinter printer)
        {
            foreach (var animal in _animals)
            {
                animal.PrintInfo(printer);
            }
        }
    }
}
