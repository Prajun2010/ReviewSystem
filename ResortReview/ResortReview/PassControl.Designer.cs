namespace ResortReview
{
    partial class PassControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PassChangeBtn = new System.Windows.Forms.Button();
            this.PassUserLbl = new System.Windows.Forms.Label();
            this.usernameValue = new System.Windows.Forms.TextBox();
            this.userOldPass = new System.Windows.Forms.TextBox();
            this.PrevPassLbl = new System.Windows.Forms.Label();
            this.userNewPass = new System.Windows.Forms.TextBox();
            this.CurrentPassLbl = new System.Windows.Forms.Label();
            this.ErrorMsgTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PassChangeBtn
            // 
            this.PassChangeBtn.BackColor = System.Drawing.Color.Green;
            this.PassChangeBtn.FlatAppearance.BorderSize = 0;
            this.PassChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassChangeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PassChangeBtn.Location = new System.Drawing.Point(57, 261);
            this.PassChangeBtn.Name = "PassChangeBtn";
            this.PassChangeBtn.Size = new System.Drawing.Size(282, 40);
            this.PassChangeBtn.TabIndex = 0;
            this.PassChangeBtn.Text = "Change";
            this.PassChangeBtn.UseVisualStyleBackColor = false;
            this.PassChangeBtn.Click += new System.EventHandler(this.PassChangeBtn_Click);
            // 
            // PassUserLbl
            // 
            this.PassUserLbl.AutoSize = true;
            this.PassUserLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassUserLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.PassUserLbl.Location = new System.Drawing.Point(52, 52);
            this.PassUserLbl.Name = "PassUserLbl";
            this.PassUserLbl.Size = new System.Drawing.Size(92, 23);
            this.PassUserLbl.TabIndex = 2;
            this.PassUserLbl.Text = "Username";
            this.PassUserLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameValue
            // 
            this.usernameValue.Location = new System.Drawing.Point(57, 89);
            this.usernameValue.Name = "usernameValue";
            this.usernameValue.Size = new System.Drawing.Size(282, 22);
            this.usernameValue.TabIndex = 3;
            // 
            // userOldPass
            // 
            this.userOldPass.Location = new System.Drawing.Point(57, 153);
            this.userOldPass.Name = "userOldPass";
            this.userOldPass.Size = new System.Drawing.Size(282, 22);
            this.userOldPass.TabIndex = 5;
            // 
            // PrevPassLbl
            // 
            this.PrevPassLbl.AutoSize = true;
            this.PrevPassLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevPassLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.PrevPassLbl.Location = new System.Drawing.Point(52, 120);
            this.PrevPassLbl.Name = "PrevPassLbl";
            this.PrevPassLbl.Size = new System.Drawing.Size(121, 23);
            this.PrevPassLbl.TabIndex = 4;
            this.PrevPassLbl.Text = "Old Password";
            this.PrevPassLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNewPass
            // 
            this.userNewPass.Location = new System.Drawing.Point(57, 216);
            this.userNewPass.Name = "userNewPass";
            this.userNewPass.Size = new System.Drawing.Size(282, 22);
            this.userNewPass.TabIndex = 7;
            // 
            // CurrentPassLbl
            // 
            this.CurrentPassLbl.AutoSize = true;
            this.CurrentPassLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPassLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.CurrentPassLbl.Location = new System.Drawing.Point(52, 183);
            this.CurrentPassLbl.Name = "CurrentPassLbl";
            this.CurrentPassLbl.Size = new System.Drawing.Size(128, 23);
            this.CurrentPassLbl.TabIndex = 6;
            this.CurrentPassLbl.Text = "New Password";
            this.CurrentPassLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorMsgTitle
            // 
            this.ErrorMsgTitle.AutoSize = true;
            this.ErrorMsgTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsgTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorMsgTitle.Location = new System.Drawing.Point(64, 315);
            this.ErrorMsgTitle.Name = "ErrorMsgTitle";
            this.ErrorMsgTitle.Size = new System.Drawing.Size(0, 16);
            this.ErrorMsgTitle.TabIndex = 8;
            this.ErrorMsgTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PassControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.ErrorMsgTitle);
            this.Controls.Add(this.userNewPass);
            this.Controls.Add(this.CurrentPassLbl);
            this.Controls.Add(this.userOldPass);
            this.Controls.Add(this.PrevPassLbl);
            this.Controls.Add(this.usernameValue);
            this.Controls.Add(this.PassUserLbl);
            this.Controls.Add(this.PassChangeBtn);
            this.Name = "PassControl";
            this.Size = new System.Drawing.Size(418, 388);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PassChangeBtn;
        private System.Windows.Forms.Label PassUserLbl;
        private System.Windows.Forms.TextBox usernameValue;
        private System.Windows.Forms.TextBox userOldPass;
        private System.Windows.Forms.Label PrevPassLbl;
        private System.Windows.Forms.TextBox userNewPass;
        private System.Windows.Forms.Label CurrentPassLbl;
        private System.Windows.Forms.Label ErrorMsgTitle;
    }
}
