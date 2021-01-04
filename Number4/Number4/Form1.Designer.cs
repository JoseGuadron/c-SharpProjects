namespace Number4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.SSNLabel = new System.Windows.Forms.Label();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SSNTextBox = new System.Windows.Forms.TextBox();
            this.PayTextBox = new System.Windows.Forms.TextBox();
            this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBotton = new System.Windows.Forms.Button();
            this.PayLabel = new System.Windows.Forms.Label();
            this.Result3Label = new System.Windows.Forms.Label();
            this.Result1Label = new System.Windows.Forms.Label();
            this.Result2Label = new System.Windows.Forms.Label();
            this.Result4Label = new System.Windows.Forms.Label();
            this.NameResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 25);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // SSNLabel
            // 
            this.SSNLabel.AutoSize = true;
            this.SSNLabel.Location = new System.Drawing.Point(12, 58);
            this.SSNLabel.Name = "SSNLabel";
            this.SSNLabel.Size = new System.Drawing.Size(117, 13);
            this.SSNLabel.TabIndex = 1;
            this.SSNLabel.Text = "Social Security Number";
            this.SSNLabel.Click += new System.EventHandler(this.SSNLabel_Click);
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Location = new System.Drawing.Point(12, 128);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(76, 13);
            this.HoursWorkedLabel.TabIndex = 3;
            this.HoursWorkedLabel.Text = "Hours Worked";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(160, 18);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 4;
            this.NameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.Location = new System.Drawing.Point(160, 51);
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.Size = new System.Drawing.Size(100, 20);
            this.SSNTextBox.TabIndex = 5;
            this.SSNTextBox.TextChanged += new System.EventHandler(this.SSNTextBox_TextChanged);
            // 
            // PayTextBox
            // 
            this.PayTextBox.Location = new System.Drawing.Point(160, 86);
            this.PayTextBox.Name = "PayTextBox";
            this.PayTextBox.Size = new System.Drawing.Size(100, 20);
            this.PayTextBox.TabIndex = 6;
            this.PayTextBox.TextChanged += new System.EventHandler(this.PayTextBox_TextChanged);
            // 
            // HoursWorkedTextBox
            // 
            this.HoursWorkedTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.HoursWorkedTextBox.Location = new System.Drawing.Point(160, 121);
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.Size = new System.Drawing.Size(100, 20);
            this.HoursWorkedTextBox.TabIndex = 7;
            this.HoursWorkedTextBox.TextChanged += new System.EventHandler(this.HoursWorkedTextBox_TextChanged);
            // 
            // CalculateBotton
            // 
            this.CalculateBotton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CalculateBotton.Location = new System.Drawing.Point(185, 228);
            this.CalculateBotton.Name = "CalculateBotton";
            this.CalculateBotton.Size = new System.Drawing.Size(75, 23);
            this.CalculateBotton.TabIndex = 8;
            this.CalculateBotton.Text = "Calculate";
            this.CalculateBotton.UseVisualStyleBackColor = true;
            this.CalculateBotton.Click += new System.EventHandler(this.CalculateBotton_Click);
            // 
            // PayLabel
            // 
            this.PayLabel.AutoSize = true;
            this.PayLabel.Location = new System.Drawing.Point(12, 93);
            this.PayLabel.Name = "PayLabel";
            this.PayLabel.Size = new System.Drawing.Size(82, 13);
            this.PayLabel.TabIndex = 9;
            this.PayLabel.Text = "Hours Pay Rate";
            // 
            // Result3Label
            // 
            this.Result3Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Result3Label.Location = new System.Drawing.Point(12, 251);
            this.Result3Label.Name = "Result3Label";
            this.Result3Label.Size = new System.Drawing.Size(167, 21);
            this.Result3Label.TabIndex = 10;
            this.Result3Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Result1Label
            // 
            this.Result1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Result1Label.Location = new System.Drawing.Point(12, 188);
            this.Result1Label.Name = "Result1Label";
            this.Result1Label.Size = new System.Drawing.Size(167, 21);
            this.Result1Label.TabIndex = 11;
            this.Result1Label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Result2Label
            // 
            this.Result2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Result2Label.Location = new System.Drawing.Point(12, 218);
            this.Result2Label.Name = "Result2Label";
            this.Result2Label.Size = new System.Drawing.Size(167, 21);
            this.Result2Label.TabIndex = 12;
            // 
            // Result4Label
            // 
            this.Result4Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Result4Label.Location = new System.Drawing.Point(12, 284);
            this.Result4Label.Name = "Result4Label";
            this.Result4Label.Size = new System.Drawing.Size(167, 21);
            this.Result4Label.TabIndex = 13;
            this.Result4Label.Click += new System.EventHandler(this.Result4Label_Click);
            // 
            // NameResult
            // 
            this.NameResult.ForeColor = System.Drawing.Color.White;
            this.NameResult.Location = new System.Drawing.Point(12, 153);
            this.NameResult.Name = "NameResult";
            this.NameResult.Size = new System.Drawing.Size(235, 25);
            this.NameResult.TabIndex = 14;
            this.NameResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 314);
            this.Controls.Add(this.NameResult);
            this.Controls.Add(this.Result4Label);
            this.Controls.Add(this.Result2Label);
            this.Controls.Add(this.Result1Label);
            this.Controls.Add(this.Result3Label);
            this.Controls.Add(this.PayLabel);
            this.Controls.Add(this.CalculateBotton);
            this.Controls.Add(this.HoursWorkedTextBox);
            this.Controls.Add(this.PayTextBox);
            this.Controls.Add(this.SSNTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.HoursWorkedLabel);
            this.Controls.Add(this.SSNLabel);
            this.Controls.Add(this.NameLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Name = "Form1";
            this.Text = "PayRollGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SSNLabel;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SSNTextBox;
        private System.Windows.Forms.TextBox PayTextBox;
        private System.Windows.Forms.TextBox HoursWorkedTextBox;
        private System.Windows.Forms.Button CalculateBotton;
        private System.Windows.Forms.Label PayLabel;
        private System.Windows.Forms.Label Result3Label;
        private System.Windows.Forms.Label Result1Label;
        private System.Windows.Forms.Label Result2Label;
        private System.Windows.Forms.Label Result4Label;
        private System.Windows.Forms.Label NameResult;
    }
}

