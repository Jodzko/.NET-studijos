namespace _9_paskaita_OOP_generics_praktika
{
    public class ReadOnlyList<T>
    {
        private List<T> Values;

        public ReadOnlyList()
        {
            Values = new List<T>();
        }
        public ReadOnlyList(List<T> values)
        {
            Values = values;
           
        }

        public void ShowInside()
        {
            foreach (var item in Values)
            {
                Console.WriteLine(item);
            }
        }
        public T[] MakeIntoArray()
        {
            var newArray = new T[Values.Count];
            Values.CopyTo(newArray);
            return newArray;
        }


        public T FindAtLeastOneElement(T item)
        {
            Validation.Validate(item);
            var count = 0;
            T foundElement = default;
            foreach (var item1 in Values)
            {
                if (item1.Equals(item))
                {
                    count++;
                    foundElement = item1;
                }
            }
            if (count > 1)
            {               
                throw new ArgumentOutOfRangeException("Found more than one instance of the item");
            }
            else if (count == 0)
            {
                throw new ArgumentOutOfRangeException("Did not find the item");
            }
            else if (count == 1)
            {
                return foundElement;
            }
            return foundElement;
        }

        public T FindElement(T item)
        {
            Validation.Validate(item);
            var count = 0;
            T foundElement = default;
            foreach (var item1 in Values)
            {
                if (item1.Equals(item))
                {
                    count++;
                    foundElement = item1;
                }
            }

            if (count > 1)
            {
                throw new ArgumentOutOfRangeException("Found more than one instance of the item");
            }
            else if(count == 0)
            {
                Console.WriteLine("Didnt find the element");
                return default;                
            }
            
            return foundElement;
            
        }

        public bool IfTheElementIsThere(T elementToFind)
        {
            Validation.Validate(elementToFind);
            if (Values.Contains(elementToFind))
            {
                Console.WriteLine("Found it!");
                return true;
            }
            else
            {
                Console.WriteLine("Did not find it...");
                return false;
            }
        }
    }
}
