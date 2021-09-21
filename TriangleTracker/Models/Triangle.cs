using System;
using System.Collections.Generic;

namespace TriangleTracker.Models
{
  public class Triangle
  {
    public int Side1 { get; set; }
    public int Side2 { get; set; }
    public int Side3 { get; set; }

    public Triangle(int side1, int side2, int side3) {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }
    
    public bool CheckEquilateral()
    {
      if (Side1 == Side2 && Side2 == Side3 && Side1 == Side3) {
        return true;
      }
      return false;
    }
     
    public bool CheckIsosceles()
    {
      if (Side1 == Side2 || Side2 == Side3 || Side1 == Side3)
      {
        return true;
      }
      return false;
    }

    public bool CheckScalene()
    {
      if (Side1 != Side2 && Side2 != Side3 && Side1 != Side3)
      {
        return true;
      }
      return false;
    }

    public bool CheckValidTriangle()
    {
      if (Side1 > (Side2 + Side3) || Side2 > (Side1 + Side3) || Side3 > (Side1 + Side2))
      {
        return false;
      }
      return true;
    }

    public string CheckType() {
      if (!CheckValidTriangle())
      {
        return "Sorry, those side lengths do not make a triangle";
      }
      else if (CheckEquilateral())
      {
        return "Your triangle is an equilateral";
      }
      else if (CheckIsosceles())
      {
        return "Your triangle is an Isosceles";
      }
      return "testing";
    }
  }
}