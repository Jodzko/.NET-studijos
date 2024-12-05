namespace _15_paskaita_OOP_interface_tasks
{
    internal class BassComparerByBiggestCaught : IComparer<Bass>
    {
        public int Compare(Bass? x, Bass? y)
        {
            if (x.BiggestCaught > y.BiggestCaught)
            {
                return 1;
            }
            else if (x.BiggestCaught == y.BiggestCaught)
            {
                return 0;
            }
            else return -1;
        }
    }
}
