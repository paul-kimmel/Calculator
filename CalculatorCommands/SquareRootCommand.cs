using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;
using System.Diagnostics;

namespace CalculatorCommands
{
  public class SquareRootCommand : UnaryOperationCommand
  {
    
    protected override string DoPerform(string commandText, string currentInput)
    {
      Debug.Assert(commandText == "√");
      LastExpression = new MathExpression(ToString(), string.Format("{0} {1}", commandText, currentInput));

      Operand op = new Operand(Math.Round(Math.Sqrt(Convert.ToDouble(currentInput)),8));
      UpdateExpression(ToString());
      return op.UnderlyingValue;
    }

    public override string GetName() { return "√"; }

    public override string ToString()
    {
      return string.Format("sqrt({1})", GetName(), lastTextValue);
    }
  }

}
