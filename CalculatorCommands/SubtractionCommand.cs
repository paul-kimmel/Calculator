using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;
using System.Diagnostics;

namespace CalculatorCommands
{
  public class SubtractionCommand : OperatorCommand
  {
    protected override string DoPerform(string commandText, string currentInput)
    {
      Debug.Assert(commandText == "-");
      InsertOperation(new Subtract(), currentInput);
      return currentInput;
    }

    public override string GetName() { return "-"; }
  }
}
