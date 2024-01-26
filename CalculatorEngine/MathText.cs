using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Tools;

namespace CalculatorEngine
{
  public static class MathText
  {
    public static double CalculateFromExpression(string expression)
    {
      try
      {
        MetaDumper.CallTrace(expression);
        return CalculateFromRpn(Tokenize(expression).GetReversePolishNotationOrdering());
      }
      catch(Exception ex)
      {
        throw new Exception("multi-step expression evaluation failed.", ex);
      }
    }

    public static double CalculateFromList(List<Token> list)
    {
      return CalculateFromRpn(list.GetReversePolishNotationOrdering());
    }

    public static double CalculateFromRpn(Stack<Token> rpn)
    {
      Debug.Assert(rpn != null);
      if(rpn == null)
        throw new ArgumentNullException("rpn");

      MetaDumper.CallTrace(rpn);
      Stack<Token> temp = new Stack<Token>();
      while(rpn.Count > 0)
      {
        MetaDumper.StatementTrace("rpn.Count: {0}", rpn.Count);
        Token current = rpn.Pop();
        if(current is Operand)
        {
          MetaDumper.StatementTrace("(current is operand): {0}", current.ToString());
          temp.Push(current);
          continue;
        }


        if(current is UnaryOperator)
        {
          Debug.Assert(temp.Count >= 1);
          CheckExpected<Operand>(temp);
          Operand op = Pop<Operand>(temp);
          temp.Push((current as UnaryOperator).PerformOp(op));
        }
        else if(current is BinaryOperator)
        {
          Debug.Assert(temp.Count > 1);
          CheckExpected<Operand>(temp);
          Operand right = Pop<Operand>(temp);
        
          CheckExpected<Operand>(temp);
          Operand left = Pop<Operand>(temp);
          temp.Push((current as BinaryOperator).PerformOp(left, right));
        }

        MetaDumper.StatementTrace("current value: {0}", (temp.Peek() as Operand).ToDouble());
      }

      Debug.Assert(rpn.Count == 0);
      CheckExpected<Operand>(temp);
      return Pop<Operand>(temp).ToDouble();
    }

    private static void CheckExpected<T>(Stack<Token> stack)
    {
      MetaDumper.CallTrace(stack);
      if(!IsExpected<T>(stack))
        throw new Exception("wrong type found in expression");
    }

    private static bool IsExpected<T>(Stack<Token> stack)
    {
      MetaDumper.CallTrace(stack);
      return (stack.Peek() is T);
    }

    private static T Pop<T>(Stack<Token> stack)
    {
      MetaDumper.CallTrace(stack);
      Debug.Assert(IsExpected<T>(stack));
      return (T)Convert.ChangeType(stack.Pop(), typeof(T));
    }

    public static List<Token> Tokenize(string expression)
    {
      MetaDumper.CallTrace(expression);
      
      string[] tokens = ParseOnSpaces(expression);

      List<Token> list = new List<Token>();
      foreach (string str in tokens)
      {
        Token token = Token.Create(str);
        if (token == Token.Empty) continue;
        list.Add(token);
      }

      return list;
    }

    private static string[] ParseOnSpaces(string expression)
    {
      return expression.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }

    public static string GetFormatted(this List<Token> list)
    {
      MetaDumper.CallTrace(list);
      return list.GetFormatted("{0} {1}");
    }

    public static string GetFormatted(this List<Token> list, string mask)
    {
        if (list == null || list.Count == 0) return string.Empty;

        return (string)(from object v in list
                        select v.ToString()).Aggregate((s, t) => string.Format(mask, s, t));
    }


    public static Stack<Token> GetReversePolishNotationOrdering(this List<Token> infix)
    {
      MetaDumper.CallTrace(infix);
      List<Token> output = GetShuntingYardOrdering(infix);

      Stack<Token> RPN = new Stack<Token>();
      while (output.Count > 0)
      {
        RPN.Push(output[output.Count - 1]);
        output.RemoveAt(output.Count - 1);

      }

      return RPN;
    }

    public static List<Token> GetShuntingYardOrdering(this List<Token> infix)
    {
      MetaDumper.CallTrace(infix);
      List<Token> output = new List<Token>();
      List<Token> operators = new List<Token>();

      // create shunting yard
      while (infix.Count > 0)
      {
        Token token = infix.TakeNext();
        if (token is Operand)
        {
          ProcessOperand(output, token);
        }
        else if (token is PiConstant)
        {
          ProcessOperand(output, (token as PiConstant).PerformOp());
        }
        else if (token is Operator)
        {
          if (token is LeftParentheses)
            output.AddRange(infix.GetShuntingYardOrdering());
          else if (token is RightParentheses)
            break;
          else
            ProcessOperator(output, operators, token);
        }
      }

      AddRemainingOperatorsToOutput(output, operators);

      return output;
    }

    private static Token TakeNext(this List<Token> list)
    {
      Token token = list[0];
      list.RemoveAt(0);
      return token;
    }

    private static void AddRemainingOperatorsToOutput(List<Token> output, List<Token> operators)
    {
      while (operators.Count > 0)
      {
        output.Add(operators[operators.Count - 1]);
        operators.RemoveAt(operators.Count - 1);
      }
    }

    private static void ProcessOperand(List<Token> output, Token token)
    {
      output.Add(token);
    }

    private static void ProcessOperator(List<Token> output, List<Token> operators, Token token)
    {
      while (operators.Count > 0 && token.Precedence <=
        operators[operators.Count - 1].Precedence)
      {
        output.Add(operators[operators.Count - 1]);
        operators.RemoveAt(operators.Count - 1);
      }
      operators.Add(token);
    }
  }
}
