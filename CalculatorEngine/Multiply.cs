
using System;
namespace CalculatorEngine
{
  public class Multiply : BinaryOperator
  {
    protected override string GetName() { return "*"; }
    public override Operand PerformOp(Operand left, Operand right)
    {
      return left * right;
    }

    protected override int GetPrecedence() { return 2; }
  }
}