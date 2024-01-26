using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CalculatorTypes;
using Tools;
using Tools.Patterns;
using CalculatorCommands;

namespace Calculator
{
  public partial class Form1 : Form, IObserve
  {
    
    private SimpleCalculator calculator = new SimpleCalculator();
    public Form1()
    {
      InitializeComponent();
      Subject = calculator;
      inputControl1.Subject = calculator;
    }

    void calculator_HistoryChanged(object sender, EventArgs e)
    {
      historyToolStripMenuItem.Items.Clear();
      foreach(var item in calculator.ExpressionHistory2)
        historyToolStripMenuItem.Items.Add(item);
    }

    private void command_Click(object sender, EventArgs e)
    {
      ProcessInput((sender as Button).Text);
    }
 
    private void ProcessInput(string input)
    {
      calculator.ProcessInput(input);
    }

    private void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
      ProcessInput(e.KeyChar.ToString());
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      const string about = 
        "Calculator\r\n" + 
        "By Paul Kimmel. © 2011\r\n" +
        "pkimmel@softconcepts.com";

      MessageBox.Show(about, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void historyToolStripMenuItem_SelectedIndexChanged(object sender, EventArgs e)
    {
      calculator.ProcessExpression((historyToolStripMenuItem.SelectedItem as MathExpression).Expression);
    }

    #region IObserve Members

    private ISubject subject = null;
    public ISubject Subject
    {
      set 
      {
        RemoveSubject();
        subject = value;
        SubjectChanged(); 
      }
    }

    private void RemoveSubject()
    {
      if(subject == null) return;
      subject.HistoryChanged -= calculator_HistoryChanged;
    }

    private void SubjectChanged()
    {
      if(subject == null) return;
      subject.HistoryChanged += calculator_HistoryChanged;
    }


    #endregion

  }
}