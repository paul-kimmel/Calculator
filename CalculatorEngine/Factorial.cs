using System;

namespace CalculatorEngine
{
  public class Factorial : UnaryOperator
  {
    protected override string GetName() { return "!"; }
    public override Operand PerformOp(Operand unary)
    {
      return new Operand(NFactorial(unary.ToDouble()));
    }

    public static double NFactorial(double value)
    {
      return value > 1 ? value * NFactorial(value - 1) : value;
    }


    protected override int GetPrecedence()
    {
      return 2;
    }
  }
}
