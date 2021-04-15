using System;

namespace Library
{
  public static class Calculator
  {
    public static decimal Sum(params decimal[] values)
    {
      var sum = 0m;

      foreach (var value in values)
        sum += value;

      return sum;
    }

    public static decimal Subtract(decimal x, decimal y) => x - y;

    public static int GetNextPrimeNumber(int baseNumber)
    {
      bool isPrimeNumber = false;
      var candidateToBePrime = baseNumber;

      do
        isPrimeNumber = CheckIsPrime(++candidateToBePrime);
      while (!isPrimeNumber);

      return candidateToBePrime;
    }

    private static bool CheckIsPrime(int value)
    {
      int amountOfNoRestDivisions = 0;

      for (int i = 1; i <= value; i++)
      {
        var rest = value % i;

        if (rest == 0)
          amountOfNoRestDivisions++;
      }

      return amountOfNoRestDivisions <= 2;
    }
  }
}
