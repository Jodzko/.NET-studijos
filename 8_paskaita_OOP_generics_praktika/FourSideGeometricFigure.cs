namespace _8_paskaita_OOP_generics_praktika
{
    public class FourSideGeometricFigure
    {
        public string Name { get; set; }
        public int Base { get; set; }
        public int Height { get; set; }

        public FourSideGeometricFigure(string name, int @base, int height)
        {
            Name = name;
            Base = @base;
            Height = height;
        }

        public void GetArea()
        {
            var area = Base * Height;
            Console.WriteLine(area);
        }

        public override string? ToString()
        {
            return $"Name: {Name}       Base: {Base}       Height: {Height}";
        }
    }
}
