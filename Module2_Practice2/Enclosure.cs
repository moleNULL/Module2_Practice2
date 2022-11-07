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

        public void PrintAnimals(IPrinter printer)
        {
            int i = 1;

            foreach (var animal in Animals)
            {
                string data = $"{i++}. {animal.GetDescription()}";
                printer.Print(data);
            }
        }

        public void PrintFirstAnimal(IPrinter printer)
        {
            if (Animals.Length == 0)
            {
                Console.WriteLine("There are no animals to print");

                return;
            }

            string data = $"1. {Animals[0].GetDescription()}";
            printer.Print(data);
        }

        public void PrintLastAnimal(IPrinter printer)
        {
            if (Animals.Length == 0)
            {
                Console.WriteLine("There are no animals to print");

                return;
            }

            string data = $"{Animals.Length}. {Animals[^1].GetDescription()}";
            printer.Print(data);
        }
    }
}
