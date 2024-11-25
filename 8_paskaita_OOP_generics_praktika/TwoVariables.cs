namespace _8_paskaita_OOP_generics_praktika
{
    public class TwoVariables<T1,T2>
    {
        private T1 MyProperty { get; set; }
        private T2 Property2 { get; set; }

        public TwoVariables()
        {
        }

        public TwoVariables(T1 myProperty, T2 property2)
        {
            MyProperty = myProperty;
            Property2 = property2;
        }

        public void ShowT1()
        {
            Console.WriteLine(MyProperty);
        }
        public void ShowT2()
        {
            Console.WriteLine(Property2);
        }

        public void ChangeT1(T1 whatTo)
        {
            MyProperty = whatTo;        
            Console.WriteLine(MyProperty);
        } 
        public void ChangeT2(T2 whatTo)
        {
            Property2 = whatTo;
            Console.WriteLine(Property2);
        }

    }
}
