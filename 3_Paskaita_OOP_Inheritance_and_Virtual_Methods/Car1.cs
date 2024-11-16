namespace _3_Paskaita_OOP_Inheritance_and_Virtual_Methods
{
    public class Car1 : Transport
    {

        public Car1(int speed)
        {
            Speed = speed;
        }


        public override void MeasureSpeed()
        {
            Console.WriteLine(Speed);
        }
    }
}
