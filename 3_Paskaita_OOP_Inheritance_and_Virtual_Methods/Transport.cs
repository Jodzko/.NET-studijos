namespace _3_Paskaita_OOP_Inheritance_and_Virtual_Methods
{
    public class Transport
    {
        public int Speed { get; set; }


        public Transport()
        {

        }
        public Transport(int speed)
        {
            Speed = speed;
        }


        public virtual void MeasureSpeed()
        {
            Console.WriteLine(Speed);
        }
    }
}
