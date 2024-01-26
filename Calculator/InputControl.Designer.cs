namespace Calculator
{
  partial class InputControl
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.textBoxInput = new System.Windows.Forms.TextBox();
      this.textBoxWorkingExpression = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // textBoxInput
      // 
      this.textBoxInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.textBoxInput.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxInput.Location = new System.Drawing.Point(3, 22);
      this.textBoxInput.Name = "textBoxInput";
      this.textBoxInput.ReadOnly = true;
      this.textBoxInput.Size = new System.Drawing.Size(261, 26);
      this.textBoxInput.TabIndex = 33;
      this.textBoxInput.Text = "0";
      this.textBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // textBoxWorkingExpression
      // 
      this.textBoxWorkingExpression.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.textBoxWorkingExpression.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxWorkingExpression.Dock = System.Windows.Forms.DockStyle.Top;
      this.textBoxWorkingExpression.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxWorkingExpression.Location = new System.Drawing.Point(3, 3);
      this.textBoxWorkingExpression.Name = "textBoxWorkingExpression";
      this.textBoxWorkingExpression.ReadOnly = true;
      this.textBoxWorkingExpression.Size = new System.Drawing.Size(261, 14);
      this.textBoxWorkingExpression.TabIndex = 34;
      this.textBoxWorkingExpression.TabStop = false;
      this.textBoxWorkingExpression.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // InputControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.textBoxWorkingExpression);
      this.Controls.Add(this.textBoxInput);
      this.Name = "InputControl";
      this.Padding = new System.Windows.Forms.Padding(3);
      this.Size = new System.Drawing.Size(267, 51);
      this.Load += new System.EventHandler(this.InputControl_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxInput;
    private System.Windows.Forms.TextBox textBoxWorkingExpression;

  }
}
