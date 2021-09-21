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
  }
}