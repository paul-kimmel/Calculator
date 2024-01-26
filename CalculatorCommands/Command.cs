using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculatorEngine;
using Tools;

namespace CalculatorCommands
{
  public abstract class Command
  {
    public static string GetFormatted()
    {
      return MathText.GetFormatted(input);
    }

    protected static List<Token> input = new List<Token>();
    public static List<Token> Input
    {
      get{ return input; }
    }

    public virtual string GetName(){ return ""; }

    public virtual string Perform(string commandText, string currentInput)
    {
      OnBeforePerform(this);
      try
      {
        lastTextValue = currentInput;
        return DoPerform(commandText, currentInput);
      }
      finally
      {
        OnAfterPerform(this);
      }
    }

    protected abstract string DoPerform(string commandText, string currentInput);

    public static event EventHandler BeforePerform;
    private static void OnBeforePerform(object sender)
    {
      if(BeforePerform != null) 
        BeforePerform(sender, EventArgs.Empty);
    }

    public static event EventHandler AfterPerform;
    private static void OnAfterPerform(object sender)
    {
      if (AfterPerform != null)
        AfterPerform(sender, EventArgs.Empty);
    }

    protected void InsertOperation(Operator op, string currentInput)
    {
      Operand operand = new Operand(currentInput);
      AddToken(operand);
      OnOperandInserted(operand);
      AddToken(op);
      OnOperatorInserted(op);
      UpdateExpression("");
    }

    private string currentExpression;
    public string CurrentExpression
    {
      get { return currentExpression; }
    }

    public static event EventHandler ExpressionChanged;
    protected static void OnExpressionChanged(object sender)
    {
      if (ExpressionChanged != null)
        ExpressionChanged(sender, EventArgs.Empty);
    }

    protected void UpdateExpression(string message)
    {
      currentExpression = string.Format("{0} {1}", input.GetFormatted(), message).Trim();
      OnExpressionChanged(this);
      Broadcaster.Broadcast(currentExpression);
    }

    protected void AddToken(Token token)
    {
      input.Add(token);
      OnTokenInserted(token);
    }

    public static event EventHandler TokenInserted;
    protected static void OnTokenInserted(object sender)
    {
      if(TokenInserted != null)
        TokenInserted(sender, EventArgs.Empty);
    }

    public static event EventHandler OperatorInserted;
    protected static void OnOperatorInserted(object sender)
    {
      if(OperatorInserted != null)
        OperatorInserted(sender, EventArgs.Empty);
    }

    public static event EventHandler OperandInserted;
    protected static void OnOperandInserted(object sender)
    {
      if (OperandInserted != null)
        OperandInserted(sender, EventArgs.Empty);
    }

    protected string lastTextValue = "";
    public override string ToString()
    {
      return string.Format("{0}{1}", lastTextValue, GetName());
    }

  }
}