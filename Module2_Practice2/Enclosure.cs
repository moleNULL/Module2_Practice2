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
            Animals = new Animal[0];
        }

        public Animal[] Animals { get; set; }

        public void PrintAnimals(IPrinter printer)
        {
            foreach (var animal in Animals)
            {
                animal.PrintInfo(printer);
            }
        }

        public void PrintFirstAnimal(IPrinter printer)
        {
            if (Animals.Length == 0)
            {
                Console.WriteLine("There are no animals to print");

                return;
            }

            Animals[0].PrintInfo(printer);
        }

        public void PrintLastAnimal(IPrinter printer)
        {
            if (Animals.Length == 0)
            {
                Console.WriteLine("There are no animals to print");

                return;
            }

            Animals[^1].PrintInfo(printer);
        }
    }
}
