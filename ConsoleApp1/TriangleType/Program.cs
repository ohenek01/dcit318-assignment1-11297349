using System;

class Program
{ 
    static void Main()
    {
        Console.WriteLine("Enter the three sides of a triangle");
        Console.Write("Side A: ");
        double sideA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Side B: ");
        double sideB = Convert.ToDouble(Console.ReadLine());
        Console.Write("Side C: ");
        double sideC = Convert.ToDouble(Console.ReadLine());

        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            Console.WriteLine("Invalid input. All sides must be positive numbers and greater than 0.");
            return;
        }
        else if (sideA == sideB && sideB == sideC)
        {
            Console.WriteLine("The triangle is an equilateral triangle.");
        }
        else if(sideA == sideB || sideB == sideC || sideA == sideC)
        {
            Console.WriteLine("The triangle is an isosceles triangle.");
        }
        else
        {
            Console.WriteLine("The triangle is a scalene triangle.");
        }
    }
}