using System;

namespace CalculatorEngine
{
  public class Operand : Token
  {
    public Operand(string value)
    {
      underlyingValue = value;
    }

    public Operand(double value)
    {
      underlyingValue = value.ToString();
    }

    private string underlyingValue;
    public string UnderlyingValue
    {
      get { return underlyingValue; }
    }

    protected override string GetName()
    {
      return underlyingValue;
    }

    public virtual double ToDouble()
    {
      return Convert.ToDouble(underlyingValue);
    }

    public static Operand operator +(Operand left, Operand right)
    {
      return new Operand(left.ToDouble() + right.ToDouble());
    }

    public static Operand operator -(Operand left, Operand right)
    {
      return new Operand(left.ToDouble() - right.ToDouble());
    }

    public static Operand operator *(Operand left, Operand right)
    {
      return new Operand(left.ToDouble() * right.ToDouble());
    }

    public static Operand operator /(Operand left, Operand right)
    {
      return new Operand(left.ToDouble() / right.ToDouble());
    }

    public static implicit operator Double(Operand operand)
    {
      return operand.ToDouble();
    }

    public override string ToString()
    {
      return underlyingValue.ToString();      
    }
  }
}
