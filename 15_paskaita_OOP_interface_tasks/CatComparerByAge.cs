namespace _15_paskaita_OOP_interface_tasks
{
    public class CatComparerByAge : IComparer<Cat>
    {
        public int Compare(Cat? x, Cat? y)        
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

