namespace ResortReview
{
    partial class Splashscreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginProgressBar = new System.Windows.Forms.ProgressBar();
            this.loginTimer = new System.Windows.Forms.Timer(this.components);
            this.progressStatus = new System.Windows.Forms.Label();
            this.copyrightTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ResortReview.Properties.Resources.parinita1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(310, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 352);
            this.panel1.TabIndex = 3;
            // 
            // loginProgressBar
            // 
            this.loginProgressBar.Location = new System.Drawing.Point(310, 475);
            this.loginProgressBar.Name = "loginProgressBar";
            this.loginProgressBar.Size = new System.Drawing.Size(412, 13);
            this.loginProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loginProgressBar.TabIndex = 4;
            // 
            // loginTimer
            // 
            this.loginTimer.Enabled = true;
            this.loginTimer.Tick += new System.EventHandler(this.LoginTimer_Tick);
            // 
            // progressStatus
            // 
            this.progressStatus.AutoSize = true;
            this.progressStatus.ForeColor = System.Drawing.Color.Green;
            this.progressStatus.Location = new System.Drawing.Point(502, 452);
            this.progressStatus.Name = "progressStatus";
            this.progressStatus.Size = new System.Drawing.Size(0, 17);
            this.progressStatus.TabIndex = 5;
            // 
            // copyrightTxt
            // 
            this.copyrightTxt.AutoSize = true;
            this.copyrightTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.copyrightTxt.Location = new System.Drawing.Point(379, 592);
            this.copyrightTxt.Name = "copyrightTxt";
            this.copyrightTxt.Size = new System.Drawing.Size(241, 15);
            this.copyrightTxt.TabIndex = 6;
            this.copyrightTxt.Text = "Copyrights © Parinita Resort (Pvt) Ltd. 2021\r\n";
            this.copyrightTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Splashscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1084, 617);
            this.Controls.Add(this.copyrightTxt);
            this.Controls.Add(this.progressStatus);
            this.Controls.Add(this.loginProgressBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splashscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splashscreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar loginProgressBar;
        private System.Windows.Forms.Timer loginTimer;
        private System.Windows.Forms.Label progressStatus;
        private System.Windows.Forms.Label copyrightTxt;
    }
}

