using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;
using Tools;
using System.Diagnostics;

namespace CalculatorCommands
{
  public class PercentageCommand : UnaryOperationCommand
  {
    public override string GetName() { return "%"; }
    protected override string DoPerform(string commandText, string currentInput)
    {
      Debug.Assert(commandText == "%");
      LastExpression = new MathExpression(string.Format("{0}{1}", currentInput, commandText), 
        string.Format("{0} / 100", currentInput));

      Operand percentage = new Operand(Convert.ToDouble(currentInput)/100);
      UpdateExpression(ToString());
      return percentage.ToString();
    }
  }
}
