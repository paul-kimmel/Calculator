using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tools.Patterns;
using CalculatorTypes;

namespace Calculator
{
  public partial class InputControl : UserControl, IObserve
  {
    public InputControl()
    {
      InitializeComponent();
    }

    private void InputControl_Load(object sender, EventArgs e)
    {
      this.SetStyle(ControlStyles.Selectable, false);
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
      if (subject == null) return;
      subject.TextChanged -= subject_TextChanged;
      subject.ExpressionChanged -= subject_ExpressionChanged;

    }

    private void SubjectChanged()
    {
      if (subject == null) return;
      subject.TextChanged += subject_TextChanged;
      subject.ExpressionChanged += subject_ExpressionChanged;
    }

    void subject_ExpressionChanged(object sender, EventArgs e)
    {
      if(subject != null)
        textBoxWorkingExpression.Text = subject.CurrentExpression;
    }

    void subject_TextChanged(object sender, EventArgs e)
    {
      if(subject != null)
        textBoxInput.Text = subject.CurrentText;
    }
    #endregion
  }
}
