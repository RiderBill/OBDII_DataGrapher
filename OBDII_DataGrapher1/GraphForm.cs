using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBDII_DataGrapher1
{
   internal partial class GraphForm : Form
   {
      public GraphForm()
      {  InitializeComponent();
      }

      public void Graph1Channel(OBD_Channel chan)
      {  double x, y;
         double xMin = 0;

      //int nChans = 1;

         this.Text = AboutBox1.AssemblyTitle + ": ";
         this.Text += chan.LongDescr;
         chart1.ChartAreas["ChartArea1"].Axes[0].Title = "Frame #";
         chart1.ChartAreas["ChartArea1"].Axes[1].Title = chan.ShortDescr + chan.Units;
         chart1.ChartAreas["ChartArea1"].Axes[0].Minimum = xMin;
         chart1.Legends[0].Enabled = true;
//         chart1.Legends[0].Position.Height = (float)(14 * nChans);
         
         chart1.Series[0].Points.Clear();
         chart1.Series[0].Color = Color.Blue;
         chart1.Series[0].BorderWidth = 3;     // Really line thickness
         chart1.Series[0].LegendText = chan.ShortDescr;
         for (int iframe = 0; iframe < chan.Length; iframe++)
         {  try
            {  x = Convert.ToDouble(iframe);
             //y = Convert.ToDouble(chan.Values[iframe]);
               y = chan.ValuesDbl[iframe];
               chart1.Series[0].Points.AddXY(x, y);
            }
            catch (FormatException)
            {
            }
         }
      } // End of Graph1Channel

      internal void GraphChannels(List<OBD_Channel> chans)
      {  double x, y;
         double xMin = 0;

         int nChans = chans.Count;
         if (nChans <= 0) return; // Nothing to do

         this.Text = AboutBox1.AssemblyTitle + ": ";
         for(int ichan=0; ichan<nChans; ichan++)
         {  this.Text += chans[ichan].ShortDescr;
            if (ichan < nChans-1) this.Text += ", ";
         }

         chart1.ChartAreas["ChartArea1"].Axes[0].Title = "Frame #";
         chart1.ChartAreas["ChartArea1"].Axes[1].Title = "Channel Value";
         chart1.ChartAreas["ChartArea1"].Axes[0].Minimum = xMin;
         chart1.Legends[0].Enabled = true;
//         chart1.Legends[0].Position.Height =(float)(14*nChans);

         //chart1.Series[0].Legend.
         chart1.Series.RemoveAt(0);
         System.Windows.Forms.DataVisualization.Charting.Series seriesN;

         for (int ichan = 0; ichan < nChans; ichan++)
         {  OBD_Channel chan = chans[ichan];
            seriesN = new System.Windows.Forms.DataVisualization.Charting.Series();
            seriesN.ChartArea = "ChartArea1";
            seriesN.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
         // seriesN.Color = System.Drawing.Color.Blue;
            seriesN.Legend = "Legend1";
            seriesN.Name = chan.ShortDescr;
            chart1.Series.Add(seriesN);

          //chart1.ChartAreas["ChartArea1"].Axes[1].Title = chan.ShortDescr + chan.Units;
          //chart1.Legends.Add(chan.ShortDescr);
            chart1.Series[ichan].LegendText = chan.ShortDescr;
            chart1.Series[ichan].Points.Clear();
          //chart1.Series[ichan].Color = Color.Blue;
            chart1.Series[ichan].BorderWidth = 2;     // Really line thickness
            for (int iframe = 0; iframe < chan.Length; iframe++)
            {  try
               {  x = Convert.ToDouble(iframe);
                //y = Convert.ToDouble(chan.Values[iframe]);
                  y = chan.ValuesDbl[iframe];
                  chart1.Series[ichan].Points.AddXY(x, y);
               }
               catch (FormatException)
               {
               }
            }
         }
      } // End of GraphChannels()

      internal void GraphChannels2(List<OBD_Channel> chans)
      {
         double x, y;
         double xMin = 0;

         int nChans = chans.Count;
         if (nChans <= 0) return; // Nothing to do

         this.Text = AboutBox1.AssemblyTitle + ": ";
         for (int ichan = 0; ichan < nChans; ichan++)
         {
            this.Text += chans[ichan].ShortDescr;
            if (ichan < nChans - 1) this.Text += ", ";
         }

         chart1.ChartAreas["ChartArea1"].Axes[0].Title = "Frame #";
         chart1.ChartAreas["ChartArea1"].Axes[1].Title = "Channel Value";
         chart1.ChartAreas["ChartArea1"].Axes[0].Minimum = xMin;
         chart1.Legends[0].Enabled = true;
         //         chart1.Legends[0].Position.Height =(float)(14*nChans);

         //chart1.Series[0].Legend.
         chart1.Series.RemoveAt(0);
         System.Windows.Forms.DataVisualization.Charting.Series seriesN;

         for (int ichan = 0; ichan < nChans; ichan++)
         {
            OBD_Channel chan = chans[ichan];
            seriesN = new System.Windows.Forms.DataVisualization.Charting.Series();
            seriesN.ChartArea = "ChartArea1";
            seriesN.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            // seriesN.Color = System.Drawing.Color.Blue;
            seriesN.Legend = "Legend1";
            seriesN.Name = chan.ShortDescr;
            chart1.Series.Add(seriesN);

            //chart1.ChartAreas["ChartArea1"].Axes[1].Title = chan.ShortDescr + chan.Units;
            //chart1.Legends.Add(chan.ShortDescr);
            chart1.Series[ichan].LegendText = chan.ShortDescr;
            chart1.Series[ichan].Points.Clear();
            //chart1.Series[ichan].Color = Color.Blue;
            chart1.Series[ichan].BorderWidth = 2;     // Really line thickness
            for (int iframe = 0; iframe < chan.Length; iframe++)
            {
               try
               {
                //y = Convert.ToDouble(chan.Values[iframe]);
                  y = chan.ValuesDbl[iframe];
                  x = Convert.ToDouble(iframe);
                  chart1.Series[ichan].Points.AddXY(x, y);
               }
               catch (FormatException)
               {
               }
            }
         }
      } // End of GraphChannels2()

   } // End of partial class GraphForm

} // End of namespace OBDII_DataGrapher1
