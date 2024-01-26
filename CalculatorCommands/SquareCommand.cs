using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;
using System.Diagnostics;

namespace CalculatorCommands
{
  public class SquareCommand : UnaryOperationCommand
  {

    protected override string DoPerform(string commandText, string currentInput)
    {
      Debug.Assert(commandText == "X²");
      LastExpression = new MathExpression(ToString(), string.Format("{0} {1}", currentInput, commandText));

      Operand op = new Square().PerformOp(new Operand(currentInput));
      double value = new Operand(Math.Round(op.ToDouble(), 8));
      UpdateExpression(ToString());
      return value.ToString();
    }

    public override string GetName() { return "X²"; }

    public override string ToString()
    {
      return string.Format("sqr({0})", lastTextValue);
    }
  }
}