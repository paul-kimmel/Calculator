using System;

namespace CalculatorEngine
{
  public class Cube : UnaryOperator
  {
    protected override string GetName() { return "X³"; }
    public override Operand PerformOp(Operand unary)
    {
      return new Operand(Math.Pow(unary.ToDouble(), 3));
    }

    protected override int GetPrecedence()
    {
      return 2;
    }
  }
}
