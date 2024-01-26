using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;

namespace CalculatorCommands
{
  public class BinaryOperationCommand : BinaryOperatorCommand, IExpressionContainer
  {
    protected override string DoPerform(string commandText, string currentInput)
    {
      Operand operand = new Operand(currentInput);
      AddToken(operand);
      OnOperandInserted(this);
      
      string expression = MathText.GetFormatted(input);

      double value = Math.Round(MathText.CalculateFromList(input), 8);
      string format = string.Format("{0} = {1}", expression, value);
      lastExpression = new MathExpression(format, expression);
      UpdateExpression(format);

      return Convert.ToString(value);
    }

    private MathExpression lastExpression = MathExpression.Empty;
    public MathExpression LastExpression
    {
      get
      {
        return lastExpression;
      }
      set
      {
        lastExpression = value;
      }
    }
  }
}