using System;

namespace CalculatorEngine
{
  public class SquareRoot : UnaryOperator
  {
    protected override string GetName() { return "√"; }
    public override Operand PerformOp(Operand unary)
		{
		  return new Operand(Math.Sqrt(unary.ToDouble()));
		}

    protected override int GetPrecedence() { return 2; }
  }
}
