namespace _3_Paskaita_OOP_Inheritance_and_Virtual_Methods
{
    public class Square : Polygon
    {
        public double Size { get; set; }


        public Square()
        {
            NumberOfAngles = 4;
        }

        public Square(double size) : base()
        {
            Size = size;
        }
    }
}
