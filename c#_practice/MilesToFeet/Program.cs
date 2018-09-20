using System;

namespace MilesToFeet
{
  class Program
  {
    static double GetFeet(double miles)
    {
      return Math.Round(miles * 5280, 0);
    }
    static double GetInches(double miles)
    {
      return Math.Round((miles * 63360) % 12, 0);
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the number of miles to convert to feet and inches");
      var miles = Convert.ToDouble(Console.ReadLine());
      var feet = Program.GetFeet(miles);
      var inches = Program.GetInches(miles);

      Console.WriteLine("{0:0.00} miles is {1} feet and {2} inches", miles, feet, inches);
    }
  }
}
