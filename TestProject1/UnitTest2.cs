using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorEngine;

namespace TestProject1
{
  [TestClass]
  public class UnitTest2
  {
    [TestMethod]
    public void TestExponentOperator()
    {
      Given("2 ^ 3");
      Expect("8");
    }

    private string _actual = "";
    private void Given(string expression)
    {
      _actual = MathText.CalculateFromExpression(expression).ToString();
    }

    private void Expect(string expected)
    {
      Assert.AreEqual(expected, _actual);
    }

    [TestMethod]
    public void ExponentWithParensTest()
    {
      Given("( 2 + 3 ) ^ 2");
      Expect("25");
    }


    [TestMethod]
    public void IsFunctionTest()
    {
      Assert.IsTrue(Function.IsFunction("func(1,2,34)"));
    }

    [TestMethod]
    public void IsPowFunctionTest()
    {
      Assert.IsTrue(Function.IsFunction("Pow( 2, 3 )"));
    }

    [TestMethod]
    public void ParseOnSpacesForFunctionsTest()
    {
      string[] pieces = "Pow( 2, 3 )".Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
      Array.ForEach(pieces, s=>Console.WriteLine(s));

      pieces = "Pow(2,3 )".Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
      Array.ForEach(pieces, s => Console.WriteLine(s));

    }

    [TestMethod]
    public void AsciiCharactersTest()
    {
      for (int i = 0; i < 256; i++)
      {
        Console.WriteLine("{0}: {1}", i, (char)i);
      }

    }


  }
}
