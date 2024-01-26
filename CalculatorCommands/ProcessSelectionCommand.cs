using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;

namespace CalculatorCommands
{
  public class ProcessSelectionCommand : OperationCommand
  {
    protected override string DoPerform(string commandText, string currentInput)
    {
      input.Clear();
      List<Token> temp = MathText.Tokenize(commandText);
      double value = Math.Round(MathText.CalculateFromList(temp), 8);
      UpdateExpression(commandText);
      return value.ToString();;
    }
  }
}
