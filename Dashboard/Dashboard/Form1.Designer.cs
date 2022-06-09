namespace Dashboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ampers = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.but = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ampers
            // 
            this.ampers.BackColor = System.Drawing.Color.Transparent;
            this.ampers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ampers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.ampers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ampers.ForeColor = System.Drawing.Color.White;
            this.ampers.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.ampers.Location = new System.Drawing.Point(12, 253);
            this.ampers.Maximum = 300;
            this.ampers.Minimum = 0;
            this.ampers.Name = "ampers";
            this.ampers.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
            this.ampers.ProgressColor2 = System.Drawing.Color.Cyan;
            this.ampers.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ampers.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ampers.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ampers.Size = new System.Drawing.Size(185, 185);
            this.ampers.TabIndex = 0;
            this.ampers.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            this.ampers.UseTransparentBackground = true;
            this.ampers.Value = 200;
            // 
            // but
            // 
            this.but.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(135)))), ((int)(((byte)(213)))));
            this.but.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but.ForeColor = System.Drawing.Color.White;
            this.but.Location = new System.Drawing.Point(307, 393);
            this.but.Name = "but";
            this.but.ShadowDecoration.BorderRadius = 0;
            this.but.Size = new System.Drawing.Size(180, 45);
            this.but.TabIndex = 1;
            this.but.Text = "PRUEBA";
            this.but.Click += new System.EventHandler(this.but_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but);
            this.Controls.Add(this.ampers);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "daasdsa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar ampers;
        private Guna.UI2.WinForms.Guna2Button but;
        private System.Windows.Forms.Timer timer1;
    }
}