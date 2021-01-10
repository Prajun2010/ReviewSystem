namespace ResortReview
{
    partial class Customer
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
            this.customerControlBox = new System.Windows.Forms.Panel();
            this.MinimizeLbl = new System.Windows.Forms.Label();
            this.CloseLbl = new System.Windows.Forms.Label();
            this.CustomerFeedLbl = new System.Windows.Forms.Label();
            this.queryLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.queryHeader = new System.Windows.Forms.Panel();
            this.queryHeaderlbl = new System.Windows.Forms.Label();
            this.PersonalInfoPanel = new System.Windows.Forms.Panel();
            this.customerEmailBox = new System.Windows.Forms.TextBox();
            this.CustomerEmail = new System.Windows.Forms.Label();
            this.customerNumberBox = new System.Windows.Forms.TextBox();
            this.CustomerNumber = new System.Windows.Forms.Label();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.Label();
            this.PersonalInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RatingLbl = new System.Windows.Forms.Label();
            this.RatingLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuggesstionLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuggesstionLbl = new System.Windows.Forms.Label();
            this.suggestionBox = new System.Windows.Forms.TextBox();
            this.closeTip = new System.Windows.Forms.ToolTip(this.components);
            this.miniTip = new System.Windows.Forms.ToolTip(this.components);
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.cutomerBanner = new System.Windows.Forms.PictureBox();
            this.customerControlBox.SuspendLayout();
            this.queryLayout.SuspendLayout();
            this.queryHeader.SuspendLayout();
            this.PersonalInfoPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuggesstionLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cutomerBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // customerControlBox
            // 
            this.customerControlBox.BackColor = System.Drawing.Color.White;
            this.customerControlBox.Controls.Add(this.MinimizeLbl);
            this.customerControlBox.Controls.Add(this.CloseLbl);
            this.customerControlBox.Controls.Add(this.CustomerFeedLbl);
            this.customerControlBox.Location = new System.Drawing.Point(-3, 0);
            this.customerControlBox.Name = "customerControlBox";
            this.customerControlBox.Size = new System.Drawing.Size(669, 62);
            this.customerControlBox.TabIndex = 0;
            this.customerControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomerControlBox_MouseDown);
            this.customerControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CustomerControlBox_MouseMove);
            this.customerControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CustomerControlBox_MouseUp);
            // 
            // MinimizeLbl
            // 
            this.MinimizeLbl.AutoSize = true;
            this.MinimizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeLbl.ForeColor = System.Drawing.Color.Orange;
            this.MinimizeLbl.Location = new System.Drawing.Point(599, 2);
            this.MinimizeLbl.Name = "MinimizeLbl";
            this.MinimizeLbl.Size = new System.Drawing.Size(37, 38);
            this.MinimizeLbl.TabIndex = 2;
            this.MinimizeLbl.Text = "●";
            this.miniTip.SetToolTip(this.MinimizeLbl, "Minimize");
            this.MinimizeLbl.Click += new System.EventHandler(this.MinimizeLbl_Click);
            this.MinimizeLbl.MouseLeave += new System.EventHandler(this.MinimizeLbl_MouseLeave);
            this.MinimizeLbl.MouseHover += new System.EventHandler(this.MinimizeLbl_MouseHover);
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(63)))), ((int)(((byte)(5)))));
            this.CloseLbl.Location = new System.Drawing.Point(631, 2);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(37, 38);
            this.CloseLbl.TabIndex = 1;
            this.CloseLbl.Text = "●";
            this.closeTip.SetToolTip(this.CloseLbl, "Close");
            this.CloseLbl.Click += new System.EventHandler(this.CloseLbl_Click);
            this.CloseLbl.MouseLeave += new System.EventHandler(this.CloseLbl_MouseLeave);
            this.CloseLbl.MouseHover += new System.EventHandler(this.CloseLbl_MouseHover);
            // 
            // CustomerFeedLbl
            // 
            this.CustomerFeedLbl.AutoSize = true;
            this.CustomerFeedLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerFeedLbl.ForeColor = System.Drawing.Color.Green;
            this.CustomerFeedLbl.Location = new System.Drawing.Point(195, 14);
            this.CustomerFeedLbl.Name = "CustomerFeedLbl";
            this.CustomerFeedLbl.Size = new System.Drawing.Size(280, 36);
            this.CustomerFeedLbl.TabIndex = 0;
            this.CustomerFeedLbl.Text = "Customer Feedback";
            this.CustomerFeedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // queryLayout
            // 
            this.queryLayout.BackColor = System.Drawing.SystemColors.Control;
            this.queryLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryLayout.Controls.Add(this.queryHeader);
            this.queryLayout.Controls.Add(this.PersonalInfoPanel);
            this.queryLayout.Controls.Add(this.panel2);
            this.queryLayout.Controls.Add(this.SuggesstionLayout);
            this.queryLayout.Location = new System.Drawing.Point(59, 212);
            this.queryLayout.Name = "queryLayout";
            this.queryLayout.Size = new System.Drawing.Size(552, 565);
            this.queryLayout.TabIndex = 1;
            // 
            // queryHeader
            // 
            this.queryHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.queryHeader.Controls.Add(this.queryHeaderlbl);
            this.queryHeader.Location = new System.Drawing.Point(3, 3);
            this.queryHeader.Name = "queryHeader";
            this.queryHeader.Size = new System.Drawing.Size(544, 61);
            this.queryHeader.TabIndex = 0;
            // 
            // queryHeaderlbl
            // 
            this.queryHeaderlbl.AutoSize = true;
            this.queryHeaderlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryHeaderlbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.queryHeaderlbl.Location = new System.Drawing.Point(161, 11);
            this.queryHeaderlbl.Name = "queryHeaderlbl";
            this.queryHeaderlbl.Size = new System.Drawing.Size(217, 36);
            this.queryHeaderlbl.TabIndex = 0;
            this.queryHeaderlbl.Text = "Resort Review ";
            this.queryHeaderlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonalInfoPanel
            // 
            this.PersonalInfoPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PersonalInfoPanel.Controls.Add(this.customerEmailBox);
            this.PersonalInfoPanel.Controls.Add(this.CustomerEmail);
            this.PersonalInfoPanel.Controls.Add(this.customerNumberBox);
            this.PersonalInfoPanel.Controls.Add(this.CustomerNumber);
            this.PersonalInfoPanel.Controls.Add(this.customerNameBox);
            this.PersonalInfoPanel.Controls.Add(this.CustomerName);
            this.PersonalInfoPanel.Controls.Add(this.PersonalInfo);
            this.PersonalInfoPanel.Location = new System.Drawing.Point(3, 70);
            this.PersonalInfoPanel.Name = "PersonalInfoPanel";
            this.PersonalInfoPanel.Size = new System.Drawing.Size(544, 150);
            this.PersonalInfoPanel.TabIndex = 1;
            // 
            // customerEmailBox
            // 
            this.customerEmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerEmailBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customerEmailBox.Location = new System.Drawing.Point(8, 113);
            this.customerEmailBox.Name = "customerEmailBox";
            this.customerEmailBox.Size = new System.Drawing.Size(251, 24);
            this.customerEmailBox.TabIndex = 4;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.AutoSize = true;
            this.CustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerEmail.ForeColor = System.Drawing.Color.DimGray;
            this.CustomerEmail.Location = new System.Drawing.Point(3, 89);
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Size = new System.Drawing.Size(129, 20);
            this.CustomerEmail.TabIndex = 6;
            this.CustomerEmail.Text = "Customer Email";
            this.CustomerEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerNumberBox
            // 
            this.customerNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNumberBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customerNumberBox.Location = new System.Drawing.Point(271, 113);
            this.customerNumberBox.MaxLength = 10;
            this.customerNumberBox.Name = "customerNumberBox";
            this.customerNumberBox.Size = new System.Drawing.Size(261, 24);
            this.customerNumberBox.TabIndex = 5;
            // 
            // CustomerNumber
            // 
            this.CustomerNumber.AutoSize = true;
            this.CustomerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNumber.ForeColor = System.Drawing.Color.DimGray;
            this.CustomerNumber.Location = new System.Drawing.Point(267, 89);
            this.CustomerNumber.Name = "CustomerNumber";
            this.CustomerNumber.Size = new System.Drawing.Size(146, 20);
            this.CustomerNumber.TabIndex = 4;
            this.CustomerNumber.Text = "Customer Number";
            this.CustomerNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerNameBox
            // 
            this.customerNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customerNameBox.Location = new System.Drawing.Point(8, 58);
            this.customerNameBox.MaxLength = 100;
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(524, 24);
            this.customerNameBox.TabIndex = 3;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.ForeColor = System.Drawing.Color.DimGray;
            this.CustomerName.Location = new System.Drawing.Point(3, 33);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(131, 20);
            this.CustomerName.TabIndex = 2;
            this.CustomerName.Text = "Customer Name";
            this.CustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.AutoSize = true;
            this.PersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalInfo.ForeColor = System.Drawing.Color.DimGray;
            this.PersonalInfo.Location = new System.Drawing.Point(3, 0);
            this.PersonalInfo.Name = "PersonalInfo";
            this.PersonalInfo.Size = new System.Drawing.Size(201, 24);
            this.PersonalInfo.TabIndex = 1;
            this.PersonalInfo.Text = "Personal Information";
            this.PersonalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.RatingLbl);
            this.panel2.Controls.Add(this.RatingLayout);
            this.panel2.Location = new System.Drawing.Point(3, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 190);
            this.panel2.TabIndex = 3;
            // 
            // RatingLbl
            // 
            this.RatingLbl.AutoSize = true;
            this.RatingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingLbl.ForeColor = System.Drawing.Color.DimGray;
            this.RatingLbl.Location = new System.Drawing.Point(4, 3);
            this.RatingLbl.Name = "RatingLbl";
            this.RatingLbl.Size = new System.Drawing.Size(75, 24);
            this.RatingLbl.TabIndex = 10;
            this.RatingLbl.Text = "Rating ";
            this.RatingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RatingLayout
            // 
            this.RatingLayout.AutoScroll = true;
            this.RatingLayout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RatingLayout.Location = new System.Drawing.Point(3, 30);
            this.RatingLayout.Name = "RatingLayout";
            this.RatingLayout.Size = new System.Drawing.Size(538, 157);
            this.RatingLayout.TabIndex = 2;
            // 
            // SuggesstionLayout
            // 
            this.SuggesstionLayout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SuggesstionLayout.Controls.Add(this.SuggesstionLbl);
            this.SuggesstionLayout.Controls.Add(this.suggestionBox);
            this.SuggesstionLayout.Location = new System.Drawing.Point(3, 422);
            this.SuggesstionLayout.Name = "SuggesstionLayout";
            this.SuggesstionLayout.Size = new System.Drawing.Size(544, 142);
            this.SuggesstionLayout.TabIndex = 3;
            // 
            // SuggesstionLbl
            // 
            this.SuggesstionLbl.AutoSize = true;
            this.SuggesstionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuggesstionLbl.ForeColor = System.Drawing.Color.DimGray;
            this.SuggesstionLbl.Location = new System.Drawing.Point(3, 0);
            this.SuggesstionLbl.Name = "SuggesstionLbl";
            this.SuggesstionLbl.Size = new System.Drawing.Size(131, 24);
            this.SuggesstionLbl.TabIndex = 8;
            this.SuggesstionLbl.Text = "Suggesstion ";
            this.SuggesstionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // suggestionBox
            // 
            this.suggestionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.suggestionBox.Location = new System.Drawing.Point(8, 27);
            this.suggestionBox.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.suggestionBox.Multiline = true;
            this.suggestionBox.Name = "suggestionBox";
            this.suggestionBox.Size = new System.Drawing.Size(524, 103);
            this.suggestionBox.TabIndex = 8;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.Green;
            this.SubmitBtn.FlatAppearance.BorderSize = 0;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitBtn.Location = new System.Drawing.Point(59, 795);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(552, 52);
            this.SubmitBtn.TabIndex = 2;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // cutomerBanner
            // 
            this.cutomerBanner.Image = global::ResortReview.Properties.Resources.resort2;
            this.cutomerBanner.Location = new System.Drawing.Point(25, 68);
            this.cutomerBanner.Name = "cutomerBanner";
            this.cutomerBanner.Size = new System.Drawing.Size(613, 243);
            this.cutomerBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cutomerBanner.TabIndex = 0;
            this.cutomerBanner.TabStop = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(664, 868);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.queryLayout);
            this.Controls.Add(this.cutomerBanner);
            this.Controls.Add(this.customerControlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.customerControlBox.ResumeLayout(false);
            this.customerControlBox.PerformLayout();
            this.queryLayout.ResumeLayout(false);
            this.queryHeader.ResumeLayout(false);
            this.queryHeader.PerformLayout();
            this.PersonalInfoPanel.ResumeLayout(false);
            this.PersonalInfoPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.SuggesstionLayout.ResumeLayout(false);
            this.SuggesstionLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cutomerBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel customerControlBox;
        private System.Windows.Forms.FlowLayoutPanel queryLayout;
        private System.Windows.Forms.PictureBox cutomerBanner;
        private System.Windows.Forms.Label CustomerFeedLbl;
        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.Label MinimizeLbl;
        private System.Windows.Forms.ToolTip closeTip;
        private System.Windows.Forms.ToolTip miniTip;
        private System.Windows.Forms.Panel queryHeader;
        private System.Windows.Forms.Label queryHeaderlbl;
        private System.Windows.Forms.Panel PersonalInfoPanel;
        private System.Windows.Forms.Label PersonalInfo;
        private System.Windows.Forms.TextBox customerEmailBox;
        private System.Windows.Forms.Label CustomerEmail;
        private System.Windows.Forms.TextBox customerNumberBox;
        private System.Windows.Forms.Label CustomerNumber;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.FlowLayoutPanel RatingLayout;
        private System.Windows.Forms.FlowLayoutPanel SuggesstionLayout;
        private System.Windows.Forms.Label SuggesstionLbl;
        private System.Windows.Forms.TextBox suggestionBox;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RatingLbl;
    }
}