using System;

namespace CalculatorEngine
{
  public abstract class Operator : Token
  {
    protected override string GetName()
    {
      return "nop";
    }

    public override string ToString()
    {
      return string.Format("{0}", GetName());
    }

    public static Token TryCreate(string token)
    {
      token = token.ToUpper().Trim();

      if (token == "X²")
        return new Square();
      else if (token == "X³")
        return new Cube();

      switch(token[0])
      {
        case '+':
          return new Add();
        case '-':
          return new Subtract();
        case '*':
          return new Multiply();
        case '/':
          return new Divide();
        case '√':
          return new SquareRoot();
        case '(':
          return new LeftParentheses();
        case ')':
          return new RightParentheses();
        case '^':
          return new Exponent();
        case '!':
          return new Factorial();
        case '¶':
          return new PiConstant();
        default:
          return Token.Empty;
      }
    }
  }
}
