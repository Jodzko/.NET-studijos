namespace _14_paskaita_OOP_Interface_and_IComparer
{
    internal class CarComparer :IComparer<Car>
    {
        public int Compare(Car? x, Car? y)
        {
            if (x.Fuel > y.Fuel)
            {
                return -1;
            }
            else if (x.Fuel == y.Fuel)
            {
                return 0;
            }
            else 
            {
                return 1;
            }
        }

        
    }
}
