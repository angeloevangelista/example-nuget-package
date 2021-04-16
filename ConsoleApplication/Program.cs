using System;
using Library;

namespace ConsoleApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int 
        initialValue = 3873,
        nextPrimeNumber = Calculator.GetNextPrimeNumber(initialValue);

      Console.WriteLine(
        $"The next prime number after {initialValue} is {nextPrimeNumber}!"
      );
    }
  }
}
