using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;
using System.Diagnostics;

namespace CalculatorCommands
{
  public class DecimalCommand : OperandCommand
  {
    public override string GetName() { return "."; }

    protected override string DoPerform(string commandText, string currentInput)
    {
      Debug.Assert(commandText == ".");
      if(currentInput.Contains(".")) return currentInput;
      
      return currentInput.Length == 0 ? "0." : currentInput + ".";
    }
  }
}
