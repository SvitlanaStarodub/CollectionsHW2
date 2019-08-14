using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHW
{
    public class Task2
    {
        public static void NumberRetriever()
        {
            IList<int> array = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                array.Add(i);
            }
            ListData accessor = new ListData(array);
            int firstIndexRange;
            int lastIndexRange;
            Console.WriteLine($"Initial array: {string.Join(" ",array)}");

            Console.WriteLine("Type a range for creation a new array. Starts from 1 till 10.");

            while (true)
            {
                Console.WriteLine("Enter the first index: ");
                string firstIndexElement = Console.ReadLine();
                if (firstIndexElement.Equals("q", StringComparison.OrdinalIgnoreCase))
                    break;
                if (!int.TryParse(firstIndexElement, out firstIndexRange))
                {
                    Console.WriteLine("Invalid input, try again");
                    continue;
                }

                Console.WriteLine("Enter the last index: ");
                string lastIndexElement = Console.ReadLine();
                if (lastIndexElement.Equals("q", StringComparison.OrdinalIgnoreCase))
                    break;
                if (!int.TryParse(lastIndexElement, out lastIndexRange))
                {
                    Console.WriteLine("Invalid input, try again");
                    continue;

                }
                accessor.AddIndexRange(firstIndexRange, lastIndexRange);
                Console.WriteLine("Its your new array: ");
                foreach (var item in accessor)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            
            




        }
    }

}
