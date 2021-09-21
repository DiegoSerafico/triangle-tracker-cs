using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void CheckEquilateral_CheckAllLengthsEqual_True() {
      Triangle testTriangle = new Triangle(3, 3, 3);
      Assert.AreEqual(true, testTriangle.CheckEquilateral());
    }
  }
}

Initialized empty Git repository in C:/Users/diego/OneDrive/Desktop/epicodus/Triangle-Tracker/TriangleTracker.Tests/.git/
git rm -rf ./TriangleTracker.Tests/.git
