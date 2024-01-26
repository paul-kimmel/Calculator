using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorEngine;

namespace TestProject1
{
  [TestClass]
  public class UnitTest3
  {
    [TestMethod]
    public void PiTest()
    {
      Given("¶");
      Expect(Math.Round(Math.PI, 8).ToString());
    }

    [TestMethod]
    public void FactorialTest()
    {
      Given("5 ! / 3");
      Expect("40");      
    }

    [TestMethod]
    public void SquareTest()
    {
      Given("3 X²");
      Expect("9");
    }

    [TestMethod]
    public void CubeTest()
    {
      Given("2 X³ * 3");
      Expect("24");
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

  }
}
