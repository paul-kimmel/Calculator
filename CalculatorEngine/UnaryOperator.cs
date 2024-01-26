using System;
namespace CalculatorEngine
{
  public abstract class UnaryOperator : Operator
  {
    public abstract Operand PerformOp(Operand unary);
  }
}
