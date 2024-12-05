namespace _15_paskaita_OOP_interface_tasks
{
    public class CarpComparerByBiggestCaught : IComparer<Carp>
    {
        public int Compare(Carp? x, Carp? y)
        {
            if (x.BiggestCaught > y.BiggestCaught)
            {
                return -1;
            }
            else if (x.BiggestCaught == y.BiggestCaught)
            {
                return 0;
            }
            else return 1;
        }
    }
}
