using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace TriangleTracker.Models.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleConstructorTest1() {
      Triangle testTriangle = new Triangle(3, 3, 3);
      Assert.AreEqual(3, testTriangle.Side1);
      Assert.AreEqual(3, testTriangle.Side2);
      Assert.AreEqual(3, testTriangle.Side3);
    }

    [TestMethod]
    public void CheckEquilateral_CheckAllLengthsEqual_True() {
      Triangle testTriangle = new Triangle(3, 3, 3);
      Assert.AreEqual(true, testTriangle.CheckEquilateral());
    }

    [TestMethod]
    public void CheckIsosceles_CheckTwoSidesEqual_True() {
      Triangle testTriangle = new Triangle(4, 4, 5);
      Assert.AreEqual(true, testTriangle.CheckIsosceles());
    }

    [TestMethod]
    public void CheckScalene_CheckAllDifferentSides_True() {
      Triangle testTriangle = new Triangle(4, 7, 6);
      Assert.AreEqual(true, testTriangle.CheckScalene());
    }

    [TestMethod]
    public void CheckValidTriangle_CheckForValidTriangle_True() {
      Triangle testTriangle = new Triangle(4, 5, 10);
      Assert.AreEqual(false, testTriangle.CheckValidTriangle());
    }

    [TestMethod]
    public void CheckType_CheckUsersTriangleType_StringAnswer() {
    Triangle testTriangle = new Triangle(4, 5, 10);
    Assert.AreEqual("Sorry, those side lengths do not make a triangle", testTriangle.CheckType());
    }

    [TestMethod]
    public void CheckType_CheckUsersTriangleIsEquilateral_StringAnswer() {
      Triangle testTriangle = new Triangle(3, 3, 3);
      Assert.AreEqual("Your triangle is an Equilateral", testTriangle.CheckType());
    }

    [TestMethod]
    public void CheckType_CheckUsersTriangleIsIsosceles_StringAnswer() {
      Triangle testTriangle = new Triangle(4, 4, 5);
      Assert.AreEqual("Your triangle is an Isosceles", testTriangle.CheckType());
    }

    [TestMethod]
    public void CheckType_CheckUsersTriangleIsScalene_StringAnswer() {
      Triangle testTriangle = new Triangle(4, 7, 6);
      Assert.AreEqual("Your triangle is a Scalene", testTriangle.CheckType());
    }
  }
}
