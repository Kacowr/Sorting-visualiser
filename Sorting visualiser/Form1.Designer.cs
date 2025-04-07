namespace Sorting_visualiser
{
    partial class mainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sortSelector = new System.Windows.Forms.ComboBox();
            this.generateTabButton = new System.Windows.Forms.Button();
            this.VisualisingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.runVisualisation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VisualisingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // sortSelector
            // 
            this.sortSelector.FormattingEnabled = true;
            this.sortSelector.Items.AddRange(new object[] {
            "Bubble sort",
            "Selection sort",
            "Insertion sort",
            "Quick sort",
            "Merge sort"});
            this.sortSelector.Location = new System.Drawing.Point(988, 80);
            this.sortSelector.Name = "sortSelector";
            this.sortSelector.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sortSelector.Size = new System.Drawing.Size(159, 21);
            this.sortSelector.TabIndex = 0;
            // 
            // generateTabButton
            // 
            this.generateTabButton.Location = new System.Drawing.Point(988, 135);
            this.generateTabButton.Name = "generateTabButton";
            this.generateTabButton.Size = new System.Drawing.Size(159, 40);
            this.generateTabButton.TabIndex = 1;
            this.generateTabButton.Text = "Generate values";
            this.generateTabButton.UseVisualStyleBackColor = true;
            this.generateTabButton.Click += new System.EventHandler(this.generateTabButton_Click);
            // 
            // VisualisingChart
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.VisualisingChart.ChartAreas.Add(chartArea1);
            this.VisualisingChart.Location = new System.Drawing.Point(-2, -2);
            this.VisualisingChart.Name = "VisualisingChart";
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.EmptyPointStyle.LabelBorderWidth = 0;
            series1.EmptyPointStyle.MarkerBorderWidth = 0;
            series1.IsVisibleInLegend = false;
            series1.LabelBorderWidth = 0;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.MarkerBorderWidth = 0;
            series1.MarkerSize = 0;
            series1.Name = "Series1";
            this.VisualisingChart.Series.Add(series1);
            this.VisualisingChart.Size = new System.Drawing.Size(965, 430);
            this.VisualisingChart.TabIndex = 2;
            this.VisualisingChart.Text = "chart1";
            // 
            // runVisualisation
            // 
            this.runVisualisation.Location = new System.Drawing.Point(988, 213);
            this.runVisualisation.Name = "runVisualisation";
            this.runVisualisation.Size = new System.Drawing.Size(159, 40);
            this.runVisualisation.TabIndex = 3;
            this.runVisualisation.Text = "Run program";
            this.runVisualisation.UseVisualStyleBackColor = true;
            this.runVisualisation.Click += new System.EventHandler(this.runVisualisation_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1164, 429);
            this.Controls.Add(this.runVisualisation);
            this.Controls.Add(this.VisualisingChart);
            this.Controls.Add(this.generateTabButton);
            this.Controls.Add(this.sortSelector);
            this.Name = "mainWindow";
            this.Text = "Sorting Visualiser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisualisingChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox sortSelector;
        private System.Windows.Forms.Button generateTabButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart VisualisingChart;
        private System.Windows.Forms.Button runVisualisation;
    }
}

