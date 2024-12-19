namespace Advent_of_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var path = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Text2.txt";         
            //var read = File.ReadAllLines(path);
            //int rows = read.Length;
            //string[,] newArray = new string[rows, 2];
            //var firstRowArray = new int[rows];
            //var secondRowArray = new int[rows];
            //for (int i = 0; i < read.Length; i++)
            //{
            //    string[] columns = read[i].Split(' ');

            //    newArray[i, 0] = columns[0];
            //    newArray[i, 1] = columns[3];
            //    firstRowArray[i] = int.Parse(columns[0]);                
            //    secondRowArray[i] = int.Parse(columns[3]);                
            //}
            //var sortedFirstArray = firstRowArray.Order();
            //var sortedSecondArray = secondRowArray.Order();

            //var sum = 0;
            //for (int i = 0; i < rows; i++)
            //{
            //    if (sortedFirstArray.ToList()[i] > sortedSecondArray.ToList()[i])
            //    {
            //        sum += sortedFirstArray.ToList()[i] - sortedSecondArray.ToList()[i];
            //    }
            //    else
            //        sum += sortedSecondArray.ToList()[i] - sortedFirstArray.ToList()[i];
            //}
            //sum = 0;
            //foreach (var item in sortedFirstArray)
            //{
            //    var count = 0;
            //    foreach (var item1 in sortedSecondArray)
            //    {
            //        if(item == item1)
            //        {
            //            count++;
            //        }
            //    }
            //    var similarity = item * count;
            //    sum += similarity;
            //}

            ////////// DAY 2
            var path = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Text2.txt";
            var read = File.ReadAllLines(path);
            var safeReports = 0;
            foreach (var item in read)
            {
                string[] items = item.Split(' ');
               
                    if (IsArrayAscending(items) || IsArrayDescending(items))
                    {
                        if (IsNumberDifferenceLessThan3(items))
                        {
                        safeReports++;
                        }
                    }                                  
                
            }


            Console.WriteLine(safeReports);
        }
        public static bool IsArrayAscending(string[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (int.Parse(array[i - 1]) > int.Parse(array[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsArrayDescending(string[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                if (int.Parse(array[i - 1]) < int.Parse(array[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsNumberDifferenceLessThan3(string[] array)
        {           
                if (IsArrayAscending(array))
                {
                var badCounter = 0;
                for (int i = 0; i < array.Length - 1; i++)
                    {
                    if ((int.Parse(array[i + 1]) - int.Parse(array[i])) > 0 && (int.Parse(array[i + 1]) - int.Parse(array[i])) <= 3 && (int.Parse(array[i + 1]) - int.Parse(array[i])) != 0)
                        {
                        continue ;
                        }
                    else
                    {
                       return false;
                    }
                    }
                return true;
                }
                else if (IsArrayDescending(array))
                {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if ((int.Parse(array[i]) - int.Parse(array[i + 1])) > 0 && (int.Parse(array[i]) - int.Parse(array[i + 1])) <= 3 && (int.Parse(array[i + 1]) - int.Parse(array[i])) != 0)
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
                }
            return false;
        }
        public static bool RemovingOneNumber(string[] array)
        {
            string[] newArray;
            for (int i = 0; i < array.Length; i++)
            {
                array.CopyTo(newArray,)
            }
        }
    }
}
