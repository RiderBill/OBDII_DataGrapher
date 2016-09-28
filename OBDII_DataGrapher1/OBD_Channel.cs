using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OBDII_DataGrapher1
{
   internal class OBD_Channel
   {  private string       _LongDescr;
      private string       _ShortDescr;
      private string       _units;
      private List<string> _valuesStr  = new List<string>();
      private List<double> _valuesDbl  = new List<double>();
      private double       _valueMax   = Double.NaN;
      private double       _valueMin   = Double.NaN;
      private double       _valueRange = Double.NaN;
   

      // Constructor(s)
      public OBD_Channel(string longStr, string shortStr, string unitsStr)
      {  this._LongDescr  = longStr;
         this._ShortDescr = shortStr;
         this._units      = unitsStr;
      }
      public OBD_Channel(string[] descrs)  : this(descrs[0], descrs[1], descrs[2]) {}

      // Properties to reserve the ability to improve the getters and setters later if necessary.
      public string   LongDescr  { get { return _LongDescr   ; } set { _LongDescr  = value; } }
      public string   ShortDescr { get { return _ShortDescr  ; } set { _ShortDescr = value; } }
      public string   Units      { get { return _units       ; } set { _units      = value; } }
      public bool     HasData    { get { return (_valuesStr.Count > 0); } }
      public int      Length     { get { return _valuesStr.Count; } }
      public List<string> Values { get { return _valuesStr; } }
      public List<double> ValuesDbl { get { return _valuesDbl; } }

      // Methods to get the data from the input file:
      public int ReadChannelData(string inFileName)
      {  string[] inFileContents   = System.IO.File.ReadAllLines(inFileName);
         return ReadChannelData(inFileContents);
      } // End of ReadChannelData(string inFileName)

      public int ReadChannelData(string[] inFileContents)
      {  _valuesStr.Clear();
         bool iChanFound = false;
         foreach (string line in inFileContents)
         {  if (line.StartsWith(_LongDescr) )
            {  // Note that channel was found in the curren frame and
               // add the channel date to _valuesStr.
               iChanFound = true;
               _valuesStr.Add( line.Substring(_LongDescr.Length) );
            }
            if(line.StartsWith("----------------------") )
            {  // End of Frame.  If the channel was not found in this frame,
               // set the value to
               if (! iChanFound)
               {  // Channel not found in current frame.  Add null string
                  // as placeholder to keep all channels in sync.
                  _valuesStr.Add("No Data");
               }
               // Reset iChanFound for the next frame.
               iChanFound = false;
            }
         } // End of foreach(line)
         gleenNumericChannelData();
         return _valuesStr.Count;
      } // End of ReadChannelData(string[] inFileContents)

      void gleenNumericChannelData()
      {  // This function converts channel data from string format to double.
         // Some data may be numeric and some string.  First find the range the numeric data
         // and how many unique non-numeric strings there are.
         bool iNumberFound = false;
         bool isNum;
         int nNonNumericStrings = 0;
         double y;
         List <string> prevStrs = new List<string>();

         for(int ival=0; ival<_valuesStr.Count; ival++)
         {  _valuesDbl.Add(Double.NaN);  // Assume string cannot be converted to a number, then try to convert
          //try // Some strings may not be convertible to double.
            isNum = double.TryParse(_valuesStr[ival], out y);
            if(isNum)
            {
             //y = Convert.ToDouble(_valuesStr[ival]);
               // Didn't throw exception, so conversion to double was successful.
               
               _valuesDbl[ival] = y;
               if (!iNumberFound)
               {  _valueMax = _valueMin = y;
                  iNumberFound = true;
               }
               else
               {  if (y < _valueMin) _valueMin = y;
                  if (y > _valueMax) _valueMax = y;
               }
            }
          //catch (FormatException)
            else
            {  // chanString conversion to double failed.
               //  See if chanStr matches any of
               // the previous found non-convertible strings.
               bool istringFound = false;
             //string  prevStr;
             //foreach(prevStr in prevStrs)
               int iprevStr;
               for(iprevStr=0; iprevStr<prevStrs.Count; iprevStr++)
               {  if(_valuesStr[ival] == prevStrs[iprevStr])
                  {  istringFound = true;
                     break;
                  }
               }
               if (!istringFound)
               {  prevStrs.Add(_valuesStr[ival]);
                  nNonNumericStrings ++;
               }
            } // End of catch(FormatException
         } // End of for(ival) loop

         // There should be 2 possiblilities:
         // 1) No numeric data and 1 or more distinct strings
         // 2) Some numeric data and at most 1 distinct string ("No Data")
         if (iNumberFound)
         {  _valueRange = _valueMax - _valueMin;

            if (nNonNumericStrings  > 1)
            {  System.Windows.Forms.MessageBox.Show("Something wrong in gleenNumericChannelData()");
            }
            if (nNonNumericStrings == 1)
            {  for(int ival = 0; ival<_valuesDbl.Count; ival++)
               {  if (Double.IsNaN(_valuesDbl[ival]) )
                  {  _valuesDbl[ival] = _valueMin - 5.0*(_valueRange + 1);
                  }
               }
            }
         }
         else
         {  // No numeric values -- all strings.
            _valueRange = nNonNumericStrings;
            for (int ival=0; ival<_valuesStr.Count; ival++)
            {  switch (_valuesStr[ival])
               {  case "No Data":
                     _valuesDbl[ival] = -2.0;
                     break;
                  case "--":
                     _valuesDbl[ival] = -1.0;
                     break;
                  case "OL":
                     _valuesDbl[ival] =  0.0;
                     break;
                  case "CL":
                     _valuesDbl[ival] =  1.0;
                     break;
                  case "OBD":
                     _valuesDbl[ival] =  1.0;
                     break;
                  case "B1S12--B2S12--":
                     _valuesDbl[ival] =  1.0;
                     break;

                  default :            
                     for (int istr=0; istr<prevStrs.Count; istr++)
                     {  if (_valuesStr[ival] == prevStrs[istr])
                        _valuesDbl[ival] = istr;
                     }
                     break;
               } // End of switch

               if (!iNumberFound)
               {  _valueMax = _valueMin = _valuesDbl[ival];
                  iNumberFound = true;
               }
               else
               {  if (_valuesDbl[ival] < _valueMin) _valueMin = _valuesDbl[ival];
                  if (_valuesDbl[ival] > _valueMax) _valueMax = _valuesDbl[ival];
               }
            } // End of for(ival) loop
            _valueRange = _valueMax - _valueMin;
            
         } // End of noNumericValues block

      } // End of gleenNumericChannelData()

   } // End of class OBD_Channel definition

//��
   internal class OBD_Channels : IEnumerable
   {  // I don't seem to need this class that much -- I just need the List<OBD_Channel> statement.
      // On the otherhand, it makes it easier to add capability later.
      private List<OBD_Channel> _obd_channels = new List<OBD_Channel>
      { new OBD_Channel("Number of DTCs stored in this ECU"               , "  DTC_CNT ", "( # )" ),  //int
        new OBD_Channel("Fuel system 1 status"                            , "  FuelSys1", "(---)" ),  //string (--, OL, or CL)
        new OBD_Channel("Fuel System 2 status"                            , "  FuelSys2", "(---)" ),  //string (--, OL, or CL)
        new OBD_Channel("Calculated LOAD Value(%)"                        , "  Load_Pct", "( % )" ),  //double
//      new OBD_Channel("Engine Coolant Temperature(¡£C)"                 , "       ECT", "( °C)" ),  //double
        new OBD_Channel("Engine Coolant Temperature(��C)"                 , "       ECT", "( °C)" ),  //double
        new OBD_Channel("Short Term Fuel Trim -Bank 1(%)"                 , "   ShrtFT1", "( % )" ),  //double
        new OBD_Channel("Long Term Fuel Trim - Bank 1(%)"                 , "   LongFT1", "( % )" ),  //double
        new OBD_Channel("Short Term Fuel Trim -Bank 2(%)"                 , "   ShrtFT2", "( % )" ),  //double
        new OBD_Channel("Long Term Fuel Trim - Bank 2(%)"                 , "   LongFT2", "( % )" ),  //double
        new OBD_Channel("Fuel Rail Pressure(gauge)(kPa)"                  , "       FRP", "(KPa)" ),  //double
        new OBD_Channel("Engine RPM(rpm)"                                 , "       RPM", "(rpm)" ),  //double or int
        new OBD_Channel("Vehicle Speed Sensor(km/h)"                      , "       VSS", "(Kmh)" ),  //double or int
//      new OBD_Channel("Ignition Timing Advanece for #1 Cylinder(¡£)"    , "  SparkAdv", "( ° )" ),  //double
        new OBD_Channel("Ignition Timing Advanece for #1 Cylinder(��)"    , "  SparkAdv", "( ° )" ),  //double
//      new OBD_Channel("Intake Air Temperature(¡£C)"                     , "       IAT", "( °C)" ),  //double
        new OBD_Channel("Intake Air Temperature(��C)"                     , "       IAT", "( °C)" ),  //double
        new OBD_Channel("Air Flow Rate from Mass Air Flow(g/s)"           , "       MAF", "(g/s)" ),  //double
        new OBD_Channel("Absolute Throttle Position(%)"                   , "        TP", "( % )" ),  //double
        new OBD_Channel("Location of Oxygen Sensors"                      , "    O2SLoc", "(---)" ),  //string, maybe string[] "B1S12--B2S12--"
        new OBD_Channel("Oxygen Sensor Output Voltage Bank 1-Sensor 1(V)" , "    O2B1S1", "( V )" ),  //double
        new OBD_Channel("Oxygen Sensor Voltage (Bank 1-Sensor 1)(V)"      , "    O2B1S1", "( V )" ),  //double //Same as prev.
        new OBD_Channel("Oxygen Sensor Output Voltage Bank 1-Sensor 2(V)" , "    O2B1S2", "( V )" ),  //double
        new OBD_Channel("Oxygen Sensor Output Voltage Bank 2-Sensor 1(V)" , "    O2B2S1", "( V )" ),  //double
        new OBD_Channel("Oxygen Sensor Output Voltage Bank 2-Sensor 2(V)" , "    O2B2S2", "( V )" ),  //double
        new OBD_Channel("Short Term Fuel Trim Bank 1-Sensor 1(%)"         , "ShrtFTB1S1", "( % )" ),  //double
        new OBD_Channel("Short Term Fuel Trim Bank 1-Sensor 2(%)"         , "ShrtFTB1S2", "( % )" ),  //double
        new OBD_Channel("Short Term Fuel Trim Bank 2-Sensor 1(%)"         , "ShrtFTB2S1", "( % )" ),  //double
        new OBD_Channel("Short Term Fuel Trim Bank 2-Sensor 2(%)"         , "ShrtFTB2S2", "( % )" ),  //double
        new OBD_Channel("OBD requirements to which vehicle is designed"   , "    OBDSup", "(---)" ),   //string "OBD"
        new OBD_Channel("Equivalence Ration (lambda)(Bank 1-Sensor 1)"    , "LambdRatio", "(---)" )  //double
      };

      // Constructor(s)
      public OBD_Channels() {}
      public OBD_Channels(OBD_Channel chan)
      {  AddChannel(chan);
      }
      public OBD_Channels(string[,] descrs)
      {  AddChannels(descrs);
      } // End of OBD_Channels(string[,]) constructor
   
      public OBD_Channels(string[][] descrs)
      {  AddChannels(descrs);
      } // End of OBD_Channels(string[][]) constructor
   
      public int AddChannel(OBD_Channel chan)
      {  _obd_channels.Add(chan);
         return Length;
      }

      public int AddChannel(string [] descrs)
      {  _obd_channels.Add(new OBD_Channel(descrs) );
         return Length;
      } // End of AddChannel()

         public int AddChannel(string descr0, string descr1, string units)
      {  _obd_channels.Add(new OBD_Channel(descr0, descr1, units));
         return Length;
      } // End of AddChannel()
   
      public int AddChannels(string [,] descrs)
      {  int nChannels = descrs.GetLength(0); // number of rows, i.e. first dimension of descr
         
         for(int ichan=0; ichan<nChannels; ichan++)
         {  _obd_channels.Add(new OBD_Channel(descrs[ichan,0], descrs[ichan,1], descrs[ichan,2]) );
         }
         return Length;
      }
   
      public int AddChannels(string [][] descrs)
      {  int nChannels = descrs.GetLength(0); // number of rows, i.e. first dimension of descrs
         
         for(int ichan=0; ichan<nChannels; ichan++)
         {  _obd_channels.Add(new OBD_Channel(descrs[ichan]) );
         }
         return Length;
      } // End of AddChannel()
   
      // Properties
      public int Length { get{return _obd_channels.Count;} }

      // Indexers
      public OBD_Channel this[int iChan] { get{return _obd_channels[iChan]; } }
      public string      this[int iChan, int istr]
      { get{ if (istr == 0) return _obd_channels[iChan].LongDescr ;
             if (istr == 1) return _obd_channels[iChan].ShortDescr;
             if (istr == 2) return _obd_channels[iChan].Units     ;
             return      _obd_channels[iChan].LongDescr
                   +"(" +_obd_channels[iChan].LongDescr
                   +")("+_obd_channels[iChan].Units               ;
           }
      }

      public OBD_Channel findChannelByLongDescr(string longDescr)
      {  foreach (OBD_Channel chan in _obd_channels)
         {  if (chan.LongDescr == longDescr) return chan;
         }
         return null;
      }

      public OBD_Channel findChannelByShortDescr(string shortDescr)
      {  foreach (OBD_Channel chan in _obd_channels)
         {  if (chan.LongDescr == shortDescr) return chan;
         }
         return null;
      }

      public List<string> getLongDescriptionList(string[] inFileContents)
      {  // This function returns an array consisting of the long descriptions
         // (LongDescr property) of the channels that have frame data.

         List<string> longDescriptionsList = new List<string>();
         foreach (OBD_Channel chan1 in _obd_channels)
         {  if (chan1.HasData)
            {  longDescriptionsList.Add(chan1.LongDescr);
            }
         }
         return longDescriptionsList;
      } // End of getLongDescriptionList()


      public string[] getLongDescriptions(string[] inFileContents)
      {  // This function returns an array consisting of the long descriptions
         // (LongDescr property) of the channels that have frame data.
         List<string> longDescriptionsList = getLongDescriptionList(inFileContents);

         // But I need an array of strings, not a List, so ...
         string[] longDescriptions = new string[longDescriptionsList.Count];
         for(int iChan=0; iChan<longDescriptionsList.Count; iChan++)
         {  longDescriptions[iChan] = longDescriptionsList[iChan];
         }
         return longDescriptions;
      } // End of getLongDescription()


      public string[,] getTabularData(string[] inFileContents)
      {  // This function builds and returns a table (2D array of strings)
         // representing the OBD channels that have data.
         // The first two rows are headers.  The first column contains
         // the frame numbers, i.e. sequence numbers for the data.
         // Think of the frame number as time, where 1 frame may or may
         // be about 1 second long (not clear from the scantool documentation).
         int nChannelsWithData = 0;
         int nFrames = 0;
         int icol;
         foreach (OBD_Channel chan1 in _obd_channels)
         {  chan1.ReadChannelData(inFileContents);
            if(chan1.HasData)
            {  nChannelsWithData++;
            // All channels with data should have the same number of frames,
            // but I'm not trusting that yet.
               if (chan1.Length > nFrames) nFrames = chan1.Length; 
            }            
         }
         if (nChannelsWithData == 0) return null;
         string[,] table = new string[nFrames+2, nChannelsWithData+1];
         table[0,0] = "Frame";
         table[1,0] = "  #  ";
         for(int iframe=0; iframe<nFrames; iframe++)
         {  table[iframe+2, 0] = iframe.ToString();
         }
         icol = 1;
         foreach (OBD_Channel chan1 in _obd_channels)
         {  if(chan1.HasData)
            {  table[0,icol] = chan1.ShortDescr;
               table[1,icol] = chan1.Units;
               for(int iframe=0; iframe<chan1.Length; iframe++)
               {  table[iframe+2, icol] = chan1.Values[iframe];
               }
               icol++;
            }
         }               
         return table;
      } // End of getTabularData()

      public string[] getCsvTable(string[] inFileContents)
      {  // This function returns a string[] version of the channel data
         // suitable for printing to a .csv file.
         string [,] table   = getTabularData(inFileContents);
         int nrows          = table.GetLength(0);
         int ncols          = table.GetLength(1);
         string [] csvLines = new string[nrows];

         for(int irow=0; irow<nrows; irow++)
         {  for(int icol=0; icol<ncols; icol++)
            {  csvLines[irow] += table[irow, icol];
               if (icol < (ncols-1)) csvLines[irow] += ", ";
            }
         }
         return csvLines;
      } // End of getCsvTable()

      public string[] getCsvTable2(string[] inFileContents)
      {  // This function returns a string[] version of the channel data
         // suitable for printing to a .csv file.
         string[,] table = getTabularData(inFileContents);
         int nrows = table.GetLength(0);
         int ncols = table.GetLength(1);
         string[] csvLines = new string[nrows];

         for (int icol = 0; icol < ncols; icol++)
         {  // Find max width for current column.
            int iWidth, maxWidth = 0;
            for (int irow = 0; irow < nrows; irow++)
            {  if ( (iWidth = table[irow, icol].Length) > maxWidth) maxWidth = iWidth;
            }
            for (int irow = 0; irow < nrows; irow++)
            {  // Pad on left of each column (right justify).
               for(int ispc=table[irow, icol].Length; ispc<maxWidth; ispc++)
               {  csvLines[irow] += " ";
               }
               csvLines[irow] += table[irow, icol];
               if (icol < (ncols - 1)) csvLines[irow] += ", ";
            }
         }
         return csvLines;
      } // End of getCsvTable2()

      IEnumerator IEnumerable.GetEnumerator()
      {  return (IEnumerator) GetEnumerator();
      }
      
      public OBDChanEnum GetEnumerator()
      {  return new OBDChanEnum(_obd_channels);
      }
   } // End of OBD_Channels class definition


   internal class OBDChanEnum : IEnumerator
   {  private List<OBD_Channel> _obdChannels;
      int index = -1; // Initialized to point to location before first List element
      
      public OBDChanEnum(List<OBD_Channel> obdChannels)
      {  _obdChannels = obdChannels;
      }
      public bool MoveNext()
      {  index++;
         return (index < _obdChannels.Count);
      }
      public void Reset()
      {  index = -1; // Point to location before first List element
      }
      object IEnumerator.Current { get{ return Current; } }
      
      public OBD_Channel Current { get{ try { return _obdChannels[index]; }
                                        catch (IndexOutOfRangeException)
                                        {  throw new InvalidOperationException();
                                        }
                                      }
                                 } // End of Current()
   } // End of class OBDChanEnum definition

} // End of namespace OBDII_DataGrapher1

 //  UInt32 i1 = '¡'; // = 0xA1
 //  UInt32 i2 = '£'; // = 0xA3
 //  UInt32 i3 = '°'; // = 0xB0; 
 //  inFileContents[0] = "° = 0x" + i1.ToString("x") + " = " + '\u00B0'.ToString();
 //  inFileContents[1] = "¡ = 0x" + i1.ToString("x") + " = " + '\u00A1'.ToString();
 //  inFileContents[2] = "£ = 0x" + i2.ToString("x") + " = " + '\u00A3'.ToString();
