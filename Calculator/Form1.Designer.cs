namespace Calculator
{
  partial class Form1
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.inputControl1 = new Calculator.InputControl();
      this.statusControl1 = new Calculator.StatusControl();
      this.buttonSquareroot = new System.Windows.Forms.Button();
      this.buttonPlusMinus = new System.Windows.Forms.Button();
      this.buttonClear = new System.Windows.Forms.Button();
      this.buttonClearEntry = new System.Windows.Forms.Button();
      this.buttonBackspace = new System.Windows.Forms.Button();
      this.buttonFactorial = new System.Windows.Forms.Button();
      this.butonPi = new System.Windows.Forms.Button();
      this.buttonCubed = new System.Windows.Forms.Button();
      this.buttonSquare = new System.Windows.Forms.Button();
      this.buttonExponent = new System.Windows.Forms.Button();
      this.buttonSum = new System.Windows.Forms.Button();
      this.buttonInvert = new System.Windows.Forms.Button();
      this.buttonPercent = new System.Windows.Forms.Button();
      this.buttonPlus = new System.Windows.Forms.Button();
      this.buttonMinus = new System.Windows.Forms.Button();
      this.buttonMultiply = new System.Windows.Forms.Button();
      this.buttonDivision = new System.Windows.Forms.Button();
      this.buttondouble = new System.Windows.Forms.Button();
      this.button0 = new System.Windows.Forms.Button();
      this.button9 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(245, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "&Edit";
      // 
      // historyToolStripMenuItem
      // 
      this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
      this.historyToolStripMenuItem.Size = new System.Drawing.Size(152, 23);
      this.historyToolStripMenuItem.Text = "History";
      this.historyToolStripMenuItem.SelectedIndexChanged += new System.EventHandler(this.historyToolStripMenuItem_SelectedIndexChanged);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      this.aboutToolStripMenuItem.Text = "&About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // inputControl1
      // 
      this.inputControl1.BackColor = System.Drawing.Color.Transparent;
      this.inputControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.inputControl1.Location = new System.Drawing.Point(12, 27);
      this.inputControl1.Name = "inputControl1";
      this.inputControl1.Padding = new System.Windows.Forms.Padding(3);
      this.inputControl1.Size = new System.Drawing.Size(220, 51);
      this.inputControl1.TabIndex = 36;
      // 
      // statusControl1
      // 
      this.statusControl1.BackColor = System.Drawing.Color.Transparent;
      this.statusControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.statusControl1.Location = new System.Drawing.Point(0, 336);
      this.statusControl1.Name = "statusControl1";
      this.statusControl1.Size = new System.Drawing.Size(245, 22);
      this.statusControl1.TabIndex = 35;
      this.statusControl1.Click += new System.EventHandler(this.command_Click);
      // 
      // buttonSquareroot
      // 
      this.buttonSquareroot.Location = new System.Drawing.Point(191, 125);
      this.buttonSquareroot.Name = "buttonSquareroot";
      this.buttonSquareroot.Size = new System.Drawing.Size(41, 38);
      this.buttonSquareroot.TabIndex = 64;
      this.buttonSquareroot.TabStop = false;
      this.buttonSquareroot.Text = "√";
      this.buttonSquareroot.UseVisualStyleBackColor = true;
      this.buttonSquareroot.Click += new System.EventHandler(this.command_Click);
      // 
      // buttonPlusMinus
      // 
      this.buttonPlusMinus.Location = new System.Drawing.Point(146, 125);
      this.buttonPlusMinus.Name = "buttonPlusMinus";
      this.buttonPlusMinus.Size = new System.Drawing.Size(41, 38);
      this.buttonPlusMinus.TabIndex = 63;
      this.buttonPlusMinus.TabStop = false;
      this.buttonPlusMinus.Text = "±";
      this.buttonPlusMinus.UseVisualStyleBackColor = true;
      this.buttonPlusMinus.Click += new System.EventHandler(this.command_Click);
      // 
      // buttonClear
      // 
      this.buttonClear.Location = new System.Drawing.Point(101, 125);
      this.buttonClear.Name = "buttonClear";
      this.buttonClear.Size = new System.Drawing.Size(41, 38);
      this.buttonClear.TabIndex = 62;
      this.buttonClear.TabStop = false;
      this.buttonClear.Text = "C";
      this.buttonClear.UseVisualStyleBackColor = true;
      this.buttonClear.Click += new System.EventHandler(this.command_Click);
      // 
      // buttonClearEntry
      // 
      this.buttonClearEntry.Location = new System.Drawing.Point(56, 125);
      this.buttonClearEntry.Name = "buttonClearEntry";
      this.buttonClearEntry.Size = new System.Drawing.Size(41, 38);
      this.buttonClearEntry.TabIndex = 61;
      this.buttonClearEntry.TabStop = false;
      this.buttonClearEntry.Text = "CE";
      this.buttonClearEntry.UseVisualStyleBackColor = true;
      this.buttonClearEntry.Click += new System.EventHandler(this.command_Click);
      // 
      // buttonBackspace
      // 
      this.buttonBackspace.Location = new System.Drawing.Point(11, 125);
      this.buttonBackspace.Name = "buttonBackspace";
      this.buttonBackspace.Size = new System.Drawing.Size(41, 38);
      this.buttonBackspace.TabIndex = 60;
      this.buttonBackspace.TabStop = false;
      this.buttonBackspace.Text = "←";
      this.buttonBackspace.UseVisualStyleBackColor = true;
      this.buttonBackspace.Click += new System.EventHandler(this.command_Click);
      // 
      // buttonFactorial
      // 
      this.buttonFactorial.Location = new System.Drawing.Point(191, 84);
      this.buttonFactorial.Name = "buttonFactorial";
      this.buttonFactorial.Size = new System.Drawing.Size(41, 38);
      this.buttonFactorial.TabIndex = 59;
      this.buttonFactorial.TabStop = false;
      this.buttonFactorial.Text = "!";
      this.buttonFactorial.UseVisualStyleBackColor = true;
      this.buttonFactorial.Click += new System.EventHandler(this.command_Click);
      // 
      // butonPi
      // 
      this.butonPi.Location = new System.Drawing.Point(146, 84);
      this.butonPi.Name = "butonPi";
      this.butonPi.Size = new System.Drawing.Size(41, 38);
      this.butonPi.TabIndex = 58;
      this.butonPi.TabStop = false;
      this.butonPi.Text = "¶";
      this.butonPi.UseVisualStyleBackColor = true;
      this.butonPi.Click += new System.EventHandler(this.command_Click);
      // 
      // buttonCubed
      // 
      this.buttonCubed.Location = new System.Drawing.Point(101, 84);
      this.buttonCubed.Name = "buttonCubed";
      this.buttonCubed.Size = new System.Drawing.Size(41, 38);
      this.buttonCubed.TabIndex = 57;
      this.buttonCubed.TabStop = false;
      this.buttonCubed.Text = "X³";
      this.buttonCubed.UseVisualStyleBackColor = true;
      this.buttonCubed.Click += new System.EventHandler(this.command_Click);
      // 
      // buttonSquare
      // 
      this.buttonSquare.Location = new System.Drawing.Point(56, 84);
      this.buttonSquare.Name = "buttonSquare";
      this.buttonSquare.Size = new System.Drawing.Size(41, 38);
      this.buttonSquare.TabIndex = 56;
      this.buttonSquare.TabStop = false;
      this.buttonSquare.Text = "X²";
      this.buttonSquare.UseVisualStyleBackColor = true;
      this.buttonSquare.Click += new System.EventHandler(this.command_Click);
      // 
      // buttonExponent
      // 
      this.buttonExponent.Location = new System.Drawing.Point(11, 84);
      this.buttonExponent.Name = "buttonExponent";
      this.buttonExponent.Size = new System.Drawing.Size(41, 38);
      this.buttonExponent.TabIndex = 55;
      this.buttonExponent.TabStop = false;
      this.buttonExponent.Text = "^";
      this.buttonExponent.UseVisualStyleBackColor = true;
      this.buttonExponent.Click += new System.EventHandler(this.command_Click);
      // 
      // buttonSum
      // 
      this.buttonSum.Location = new System.Drawing.Point(191, 248);
      this.buttonSum.Name = "buttonSum";
      this.buttonSum.Size = new System.Drawing.Size(41, 79);
      this.buttonSum.TabIndex = 54;
      this.buttonSum.TabStop = false;
      this.buttonSum.Text = "=";
      this.buttonSum.UseVisualStyleBackColor = true;
      this.buttonSum.Click += new System.EventHandler(this.command_Click);
      // 
      // buttonInvert
      // 
      this.buttonInvert.Location = new System.Drawing.Point(191, 207);
      this.buttonInvert.Name = "buttonInvert";
      this.buttonInvert.Size = new System.Drawing.Size(41, 38);
      this.buttonInvert.TabIndex = 53;
      this.buttonInvert.TabStop = false;
      this.buttonInvert.Text = "1/x";
      this.buttonInvert.UseVisualStyleBackColor = true;
      this.buttonInvert.Click += new System.EventHandler(this.command_Click);
      // 
      // buttonPercent
      // 
      this.buttonPercent.Location = new System.Drawing.Point(191, 166);
      this.buttonPercent.Name = "buttonPercent";
      this.buttonPercent.Size = new System.Drawing.Size(41, 38);
      this.buttonPercent.TabIndex = 52;
      this.buttonPercent.TabStop = false;
      this.buttonPercent.Text = "%";
      this.buttonPercent.UseVisualStyleBackColor = true;
      this.buttonPercent.Click += new System.EventHandler(this.command_Click);
      // 
      // buttonPlus
      // 
      this.buttonPlus.Location = new System.Drawing.Point(146, 289);
      this.buttonPlus.Name = "buttonPlus";
      this.buttonPlus.Size = new System.Drawing.Size(41, 38);
      this.buttonPlus.TabIndex = 51;
      this.buttonPlus.TabStop = false;
      this.buttonPlus.Text = "+";
      this.buttonPlus.UseVisualStyleBackColor = true;
      this.buttonPlus.Click += new System.EventHandler(this.command_Click);
      // 
      // buttonMinus
      // 
      this.buttonMinus.Location = new System.Drawing.Point(146, 248);
      this.buttonMinus.Name = "buttonMinus";
      this.buttonMinus.Size = new System.Drawing.Size(41, 38);
      this.buttonMinus.TabIndex = 50;
      this.buttonMinus.TabStop = false;
      this.buttonMinus.Text = "-";
      this.buttonMinus.UseVisualStyleBackColor = true;
      this.buttonMinus.Click += new System.EventHandler(this.command_Click);
      // 
      // buttonMultiply
      // 
      this.buttonMultiply.Location = new System.Drawing.Point(146, 207);
      this.buttonMultiply.Name = "buttonMultiply";
      this.buttonMultiply.Size = new System.Drawing.Size(41, 38);
      this.buttonMultiply.TabIndex = 49;
      this.buttonMultiply.TabStop = false;
      this.buttonMultiply.Text = "*";
      this.buttonMultiply.UseVisualStyleBackColor = true;
      this.buttonMultiply.Click += new System.EventHandler(this.command_Click);
      // 
      // buttonDivision
      // 
      this.buttonDivision.Location = new System.Drawing.Point(146, 166);
      this.buttonDivision.Name = "buttonDivision";
      this.buttonDivision.Size = new System.Drawing.Size(41, 38);
      this.buttonDivision.TabIndex = 48;
      this.buttonDivision.TabStop = false;
      this.buttonDivision.Text = "/";
      this.buttonDivision.UseVisualStyleBackColor = true;
      this.buttonDivision.Click += new System.EventHandler(this.command_Click);
      // 
      // buttondouble
      // 
      this.buttondouble.Location = new System.Drawing.Point(101, 289);
      this.buttondouble.Name = "buttondouble";
      this.buttondouble.Size = new System.Drawing.Size(41, 38);
      this.buttondouble.TabIndex = 47;
      this.buttondouble.TabStop = false;
      this.buttondouble.Text = ".";
      this.buttondouble.UseVisualStyleBackColor = true;
      this.buttondouble.Click += new System.EventHandler(this.command_Click);
      // 
      // button0
      // 
      this.button0.Location = new System.Drawing.Point(11, 289);
      this.button0.Name = "button0";
      this.button0.Size = new System.Drawing.Size(86, 38);
      this.button0.TabIndex = 46;
      this.button0.TabStop = false;
      this.button0.Text = "0";
      this.button0.UseVisualStyleBackColor = true;
      this.button0.Click += new System.EventHandler(this.command_Click);
      // 
      // button9
      // 
      this.button9.Location = new System.Drawing.Point(101, 248);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(41, 38);
      this.button9.TabIndex = 45;
      this.button9.TabStop = false;
      this.button9.Text = "9";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Click += new System.EventHandler(this.command_Click);
      // 
      // button8
      // 
      this.button8.Location = new System.Drawing.Point(56, 248);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(41, 38);
      this.button8.TabIndex = 44;
      this.button8.TabStop = false;
      this.button8.Text = "8";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new System.EventHandler(this.command_Click);
      // 
      // button7
      // 
      this.button7.Location = new System.Drawing.Point(11, 248);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(41, 38);
      this.button7.TabIndex = 43;
      this.button7.TabStop = false;
      this.button7.Text = "7";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new System.EventHandler(this.command_Click);
      // 
      // button6
      // 
      this.button6.Location = new System.Drawing.Point(101, 207);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(41, 38);
      this.button6.TabIndex = 42;
      this.button6.TabStop = false;
      this.button6.Text = "6";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.command_Click);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(56, 207);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(41, 38);
      this.button5.TabIndex = 41;
      this.button5.TabStop = false;
      this.button5.Text = "5";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.command_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(11, 207);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(41, 38);
      this.button4.TabIndex = 40;
      this.button4.TabStop = false;
      this.button4.Text = "4";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.command_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(101, 166);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(41, 38);
      this.button3.TabIndex = 39;
      this.button3.TabStop = false;
      this.button3.Text = "3";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.command_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(56, 166);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(41, 38);
      this.button2.TabIndex = 38;
      this.button2.TabStop = false;
      this.button2.Text = "2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.command_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(11, 166);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(41, 38);
      this.button1.TabIndex = 37;
      this.button1.TabStop = false;
      this.button1.Text = "1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.command_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.ClientSize = new System.Drawing.Size(245, 358);
      this.Controls.Add(this.buttonSquareroot);
      this.Controls.Add(this.buttonPlusMinus);
      this.Controls.Add(this.buttonClear);
      this.Controls.Add(this.buttonClearEntry);
      this.Controls.Add(this.buttonBackspace);
      this.Controls.Add(this.buttonFactorial);
      this.Controls.Add(this.butonPi);
      this.Controls.Add(this.buttonCubed);
      this.Controls.Add(this.buttonSquare);
      this.Controls.Add(this.buttonExponent);
      this.Controls.Add(this.buttonSum);
      this.Controls.Add(this.buttonInvert);
      this.Controls.Add(this.buttonPercent);
      this.Controls.Add(this.buttonPlus);
      this.Controls.Add(this.buttonMinus);
      this.Controls.Add(this.buttonMultiply);
      this.Controls.Add(this.buttonDivision);
      this.Controls.Add(this.buttondouble);
      this.Controls.Add(this.button0);
      this.Controls.Add(this.button9);
      this.Controls.Add(this.button8);
      this.Controls.Add(this.button7);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.inputControl1);
      this.Controls.Add(this.statusControl1);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.KeyPreview = true;
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Calculator";
      this.TopMost = true;
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private StatusControl statusControl1;
    private InputControl inputControl1;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripComboBox historyToolStripMenuItem;
    private System.Windows.Forms.Button buttonSquareroot;
    private System.Windows.Forms.Button buttonPlusMinus;
    private System.Windows.Forms.Button buttonClear;
    private System.Windows.Forms.Button buttonClearEntry;
    private System.Windows.Forms.Button buttonBackspace;
    private System.Windows.Forms.Button buttonFactorial;
    private System.Windows.Forms.Button butonPi;
    private System.Windows.Forms.Button buttonCubed;
    private System.Windows.Forms.Button buttonSquare;
    private System.Windows.Forms.Button buttonExponent;
    private System.Windows.Forms.Button buttonSum;
    private System.Windows.Forms.Button buttonInvert;
    private System.Windows.Forms.Button buttonPercent;
    private System.Windows.Forms.Button buttonPlus;
    private System.Windows.Forms.Button buttonMinus;
    private System.Windows.Forms.Button buttonMultiply;
    private System.Windows.Forms.Button buttonDivision;
    private System.Windows.Forms.Button buttondouble;
    private System.Windows.Forms.Button button0;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
  }
}

