namespace ResortReview
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.RatingGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.customerReviewData = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RatingGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReviewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RatingGraph
            // 
            this.RatingGraph.BackColor = System.Drawing.Color.SandyBrown;
            chartArea6.Name = "ChartArea1";
            this.RatingGraph.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.RatingGraph.Legends.Add(legend6);
            this.RatingGraph.Location = new System.Drawing.Point(3, 3);
            this.RatingGraph.Name = "RatingGraph";
            this.RatingGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Customers Rating";
            this.RatingGraph.Series.Add(series6);
            this.RatingGraph.Size = new System.Drawing.Size(659, 270);
            this.RatingGraph.TabIndex = 2;
            this.RatingGraph.Text = "RatingChart";
            // 
            // customerReviewData
            // 
            this.customerReviewData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerReviewData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerReviewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerReviewData.Location = new System.Drawing.Point(3, 279);
            this.customerReviewData.Name = "customerReviewData";
            this.customerReviewData.RowHeadersWidth = 51;
            this.customerReviewData.RowTemplate.Height = 24;
            this.customerReviewData.Size = new System.Drawing.Size(1112, 219);
            this.customerReviewData.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ResortReview.Properties.Resources.dash;
            this.pictureBox1.Location = new System.Drawing.Point(668, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customerReviewData);
            this.Controls.Add(this.RatingGraph);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1020, 568);
            ((System.ComponentModel.ISupportInitialize)(this.RatingGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReviewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart RatingGraph;
        private System.Windows.Forms.DataGridView customerReviewData;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
