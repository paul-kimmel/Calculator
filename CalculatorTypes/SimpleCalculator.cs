using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tools;
using CalculatorCommands;
using System.Windows.Forms;
using Tools.Patterns;

namespace CalculatorTypes
{
  public class SimpleCalculator : ISubject
  {
    private AdditionCommand additionCommand = new AdditionCommand();
    private BackspaceCommand backspaceCommand = new BackspaceCommand();
    private BinaryOperationCommand binaryOperationCommand = new BinaryOperationCommand();
    private ChangeSignCommand changeSignCommand = new ChangeSignCommand();
    private ClearCommand clearCommand = new ClearCommand();
    private ClearEntryCommand clearEntryCommand = new ClearEntryCommand();
    private DecimalCommand decimalCommand = new DecimalCommand();
    private DigitCommand digitCommand = new DigitCommand();
    private DivisionCommand divisionCommand = new DivisionCommand();
    private InversionCommand inversionCommand = new InversionCommand();
    private MultiplicationCommand multiplicationCommand = new MultiplicationCommand();
    private NopCommand nopCommand = new NopCommand();
    private PercentageCommand percentageCommand = new PercentageCommand();
    private ProcessSelectionCommand processSelectionCommand = new ProcessSelectionCommand();
    private SquareRootCommand squareRootCommand = new SquareRootCommand();
    private SubtractionCommand subtractionCommand = new SubtractionCommand();
    private ExponentCommand exponentCommand = new ExponentCommand();
    private CubeCommand cubeCommand = new CubeCommand();
    private SquareCommand squareCommand = new SquareCommand();
    private FactorialCommand factorialCommand = new FactorialCommand();
    private PiCommand piCommand = new PiCommand();
    
    public SimpleCalculator()
    {
      Command.BeforePerform += Command_BeforePerform;
      Command.AfterPerform += Command_AfterPerform;
      Command.OperatorInserted += Command_OperatorInserted;
      Command.TokenInserted += Command_TokenInserted;
      Command.OperandInserted += Command_OperandInserted;
      Command.ExpressionChanged += Command_ExpressionChanged;
    }

    public void Command_ExpressionChanged(object sender, EventArgs e)
    {
      if(sender is Command == false) return;
      currentExpression = (sender as Command).CurrentExpression;
      OnExpressionChanged();
    }

    void Command_OperandInserted(object sender, EventArgs e)
    {
    }

    void Command_TokenInserted(object sender, EventArgs e)
    {
    }

    void Command_OperatorInserted(object sender, EventArgs e)
    {
    }

    void Command_AfterPerform(object sender, EventArgs e)
    {
      if(sender is IExpressionContainer)
        AppendHistoryItem((sender as IExpressionContainer).LastExpression);
    }

    void Command_BeforePerform(object sender, EventArgs e)
    {
    }

    private string currentText = "0";
    public string CurrentText
    {
      get { return currentText; }
      protected set 
      {
        currentText = value; 
        OnTextChanged();
        OnExpressionChanged();
      }
    }

    private string currentExpression = "";
    public string CurrentExpression
    {
      get{ return currentExpression; }
    }

    public double CurrentValue
    {
      get { return Convert.ToDouble(CurrentValue); }
    }

    private Dictionary<string, Command> commands = null;
    private Dictionary<string, Command> Commands
    {
      get
      {
        if (commands == null)
        {
          commands = new Dictionary<string, Command>();

          commands.Add("←", backspaceCommand);
          commands.Add("C", clearCommand);
          commands.Add("CE", clearEntryCommand);
          commands.Add("±", changeSignCommand);
          commands.Add("√", squareRootCommand);
          commands.Add("0", digitCommand);
          commands.Add("1", digitCommand);
          commands.Add("2", digitCommand);
          commands.Add("3", digitCommand);
          commands.Add("/", divisionCommand);
          commands.Add("%", percentageCommand);
          commands.Add("4", digitCommand);
          commands.Add("5", digitCommand);
          commands.Add("6", digitCommand);
          commands.Add("*", multiplicationCommand);
          commands.Add("1/x", inversionCommand);
          commands.Add("7", digitCommand);
          commands.Add("8", digitCommand);
          commands.Add("9", digitCommand);
          commands.Add(".", decimalCommand);
          commands.Add("-", subtractionCommand);
          commands.Add("=", binaryOperationCommand);
          commands.Add("+", additionCommand);
          commands.Add("\r", binaryOperationCommand);
          commands.Add("X²", squareCommand);
          commands.Add("X³", cubeCommand);
          commands.Add("^", exponentCommand);
          commands.Add("¶", piCommand);
          commands.Add("!", factorialCommand);
        }  
        return commands;
      }
    }
  
    public void ProcessInput(string commandText)
    {
      if (Commands.ContainsKey(commandText))
      { 
        currentCommand = Commands[commandText];
        ProcessCommand(commandText);
        lastCommand = currentCommand;
        CheckIsRepeatableOperator();
      }
    }

    private void CheckIsRepeatableOperator()
    {
      if(currentCommand is OperatorCommand && currentCommand is BinaryOperationCommand == false)
        lastOperatorCommand = currentCommand;
    }

    private Command lastCommand = null;
    private Command currentCommand = null;
    private string  lastOperandText = "";
    private Command lastOperatorCommand = null;
    
    private void ProcessCommand(string commandText)
    {
      if (currentCommand is OperandCommand)
        lastOperandText = commandText;
     
      if (IsRepeatingBinaryOperation())
      {
        RepeatBinaryOperation(commandText);
      }
      else
      {
        if (lastCommand is OperatorCommand && currentCommand is OperandCommand)
          CurrentText = "";
        CurrentText = currentCommand.Perform(commandText, currentText);
      }
    }

    private void RepeatBinaryOperation(string commandText)
    {
      if (lastOperatorCommand != null)
      {
        lastOperatorCommand.Perform(lastOperatorCommand.GetName(), lastOperandText);
        CurrentText = currentCommand.Perform("=", CurrentText);
      }
    }

    private bool IsRepeatingBinaryOperation()
    {
      return lastCommand is BinaryOperationCommand && currentCommand is BinaryOperationCommand;
    }

   

    public void ProcessExpression(string completeMathExpression)
    {
      try
      {
        CurrentText = processSelectionCommand.Perform(completeMathExpression, currentText);
      }
      catch(Exception ex)
      {
        throw new Exception(string.Format("error calculating expression {0}", currentText), ex);
      }
    }

    public event EventHandler TextChanged;
    protected virtual void OnTextChanged()
    {
      if(TextChanged != null)
        TextChanged(this, EventArgs.Empty);
    }

    public event EventHandler ExpressionChanged;
    protected virtual void OnExpressionChanged()
    {
      if(ExpressionChanged != null)
        ExpressionChanged(this, EventArgs.Empty);
    }

    public event EventHandler HistoryChanged;
    protected virtual void OnHistoryChanged()
    {
      if(HistoryChanged != null)
        HistoryChanged(this, EventArgs.Empty);
    }

    protected virtual void AppendHistoryItem(MathExpression historyItem)
    {
      expressionHistory2.Add(historyItem);
      OnHistoryChanged();
    }

    protected virtual void AppendHistoryItem(string historyItem)
    {
      expressionHistory.Add(historyItem);
      OnHistoryChanged();
    }

    private List<MathExpression> expressionHistory2 = new List<MathExpression>();
    public List<MathExpression> ExpressionHistory2
    {
      get{ return expressionHistory2; }
    }

    private List<string> expressionHistory = new List<string>();
    public List<string> ExpressionHistory
    {
      get{ return expressionHistory; }
    }
  }
}
