using System;
using System.Collections.Generic;
using TriangleTracker.Models;

namespace TriangleTracker
{
  public class Program {
    
    public static void Main(){
      
      Console.WriteLine("Welcome to Triangle Tracker! Please enter a whole number.");
      int side1;
      int side2;
      int side3;
      string stringSide1 = Console.ReadLine();
      Console.WriteLine("Enter another whole number:");
      string stringSide2 = Console.ReadLine();
      Console.WriteLine("One more whole number, please:");
      string stringSide3 = Console.ReadLine();
      if (int.TryParse(stringSide1, out side1) && int.TryParse(stringSide2, out side2) && int.TryParse(stringSide3, out side3)) {
      Triangle usersTriangle = new Triangle(side1, side2, side3);
      string result = usersTriangle.CheckType();
      Console.WriteLine(result);

      } else {
        Console.WriteLine("You didn't enter only whole numbers. Try again.");
        Main();
      }
    }
  }
}