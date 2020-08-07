namespace Assignment4
{
    partial class BMICalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bmilabel = new System.Windows.Forms.Label();
            this.imperialradiobutton = new System.Windows.Forms.RadioButton();
            this.metricradiobutton = new System.Windows.Forms.RadioButton();
            this.heightlabel = new System.Windows.Forms.Label();
            this.weightlabel = new System.Windows.Forms.Label();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.resultlabel = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bmilabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imperialradiobutton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metricradiobutton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.heightlabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.weightlabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.calculatebutton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.resultlabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.height, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 449);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bmilabel
            // 
            this.bmilabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.bmilabel, 2);
            this.bmilabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmilabel.Font = new System.Drawing.Font("Algerian", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmilabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bmilabel.Location = new System.Drawing.Point(3, 0);
            this.bmilabel.Name = "bmilabel";
            this.bmilabel.Size = new System.Drawing.Size(332, 89);
            this.bmilabel.TabIndex = 0;
            this.bmilabel.Text = "BMI Calculator";
            this.bmilabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imperialradiobutton
            // 
            this.imperialradiobutton.AutoSize = true;
            this.imperialradiobutton.Checked = true;
            this.imperialradiobutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imperialradiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imperialradiobutton.ForeColor = System.Drawing.Color.Navy;
            this.imperialradiobutton.Location = new System.Drawing.Point(3, 92);
            this.imperialradiobutton.Name = "imperialradiobutton";
            this.imperialradiobutton.Size = new System.Drawing.Size(163, 65);
            this.imperialradiobutton.TabIndex = 1;
            this.imperialradiobutton.TabStop = true;
            this.imperialradiobutton.Text = "Imperial (in,pd)";
            this.imperialradiobutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imperialradiobutton.UseVisualStyleBackColor = true;
            // 
            // metricradiobutton
            // 
            this.metricradiobutton.AutoSize = true;
            this.metricradiobutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metricradiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metricradiobutton.ForeColor = System.Drawing.Color.Navy;
            this.metricradiobutton.Location = new System.Drawing.Point(172, 92);
            this.metricradiobutton.Name = "metricradiobutton";
            this.metricradiobutton.Size = new System.Drawing.Size(163, 65);
            this.metricradiobutton.TabIndex = 2;
            this.metricradiobutton.Text = "Metric (cm,kg)";
            this.metricradiobutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metricradiobutton.UseVisualStyleBackColor = true;
            // 
            // heightlabel
            // 
            this.heightlabel.AutoSize = true;
            this.heightlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightlabel.ForeColor = System.Drawing.Color.Navy;
            this.heightlabel.Location = new System.Drawing.Point(3, 160);
            this.heightlabel.Name = "heightlabel";
            this.heightlabel.Size = new System.Drawing.Size(163, 71);
            this.heightlabel.TabIndex = 3;
            this.heightlabel.Text = "My Height";
            this.heightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightlabel
            // 
            this.weightlabel.AutoSize = true;
            this.weightlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightlabel.ForeColor = System.Drawing.Color.Navy;
            this.weightlabel.Location = new System.Drawing.Point(3, 231);
            this.weightlabel.Name = "weightlabel";
            this.weightlabel.Size = new System.Drawing.Size(163, 71);
            this.weightlabel.TabIndex = 4;
            this.weightlabel.Text = "My Weight";
            this.weightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatebutton
            // 
            this.calculatebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculatebutton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.calculatebutton, 2);
            this.calculatebutton.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatebutton.ForeColor = System.Drawing.Color.SkyBlue;
            this.calculatebutton.Location = new System.Drawing.Point(49, 315);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(239, 44);
            this.calculatebutton.TabIndex = 5;
            this.calculatebutton.Text = "Calculate";
            this.calculatebutton.UseVisualStyleBackColor = false;
            // 
            // resultlabel
            // 
            this.resultlabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.resultlabel, 2);
            this.resultlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultlabel.Location = new System.Drawing.Point(3, 373);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(332, 76);
            this.resultlabel.TabIndex = 6;
            this.resultlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // height
            // 
            this.height.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.height.BackColor = System.Drawing.Color.AliceBlue;
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height.Location = new System.Drawing.Point(172, 180);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(163, 30);
            this.height.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown2.BackColor = System.Drawing.Color.AliceBlue;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(172, 251);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(163, 30);
            this.numericUpDown2.TabIndex = 8;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(362, 473);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label bmilabel;
        private System.Windows.Forms.RadioButton imperialradiobutton;
        private System.Windows.Forms.RadioButton metricradiobutton;
        private System.Windows.Forms.Label heightlabel;
        private System.Windows.Forms.Label weightlabel;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.Label resultlabel;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

