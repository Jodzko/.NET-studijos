namespace _15_paskaita_OOP_interface_tasks
{
    public class DogComparerByAge : IComparer<Dog>
    {
        public int Compare(Dog? x, Dog? y)
        {
            if (x.Age > y.Age)
            {
                return 1;
            }
            else if (x.Age == y.Age)
            {
                return 0;
            }
            else return -1;
        }
    }
}
