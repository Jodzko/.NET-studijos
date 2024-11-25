namespace _8_paskaita_OOP_generics_praktika
{
    public class Type<T1, T2>
    {
        public T1 MyProperty { get; set; }
        public T2 MyProperty2 { get; set; }



        public Type(T1 property, T2 property2)
        {
            MyProperty = property;
            MyProperty2 = property2;
        }

        public void GetType(T1 input)
        {
            Console.WriteLine(input.GetType().Name);
        }
        public void GetType(T2 input)
        {
            Console.WriteLine(input.GetType().Name);
        }
    }
}
