using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;
using System.Diagnostics;

namespace CalculatorCommands
{
  public class PiCommand : ConstantCommand
  {
    protected override string DoPerform(string commandText, string currentInput)
    {
      Debug.Assert(commandText == "¶");
      Operand op = new PiConstant().PerformOp();
      UpdateExpression(ToString());
      return op.ToString();
    }

    public override string GetName() { return "¶"; }

    public override string ToString()
    {
      return string.Format("{0}", lastTextValue);
    }
  }
}