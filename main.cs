using System;

class Program{
  public static void Main(string[] args) {
    const double CENTIMETERS_PER_INCH = 2.54;
    
    Console.WriteLine("Enter the number of inches:");
    string input = Console.ReadLine();
    double inches = Convert.ToDouble(input);
    double centimeters = inches * CENTIMETERS_PER_INCH;
   
    Console.WriteLine($"{inches} inches is {centimeters} centimeters.");
  }
}