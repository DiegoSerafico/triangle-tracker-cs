using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
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
  }
}
