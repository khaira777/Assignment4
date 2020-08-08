namespace Assignment4
{
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            this.splashformtimer = new System.Windows.Forms.Timer(this.components);
            this.splashlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // splashformtimer
            // 
            this.splashformtimer.Enabled = true;
            this.splashformtimer.Interval = 4000;
            this.splashformtimer.Tick += new System.EventHandler(this.splashformtimer_Tick);
            // 
            // splashlabel
            // 
            this.splashlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splashlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splashlabel.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splashlabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.splashlabel.Location = new System.Drawing.Point(12, 9);
            this.splashlabel.Name = "splashlabel";
            this.splashlabel.Size = new System.Drawing.Size(576, 297);
            this.splashlabel.TabIndex = 0;
            this.splashlabel.Text = "Welcome to the BMI Calculator app";
            this.splashlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 315);
            this.ControlBox = false;
            this.Controls.Add(this.splashlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer splashformtimer;
        private System.Windows.Forms.Label splashlabel;
    }
}