using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;
using System.Windows.Forms;

namespace CalculatorCommands
{
  public class NopCommand : OperandCommand
  {
    protected override string DoPerform(string commandText, string currentInput) 
    { 
      MessageBox.Show("Not implemented yet!", "NOP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return currentInput;
    }
  }
}
