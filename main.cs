using System;
  
class Program 
{  

  public static void Main (string[] args) 
    {
    // Declaration of variables
    const double CentimetersPerInch = 2.54;

    // Prompt for the user to enter a number in inches
    Console.WriteLine("Enter a number in inches: ");

    // Declare Inches and Centimeters
    double inches =  double.Parse(Console.ReadLine());
    double centimeters = inches * CentimetersPerInch;

    // Display the final result
    Console.WriteLine($"{inches} inches is equal to {centimeters} centimeters.");
  
  }
}