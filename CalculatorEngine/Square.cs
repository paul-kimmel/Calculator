using System;

namespace CalculatorEngine
{
  public class Square : UnaryOperator
  {
    protected override string GetName() { return "X²"; }
    public override Operand PerformOp(Operand unary)
    {
      return new Operand(Math.Pow(unary.ToDouble(), 2));
    }

    protected override int GetPrecedence()
    {
      return 2;
    }
  }
}
