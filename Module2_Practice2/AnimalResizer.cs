namespace Module2_Practice2
{
    // class that provide logic to Add/Remove animals
    public class AnimalResizer
    {
        public static Animal[] AddAnimals(Animal[] oldAnimals, Animal[] newAnimals)
        {
            int oldAnimLength = oldAnimals.Length;
            int newAnimLength = newAnimals.Length;
            Animal[] arr = new Animal[oldAnimLength + newAnimLength];

            Array.Copy(oldAnimals, arr, oldAnimLength);
            Array.Copy(newAnimals, 0, arr, oldAnimLength, newAnimLength);

            return arr;
        }
    }
}
