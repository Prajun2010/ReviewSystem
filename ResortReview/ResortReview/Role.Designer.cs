namespace ResortReview
{
    partial class Role
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Role));
            this.basePanel = new System.Windows.Forms.Panel();
            this.workTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.workFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.adminBtn = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.adminLoginBtn = new System.Windows.Forms.Button();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.customerBtn = new System.Windows.Forms.Button();
            this.guidePanel = new System.Windows.Forms.Panel();
            this.userGuide = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.ToolTip(this.components);
            this.CloseLbl = new System.Windows.Forms.Label();
            this.minimizeTltp = new System.Windows.Forms.ToolTip(this.components);
            this.MinimizeLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showHideBtn = new System.Windows.Forms.Button();
            this.loginportal = new System.Windows.Forms.PictureBox();
            this.basePanel.SuspendLayout();
            this.workTitle.SuspendLayout();
            this.workFlowLayout.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.guidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginportal)).BeginInit();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.basePanel.Controls.Add(this.workTitle);
            this.basePanel.Controls.Add(this.workFlowLayout);
            this.basePanel.Location = new System.Drawing.Point(768, 224);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(448, 530);
            this.basePanel.TabIndex = 2;
            // 
            // workTitle
            // 
            this.workTitle.Controls.Add(this.label1);
            this.workTitle.Location = new System.Drawing.Point(20, 16);
            this.workTitle.Name = "workTitle";
            this.workTitle.Size = new System.Drawing.Size(412, 50);
            this.workTitle.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Work As";
            // 
            // workFlowLayout
            // 
            this.workFlowLayout.Controls.Add(this.adminBtn);
            this.workFlowLayout.Controls.Add(this.loginPanel);
            this.workFlowLayout.Controls.Add(this.customerBtn);
            this.workFlowLayout.Controls.Add(this.guidePanel);
            this.workFlowLayout.Location = new System.Drawing.Point(17, 72);
            this.workFlowLayout.Name = "workFlowLayout";
            this.workFlowLayout.Size = new System.Drawing.Size(415, 445);
            this.workFlowLayout.TabIndex = 5;
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.Green;
            this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.adminBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminBtn.Location = new System.Drawing.Point(3, 3);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(412, 77);
            this.adminBtn.TabIndex = 0;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.Control;
            this.loginPanel.Controls.Add(this.passwordTxt);
            this.loginPanel.Controls.Add(this.loginError);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.usernameTxt);
            this.loginPanel.Controls.Add(this.adminLoginBtn);
            this.loginPanel.Controls.Add(this.usernameLbl);
            this.loginPanel.Controls.Add(this.showHideBtn);
            this.loginPanel.Location = new System.Drawing.Point(3, 86);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(412, 227);
            this.loginPanel.TabIndex = 1;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTxt.Location = new System.Drawing.Point(40, 101);
            this.passwordTxt.MaxLength = 20;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(314, 24);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // loginError
            // 
            this.loginError.AutoSize = true;
            this.loginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginError.ForeColor = System.Drawing.Color.Firebrick;
            this.loginError.Location = new System.Drawing.Point(105, 199);
            this.loginError.Name = "loginError";
            this.loginError.Size = new System.Drawing.Size(0, 15);
            this.loginError.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(37, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // usernameTxt
            // 
            this.usernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameTxt.Location = new System.Drawing.Point(40, 40);
            this.usernameTxt.MaxLength = 28;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(314, 24);
            this.usernameTxt.TabIndex = 1;
            // 
            // adminLoginBtn
            // 
            this.adminLoginBtn.BackColor = System.Drawing.Color.Green;
            this.adminLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.adminLoginBtn.Location = new System.Drawing.Point(40, 144);
            this.adminLoginBtn.Name = "adminLoginBtn";
            this.adminLoginBtn.Size = new System.Drawing.Size(314, 46);
            this.adminLoginBtn.TabIndex = 4;
            this.adminLoginBtn.Text = "Login";
            this.adminLoginBtn.UseVisualStyleBackColor = false;
            this.adminLoginBtn.Click += new System.EventHandler(this.AdminLoginBtn_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usernameLbl.Location = new System.Drawing.Point(36, 13);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(86, 20);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Username";
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.Color.Green;
            this.customerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.customerBtn.Location = new System.Drawing.Point(3, 319);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(412, 77);
            this.customerBtn.TabIndex = 5;
            this.customerBtn.Text = "Customer";
            this.customerBtn.UseVisualStyleBackColor = false;
            this.customerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // guidePanel
            // 
            this.guidePanel.Controls.Add(this.userGuide);
            this.guidePanel.Location = new System.Drawing.Point(3, 402);
            this.guidePanel.Name = "guidePanel";
            this.guidePanel.Size = new System.Drawing.Size(412, 38);
            this.guidePanel.TabIndex = 8;
            // 
            // userGuide
            // 
            this.userGuide.AutoSize = true;
            this.userGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGuide.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.userGuide.Location = new System.Drawing.Point(338, 12);
            this.userGuide.Name = "userGuide";
            this.userGuide.Size = new System.Drawing.Size(46, 15);
            this.userGuide.TabIndex = 7;
            this.userGuide.Text = "Help ? ";
            this.userGuide.Click += new System.EventHandler(this.UserGuide_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Edwardian Script ITC", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(230, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 65);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parinita Resort";
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(63)))), ((int)(((byte)(5)))));
            this.CloseLbl.Location = new System.Drawing.Point(1214, -4);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(37, 38);
            this.CloseLbl.TabIndex = 8;
            this.CloseLbl.Text = "●";
            this.closeBtn.SetToolTip(this.CloseLbl, "Close");
            this.CloseLbl.Click += new System.EventHandler(this.CloseLbl_Click);
            this.CloseLbl.MouseLeave += new System.EventHandler(this.CloseLbl_MouseLeave);
            this.CloseLbl.MouseHover += new System.EventHandler(this.CloseLbl_MouseHover);
            // 
            // MinimizeLbl
            // 
            this.MinimizeLbl.AutoSize = true;
            this.MinimizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeLbl.ForeColor = System.Drawing.Color.Orange;
            this.MinimizeLbl.Location = new System.Drawing.Point(1182, -4);
            this.MinimizeLbl.Name = "MinimizeLbl";
            this.MinimizeLbl.Size = new System.Drawing.Size(37, 38);
            this.MinimizeLbl.TabIndex = 9;
            this.MinimizeLbl.Text = "●";
            this.minimizeTltp.SetToolTip(this.MinimizeLbl, "Minimize");
            this.MinimizeLbl.Click += new System.EventHandler(this.MinimizeLbl_Click);
            this.MinimizeLbl.MouseLeave += new System.EventHandler(this.MinimizeLbl_MouseLeave);
            this.MinimizeLbl.MouseHover += new System.EventHandler(this.MinimizeLbl_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ResortReview.Properties.Resources.parinita1;
            this.pictureBox1.Location = new System.Drawing.Point(896, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // showHideBtn
            // 
            this.showHideBtn.BackColor = System.Drawing.SystemColors.Control;
            this.showHideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showHideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showHideBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.showHideBtn.Image = ((System.Drawing.Image)(resources.GetObject("showHideBtn.Image")));
            this.showHideBtn.Location = new System.Drawing.Point(354, 94);
            this.showHideBtn.Name = "showHideBtn";
            this.showHideBtn.Size = new System.Drawing.Size(55, 40);
            this.showHideBtn.TabIndex = 3;
            this.showHideBtn.UseVisualStyleBackColor = false;
            this.showHideBtn.Click += new System.EventHandler(this.ShowHideBtn_Click);
            // 
            // loginportal
            // 
            this.loginportal.Image = global::ResortReview.Properties.Resources.login2;
            this.loginportal.Location = new System.Drawing.Point(24, 103);
            this.loginportal.Name = "loginportal";
            this.loginportal.Size = new System.Drawing.Size(710, 651);
            this.loginportal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginportal.TabIndex = 0;
            this.loginportal.TabStop = false;
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1250, 790);
            this.Controls.Add(this.MinimizeLbl);
            this.Controls.Add(this.CloseLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.basePanel);
            this.Controls.Add(this.loginportal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Role";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Role";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Role_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Role_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Role_MouseUp);
            this.basePanel.ResumeLayout(false);
            this.workTitle.ResumeLayout(false);
            this.workTitle.PerformLayout();
            this.workFlowLayout.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.guidePanel.ResumeLayout(false);
            this.guidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginportal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loginportal;
        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.Panel workTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel workFlowLayout;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Button adminLoginBtn;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label userGuide;
        private System.Windows.Forms.Panel guidePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label loginError;
        private System.Windows.Forms.ToolTip closeBtn;
        private System.Windows.Forms.ToolTip minimizeTltp;
        private System.Windows.Forms.Button showHideBtn;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MinimizeLbl;
        private System.Windows.Forms.Label CloseLbl;
    }
}