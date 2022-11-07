global using Module2_Practice2.Animals;
global using Module2_Practice2.Animals.Birds;
global using Module2_Practice2.Animals.Mammals;
global using Module2_Practice2.Animals.Reptiles;
global using Module2_Practice2.Printers;

namespace Module2_Practice2
{
    // Class that is responsible for keeping animals within SafariPark
    public class Enclosure
    {
        public Enclosure()
        {
            // a plug cuz outdated settings.ruleset cannot create Animal[]? object
            Animals = new Animal[0];
        }

        public Animal[] Animals { get; set; }

        // print all animals to IPrinter
        public void PrintAnimals(IPrinter printer)
        {
            int i = 1;

            foreach (var animal in Animals)
            {
                string data = $"{i++}. {animal.GetDescription()}";
                printer.Print(data);
            }
        }
    }
}
