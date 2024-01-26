using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;
using Tools;
using System.Diagnostics;

namespace CalculatorCommands
{
  public class ClearCommand : OperandCommand
  {
    public void Silent()
    {
      input.Clear();
    }

    public override string GetName() { return "C"; }

    protected override string DoPerform(string commandText, string currentInput)
    {
      Broadcaster.Broadcast("C pressed");
      Debug.Assert(commandText.ToUpper() == "C");
      input.Clear();
      UpdateExpression("");
      return "0";
    }

    public override string ToString()
    {
      return GetName();
    }

  }
}