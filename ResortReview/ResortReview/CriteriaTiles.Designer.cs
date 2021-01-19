namespace ResortReview
{
    partial class CriteriaTiles
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
            this.criteriaName = new System.Windows.Forms.Label();
            this.RateOne = new System.Windows.Forms.Button();
            this.RateFive = new System.Windows.Forms.Button();
            this.RateFour = new System.Windows.Forms.Button();
            this.RateThree = new System.Windows.Forms.Button();
            this.RateTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // criteriaName
            // 
            this.criteriaName.AutoSize = true;
            this.criteriaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criteriaName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.criteriaName.Location = new System.Drawing.Point(16, 14);
            this.criteriaName.Name = "criteriaName";
            this.criteriaName.Size = new System.Drawing.Size(0, 20);
            this.criteriaName.TabIndex = 0;
            // 
            // RateOne
            // 
            this.RateOne.FlatAppearance.BorderSize = 0;
            this.RateOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RateOne.Image = global::ResortReview.Properties.Resources.white_star;
            this.RateOne.Location = new System.Drawing.Point(263, 0);
            this.RateOne.Name = "RateOne";
            this.RateOne.Size = new System.Drawing.Size(44, 50);
            this.RateOne.TabIndex = 1;
            this.RateOne.UseVisualStyleBackColor = true;
            this.RateOne.Click += new System.EventHandler(this.RateOne_Click);
            // 
            // RateFive
            // 
            this.RateFive.FlatAppearance.BorderSize = 0;
            this.RateFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RateFive.Image = global::ResortReview.Properties.Resources.white_star;
            this.RateFive.Location = new System.Drawing.Point(463, 0);
            this.RateFive.Name = "RateFive";
            this.RateFive.Size = new System.Drawing.Size(44, 50);
            this.RateFive.TabIndex = 5;
            this.RateFive.UseVisualStyleBackColor = true;
            this.RateFive.Click += new System.EventHandler(this.RateFive_Click);
            // 
            // RateFour
            // 
            this.RateFour.FlatAppearance.BorderSize = 0;
            this.RateFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RateFour.Image = global::ResortReview.Properties.Resources.white_star;
            this.RateFour.Location = new System.Drawing.Point(413, 0);
            this.RateFour.Name = "RateFour";
            this.RateFour.Size = new System.Drawing.Size(44, 50);
            this.RateFour.TabIndex = 4;
            this.RateFour.UseVisualStyleBackColor = true;
            this.RateFour.Click += new System.EventHandler(this.RateFour_Click);
            // 
            // RateThree
            // 
            this.RateThree.FlatAppearance.BorderSize = 0;
            this.RateThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RateThree.Image = global::ResortReview.Properties.Resources.white_star;
            this.RateThree.Location = new System.Drawing.Point(363, 0);
            this.RateThree.Name = "RateThree";
            this.RateThree.Size = new System.Drawing.Size(44, 50);
            this.RateThree.TabIndex = 3;
            this.RateThree.UseVisualStyleBackColor = true;
            this.RateThree.Click += new System.EventHandler(this.RateThree_Click);
            // 
            // RateTwo
            // 
            this.RateTwo.FlatAppearance.BorderSize = 0;
            this.RateTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RateTwo.Image = global::ResortReview.Properties.Resources.white_star;
            this.RateTwo.Location = new System.Drawing.Point(313, 0);
            this.RateTwo.Name = "RateTwo";
            this.RateTwo.Size = new System.Drawing.Size(44, 50);
            this.RateTwo.TabIndex = 2;
            this.RateTwo.UseVisualStyleBackColor = true;
            this.RateTwo.Click += new System.EventHandler(this.RateTwo_Click);
            // 
            // InsertedCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.RateOne);
            this.Controls.Add(this.RateFive);
            this.Controls.Add(this.RateFour);
            this.Controls.Add(this.RateThree);
            this.Controls.Add(this.RateTwo);
            this.Controls.Add(this.criteriaName);
            this.Name = "InsertedCriteria";
            this.Size = new System.Drawing.Size(511, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label criteriaName;
        private System.Windows.Forms.Button RateTwo;
        private System.Windows.Forms.Button RateThree;
        private System.Windows.Forms.Button RateFour;
        private System.Windows.Forms.Button RateFive;
        private System.Windows.Forms.Button RateOne;
    }
}
