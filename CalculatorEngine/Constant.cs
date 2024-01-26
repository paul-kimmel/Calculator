using System;

namespace CalculatorEngine
{
  public abstract class Constant : Operator
  {
    public abstract Operand PerformOp();
  }
}
