using System;
namespace CalculatorEngine
{
  public class Exponent : BinaryOperator
  {
    protected override string GetName() { return "^"; }
    public override Operand PerformOp(Operand left, Operand right)
    {
      return new Operand(Math.Pow(left, right));
    }

    protected override int GetPrecedence()
    {
      return 2;
    }
  }
}