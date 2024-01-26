using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CalculatorCommands
{
  public class DigitCommand : OperandCommand
  {
    public override string GetName() { return "digit"; }

    protected override string DoPerform(string commandText, string currentInput)
    {
      lastTextValue = commandText;
      Debug.Assert(Regex.IsMatch(commandText, "[0-9]{1}"));
      int number = 0;
      if(Int32.TryParse(commandText, out number) == false)
        throw new ArgumentException(string.Format("value {0} is not a digit", commandText), "digit");

      string result = currentInput == "0" ? number.ToString() : currentInput + number.ToString();
      UpdateExpression(result);
      return result;
    }

    public override string ToString()
    {
      return string.Format("{0}({1})", GetName(), lastTextValue);
    }

  }
}
