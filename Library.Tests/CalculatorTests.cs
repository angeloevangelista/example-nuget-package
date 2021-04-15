using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library.Tests
{
  [TestClass]
  public class CalculatorTests
  {
    [TestMethod]
    public void ShouldSumTwoValues()
    {
      decimal
        x = 10,
        y = 30;

      var sum = Calculator.Sum(x, y);

      Assert.IsTrue(sum == 40);
    }

    [TestMethod]
    public void ShouldSumCollectionOfPositiveValues()
    {
      decimal[] values = new decimal[] { 1, 2, 3, 4, 5 };

      var sum = Calculator.Sum(values);

      Assert.IsTrue(sum == 15);
    }

    [TestMethod]
    public void ShouldSumCollectionOfNegativeValues()
    {
      decimal[] values = new decimal[] { -1, -2, -3, -4, -5 };

      var sum = Calculator.Sum(values);

      Assert.IsTrue(sum == -15);
    }

    [TestMethod]
    public void ShouldSumCollectionOfBothPositiveAndNegativeValues()
    {
      decimal[] values = new decimal[] { 1, -2, 3, -4, 5 };

      var sum = Calculator.Sum(values);

      Assert.IsTrue(sum == 3);
    }

    [TestMethod]
    public void ShouldReturnNextPrimeNumber()
    {
      var initialNumber = 37;

      var nextPrimeNumber = Calculator.GetNextPrimeNumber(initialNumber);

      Assert.AreEqual(41, nextPrimeNumber);
    }
  }
}
