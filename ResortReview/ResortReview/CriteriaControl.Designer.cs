namespace ResortReview
{
    partial class CriteriaControl
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
            this.criteriaSetLbl = new System.Windows.Forms.Label();
            this.criteriaSpecifyBox = new System.Windows.Forms.TextBox();
            this.CriteriaBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // criteriaSetLbl
            // 
            this.criteriaSetLbl.AutoSize = true;
            this.criteriaSetLbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.criteriaSetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criteriaSetLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.criteriaSetLbl.Location = new System.Drawing.Point(318, 48);
            this.criteriaSetLbl.Name = "criteriaSetLbl";
            this.criteriaSetLbl.Size = new System.Drawing.Size(208, 32);
            this.criteriaSetLbl.TabIndex = 0;
            this.criteriaSetLbl.Text = "Specify Criteria";
            // 
            // criteriaSpecifyBox
            // 
            this.criteriaSpecifyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criteriaSpecifyBox.Location = new System.Drawing.Point(323, 94);
            this.criteriaSpecifyBox.MaxLength = 50;
            this.criteriaSpecifyBox.Name = "criteriaSpecifyBox";
            this.criteriaSpecifyBox.Size = new System.Drawing.Size(507, 27);
            this.criteriaSpecifyBox.TabIndex = 2;
            // 
            // CriteriaBtn
            // 
            this.CriteriaBtn.BackColor = System.Drawing.Color.Green;
            this.CriteriaBtn.FlatAppearance.BorderSize = 0;
            this.CriteriaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CriteriaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriteriaBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CriteriaBtn.Location = new System.Drawing.Point(755, 94);
            this.CriteriaBtn.Name = "CriteriaBtn";
            this.CriteriaBtn.Size = new System.Drawing.Size(75, 27);
            this.CriteriaBtn.TabIndex = 4;
            this.CriteriaBtn.Text = "Insert ";
            this.CriteriaBtn.UseVisualStyleBackColor = false;
            this.CriteriaBtn.Click += new System.EventHandler(this.CriteriaBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ResortReview.Properties.Resources.criteria1;
            this.pictureBox1.Location = new System.Drawing.Point(324, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // CriteriaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CriteriaBtn);
            this.Controls.Add(this.criteriaSpecifyBox);
            this.Controls.Add(this.criteriaSetLbl);
            this.Name = "CriteriaControl";
            this.Size = new System.Drawing.Size(1094, 568);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label criteriaSetLbl;
        private System.Windows.Forms.TextBox criteriaSpecifyBox;
        private System.Windows.Forms.Button CriteriaBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
