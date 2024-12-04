namespace _14_paskaita_OOP_Interface_and_IComparer
{
    public class AudiCar : Car
    {
        public bool IsQuattro { get; set; }

        public AudiCar(bool isQuattro, string model, int fuel, int maxCapacity) : base(model, fuel, maxCapacity)
        {
            IsQuattro = isQuattro;
        }

    }
}
