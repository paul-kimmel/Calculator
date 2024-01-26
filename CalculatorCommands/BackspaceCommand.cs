using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;
using System.Diagnostics;

namespace CalculatorCommands
{
  public class BackspaceCommand : OperandCommand
  {
    public override string GetName() { return "←"; }

    protected override string DoPerform(string commandText, string currentInput)
    {
      Debug.Assert(commandText == "←");

      UpdateExpression(ToString());
      if(currentInput.Length <= 1 ) 
        return "";
      else
        return currentInput.Substring(0, currentInput.Length - 1);

      
    }
  }
}
