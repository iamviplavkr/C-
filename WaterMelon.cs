using System;

class Program
{
    static void Main()
    {
        int w = int.Parse(Console.ReadLine());

        // Check if w is greater than 2 and even
        if (w > 2 && w % 2 == 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
