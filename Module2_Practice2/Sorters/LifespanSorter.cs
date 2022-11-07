namespace Module2_Practice2.Sorters
{
    // sort animals by their lifespan
    public class LifespanSorter : ISort
    {
        public void Sort(ref Animal[] animals)
        {
            int[] lifespans = new int[animals.Length];

            for (int i = 0; i < animals.Length; i++)
            {
                lifespans[i] = animals[i].Lifespan;
            }

            Array.Sort(lifespans);

            Animal[] temp = new Animal[animals.Length];

            for (int i = 0; i < lifespans.Length; i++)
            {
                foreach (var animal in animals)
                {
                    if (lifespans[i] == animal.Lifespan)
                    {
                        temp[i] = animal;
                    }
                }
            }

            animals = temp;
        }
    }
}
