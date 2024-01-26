using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;
using System.Diagnostics;

namespace CalculatorCommands
{
  public class ExponentCommand : BinaryOperatorCommand
  {
    public override string GetName() { return "^"; }

    protected override string DoPerform(string commandText, string currentInput)
    {
      Debug.Assert(commandText == "^");
      InsertOperation(new Exponent(), currentInput);
      return currentInput;
    }

  }
}
