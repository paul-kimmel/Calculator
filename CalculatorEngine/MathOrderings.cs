using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorEngine
{
  //TODO: Add tokenize methods that take math strings and parse them correctly
  public class MathOrderings
  {

    public static Stack<Token> GetReversePolishNotationOrdering(List<Token> infix)
    {
      List<Token> output = GetShuntingYardOrdering(infix);


      Stack<Token> RPN = new Stack<Token>();
      while (output.Count > 0)
      {
        RPN.Push(output[output.Count - 1]);
        output.RemoveAt(output.Count - 1);

      }

      return RPN;
    }


    public static List<Token> GetShuntingYardOrdering(List<Token> infix)
    {
      List<Token> output = new List<Token>();
      List<Token> operators = new List<Token>();

      // create shunting yard
      while (infix.Count > 0)
      {
        Token token = infix[0];
        infix.RemoveAt(0);
        if (token is Operand)
        {
          output.Add(token);
          continue;
        }

        if (token is Operator)
        {
          while (operators.Count > 0 && token.Precedence <=
            operators[0].Precedence)
          {
            output.Add(operators[0]);
            operators.RemoveAt(0);
          }
          operators.Add(token);
          continue;
        }
      }

      while (operators.Count > 0)
      {
        output.Add(operators[operators.Count - 1]);
        operators.RemoveAt(operators.Count - 1);
      }

      return output;
    }
  }
}
