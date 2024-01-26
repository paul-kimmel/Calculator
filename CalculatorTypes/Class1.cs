using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tools;
using CalculatorCommands;
using System.Windows.Forms;

namespace CalculatorTypes
{
  public class SimpleCalculator
  {
    private string currentText;
    public string CurrentText
    {
      get { return currentText; }
      set { currentText = value; }
    }

    private double currentValue;
    public double CurrentValue
    {
      get { return currentValue; }
      set { currentValue = value; }
    }


    public string ProcessInput(string input)
    {

    }

    public string ProcessKey(char key)
    {

    }

    public event EventHandler StatusChanged;
    protected virtual void OnStatusChanged(object sender, EventArgs e)
    {
      if(StatusChanged != null) 
        StatusChanged(sender, e);
    }


  }
}
