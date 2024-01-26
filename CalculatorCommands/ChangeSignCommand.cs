using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;
using System.Diagnostics;

namespace CalculatorCommands
{
  public class ChangeSignCommand : UnaryOperationCommand
  {
    public override string GetName() { return "±"; }
    
    protected override string DoPerform(string commandText, string currentInput)
    {
      Debug.Assert(commandText == "±");
      LastExpression = new MathExpression(ToString(), string.Format("-1 * {0}", currentInput));
   
      double number = 0;
      if(!Double.TryParse(currentInput, out number))
        throw new ArgumentException(string.Format("value {0} is not a number", currentInput), "currentInput");

      UpdateExpression(ToString());
      return Convert.ToString(number * -1);
    }

    public override string ToString()
    {
      return string.Format("{0}{1}", GetName(), lastTextValue);
    }
  }
}
