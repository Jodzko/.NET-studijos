namespace _14_paskaita_OOP_Interface_and_IComparer
{
    public class BmwCar : Car
    {
        public bool IsXDrive { get; set; }

        public BmwCar(bool isXDrive, string model, int fuel, int maxCapacity) : base(model, fuel, maxCapacity)
        {
            IsXDrive = isXDrive;
        }
    }
}
