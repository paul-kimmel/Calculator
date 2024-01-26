
namespace CalculatorEngine
{
  public class Subtract : BinaryOperator
  {

    protected override string GetName() { return "-"; }
    public override Operand PerformOp(Operand left, Operand right)
    {
      return left - right;
    }

    protected override int GetPrecedence() { return 1; }
  }
}
