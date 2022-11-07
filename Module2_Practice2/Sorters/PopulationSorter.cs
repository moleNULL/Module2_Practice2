namespace Module2_Practice2.Sorters
{
    // sort animals by their population number
    public class PopulationSorter : ISort
    {
        public void Sort(ref Animal[] animals)
        {
            int[] populations = new int[animals.Length];

            for (int i = 0; i < animals.Length; i++)
            {
                populations[i] = animals[i].PopulationNumber;
            }

            Array.Sort(populations);

            Animal[] temp = new Animal[animals.Length];

            for (int i = 0; i < populations.Length; i++)
            {
                foreach (var animal in animals)
                {
                    if (populations[i] == animal.PopulationNumber)
                    {
                        temp[i] = animal;
                    }
                }
            }

            animals = temp;
        }
    }
}
