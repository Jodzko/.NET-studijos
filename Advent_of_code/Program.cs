﻿namespace Advent_of_code
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

                for (int i = 0; i < items.Length - 1; i++)
                {
                    if ((int.Parse(items[i + 1]) - int.Parse(items[i])) < 3)
                    {
                        if (items == items.OrderBy(x=> x) || items.OrderByDescending(x => x) == items.AsEnumerable())
                        {
                            if (i == items.Length - 2)
                            {
                                safeReports++;
                            }
                        }
                    }
                    
                }
                
            }


            Console.WriteLine();
        }
    }
}
