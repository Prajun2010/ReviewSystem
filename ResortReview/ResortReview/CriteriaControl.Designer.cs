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
            this.criteriaTableLbl = new System.Windows.Forms.Label();
            this.criteriaSpecifyBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CriteriaBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            // criteriaTableLbl
            // 
            this.criteriaTableLbl.AutoSize = true;
            this.criteriaTableLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.criteriaTableLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criteriaTableLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.criteriaTableLbl.Location = new System.Drawing.Point(15, 14);
            this.criteriaTableLbl.Name = "criteriaTableLbl";
            this.criteriaTableLbl.Size = new System.Drawing.Size(193, 32);
            this.criteriaTableLbl.TabIndex = 1;
            this.criteriaTableLbl.Text = "Criteria Table ";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.criteriaTableLbl);
            this.panel1.Location = new System.Drawing.Point(323, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 329);
            this.panel1.TabIndex = 3;
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
            // CriteriaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.CriteriaBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.criteriaSpecifyBox);
            this.Controls.Add(this.criteriaSetLbl);
            this.Name = "CriteriaControl";
            this.Size = new System.Drawing.Size(1094, 568);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label criteriaSetLbl;
        private System.Windows.Forms.Label criteriaTableLbl;
        private System.Windows.Forms.TextBox criteriaSpecifyBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CriteriaBtn;
    }
}
