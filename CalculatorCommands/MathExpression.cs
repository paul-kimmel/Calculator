using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;

namespace CalculatorCommands
{
  public class MathExpression
  {
    /// <summary>
    /// Initializes a new instance of the MathExpression class.
    /// </summary>
    /// <param name="prettyExpression"></param>
    /// <param name="expression"></param>
    public MathExpression(string prettyExpression, string expression)
    {
      this.prettyExpression = prettyExpression;
      this.expression = expression;
    }

    private string prettyExpression;
    public string PrettyExpression
    {
      get { return prettyExpression; }
    }

    private string expression;
    public string Expression
    {
      get { return expression; }
    }

    public override string ToString()
    {
      return prettyExpression;
    }

    private static readonly MathExpression empty = new MathExpression("test", "2 * 5");
    public static MathExpression Empty{ get{ return empty;  } }
  }
}
