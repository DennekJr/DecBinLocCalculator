namespace WindowsformTest
{
    partial class MainForm
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
            this.TestLableTextButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Outcome = new System.Windows.Forms.Label();
            this.Subtract = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Bin = new System.Windows.Forms.Button();
            this.Dec = new System.Windows.Forms.Button();
            this.Binary = new System.Windows.Forms.Label();
            this.Decimal = new System.Windows.Forms.Label();
            this.Loc = new System.Windows.Forms.Button();
            this.LocValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TestLableTextButton
            // 
            this.TestLableTextButton.AccessibleDescription = "Add item to todo list";
            this.TestLableTextButton.AccessibleName = "Add New Item Button";
            this.TestLableTextButton.Location = new System.Drawing.Point(540, 310);
            this.TestLableTextButton.Name = "TestLableTextButton";
            this.TestLableTextButton.Size = new System.Drawing.Size(123, 49);
            this.TestLableTextButton.TabIndex = 0;
            this.TestLableTextButton.Text = "Add";
            this.TestLableTextButton.UseVisualStyleBackColor = true;
            this.TestLableTextButton.Click += new System.EventHandler(this.Add_Click);
            this.TestLableTextButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Add_KeyUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(508, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 26);
            this.textBox1.TabIndex = 1;
            // 
            // Outcome
            // 
            this.Outcome.AutoSize = true;
            this.Outcome.Location = new System.Drawing.Point(662, 42);
            this.Outcome.Name = "Outcome";
            this.Outcome.Size = new System.Drawing.Size(18, 20);
            this.Outcome.TabIndex = 2;
            this.Outcome.Text = "0";
            // 
            // Subtract
            // 
            this.Subtract.AccessibleDescription = "Subtract function";
            this.Subtract.Location = new System.Drawing.Point(701, 310);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(113, 49);
            this.Subtract.TabIndex = 3;
            this.Subtract.Text = "Subtract";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            this.Subtract.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Subtract_KeyUp);
            // 
            // Divide
            // 
            this.Divide.AccessibleDescription = "Divide by";
            this.Divide.AccessibleName = "Divide";
            this.Divide.Location = new System.Drawing.Point(853, 310);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(113, 49);
            this.Divide.TabIndex = 4;
            this.Divide.Text = "Divide";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            this.Divide.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Divide_KeyUp);
            // 
            // Multiply
            // 
            this.Multiply.AccessibleDescription = "Multiply are";
            this.Multiply.AccessibleName = "Multiply";
            this.Multiply.Location = new System.Drawing.Point(1006, 310);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(113, 49);
            this.Multiply.TabIndex = 5;
            this.Multiply.Text = "Multiply";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            this.Multiply.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Multiply_KeyUp);
            // 
            // Equals
            // 
            this.Equals.AccessibleDescription = "Equal to";
            this.Equals.AccessibleName = "Equals";
            this.Equals.Location = new System.Drawing.Point(571, 532);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(261, 53);
            this.Equals.TabIndex = 6;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Reset
            // 
            this.Reset.AccessibleDescription = "Reset All Values";
            this.Reset.AccessibleName = "Reset";
            this.Reset.Location = new System.Drawing.Point(966, 367);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(93, 59);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Bin
            // 
            this.Bin.AccessibleDescription = "Conver to binary";
            this.Bin.AccessibleName = "Binary";
            this.Bin.Location = new System.Drawing.Point(1158, 310);
            this.Bin.Name = "Bin";
            this.Bin.Size = new System.Drawing.Size(121, 49);
            this.Bin.TabIndex = 8;
            this.Bin.Text = "Bin";
            this.Bin.UseVisualStyleBackColor = true;
            this.Bin.Click += new System.EventHandler(this.Bin_Click);
            // 
            // Dec
            // 
            this.Dec.AccessibleDescription = "Convert to Decimal";
            this.Dec.AccessibleName = "Decimal";
            this.Dec.Location = new System.Drawing.Point(374, 310);
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(138, 49);
            this.Dec.TabIndex = 9;
            this.Dec.Text = "Dec";
            this.Dec.UseVisualStyleBackColor = true;
            this.Dec.Click += new System.EventHandler(this.Dec_Click);
            // 
            // Binary
            // 
            this.Binary.AccessibleDescription = "BinaryResult";
            this.Binary.AutoSize = true;
            this.Binary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Binary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Binary.Location = new System.Drawing.Point(1002, 42);
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(94, 20);
            this.Binary.TabIndex = 10;
            this.Binary.Text = "Binary Form";
            // 
            // Decimal
            // 
            this.Decimal.AccessibleDescription = "Decimal Form";
            this.Decimal.AccessibleName = "Decimal";
            this.Decimal.AutoSize = true;
            this.Decimal.Location = new System.Drawing.Point(386, 42);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(66, 20);
            this.Decimal.TabIndex = 11;
            this.Decimal.Text = "Decimal";
            // 
            // Loc
            // 
            this.Loc.AccessibleDescription = "locational number";
            this.Loc.Location = new System.Drawing.Point(508, 367);
            this.Loc.Name = "Loc";
            this.Loc.Size = new System.Drawing.Size(114, 59);
            this.Loc.TabIndex = 12;
            this.Loc.Text = "Loc";
            this.Loc.UseVisualStyleBackColor = true;
            this.Loc.Click += new System.EventHandler(this.Loc_Click);
            // 
            // LocValue
            // 
            this.LocValue.AccessibleDescription = "locational value of decimal";
            this.LocValue.AccessibleName = "loc";
            this.LocValue.AutoSize = true;
            this.LocValue.Location = new System.Drawing.Point(666, 84);
            this.LocValue.Name = "LocValue";
            this.LocValue.Size = new System.Drawing.Size(74, 20);
            this.LocValue.TabIndex = 13;
            this.LocValue.Text = "loc Value";
            this.LocValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 738);
            this.Controls.Add(this.LocValue);
            this.Controls.Add(this.Loc);
            this.Controls.Add(this.Decimal);
            this.Controls.Add(this.Binary);
            this.Controls.Add(this.Dec);
            this.Controls.Add(this.Bin);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Outcome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TestLableTextButton);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestLableTextButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Outcome;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Bin;
        private System.Windows.Forms.Button Dec;
        private System.Windows.Forms.Label Binary;
        private System.Windows.Forms.Label Decimal;
        private System.Windows.Forms.Button Loc;
        private System.Windows.Forms.Label LocValue;
    }
}

