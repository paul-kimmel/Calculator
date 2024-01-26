using System;

namespace CalculatorEngine
{
  public class Inversion : Operand
  {
    public Inversion(string value)
      : base(value)
    {
    }

    public Inversion(double value)
      : base(value)
    {
    }

    public override double ToDouble()
    {
      return 1 / Convert.ToDouble(UnderlyingValue);
    }

    protected override string GetName()
    {
      return ToString();
    }

    public override string ToString()
    {
      return string.Format("recipr({0})", UnderlyingValue);
    }

  }
}
