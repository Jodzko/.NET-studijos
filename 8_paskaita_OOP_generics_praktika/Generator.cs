namespace _8_paskaita_OOP_generics_praktika
{
    public class Generator<T>
    {
        public Generator()
        {
        }

        public void Show(T item)
        {
            Console.WriteLine(item.ToString);
        }
    }
}
