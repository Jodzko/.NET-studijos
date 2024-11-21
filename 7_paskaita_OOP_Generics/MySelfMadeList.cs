using System.Drawing;

namespace _7_paskaita_OOP_Generics
{
    public class MySelfMadeList<T>
    {
        private T[] InternalArray { get; set; }
        public int Index = 0;
        private int Size = 10;

        public MySelfMadeList()
        {
            InternalArray = new T[Size];
        }

        public void AddItem(T item)
        {
            if (CheckIfFull())
            {
                InternalArray = IncreaseListSize();
            }
            if(item != null)
            {
                InternalArray[Index] = item;
                Index++;
            }
            else
            {
                throw new ArgumentNullException($"Argument was null: {item}");
            }

        }
        private bool CheckIfFull()
        {
            return Index == Size;
        }
        private T[] IncreaseListSize()
        {
            Size += (Size / 2);
            var newArray = new T[Size];
            InternalArray.CopyTo(newArray, 0);
            return newArray;
        }

        public void RemoveItem(T item)
        {
            if (InternalArray.Contains(item) && item != null)
            {
                bool foundIt = false;
                var newArray = new T[Size];
                for (int i = 0; i < Size - 1; i++)
                {                                                          
                    if (!InternalArray[i].Equals(item))
                    {
                        newArray[i] = InternalArray[i];                      
                    }
                    else
                    {
                        foundIt = true;
                    }
                    if (foundIt)
                    {
                        newArray[i] = InternalArray[i + 1];
                    }
                    if (i == Size - 2)
                    {                       
                        InternalArray = newArray;
                        
                    }
                }
              
            }
            else
            {
                Console.WriteLine("Cant remove item, because it is not there or there is no item");
            }
        }
    }
}
