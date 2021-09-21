using System;
using System.Collections.Generic;
using TriangleTracker.Models;

namespace TriangleTracker
{
  public class Program {
    
    public static void Main(){
      
      Console.WriteLine("Welcome to Triangle Tracker! Please enter a number.");
      string stringSide1 = Console.ReadLine();
      Console.WriteLine("Enter another number:");
      string stringSide2 = Console.ReadLine();
      Console.WriteLine("One more member, please:");
      string stringSide3 = Console.ReadLine();
      int side1 = int.Parse(stringSide1);
      int side2 = int.Parse(stringSide2);
      int side3 = int.Parse(stringSide3);
      Triangle usersTriangle = new Triangle(side1, side2, side3);

    }
  }
}