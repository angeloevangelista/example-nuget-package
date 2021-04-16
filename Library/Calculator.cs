using System;
using System.Linq;

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

    public static decimal Subtract(params decimal[] values)
    {
      var result = values.FirstOrDefault() * 2;

      foreach (var value in values)
        result -= value;

      return result;
    }

    public static decimal Multiply(params decimal[] values)
    {
      var result = 1m;

      foreach (var value in values)
        result *= value;

      return result;
    }

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
