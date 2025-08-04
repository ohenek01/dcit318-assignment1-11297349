using System;

class Program
{
    static void Main()
    {
      Console.WriteLine("Enter your age:");
        if(int.TryParse(Console.ReadLine(), out int age))
        {
            if (age >= 65)
            {
                Console.WriteLine("You are eleigible for a senior citizen's discount.");
                Console.WriteLine("Your ticket price is GHS 7.00");
            }
            else if (age <= 12)
            {
                Console.WriteLine("You are eligible for a children's discount.");
                Console.WriteLine("Your ticket price is GHS 7.00");
            }
            else if (age >= 13 && age < 65)
            {
                Console.WriteLine("You are not eligible for any discounts.");
                Console.WriteLine("Your ticket price is GHS 10.00");
            }
            else
            {
                Console.WriteLine("Invalid age entered. Please enter a valid age.");
            }
        }
    }
    
}
