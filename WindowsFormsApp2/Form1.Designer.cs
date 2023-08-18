namespace WindowsFormsApp2
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Threads = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Threads)).BeginInit();
            this.SuspendLayout();
            // 
            // Threads
            // 
            this.Threads.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Threads.BorderlineColor = System.Drawing.Color.YellowGreen;
            this.Threads.BorderSkin.PageColor = System.Drawing.Color.IndianRed;
            chartArea1.Name = "ChartArea1";
            this.Threads.ChartAreas.Add(chartArea1);
            this.Threads.Cursor = System.Windows.Forms.Cursors.Default;
            this.Threads.DataSource = this.Threads.Series;
            legend1.Name = "Legend1";
            this.Threads.Legends.Add(legend1);
            this.Threads.Location = new System.Drawing.Point(0, -1);
            this.Threads.Margin = new System.Windows.Forms.Padding(1);
            this.Threads.Name = "Threads";
            this.Threads.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Milliseconds";
            this.Threads.Series.Add(series1);
            this.Threads.Size = new System.Drawing.Size(788, 372);
            this.Threads.TabIndex = 0;
            this.Threads.Text = "Threads";
            this.Threads.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::WindowsFormsApp2.Properties.Resources.images;
            this.button1.Location = new System.Drawing.Point(325, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Threads);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Threads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Threads;
        private System.Windows.Forms.Button button1;
    }
}

