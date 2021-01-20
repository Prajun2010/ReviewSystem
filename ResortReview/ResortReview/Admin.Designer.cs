namespace ResortReview
{
    partial class Admin
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
            this.MinimizeLbl = new System.Windows.Forms.Label();
            this.CloseLbl = new System.Windows.Forms.Label();
            this.AdminTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminControlBtn = new System.Windows.Forms.Panel();
            this.ButtonMarker = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ClostTip = new System.Windows.Forms.ToolTip(this.components);
            this.MinimizeTip = new System.Windows.Forms.ToolTip(this.components);
            this.GeneralTitle = new System.Windows.Forms.Label();
            this.AdminBoardTitle = new System.Windows.Forms.Label();
            this.AdminLogo = new System.Windows.Forms.PictureBox();
            this.TitleLogo = new System.Windows.Forms.PictureBox();
            this.CriteriaBtn = new System.Windows.Forms.Button();
            this.PasswordChangeBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.dashboard1 = new ResortReview.Dashboard();
            this.passControl1 = new ResortReview.PassControl();
            this.criteriaControl1 = new ResortReview.CriteriaControl();
            this.AdminTitleBar.SuspendLayout();
            this.AdminControlBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MinimizeLbl
            // 
            this.MinimizeLbl.AutoSize = true;
            this.MinimizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeLbl.ForeColor = System.Drawing.Color.Orange;
            this.MinimizeLbl.Location = new System.Drawing.Point(1287, 3);
            this.MinimizeLbl.Name = "MinimizeLbl";
            this.MinimizeLbl.Size = new System.Drawing.Size(37, 38);
            this.MinimizeLbl.TabIndex = 11;
            this.MinimizeLbl.Text = "●";
            this.MinimizeTip.SetToolTip(this.MinimizeLbl, "Minimize");
            this.MinimizeLbl.Click += new System.EventHandler(this.MinimizeLbl_Click);
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(63)))), ((int)(((byte)(5)))));
            this.CloseLbl.Location = new System.Drawing.Point(1319, 3);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(37, 38);
            this.CloseLbl.TabIndex = 10;
            this.CloseLbl.Text = "●";
            this.ClostTip.SetToolTip(this.CloseLbl, "Close");
            this.CloseLbl.Click += new System.EventHandler(this.CloseLbl_Click);
            // 
            // AdminTitleBar
            // 
            this.AdminTitleBar.BackColor = System.Drawing.SystemColors.Control;
            this.AdminTitleBar.Controls.Add(this.label1);
            this.AdminTitleBar.Controls.Add(this.MinimizeLbl);
            this.AdminTitleBar.Controls.Add(this.CloseLbl);
            this.AdminTitleBar.Controls.Add(this.TitleLogo);
            this.AdminTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminTitleBar.Location = new System.Drawing.Point(0, 0);
            this.AdminTitleBar.Name = "AdminTitleBar";
            this.AdminTitleBar.Size = new System.Drawing.Size(1359, 78);
            this.AdminTitleBar.TabIndex = 12;
            this.AdminTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminTitleBar_MouseDown);
            this.AdminTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminTitleBar_MouseMove);
            this.AdminTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminTitleBar_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(95, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Parinita Resort";
            // 
            // AdminControlBtn
            // 
            this.AdminControlBtn.BackColor = System.Drawing.Color.Green;
            this.AdminControlBtn.Controls.Add(this.ButtonMarker);
            this.AdminControlBtn.Controls.Add(this.label2);
            this.AdminControlBtn.Controls.Add(this.CriteriaBtn);
            this.AdminControlBtn.Controls.Add(this.PasswordChangeBtn);
            this.AdminControlBtn.Controls.Add(this.LogoutBtn);
            this.AdminControlBtn.Controls.Add(this.DashboardBtn);
            this.AdminControlBtn.Location = new System.Drawing.Point(-1, 0);
            this.AdminControlBtn.Name = "AdminControlBtn";
            this.AdminControlBtn.Size = new System.Drawing.Size(229, 728);
            this.AdminControlBtn.TabIndex = 13;
            // 
            // ButtonMarker
            // 
            this.ButtonMarker.BackColor = System.Drawing.Color.DarkGreen;
            this.ButtonMarker.Location = new System.Drawing.Point(0, 77);
            this.ButtonMarker.Name = "ButtonMarker";
            this.ButtonMarker.Size = new System.Drawing.Size(10, 75);
            this.ButtonMarker.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(23, 679);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parinita Resort (Pvt) Ltd.\r\nDeveloper | Prajun Lungeli";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GeneralTitle
            // 
            this.GeneralTitle.AutoSize = true;
            this.GeneralTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralTitle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.GeneralTitle.Location = new System.Drawing.Point(238, 91);
            this.GeneralTitle.Name = "GeneralTitle";
            this.GeneralTitle.Size = new System.Drawing.Size(298, 43);
            this.GeneralTitle.TabIndex = 14;
            this.GeneralTitle.Text = "Change Password";
            this.GeneralTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminBoardTitle
            // 
            this.AdminBoardTitle.AutoSize = true;
            this.AdminBoardTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBoardTitle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.AdminBoardTitle.Location = new System.Drawing.Point(1189, 101);
            this.AdminBoardTitle.Name = "AdminBoardTitle";
            this.AdminBoardTitle.Size = new System.Drawing.Size(117, 23);
            this.AdminBoardTitle.TabIndex = 17;
            this.AdminBoardTitle.Text = "Admin Board";
            this.AdminBoardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminLogo
            // 
            this.AdminLogo.Image = global::ResortReview.Properties.Resources.admin;
            this.AdminLogo.Location = new System.Drawing.Point(1312, 94);
            this.AdminLogo.Name = "AdminLogo";
            this.AdminLogo.Size = new System.Drawing.Size(30, 30);
            this.AdminLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AdminLogo.TabIndex = 16;
            this.AdminLogo.TabStop = false;
            // 
            // TitleLogo
            // 
            this.TitleLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleLogo.Image = global::ResortReview.Properties.Resources.mini_logo;
            this.TitleLogo.Location = new System.Drawing.Point(0, 0);
            this.TitleLogo.Name = "TitleLogo";
            this.TitleLogo.Size = new System.Drawing.Size(92, 78);
            this.TitleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitleLogo.TabIndex = 12;
            this.TitleLogo.TabStop = false;
            // 
            // CriteriaBtn
            // 
            this.CriteriaBtn.FlatAppearance.BorderSize = 0;
            this.CriteriaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CriteriaBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriteriaBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CriteriaBtn.Image = global::ResortReview.Properties.Resources.criteria;
            this.CriteriaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CriteriaBtn.Location = new System.Drawing.Point(0, 154);
            this.CriteriaBtn.Name = "CriteriaBtn";
            this.CriteriaBtn.Padding = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.CriteriaBtn.Size = new System.Drawing.Size(229, 75);
            this.CriteriaBtn.TabIndex = 3;
            this.CriteriaBtn.Text = "Criteria";
            this.CriteriaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CriteriaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CriteriaBtn.UseVisualStyleBackColor = true;
            this.CriteriaBtn.Click += new System.EventHandler(this.CriteriaBtn_Click);
            // 
            // PasswordChangeBtn
            // 
            this.PasswordChangeBtn.FlatAppearance.BorderSize = 0;
            this.PasswordChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordChangeBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordChangeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PasswordChangeBtn.Image = global::ResortReview.Properties.Resources.changepass;
            this.PasswordChangeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PasswordChangeBtn.Location = new System.Drawing.Point(0, 230);
            this.PasswordChangeBtn.Name = "PasswordChangeBtn";
            this.PasswordChangeBtn.Padding = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.PasswordChangeBtn.Size = new System.Drawing.Size(229, 75);
            this.PasswordChangeBtn.TabIndex = 2;
            this.PasswordChangeBtn.Text = "Change Password";
            this.PasswordChangeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PasswordChangeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.PasswordChangeBtn.UseVisualStyleBackColor = true;
            this.PasswordChangeBtn.Click += new System.EventHandler(this.PasswordChangeBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogoutBtn.Image = global::ResortReview.Properties.Resources.logout;
            this.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutBtn.Location = new System.Drawing.Point(0, 306);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Padding = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.LogoutBtn.Size = new System.Drawing.Size(229, 75);
            this.LogoutBtn.TabIndex = 1;
            this.LogoutBtn.Text = "Logout ";
            this.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.BackColor = System.Drawing.Color.Green;
            this.DashboardBtn.FlatAppearance.BorderSize = 0;
            this.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DashboardBtn.Image = global::ResortReview.Properties.Resources.dashboard;
            this.DashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DashboardBtn.Location = new System.Drawing.Point(0, 77);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Padding = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.DashboardBtn.Size = new System.Drawing.Size(229, 75);
            this.DashboardBtn.TabIndex = 0;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DashboardBtn.UseVisualStyleBackColor = false;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(230, 158);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1129, 567);
            this.dashboard1.TabIndex = 21;
            // 
            // passControl1
            // 
            this.passControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.passControl1.Location = new System.Drawing.Point(230, 155);
            this.passControl1.Name = "passControl1";
            this.passControl1.Size = new System.Drawing.Size(1129, 574);
            this.passControl1.TabIndex = 20;
            this.passControl1.Load += new System.EventHandler(this.passControl1_Load);
            // 
            // criteriaControl1
            // 
            this.criteriaControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.criteriaControl1.Location = new System.Drawing.Point(230, 158);
            this.criteriaControl1.Name = "criteriaControl1";
            this.criteriaControl1.Size = new System.Drawing.Size(1129, 594);
            this.criteriaControl1.TabIndex = 19;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1359, 726);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.passControl1);
            this.Controls.Add(this.criteriaControl1);
            this.Controls.Add(this.AdminBoardTitle);
            this.Controls.Add(this.AdminLogo);
            this.Controls.Add(this.GeneralTitle);
            this.Controls.Add(this.AdminTitleBar);
            this.Controls.Add(this.AdminControlBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.AdminTitleBar.ResumeLayout(false);
            this.AdminTitleBar.PerformLayout();
            this.AdminControlBtn.ResumeLayout(false);
            this.AdminControlBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MinimizeLbl;
        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.Panel AdminTitleBar;
        private System.Windows.Forms.PictureBox TitleLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel AdminControlBtn;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.ToolTip MinimizeTip;
        private System.Windows.Forms.ToolTip ClostTip;
        private System.Windows.Forms.Button CriteriaBtn;
        private System.Windows.Forms.Button PasswordChangeBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ButtonMarker;
        private System.Windows.Forms.Label GeneralTitle;
        private System.Windows.Forms.PictureBox AdminLogo;
        private System.Windows.Forms.Label AdminBoardTitle;
        private CriteriaControl criteriaControl1;
        private PassControl passControl1;
        private Dashboard dashboard1;
    }
}