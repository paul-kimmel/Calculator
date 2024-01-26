using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;
using Tools;
using System.Diagnostics;

namespace CalculatorCommands
{
  public class ClearEntryCommand : OperandCommand
  {
    public override string GetName() { return "CE"; }

    protected override string DoPerform(string commandText, string currentInput)
    {
      Debug.Assert(commandText == "CE");
      UpdateExpression("");
      return "";
    }

    public override string ToString()
    {
      return GetName();
    }

  }
}
