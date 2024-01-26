using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tools;

namespace Calculator
{
  public partial class StatusControl : UserControl, IListener
  {
    public StatusControl()
    {
      InitializeComponent();
    }

    protected override void OnHandleDestroyed(EventArgs e)
    {
      Broadcaster.RemoveListener(this);
      base.OnHandleDestroyed(e);
    }
    
    
    public void UpdateStatus(string text)
    {
      if(text == "")
        toolStripStatusLabel1.Text = "Ready";
      else
        toolStripStatusLabel1.Text = text;
    }

    private void StatusControl_Load(object sender, EventArgs e)
    {
      Broadcaster.AddListener(this);
    }

    

    #region IListener Members

    public void Listen(string text)
    {
      UpdateStatus(text);
    }

    #endregion
  }
}
