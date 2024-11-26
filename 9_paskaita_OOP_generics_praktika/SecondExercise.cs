using System.Collections.Generic;

namespace _9_paskaita_OOP_generics_praktika
{
    public class SecondExercise<T>
    {
        public List<T> MyList = new();

        public SecondExercise()
        {
            
        }
        public void PrintList()
        {
            foreach (var item in MyList)
            {
                Console.WriteLine(item);
            }
        }
        public T[] ConvertToArray()
        {
            var newArray = new T[MyList.Count];
            MyList.CopyTo(newArray);
            return newArray;
        }
        public void AddElement(T item)
        {
            MyList.Add(item);
        }
        public void AddListOfElements(List<T> elements)
        {
            Validation.Validate(elements);
            foreach (var item in elements)
            {
                MyList.Add(item);
            }
        }

        public void RemoveElement(T item)
        {
            Validation.Validate(item);
            if (MyList.Contains(item))
            {
                MyList.Remove(item);
            }
            else
            {
                Console.WriteLine("The element you entered is not in the list");
            }
        }

        public void RemoveByIndex(int index)
        {
            MyList.Remove(MyList[index]);
        }

        public void RemoveAllInstances(T item)
        {
            Validation.Validate(item);
            var sameList = new List<T>();           
            foreach (var item1 in MyList)
            {
                if (!item1.Equals(item))
                {
                    sameList.Add(item1);
                }
                else
                {
                    continue;
                }
            }
            MyList = sameList;
        }
    }
}
