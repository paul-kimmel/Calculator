using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CalculatorEngine
{
  public class Pow : Function
  {
    private static readonly string pattern = @"pow\((\s*\d+)(,\s*\d+\s*)*\)";

    private string expression = "";
    public Pow(string expression)
    {
      this.expression = expression;
      
    }

    public override bool IsMatch(string expression)
    {
      return base.IsMatch(expression) &&
        Regex.IsMatch(expression, pattern, RegexOptions.IgnoreCase);
    }
    protected override string GetName()
    {
      return "pow";
    }

    public override Operand PerformOp(Function function)
    {
      return new Operand(0);
    }
  }
}
