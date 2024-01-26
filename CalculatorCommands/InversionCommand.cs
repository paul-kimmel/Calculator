using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;
using System.Diagnostics;

namespace CalculatorCommands
{
  public class InversionCommand : UnaryOperationCommand
  {
    public override string GetName() { return "1/X"; }

    protected override string DoPerform(string commandText, string currentInput)
    {
      Debug.Assert(commandText.ToUpper() == "1/X");
      LastExpression = new MathExpression(ToString(), string.Format("1 / {0}", currentInput));

      Operand inversion = new Inversion(currentInput);
      UpdateExpression(ToString());
      return inversion.ToDouble().ToString();
    }

    public override string ToString()
    {
      return string.Format("recipr({0})", lastTextValue);
    }
  }
}
