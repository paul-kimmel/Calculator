using System;
namespace CalculatorEngine
{
  public abstract class BinaryOperator : Operator
  {
    public abstract Operand PerformOp(Operand left, Operand right);
  }
}
