using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace OBDII_DataGrapher1
{
   public partial class Form1 : Form
   {  private string       _inFileName = null;
      private string[]     _inFileContents;
      private OBD_Channels _obdChannels;
      private string       _browseForFileString = "<Browse for input file>";

      public Form1()
      {  InitializeComponent();
      this.Text = String.Format(AboutBox1.AssemblyTitle);
      }


      private void Form1_Load(object sender, EventArgs e)
      {  // Set last item in list box;
         int index = listBoxInputFiles.Items.Count;
         listBoxInputFiles.Items.Insert(index, _browseForFileString);
         hideLowerStuff();
      } // End of Form1_Load()


      private void hideLowerStuff()
      {  // Buttons
         showFileBtn.Hide();
         chanListBtn.Hide();
         graphBtn   .Hide();
         tableBtn   .Hide();

         // Labels
         labelFrameData   .Hide();
         fileContentsLabel.Hide();

         // Boxes and charts
         inFileContentsRichTextBox.Hide();
         listBoxChannels          .Hide();
         TabularDataRichTextBox   .Hide();       
         chart1                   .Hide();
      }

      private void showLowerStuff()
      {  // Buttons
         showFileBtn.Show();
         chanListBtn.Show();
         graphBtn   .Show();
         tableBtn   .Show();

         // Labels
         labelFrameData   .Show();
         fileContentsLabel.Show();

         // Boxes and charts
         inFileContentsRichTextBox.Show();
         TabularDataRichTextBox   .Show();
         chart1                   .Show();
      }

      private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
      {  AboutBox1 aBox = new AboutBox1();
         aBox.ShowDialog();
         aBox.Dispose();
      } // End of aboutToolStripMenuItem_Click()

      private void openToolStripMenuItem_Click(object sender, EventArgs e)
      {  openFileStuff(sender, e);
      } // End of openToolStripMenuItem_Click()

      private void browsBtn1_Click(object sender, EventArgs e)
      {  openFileStuff(sender, e);
      } // End of browsBtn1_Click()

      private void listBoxInputFiles_SelectedIndexChanged(object sender, EventArgs e)
      {  string selectedText = listBoxInputFiles.Text;
         if (selectedText == _browseForFileString)
         {  openFileStuff(sender, e);
         }
         else
         {  _inFileName = listBoxInputFiles.Text;
            // Open the file and work with the data
            workWithInputFileData(_inFileName);
         }
      }  // End of listBoxInputFiles_SelectedIndexChanged()

      private void openFileStuff(object sender, EventArgs e)
      {  // run the openfile dialog.
         if( this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
         {  _inFileName = this.openFileDialog1.FileName;

            // If file name is not already in the listbox, insert it at the top.
            int index = listBoxInputFiles.FindStringExact(_inFileName);

            // Determine if a valid index is returned. Select the item if it is valid.
            if (index == ListBox.NoMatches)
            {  index = 0;
               listBoxInputFiles.Items.Insert(index, _inFileName);
            }

            // Show the file name as selected
            listBoxInputFiles.SetSelected(index, true);
 
            // Open the file and work with the data
            workWithInputFileData(_inFileName);

         } // End of if(openFileDialog1 == OK)
      } // End of openFileStuff()


      private void workWithInputFileData(string inFileName)
      {  // Get contents of the input file and put them in the fileTextBox.
         _inFileContents   = System.IO.File.ReadAllLines(inFileName);
         updateInFileTextBox(_inFileContents);
         getFrameData(_inFileContents);
         
         showLowerStuff();
      }

      private void updateInFileTextBox(string[] inFileContents)
      {  if (_inFileContents.Length > 0)
         {  graphBtn.Enabled = false;
            inFileContentsRichTextBox.Show();
            listBoxChannels.Hide();
            this.inFileContentsRichTextBox.Lines = inFileContents;
         }
      }

      private void getFrameData(string[] inFileContents)
      {  _obdChannels = new OBD_Channels();
         foreach (OBD_Channel chan1 in _obdChannels)
         {  chan1.ReadChannelData(inFileContents);
         }
      } // End of getFrameData()


      private void graphBtn_Click(object sender, EventArgs e)
      {  List<OBD_Channel> chans = SelectedChannels;
         GraphForm graphForm = new GraphForm();
         if (chans.Count == 1) graphForm.Graph1Channel(chans[0]);
         if (chans.Count  > 1) graphForm.GraphChannels(chans);
         graphForm.Show();
      }


      private void tableBtn_Click(object sender, EventArgs e)
      {  if (_inFileContents.Length > 0)
         {  chart1.Hide();
            TabularDataRichTextBox.Show();
            string[] csvTable = _obdChannels.getCsvTable2(_inFileContents);
            TabularDataRichTextBox.Lines = csvTable;
         }
      }

      private void showFileBtn_Click(object sender, EventArgs e)
      {  if (_inFileContents.Length > 0) updateInFileTextBox(_inFileContents);
      }

      private void chanListBtn_Click(object sender, EventArgs e)
      {  if (_inFileContents.Length > 0)
         {  inFileContentsRichTextBox.Hide();
            listBoxChannels.Show();
            graphBtn.Enabled = true;
            List<string> longDescrs = _obdChannels.getLongDescriptionList(_inFileContents);
            this.listBoxChannels.DataSource = longDescrs;
         }
      }

      internal OBD_Channel SelectedChannel
      { get { return _obdChannels.findChannelByLongDescr(listBoxChannels.SelectedItem.ToString()); } }

      internal List<OBD_Channel> SelectedChannels
      {  get
         {  List<OBD_Channel> selChans = new List<OBD_Channel>();
            foreach (string lDescr in listBoxChannels.SelectedItems)
            {  selChans.Add(_obdChannels.findChannelByLongDescr(lDescr) );
            }
            return selChans; //_obdChannels.findChannelByLongDescr(listBoxChannels.SelectedItem.ToString()); } }
         }
      }

   } // End of partial class Form1

} // End of namespace OBDII_DataGrapher1
       // UInt32 i1 = '¡'; // = 0xA1
       // UInt32 i2 = '£'; // = 0xA3
       // inFileContents[0] = "Degree: \\u00B0 = " + '\u00B0'.ToString();
       // inFileContents[1] = "¡ = 0x" + i1.ToString("x");
       // inFileContents[2] = "£ = 0x" + i2.ToString("x");