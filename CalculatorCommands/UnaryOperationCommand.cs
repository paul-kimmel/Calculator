using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;

namespace CalculatorCommands
{
  public abstract class UnaryOperationCommand : UnaryOperatorCommand, IExpressionContainer
  {
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
