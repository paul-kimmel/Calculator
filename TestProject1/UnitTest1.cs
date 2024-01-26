using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorEngine;
using Tools;

namespace TestProject1
{
  [TestClass]
  public class UnitTest1
  {

  #region "Test without parentheses"
    [TestMethod]
    public void TokenizeNegativeValue()
    {
      const string expression = "-5 * 3";
      double value = MathText.CalculateFromExpression(expression);
      Assert.AreEqual(value, -15);
    }


    [TestMethod]
    public void CalculateSquareRootFromExpressionTest()
    {
      const string expression = "4 √";

      Console.WriteLine(MathText.Tokenize(expression).GetShuntingYardOrdering().GetFormatted());
      double result = MathText.CalculateFromExpression(expression);
      
      Assert.AreEqual(result, 2);
    }


    [TestMethod]
    public void CalculateFromExpressionTest()
    {
      double result = MathText.CalculateFromExpression("3 + 2 * 5");
      Assert.AreEqual(result, 13);
    }

    [TestMethod]
    public void CalculateFromExpressionTest2()
    {
      const string expression = "3 + 2 * 10 / 5";
      double result = MathText.CalculateFromExpression(expression);
      
      Console.WriteLine(MathText.Tokenize(expression).GetShuntingYardOrdering().GetFormatted());

      Console.WriteLine(result);
      Assert.AreEqual(result, 7);
    }

    [TestMethod]
    public void CalculateFromExpression3()
    {
      const string expression = "4 + 1 * 7 - 2 / 2 * 6";

      // should be 417*+22/6*-
      double result = MathText.CalculateFromExpression(expression);
      
      Console.WriteLine(result);
      Assert.AreEqual(result, 5);
    }

    
    [TestMethod]
    public void SimpleOrderingTest()
    {
      List<Token> list = MathText.Tokenize("4 + 5 * 6");
     
      // Given: 4 + 5 * 6
      // Expect: 456*+

      List<Token> output = MathText.GetShuntingYardOrdering(list);
      Console.WriteLine(output.GetFormatted());
      Assert.AreEqual("4 5 6 * +", output.GetFormatted());
    }

    [TestMethod]
    public void SimpleOrderingTest2()
    {
      List<Token> list = MathText.Tokenize("3 + 2 * 6 - 4");

      // Given: 3 + 2 * 6 - 4
      // Expect: 326*+4-

      List<Token> output = MathText.GetShuntingYardOrdering(list);
      Console.WriteLine(output.GetFormatted());
      Assert.AreEqual("3 2 6 * + 4 -", output.GetFormatted());
    }

    [TestMethod]
    public void TokenizeTest()
    {
      List<Token> list = MathText.Tokenize("3 + 6 * 5");
      Console.WriteLine(list.GetFormatted());

    }



    [TestMethod]
    public void GetRpnTest()
    {
      List<Token> list = MathText.Tokenize("2 + 3 * 6 + 4 / 3");
      // Given: 2+(3*6)+(4/3)
      // Expect: 236*+43/+

      Stack<Token> output = list.GetReversePolishNotationOrdering();
      string result = "";
      foreach (Token token in output)
        result += token.ToString();

      Console.WriteLine(result);
      Assert.AreEqual("236*+43/+", result);

    }

    [TestMethod]
    public void AggregatorTest()
    {
      List<int> ints = new List<int>();
      ints.Add(3);
      ints.Add(4);

      string result = MetaDumper.GetArrayValues(ints, "{0},{1}");
      Console.WriteLine(result);
    }

#endregion

    #region "Test with parentheses"
   
    [TestMethod]
    public void WithAndWithoutParensTest()
    {
      string expression1 = "( 3 + 2 ) * 6";
      string expression2 = "3 + 2 * 6";

      double value1 = MathText.CalculateFromExpression(expression1);
      Console.WriteLine("{0} = {1}", expression1, value1);
      double value2 = MathText.CalculateFromExpression(expression2);
      Console.WriteLine("{0} = {1}", expression2, value2);

      Assert.AreNotEqual(value1, value2);
      Assert.AreEqual(value1, 30);
      Assert.AreEqual(value2, 15);
    }

    [TestMethod]
    public void SimpleOrderingWithParensTest()
    {
      string expression = "( 3 + 2 ) * 6";
      List<Token> list = MathText.Tokenize(expression);

      List<Token> output = MathText.GetShuntingYardOrdering(list);
      Console.WriteLine(output.GetFormatted());

      Assert.AreEqual("3 2 + 6 *", output.GetFormatted());
    }

    [TestMethod]
    public void SimpleOrderingWithParensTest2()
    {
      string expression = "( 3 + 2 ) * 6 + 5";
      List<Token> list = MathText.Tokenize(expression);

      List<Token> output = MathText.GetShuntingYardOrdering(list);
      Console.WriteLine(output.GetFormatted());

      Assert.AreEqual("3 2 + 6 * 5 +", output.GetFormatted());
    }

    [TestMethod]
    public void SimpleOrderingWithParensTest3()
    {
      string expression = "( 3 + 2 ) + 6 * 5";
      List<Token> list = MathText.Tokenize(expression);

      List<Token> output = MathText.GetShuntingYardOrdering(list);
      Console.WriteLine(output.GetFormatted());

      Assert.AreEqual("3 2 + 6 5 * +", output.GetFormatted());
    }

    [TestMethod]
    public void NestedParensTest()
    {
      string expression = "( 3 * 6 + ( 3 * 5 ) )";
      List<Token> list = MathText.Tokenize(expression);

      List<Token> output = MathText.GetShuntingYardOrdering(list);
      Console.WriteLine(output.GetFormatted());

      Assert.AreEqual("3 6 * 3 5 * +", output.GetFormatted());
    }

    [TestMethod]
    public void TokenizeParensTest()
    {
      List<Token> list = MathText.Tokenize("( 3 + 6 ) * 5");
      Console.WriteLine(list.GetFormatted());
    }
    #endregion
  }
}
