using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author: Shawn M. Crawford
namespace TheLegendOfZeldaTextEditor {
    class Backend {

        int textFlag = 0;

        public void getText(string path, TextBox texboxname, int length, int offset, int tableToUse) {

            string romCodeString = "";
            string lozAsciiOut = "";
            string tempHexString = "";
            int x = 0;
            using (FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read)) { 
                fileStream.Seek(offset, SeekOrigin.Begin);

                while (x < length) {
                    romCodeString = fileStream.ReadByte().ToString("X");
                    //if length is single digit add a 0 ( 1 now is 01)
                    if (romCodeString.Length == 1) {
                        romCodeString = "0" + romCodeString;
                    }
                    tempHexString = romCodeString;

                    if (tableToUse == 1) {
                        decodeRomText1(tempHexString);
                    } else if (tableToUse == 2) {
                        decodeRomText2(tempHexString);
                    } else if (tableToUse == 3) {
                        decodeRomText3(tempHexString);
                    } else if (tableToUse == 4) {
                        decodeRomText4(tempHexString);
                    }
                    //else if (tableToUse == 5) {
                    //    // Story text, table 5
                    //    decodeRomTextTable5(tempHexString);
                    //}
                    
                    if (textFlag == 0) {
                        if (tableToUse == 1) {
                            // No encoding.
                            lozAsciiOut += decodeRomText1(tempHexString);
                        } else if (tableToUse == 2) {
                            // 0x80 is added to each value if it is the last character on the first line.
                            lozAsciiOut += decodeRomText2(tempHexString);
                        } else if (tableToUse == 3) {
                            // 0x40 is added to each value if it is the last character on the second line.
                            lozAsciiOut += decodeRomText3(tempHexString);
                        } else if (tableToUse == 4) {
                            // 0xC0 is added to each value if it is the last character on the third line.
                            lozAsciiOut += decodeRomText4(tempHexString);
                        }
                        //else if (tableToUse == 5) {
                        //    // Story text, table 5
                        //    lozAsciiOut += decodeRomTextTable5(tempHexString);
                        //}
                    }
                    x++;
                }

                // Build and append
                texboxname.Text += lozAsciiOut;
            }

        }

        public void updateROMText(string absoluteFilename, int length, TextBox textBox, int offset, int tableToUse) {
            // TODO: Optimize, all of these steps are unneccesary
            string newLOZString = textBox.Text;

            //Console.WriteLine("newEBString: " + newEBString);

            newLOZString = newLOZString.PadRight(length);
            string hexReturn = "";
            string tempascii = "";
            string[] newLOZStringArray = new string[length];
            byte[] newLOZStringByteArray = new byte[length];
            int[] lozDecimal = new int[length];
            string[] lozFinal = new string[length];
            string[] lozs = new string[length];

            int x = 0;
            while (x < length) {
                newLOZStringArray[x] = newLOZString[x].ToString();
                tempascii = newLOZStringArray[x];
                if (tableToUse == 1) {
                    hexReturn += encodeRomText1(tempascii);
                } else if (tableToUse == 2) {
                    hexReturn += encodeRomText2(tempascii);
                } else if (tableToUse == 3) {
                    hexReturn += encodeRomText3(tempascii);
                } else if (tableToUse == 4) {
                    hexReturn += encodeRomText4(tempascii);
                } 
                //else if (tableToUse == 5) {
                //    hexReturn += decodeRomTextTable5(tempascii);
                //}
                x++;
            }

            int i = 0;
            int j = 0;
            while (i < length) {
                lozs[i] = hexReturn[j].ToString() + hexReturn[j + 1].ToString();
                i++;
                j += 2;
            }

            int q = 0;
            while (q < length) {
                lozDecimal[q] = int.Parse(lozs[q], System.Globalization.NumberStyles.HexNumber);
                lozFinal[q] = lozDecimal[q].ToString();
                newLOZStringByteArray[q] = byte.Parse(lozFinal[q]);
                q++;
            }

            using (FileStream fileStream = new FileStream(@absoluteFilename, FileMode.Open, FileAccess.Write)) {
                fileStream.Seek(offset, SeekOrigin.Begin);
                q = 0;
                while (q < length) {
                    fileStream.WriteByte(newLOZStringByteArray[q]);
                    q++;
                }
            }
        }

        public void updateROMTextSingleLetter(string absoluteFilename, int length, string letter, int offset, int tableToUse) {
            // TODO: Optimize, all of these steps are unneccesary
            string newLOZString = letter;

            //Console.WriteLine("newEBString: " + newEBString);

            newLOZString = newLOZString.PadRight(length);
            string hexReturn = "";
            string tempascii = "";
            string[] newLOZStringArray = new string[length];
            byte[] newLOZStringByteArray = new byte[length];
            int[] lozDecimal = new int[length];
            string[] lozFinal = new string[length];
            string[] lozs = new string[length];

            int x = 0;
            while (x < length) {
                newLOZStringArray[x] = newLOZString[x].ToString();
                tempascii = newLOZStringArray[x];
                if (tableToUse == 1) {
                    hexReturn += encodeRomText1(tempascii);
                } else if (tableToUse == 2) {
                    hexReturn += encodeRomText2(tempascii);
                } else if (tableToUse == 3) {
                    hexReturn += encodeRomText3(tempascii);
                } else if (tableToUse == 4) {
                    hexReturn += encodeRomText4(tempascii);
                }
                //else if (tableToUse == 5) {
                //    hexReturn += decodeRomTextTable5(tempascii);
                //}
                x++;
            }

            int i = 0;
            int j = 0;
            while (i < length) {
                lozs[i] = hexReturn[j].ToString() + hexReturn[j + 1].ToString();
                i++;
                j += 2;
            }

            int q = 0;
            while (q < length) {
                lozDecimal[q] = int.Parse(lozs[q], System.Globalization.NumberStyles.HexNumber);
                lozFinal[q] = lozDecimal[q].ToString();
                newLOZStringByteArray[q] = byte.Parse(lozFinal[q]);
                q++;
            }

            using (FileStream fileStream = new FileStream(@absoluteFilename, FileMode.Open, FileAccess.Write)) {
                fileStream.Seek(offset, SeekOrigin.Begin);
                q = 0;
                while (q < length) {
                    fileStream.WriteByte(newLOZStringByteArray[q]);
                    q++;
                }
            }
        }

        //// The Story mode uses additional graphics but is otherwise the same.
        //// Maybe implement this in the future.
        //private string decodeRomTextTable5(string tempHexString) {
        //    string lozAscii = "";
        //    textFlag = 0;

        //    switch (tempHexString) {
        //        case "00":
        //            lozAscii += "0";
        //            break;
        //        case "01":
        //            lozAscii += "1";
        //            break;
        //        case "02":
        //            lozAscii += "2";
        //            break;
        //        case "03":
        //            lozAscii += "3";
        //            break;
        //        case "04":
        //            lozAscii += "4";
        //            break;
        //        case "05":
        //            lozAscii += "5";
        //            break;
        //        case "06":
        //            lozAscii += "6";
        //            break;
        //        case "07":
        //            lozAscii += "7";
        //            break;
        //        case "08":
        //            lozAscii += "8";
        //            break;
        //        case "09":
        //            lozAscii += "9";
        //            break;
        //        case "0A":
        //            lozAscii += "A";
        //            break;
        //        case "0B":
        //            lozAscii += "B";
        //            break;
        //        case "0C":
        //            lozAscii += "C";
        //            break;
        //        case "0D":
        //            lozAscii += "D";
        //            break;
        //        case "0E":
        //            lozAscii += "E";
        //            break;
        //        case "0F":
        //            lozAscii += "F";
        //            break;
        //        case "10":
        //            lozAscii += "G";
        //            break;
        //        case "11":
        //            lozAscii += "H";
        //            break;
        //        case "12":
        //            lozAscii += "I";
        //            break;
        //        case "13":
        //            lozAscii += "J";
        //            break;
        //        case "14":
        //            lozAscii += "K";
        //            break;
        //        case "15":
        //            lozAscii += "L";
        //            break;
        //        case "16":
        //            lozAscii += "M";
        //            break;
        //        case "17":
        //            lozAscii += "N";
        //            break;
        //        case "18":
        //            lozAscii += "O";
        //            break;
        //        case "19":
        //            lozAscii += "P";
        //            break;
        //        case "1A":
        //            lozAscii += "Q";
        //            break;
        //        case "1B":
        //            lozAscii += "R";
        //            break;
        //        case "1C":
        //            lozAscii += "S";
        //            break;
        //        case "1D":
        //            lozAscii += "T";
        //            break;
        //        case "1E":
        //            lozAscii += "U";
        //            break;
        //        case "1F":
        //            lozAscii += "V";
        //            break;
        //        case "20":
        //            lozAscii += "W";
        //            break;
        //        case "21":
        //            lozAscii += "X";
        //            break;
        //        case "22":
        //            lozAscii += "Y";
        //            break;
        //        case "23":
        //            lozAscii += "Z";
        //            break;
        //        case "24":
        //            lozAscii += " ";
        //            break;
        //        case "25":
        //            lozAscii += "~";
        //            break;
        //        //26, 27? These seem to be unused.
        //        case "28":
        //            lozAscii += ",";
        //            break;
        //        case "29":
        //            lozAscii += "!";
        //            break;
        //        case "2A":
        //            lozAscii += "'";
        //            break;
        //        case "2B":
        //            lozAscii += "&";
        //            break;
        //        //case "2C": // Not sure if 2C is "."
        //        case "63": // This is correct in the story, use this one
        //            lozAscii += ".";
        //            break;
        //        //case "2D": // Not sure if 2D is "\""
        //        case "F8": // This is correct in the story, use this one
        //            lozAscii += "\"";
        //            break;
        //        case "2E":
        //            lozAscii += "?";
        //            break;
        //        case "2F": // Not sure if 2F is "-"
        //        case "62": // This is correct in the story, use this one
        //            lozAscii += "-";
        //            break;
        //        case "64":
        //            lozAscii += "+";
        //            break;
        //        case "F0":
        //        case "FC": // Not sure if FC is "©"
        //            lozAscii += "©";
        //            break;
        //        // TODO: Might add these in a later build.
        //        //case "E2":
        //        //    lozAscii += "("; // vertical part of wreath
        //        //    break;
        //        //case "E3":
        //        //    lozAscii += ")"; // vertical part of wreath
        //        //    break;
        //        //case "E4":
        //        //    lozAscii += "<"; // horizontal part of wreath
        //        //    break;
        //        //case "E5":
        //        //    lozAscii += ">"; // horizontal part of wreath
        //        //    break;
        //        //case "E6":
        //        //    lozAscii += "#"; // corner piece of wreath
        //        //    break;
        //        //case "F8":
        //        //    lozAscii += "_"; // represents a quote
        //        //    break;

        //        // unused at the moment:
        //        // F9 key shape
        //        // F7 Rupee shape
        //        // F2, 65 heart shape

        //        default:
        //            lozAscii += " ";
        //            textFlag = 1;
        //            break;
        //    }

        //    return lozAscii;
        //}

        // This needs to be broken up into 4 methods.
        // Method 1: no encoding.
        // Method 2: 0x80 is added to each value if it is the last character on the first line.
        // Method 3: 0x40 is added to each value if it is the last character on the second line.
        // Method 4: 0xC0 is added to each value if it is the last character on the third line.
        // We have to break it up to avoid decoding conflict, for example:
        // 63 could be a "." or a "Z", normal text 63 is a period, encoded at end of second line would be a Z.
        // The different methods would have to be set on the front end where necessary, using a flag for the table to use.
        // So some text will require but not all.
        private string decodeRomText1(string tempHexString) {
            string lozAscii = "";
            textFlag = 0;

            switch (tempHexString) {
                case "00":
                    lozAscii += "0";
                    break;
                case "01":
                    lozAscii += "1";
                    break;
                case "02":
                    lozAscii += "2";
                    break;
                case "03":
                    lozAscii += "3";
                    break;
                case "04":
                    lozAscii += "4";
                    break;
                case "05":
                    lozAscii += "5";
                    break;
                case "06":
                    lozAscii += "6";
                    break;
                case "07":
                    lozAscii += "7";
                    break;
                case "08":
                    lozAscii += "8";
                    break;
                case "09":
                    lozAscii += "9";
                    break;
                case "0A":
                    lozAscii += "A";
                    break;
                case "0B":
                    lozAscii += "B";
                    break;
                case "0C":
                    lozAscii += "C";
                    break;
                case "0D":
                    lozAscii += "D";
                    break;
                case "0E":
                    lozAscii += "E";
                    break;
                case "0F":
                    lozAscii += "F";
                    break;
                case "10":
                    lozAscii += "G";
                    break;
                case "11":
                    lozAscii += "H";
                    break;
                case "12":
                    lozAscii += "I";
                    break;
                case "13":
                    lozAscii += "J";
                    break;
                case "14":
                    lozAscii += "K";
                    break;
                case "15":
                    lozAscii += "L";
                    break;
                case "16":
                    lozAscii += "M";
                    break;
                case "17":
                    lozAscii += "N";
                    break;
                case "18":
                    lozAscii += "O";
                    break;
                case "19":
                    lozAscii += "P";
                    break;
                case "1A":
                    lozAscii += "Q";
                    break;
                case "1B":
                    lozAscii += "R";
                    break;
                case "1C":
                    lozAscii += "S";
                    break;
                case "1D":
                    lozAscii += "T";
                    break;
                case "1E":
                    lozAscii += "U";
                    break;
                case "1F":
                    lozAscii += "V";
                    break;
                case "20":
                    lozAscii += "W";
                    break;
                case "21":
                    lozAscii += "X";
                    break;
                case "22":
                    lozAscii += "Y";
                    break;
                case "23":
                    lozAscii += "Z";
                    break;
                case "24":
                    lozAscii += " ";
                    break;
                case "25":
                    lozAscii += "~"; // Tilde is used for indenting spaces
                    break;
                    //26, 27?
                case "28":
                    lozAscii += ",";
                    break;
                case "29":
                    lozAscii += "!";
                    break;
                case "2A":
                    lozAscii += "'";
                    break;
                case "2B":
                    lozAscii += "&";
                    break;
                case "2C":
                case "63": // This does not follow the pattern but is correct.
                    lozAscii += ".";
                    break;
                case "2D":
                case "F8": // This does not follow the pattern but is correct.
                    lozAscii += "\"";
                    break;
                case "2E":
                    lozAscii += "?";
                    break;
                case "2F":
                case "62": // TODO: the registration screen encodes "-" as 62, not sure why yet
                    lozAscii += "-";
                    break;
                case "30":
                case "FC": // In the ending credits.
                    lozAscii += "©";
                    break;
                case "64":
                    lozAscii += "+";
                    break;
                default:
                    lozAscii += " ";
                    textFlag = 1;
                    break;
            }

            return lozAscii;
        }

        // Method 2: 0x80 is added to each value if it is the last character on the first line.
        private string decodeRomText2(string tempHexString) {
            string lozAscii = "";
            textFlag = 0;

            switch (tempHexString) {
                case "80":
                    lozAscii += "0";
                    break;
                case "81":
                    lozAscii += "1";
                    break;
                case "82":
                    lozAscii += "2";
                    break;
                case "83":
                    lozAscii += "3";
                    break;
                case "84":
                    lozAscii += "4";
                    break;
                case "85":
                    lozAscii += "5";
                    break;
                case "86":
                    lozAscii += "6";
                    break;
                case "87":
                    lozAscii += "7";
                    break;
                case "88":
                    lozAscii += "8";
                    break;
                case "89":
                    lozAscii += "9";
                    break;
                case "8A":
                    lozAscii += "A";
                    break;
                case "8B":
                    lozAscii += "B";
                    break;
                case "8C":
                    lozAscii += "C";
                    break;
                case "8D":
                    lozAscii += "D";
                    break;
                case "8E":
                    lozAscii += "E";
                    break;
                case "8F":
                    lozAscii += "F";
                    break;
                case "90":
                    lozAscii += "G";
                    break;
                case "91":
                    lozAscii += "H";
                    break;
                case "92":
                    lozAscii += "I";
                    break;
                case "93":
                    lozAscii += "J";
                    break;
                case "94":
                    lozAscii += "K";
                    break;
                case "95":
                    lozAscii += "L";
                    break;
                case "96":
                    lozAscii += "M";
                    break;
                case "97":
                    lozAscii += "N";
                    break;
                case "98":
                    lozAscii += "O";
                    break;
                case "99":
                    lozAscii += "P";
                    break;
                case "9A":
                    lozAscii += "Q";
                    break;
                case "9B":
                    lozAscii += "R";
                    break;
                case "9C":
                    lozAscii += "S";
                    break;
                case "9D":
                    lozAscii += "T";
                    break;
                case "9E":
                    lozAscii += "U";
                    break;
                case "9F":
                    lozAscii += "V";
                    break;
                case "A0":
                    lozAscii += "W";
                    break;
                case "A1":
                    lozAscii += "X";
                    break;
                case "A2":
                    lozAscii += "Y";
                    break;
                case "A3":
                    lozAscii += "Z";
                    break;
                case "A4":
                    lozAscii += " ";
                    break;
                case "A5":
                    lozAscii += "~"; // Tilde is used for indenting spaces
                    break;
                //A6, A7?
                case "A8":
                    lozAscii += ",";
                    break;
                case "A9":
                    lozAscii += "!";
                    break;
                case "AA":
                    lozAscii += "'";
                    break;
                case "AB":
                    lozAscii += "&";
                    break;
                case "AC":
                    lozAscii += ".";
                    break;
                case "AD":
                    lozAscii += "\"";
                    break;
                case "AE":
                    lozAscii += "?";
                    break;
                case "AF":
                    lozAscii += "-";
                    break;
                case "B0":
                    lozAscii += "©";
                    break;
                case "E4":
                    lozAscii += "+";
                    break;
                default:
                    lozAscii += " ";
                    textFlag = 1;
                    break;
            }

            return lozAscii;
        }

        // Method 3: 0x40 is added to each value if it is the last character on the second line.
        private string decodeRomText3(string tempHexString) {
            string lozAscii = "";
            textFlag = 0;

            switch (tempHexString) {
                case "40":
                    lozAscii += "0";
                    break;
                case "41":
                    lozAscii += "1";
                    break;
                case "42":
                    lozAscii += "2";
                    break;
                case "43":
                    lozAscii += "3";
                    break;
                case "44":
                    lozAscii += "4";
                    break;
                case "45":
                    lozAscii += "5";
                    break;
                case "46":
                    lozAscii += "6";
                    break;
                case "47":
                    lozAscii += "7";
                    break;
                case "48":
                    lozAscii += "8";
                    break;
                case "49":
                    lozAscii += "9";
                    break;
                case "4A":
                    lozAscii += "A";
                    break;
                case "4B":
                    lozAscii += "B";
                    break;
                case "4C":
                    lozAscii += "C";
                    break;
                case "4D":
                    lozAscii += "D";
                    break;
                case "4E":
                    lozAscii += "E";
                    break;
                case "4F":
                    lozAscii += "F";
                    break;
                case "50":
                    lozAscii += "G";
                    break;
                case "51":
                    lozAscii += "H";
                    break;
                case "52":
                    lozAscii += "I";
                    break;
                case "53":
                    lozAscii += "J";
                    break;
                case "54":
                    lozAscii += "K";
                    break;
                case "55":
                    lozAscii += "L";
                    break;
                case "56":
                    lozAscii += "M";
                    break;
                case "57":
                    lozAscii += "N";
                    break;
                case "58":
                    lozAscii += "O";
                    break;
                case "59":
                    lozAscii += "P";
                    break;
                case "5A":
                    lozAscii += "Q";
                    break;
                case "5B":
                    lozAscii += "R";
                    break;
                case "5C":
                    lozAscii += "S";
                    break;
                case "5D":
                    lozAscii += "T";
                    break;
                case "5E":
                    lozAscii += "U";
                    break;
                case "5F":
                    lozAscii += "V";
                    break;
                case "60":
                    lozAscii += "W";
                    break;
                case "61":
                    lozAscii += "X";
                    break;
                case "62":
                    lozAscii += "Y";
                    break;
                case "63":
                    lozAscii += "Z";
                    break;
                case "64":
                    lozAscii += " ";
                    break;
                case "65":
                    lozAscii += "~"; // Tilde is used for indenting spaces
                    break;
                //66, 67?
                case "68":
                    lozAscii += ",";
                    break;
                case "69":
                    lozAscii += "!";
                    break;
                case "6A":
                    lozAscii += "'";
                    break;
                case "6B":
                    lozAscii += "&";
                    break;
                case "6C":
                    lozAscii += ".";
                    break;
                case "6D":
                    lozAscii += "\"";
                    break;
                case "6E":
                    lozAscii += "?";
                    break;
                case "6F":
                    lozAscii += "-";
                    break;
                case "70":
                    lozAscii += "©";
                    break;
                case "A4":
                    lozAscii += "+";
                    break;
                default:
                    lozAscii += " ";
                    textFlag = 1;
                    break;
            }

            return lozAscii;
        }



        // Method 4: 0xC0 is added to each value if it is the last character on the third line.
        private string decodeRomText4(string tempHexString) {
            string lozAscii = "";
            textFlag = 0;

            switch (tempHexString) {
                case "C0":
                    lozAscii += "0";
                    break;
                case "C1":
                    lozAscii += "1";
                    break;
                case "C2":
                    lozAscii += "2";
                    break;
                case "C3":
                    lozAscii += "3";
                    break;
                case "C4":
                    lozAscii += "4";
                    break;
                case "C5":
                    lozAscii += "5";
                    break;
                case "C6":
                    lozAscii += "6";
                    break;
                case "C7":
                    lozAscii += "7";
                    break;
                case "C8":
                    lozAscii += "8";
                    break;
                case "C9":
                    lozAscii += "9";
                    break;
                case "CA":
                    lozAscii += "A";
                    break;
                case "CB":
                    lozAscii += "B";
                    break;
                case "CC":
                    lozAscii += "C";
                    break;
                case "CD":
                    lozAscii += "D";
                    break;
                case "CE":
                    lozAscii += "E";
                    break;
                case "CF":
                    lozAscii += "F";
                    break;
                case "D0":
                    lozAscii += "G";
                    break;
                case "D1":
                    lozAscii += "H";
                    break;
                case "D2":
                    lozAscii += "I";
                    break;
                case "D3":
                    lozAscii += "J";
                    break;
                case "D4":
                    lozAscii += "K";
                    break;
                case "D5":
                    lozAscii += "L";
                    break;
                case "D6":
                    lozAscii += "M";
                    break;
                case "D7":
                    lozAscii += "N";
                    break;
                case "D8":
                    lozAscii += "O";
                    break;
                case "D9":
                    lozAscii += "P";
                    break;
                case "DA":
                    lozAscii += "Q";
                    break;
                case "DB":
                    lozAscii += "R";
                    break;
                case "DC":
                    lozAscii += "S";
                    break;
                case "DD":
                    lozAscii += "T";
                    break;
                case "DE":
                    lozAscii += "U";
                    break;
                case "DF":
                    lozAscii += "V";
                    break;
                case "E0":
                    lozAscii += "W";
                    break;
                case "E1":
                    lozAscii += "X";
                    break;
                case "E2":
                    lozAscii += "Y";
                    break;
                case "E3":
                    lozAscii += "Z";
                    break;
                case "E4":
                    lozAscii += " ";
                    break;
                case "E5":
                    lozAscii += "~"; // Tilde is used for indenting spaces
                    break;
                // E6, E7?
                case "E8":
                    lozAscii += ",";
                    break;
                case "E9":
                    lozAscii += "!";
                    break;
                case "EA":
                    lozAscii += "'";
                    break;
                case "EB":
                    lozAscii += "&";
                    break;
                case "EC":
                    lozAscii += ".";
                    break;
                case "ED":
                    lozAscii += "\"";
                    break;
                case "EE":
                    lozAscii += "?";
                    break;
                case "EF":
                    lozAscii += "-";
                    break;
                case "F0":
                    lozAscii += "©";
                    break;
                    // no idea on "+", 124h wont fit
                default:
                    lozAscii += " ";
                    textFlag = 1;
                    break;
            }

            return lozAscii;
        }

        public string encodeRomText1(string tempascii) {
            string lozHex = "";
            tempascii = tempascii.ToUpper();

            switch (tempascii) {
                case "0":
                    lozHex += "00";
                    break;
                case "1":
                    lozHex += "01";
                    break;
                case "2":
                    lozHex += "02";
                    break;
                case "3":
                    lozHex += "03";
                    break;
                case "4":
                    lozHex += "04";
                    break;
                case "5":
                    lozHex += "05";
                    break;
                case "6":
                    lozHex += "06";
                    break;
                case "7":
                    lozHex += "07";
                    break;
                case "8":
                    lozHex += "08";
                    break;
                case "9":
                    lozHex += "09";
                    break;
                case "A":
                    lozHex += "0A";
                    break;
                case "B":
                    lozHex += "0B";
                    break;
                case "C":
                    lozHex += "0C";
                    break;
                case "D":
                    lozHex += "0D";
                    break;
                case "E":
                    lozHex += "0E";
                    break;
                case "F":
                    lozHex += "0F";
                    break;
                case "G":
                    lozHex += "10";
                    break;
                case "H":
                    lozHex += "11";
                    break;
                case "I":
                    lozHex += "12";
                    break;
                case "J":
                    lozHex += "13";
                    break;
                case "K":
                    lozHex += "14";
                    break;
                case "L":
                    lozHex += "15";
                    break;
                case "M":
                    lozHex += "16";
                    break;
                case "N":
                    lozHex += "17";
                    break;
                case "O":
                    lozHex += "18";
                    break;
                case "P":
                    lozHex += "19";
                    break;
                case "Q":
                    lozHex += "1A";
                    break;
                case "R":
                    lozHex += "1B";
                    break;
                case "S":
                    lozHex += "1C";
                    break;
                case "T":
                    lozHex += "1D";
                    break;
                case "U":
                    lozHex += "1E";
                    break;
                case "V":
                    lozHex += "1F";
                    break;
                case "W":
                    lozHex += "20";
                    break;
                case "X":
                    lozHex += "21";
                    break;
                case "Y":
                    lozHex += "22";
                    break;
                case "Z":
                    lozHex += "23";
                    break;
                case " ":
                    lozHex += "24";
                    break;
                case "~": // Tilde is used for indenting spaces
                    lozHex += "25";
                    break;
                //case "*":
                //    lozHex += "26";
                //    break;
                    //26, 27?
                case ",":
                    lozHex += "28";
                    break;
                case "!":
                    lozHex += "29";
                    break;
                case "'":
                    lozHex += "2A";
                    break;
                case "&":
                    lozHex += "2B";
                    break;
                case "?":
                    lozHex += "2E";
                    break;
                case "-":
                    lozHex += "2F";
                    break;
                case ".":
                    lozHex += "63"; //2C also??
                    break;
                case "+":
                    lozHex += "64";
                    break;
                case "\"":
                    lozHex += "F8"; //2D also??
                    break;
                case "©":
                    lozHex += "FC"; // 30 also??
                    break;
                default:
                    lozHex += "24";
                    break;
            }

            return lozHex;
        }

        // Method 2: 0x80 is added to each value if it is the last character on the first line.
        public string encodeRomText2(string tempascii) {
            string lozHex = "";
            tempascii = tempascii.ToUpper();

            switch (tempascii) {
                case "0":
                    lozHex += "80";
                    break;
                case "1":
                    lozHex += "81";
                    break;
                case "2":
                    lozHex += "82";
                    break;
                case "3":
                    lozHex += "83";
                    break;
                case "4":
                    lozHex += "84";
                    break;
                case "5":
                    lozHex += "85";
                    break;
                case "6":
                    lozHex += "86";
                    break;
                case "7":
                    lozHex += "87";
                    break;
                case "8":
                    lozHex += "88";
                    break;
                case "9":
                    lozHex += "89";
                    break;
                case "A":
                    lozHex += "8A";
                    break;
                case "B":
                    lozHex += "8B";
                    break;
                case "C":
                    lozHex += "8C";
                    break;
                case "D":
                    lozHex += "8D";
                    break;
                case "E":
                    lozHex += "8E";
                    break;
                case "F":
                    lozHex += "8F";
                    break;
                case "G":
                    lozHex += "90";
                    break;
                case "H":
                    lozHex += "91";
                    break;
                case "I":
                    lozHex += "92";
                    break;
                case "J":
                    lozHex += "93";
                    break;
                case "K":
                    lozHex += "94";
                    break;
                case "L":
                    lozHex += "95";
                    break;
                case "M":
                    lozHex += "96";
                    break;
                case "N":
                    lozHex += "97";
                    break;
                case "O":
                    lozHex += "98";
                    break;
                case "P":
                    lozHex += "99";
                    break;
                case "Q":
                    lozHex += "9A";
                    break;
                case "R":
                    lozHex += "9B";
                    break;
                case "S":
                    lozHex += "9C";
                    break;
                case "T":
                    lozHex += "9D";
                    break;
                case "U":
                    lozHex += "9E";
                    break;
                case "V":
                    lozHex += "9F";
                    break;
                case "W":
                    lozHex += "A0";
                    break;
                case "X":
                    lozHex += "A1";
                    break;
                case "Y":
                    lozHex += "A2";
                    break;
                case "Z":
                    lozHex += "A3";
                    break;
                case " ":
                    lozHex += "A4";
                    break;
                case "~": // Tilde is used for indenting spaces
                    lozHex += "A5";
                    break;
                //case "*": //?
                //    lozHex += "A6";
                //    break;
                //A6, A7?
                case ",":
                    lozHex += "A8";
                    break;
                case "!":
                    lozHex += "A9";
                    break;
                case "'":
                    lozHex += "AA";
                    break;
                case "&":
                    lozHex += "AB";
                    break;
                case ".":
                    lozHex += "AC";
                    break;
                case "\"":
                    lozHex += "AD";
                    break;
                case "?":
                    lozHex += "AE";
                    break;
                case "-":
                    lozHex += "AF";
                    break;
                case "©":
                    lozHex += "B0";
                    break;
                case "+":
                    lozHex += "E4";
                    break;
                default:
                    lozHex += "24";
                    break;
            }

            return lozHex;
        }

        // 0x40 is added to each value if it is the last character on the second line.
        public string encodeRomText3(string tempascii) {
            string lozHex = "";
            tempascii = tempascii.ToUpper();

            switch (tempascii) {
                case "0":
                    lozHex += "40";
                    break;
                case "1":
                    lozHex += "41";
                    break;
                case "2":
                    lozHex += "42";
                    break;
                case "3":
                    lozHex += "43";
                    break;
                case "4":
                    lozHex += "44";
                    break;
                case "5":
                    lozHex += "45";
                    break;
                case "6":
                    lozHex += "46";
                    break;
                case "7":
                    lozHex += "47";
                    break;
                case "8":
                    lozHex += "48";
                    break;
                case "9":
                    lozHex += "49";
                    break;
                case "A":
                    lozHex += "4A";
                    break;
                case "B":
                    lozHex += "4B";
                    break;
                case "C":
                    lozHex += "4C";
                    break;
                case "D":
                    lozHex += "4D";
                    break;
                case "E":
                    lozHex += "4E";
                    break;
                case "F":
                    lozHex += "4F";
                    break;
                case "G":
                    lozHex += "50";
                    break;
                case "H":
                    lozHex += "51";
                    break;
                case "I":
                    lozHex += "52";
                    break;
                case "J":
                    lozHex += "53";
                    break;
                case "K":
                    lozHex += "54";
                    break;
                case "L":
                    lozHex += "55";
                    break;
                case "M":
                    lozHex += "56";
                    break;
                case "N":
                    lozHex += "57";
                    break;
                case "O":
                    lozHex += "58";
                    break;
                case "P":
                    lozHex += "59";
                    break;
                case "Q":
                    lozHex += "5A";
                    break;
                case "R":
                    lozHex += "5B";
                    break;
                case "S":
                    lozHex += "5C";
                    break;
                case "T":
                    lozHex += "5D";
                    break;
                case "U":
                    lozHex += "5E";
                    break;
                case "V":
                    lozHex += "5F";
                    break;
                case "W":
                    lozHex += "60";
                    break;
                case "X":
                    lozHex += "61";
                    break;
                case "Y":
                    lozHex += "62";
                    break;
                case "Z":
                    lozHex += "63";
                    break;
                case " ":
                    lozHex += "64";
                    break;
                case "~": // Tilde is used for indenting spaces
                    lozHex += "65";
                    break;
                //case "*":
                //    lozHex += "66";
                //    break;
                //66, 67?
                case ",":
                    lozHex += "68";
                    break;
                case "!":
                    lozHex += "69";
                    break;
                case "'":
                    lozHex += "6A";
                    break;
                case "&":
                    lozHex += "6B";
                    break;
                case ".":
                    lozHex += "6C";
                    break;
                case "\"":
                    lozHex += "6D";
                    break;
                case "?":
                    lozHex += "6E";
                    break;
                case "-":
                    lozHex += "6F";
                    break;
                case "©":
                    lozHex += "70";
                    break;
                case "+":
                    lozHex += "A4";
                    break;
                default:
                    lozHex += "64";
                    break;
            }

            return lozHex;
        }

        // 0xC0 is added to each value if it is the last character on the third line.
        public string encodeRomText4(string tempascii) {
            string lozHex = "";
            tempascii = tempascii.ToUpper();

            switch (tempascii) {
                case "0":
                    lozHex += "C0";
                    break;
                case "1":
                    lozHex += "C1";
                    break;
                case "2":
                    lozHex += "C2";
                    break;
                case "3":
                    lozHex += "C3";
                    break;
                case "4":
                    lozHex += "C4";
                    break;
                case "5":
                    lozHex += "C5";
                    break;
                case "6":
                    lozHex += "C6";
                    break;
                case "7":
                    lozHex += "C7";
                    break;
                case "8":
                    lozHex += "C8";
                    break;
                case "9":
                    lozHex += "C9";
                    break;
                case "A":
                    lozHex += "CA";
                    break;
                case "B":
                    lozHex += "CB";
                    break;
                case "C":
                    lozHex += "CC";
                    break;
                case "D":
                    lozHex += "CD";
                    break;
                case "E":
                    lozHex += "CE";
                    break;
                case "F":
                    lozHex += "CF";
                    break;
                case "G":
                    lozHex += "D0";
                    break;
                case "H":
                    lozHex += "D1";
                    break;
                case "I":
                    lozHex += "D2";
                    break;
                case "J":
                    lozHex += "D3";
                    break;
                case "K":
                    lozHex += "D4";
                    break;
                case "L":
                    lozHex += "D5";
                    break;
                case "M":
                    lozHex += "D6";
                    break;
                case "N":
                    lozHex += "D7";
                    break;
                case "O":
                    lozHex += "D8";
                    break;
                case "P":
                    lozHex += "D9";
                    break;
                case "Q":
                    lozHex += "DA";
                    break;
                case "R":
                    lozHex += "DB";
                    break;
                case "S":
                    lozHex += "DC";
                    break;
                case "T":
                    lozHex += "DD";
                    break;
                case "U":
                    lozHex += "DE";
                    break;
                case "V":
                    lozHex += "DF";
                    break;
                case "W":
                    lozHex += "E0";
                    break;
                case "X":
                    lozHex += "E1";
                    break;
                case "Y":
                    lozHex += "E2";
                    break;
                case "Z":
                    lozHex += "E3";
                    break;
                case " ":
                    lozHex += "E4";
                    break;
                case "~": // Tilde is used for indenting spaces
                    lozHex += "E5";
                    break;
                //case "*":
                //    lozHex += "E6";
                //    break;
                //E6, E7?
                case ",":
                    lozHex += "E8";
                    break;
                case "!":
                    lozHex += "E9";
                    break;
                case "'":
                    lozHex += "EA";
                    break;
                case "&":
                    lozHex += "EB";
                    break;
                case ".":
                    lozHex += "EC";
                    break;
                case "\"":
                    lozHex += "ED";
                    break;
                case "?":
                    lozHex += "EE";
                    break;
                case "-":
                    lozHex += "EF";
                    break;
                case "©":
                    lozHex += "F0";
                    break;
                // no idea on "+", 124h wont fit
                default:
                    lozHex += "24";
                    break;
            }

            return lozHex;
        }

    }
}
