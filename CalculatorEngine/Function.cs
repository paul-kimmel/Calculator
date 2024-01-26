using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CalculatorEngine
{
  public abstract class Function : Operator
  {
    public static bool IsFunction(string expression)
    {
      return Regex.IsMatch(expression, @"\w+[0-9A-Za-z]*\((\s*\d+)(,\s*\d+\s*)*\)");
    }

    public virtual bool IsMatch(string expression)
    {
      return Function.IsFunction(expression);
    }

    protected List<Token> parameters = new List<Token>();
    protected override string GetName()
    {
      return "function";
    }

    public abstract Operand PerformOp(Function function);
    protected override int GetPrecedence()
    {
      return 1;
    }
  }
}