using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;
using System.Diagnostics;

namespace CalculatorCommands
{
  public class DivisionCommand : OperatorCommand
  {

    public override string GetName() { return "/"; }

    protected override string DoPerform(string commandText, string currentInput)
    {
      Debug.Assert(commandText == "/");
      InsertOperation(new Divide(), currentInput);
      return currentInput;
    }

    public override string ToString()
    {
      return "/";
    }
  }
}
