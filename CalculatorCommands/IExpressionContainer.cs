using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;

namespace CalculatorCommands
{
  public interface IExpressionContainer
  {
    MathExpression LastExpression { get; set; }
  }
}
