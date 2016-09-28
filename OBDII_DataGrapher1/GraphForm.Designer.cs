namespace OBDII_DataGrapher1
{
   partial class GraphForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphForm));
         this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
         ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
         this.SuspendLayout();
         // 
         // chart1
         // 
         this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
         chartArea1.AlignWithChartArea = "ChartArea1";
         chartArea1.AxisX.Crossing = -1.7976931348623157E+308D;
         chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
         chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
         chartArea1.AxisX.Title = "Frame Number";
         chartArea1.AxisX2.Crossing = -1.7976931348623157E+308D;
         chartArea1.AxisY.Crossing = -1.7976931348623157E+308D;
         chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
         chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
         chartArea1.AxisY.Title = "y axis";
         chartArea1.AxisY2.Crossing = -1.7976931348623157E+308D;
         chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         chartArea1.InnerPlotPosition.Auto = false;
         chartArea1.InnerPlotPosition.Height = 67.1358F;
         chartArea1.InnerPlotPosition.Width = 88.58145F;
         chartArea1.InnerPlotPosition.X = 9.98698F;
         chartArea1.InnerPlotPosition.Y = 8.43424F;
         chartArea1.Name = "ChartArea1";
         this.chart1.ChartAreas.Add(chartArea1);
         this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
         legend1.BackColor = System.Drawing.Color.Transparent;
         legend1.DockedToChartArea = "ChartArea1";
         legend1.IsDockedInsideChartArea = false;
         legend1.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.ReversedSeriesOrder;
         legend1.Name = "Legend1";
         this.chart1.Legends.Add(legend1);
         this.chart1.Location = new System.Drawing.Point(0, 0);
         this.chart1.Name = "chart1";
         this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
         series1.ChartArea = "ChartArea1";
         series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
         series1.Color = System.Drawing.Color.Blue;
         series1.Legend = "Legend1";
         series1.Name = "Series1";
         series1.XValueMember = "Form1.x";
         series1.YValueMembers = "Form1.y";
         this.chart1.Series.Add(series1);
         this.chart1.Size = new System.Drawing.Size(664, 145);
         this.chart1.TabIndex = 9;
         this.chart1.Text = "OBD Frame Data";
         // 
         // GraphForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(664, 145);
         this.Controls.Add(this.chart1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Location = new System.Drawing.Point(680, 0);
         this.Name = "GraphForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
         this.Text = "OBD-II Graph";
         ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
   }
}