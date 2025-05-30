using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main()
    {
       
        try
        {
            Console.Write("Enter the number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a * 2;
            Console.WriteLine(b);
        }
        catch(OverflowException)
        {
            Console.WriteLine("Out Of Bounds ");

        }
    }
}
