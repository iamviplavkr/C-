using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size : ");
        int a = Convert.ToInt32(Console.ReadLine());
        if(a == 0)
        {
            Console.WriteLine("Cannot add up an empty array");
        }
        int[] numbers = new int[a];
        for (int i = 0; i < numbers.Length; i++) {
            Console.Write("Enter the Numbers : ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            int result = SumOfNumbers(numbers);

            if(result > -1)
            {
                Console.WriteLine($"The total is : {result}");
            }      
        }
        static int SumOfNumbers(int[] numbers)
        {
            if (numbers.Length > 0)
            {
                int total = 0;
                foreach (var item in numbers)
                {
                    total += item;
                }
                return total;
            }
            return -1;

        }

    }
}
