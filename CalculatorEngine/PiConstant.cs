using System;

namespace CalculatorEngine
{
  public class PiConstant : Constant
  {
    protected override string GetName()
		    {
		      return "¶";
		    }

    public override Operand PerformOp()
    {
      return new Operand(Math.Round(Math.PI, 8));
    }

    protected override int GetPrecedence()
    {
      return 2;
    }
  }
}
