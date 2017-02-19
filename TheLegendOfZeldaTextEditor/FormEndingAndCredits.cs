using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author: Shawn M. Crawford
namespace TheLegendOfZeldaTextEditor {
    public partial class FormEndingAndCredits : Form {

        string path = "";

        public FormEndingAndCredits() {
            InitializeComponent();
        }

        public string sendPathToOtherForm {
            get {
                return path;
            }
            set {
                path = value;
            }
        }

        private void readRomText() {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                // TODO: Figure out where "LINK    - 0" is located, 0xADA2 is the pointer, the spaces and "-" are there but the other data is pulled
                // from somewhere else.


                // The last letter of this one needs special encoding (THANKS LINK,YOU'RE).
                // The E is encoded as '8E' instead of '0E'.
                // 0x80 is added to each value if it is the last character on the first line.
                //backend.getText(absoluteFilename, textBoxEndingAndCredits1, 0x12, 0xA969, 1);
                backend.getText(absoluteFilename, textBoxEndingAndCredits1, 0x11, 0xA969, 1);
                backend.getText(absoluteFilename, textBoxEndingAndCredits1, 0x1, 0xA97A, 2);

                // Another special case, need to use table 4 for the "."
                //backend.getText(absoluteFilename, textBoxEndingAndCredits2, 0x13, 0xA97C, 1); //THE HERO OF HYRULE.
                backend.getText(absoluteFilename, textBoxEndingAndCredits2, 0x12, 0xA97C, 1);
                backend.getText(absoluteFilename, textBoxEndingAndCredits2, 0x1, 0xA98E, 4);

                backend.getText(absoluteFilename, textBoxEndingAndCredits3, 0x34, 0xAB17, 1); //Finally, peace retu...
                backend.getText(absoluteFilename, textBoxEndingAndCredits4, 0x7, 0xAC6E, 1);
                backend.getText(absoluteFilename, textBoxEndingAndCredits5, 0x9, 0xAC77, 1);

                backend.getText(absoluteFilename, textBoxEndingAndCredits6, 0x16, 0xAC82, 1);
                backend.getText(absoluteFilename, textBoxEndingAndCredits7, 0x16, 0xAC9A, 1);
                backend.getText(absoluteFilename, textBoxEndingAndCredits8, 0x16, 0xACB2, 1);
                backend.getText(absoluteFilename, textBoxEndingAndCredits9, 0xE, 0xACCA, 1);
                backend.getText(absoluteFilename, textBoxEndingAndCredits10, 0x16, 0xACDA, 1);

                backend.getText(absoluteFilename, textBoxEndingAndCredits11, 0x16, 0xACF2, 1);
                backend.getText(absoluteFilename, textBoxEndingAndCredits12, 0xC, 0xAD0A, 1);
                backend.getText(absoluteFilename, textBoxEndingAndCredits13, 0xC, 0xAD18, 1);
                backend.getText(absoluteFilename, textBoxEndingAndCredits14, 0x5, 0xAD26, 1);
                backend.getText(absoluteFilename, textBoxEndingAndCredits15, 0x16, 0xAD2D, 1);

                backend.getText(absoluteFilename, textBoxEndingAndCredits16, 0x18, 0xAD45, 1);
                backend.getText(absoluteFilename, textBoxEndingAndCredits17, 0xA, 0xAD5F, 1);
                
                backend.getText(absoluteFilename, textBoxEndingAndCredits18, 0x17, 0xAD6B, 1);

                backend.getText(absoluteFilename, textBoxEndingAndCredits19, 0xE, 0xAD84, 1);
                
                backend.getText(absoluteFilename, textBoxEndingAndCredits20, 0xE, 0xAD94, 1);

                backend.getText(absoluteFilename, textBoxEndingAndCredits21, 0x13, 0xADB3, 1);
                backend.getText(absoluteFilename, textBoxEndingAndCredits22, 0x11, 0xADC8, 1);
                backend.getText(absoluteFilename, textBoxEndingAndCredits23, 0x6, 0xADDB, 1);
                backend.getText(absoluteFilename, textBoxEndingAndCredits24, 0x17, 0xADE3, 1);
                
                backend.getText(absoluteFilename, textBoxEndingAndCredits25, 0xE, 0xADFC, 1);
                

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                // The last letter of this one needs special encoding (THANKS LINK,YOU'RE).
                //backend.updateROMText(absoluteFilename, 0x12, textBoxEndingAndCredits1, 0xA969, 1);
                backend.updateROMText(absoluteFilename, 0x11, textBoxEndingAndCredits1, 0xA969, 1);
                backend.updateROMText(absoluteFilename, 0x1, textBoxEndingAndCredits1, 0xA97A, 2);

                backend.updateROMText(absoluteFilename, 0x12, textBoxEndingAndCredits2, 0xA97C, 1);
                backend.updateROMText(absoluteFilename, 0x34, textBoxEndingAndCredits3, 0xAB17, 1);
                backend.updateROMText(absoluteFilename, 0x7, textBoxEndingAndCredits4, 0xAC6E, 1);
                backend.updateROMText(absoluteFilename, 0x9, textBoxEndingAndCredits5, 0xAC77, 1);

                backend.updateROMText(absoluteFilename, 0x16, textBoxEndingAndCredits6, 0xAC82, 1);
                backend.updateROMText(absoluteFilename, 0x16, textBoxEndingAndCredits7, 0xAC9A, 1);
                backend.updateROMText(absoluteFilename, 0x16, textBoxEndingAndCredits8, 0xACB2, 1);
                backend.updateROMText(absoluteFilename, 0xE, textBoxEndingAndCredits9, 0xACCA, 1);
                backend.updateROMText(absoluteFilename, 0x16, textBoxEndingAndCredits10, 0xACDA, 1);

                backend.updateROMText(absoluteFilename, 0x16, textBoxEndingAndCredits11, 0xACF2, 1);
                backend.updateROMText(absoluteFilename, 0xC, textBoxEndingAndCredits12, 0xAD0A, 1);
                backend.updateROMText(absoluteFilename, 0xC, textBoxEndingAndCredits13, 0xAD18, 1);
                backend.updateROMText(absoluteFilename, 0x5, textBoxEndingAndCredits14, 0xAD26, 1);
                backend.updateROMText(absoluteFilename, 0x16, textBoxEndingAndCredits15, 0xAD2D, 1);

                backend.updateROMText(absoluteFilename, 0x18, textBoxEndingAndCredits16, 0xAD45, 1);
                backend.updateROMText(absoluteFilename, 0xA, textBoxEndingAndCredits17, 0xAD5F, 1);
                backend.updateROMText(absoluteFilename, 0x17, textBoxEndingAndCredits18, 0xAD6B, 1);
                backend.updateROMText(absoluteFilename, 0xE, textBoxEndingAndCredits19, 0xAD84, 1);
                backend.updateROMText(absoluteFilename, 0xE, textBoxEndingAndCredits20, 0xAD94, 1);

                backend.updateROMText(absoluteFilename, 0x13, textBoxEndingAndCredits21, 0xADB3, 1);
                backend.updateROMText(absoluteFilename, 0x11, textBoxEndingAndCredits22, 0xADC8, 1);
                backend.updateROMText(absoluteFilename, 0x6, textBoxEndingAndCredits23, 0xADDB, 1);
                backend.updateROMText(absoluteFilename, 0x17, textBoxEndingAndCredits24, 0xADE3, 1);
                backend.updateROMText(absoluteFilename, 0xE, textBoxEndingAndCredits25, 0xADFC, 1);

                MessageBox.Show("Updated Text!", "The Legend of Zelda Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxEndingAndCredits1.MaxLength = 0x12;
            textBoxEndingAndCredits2.MaxLength = 0x12;
            textBoxEndingAndCredits3.MaxLength = 0x34;
            textBoxEndingAndCredits4.MaxLength = 0x7;
            textBoxEndingAndCredits5.MaxLength = 0x9;

            textBoxEndingAndCredits6.MaxLength = 0x16;
            textBoxEndingAndCredits7.MaxLength = 0x16;
            textBoxEndingAndCredits8.MaxLength = 0x16;
            textBoxEndingAndCredits9.MaxLength = 0xE;
            textBoxEndingAndCredits10.MaxLength = 0x16;

            textBoxEndingAndCredits11.MaxLength = 0x16;
            textBoxEndingAndCredits12.MaxLength = 0xC;
            textBoxEndingAndCredits13.MaxLength = 0xC;
            textBoxEndingAndCredits14.MaxLength = 0x5;
            textBoxEndingAndCredits15.MaxLength = 0x16;

            textBoxEndingAndCredits16.MaxLength = 0x18;
            textBoxEndingAndCredits17.MaxLength = 0xA;
            textBoxEndingAndCredits18.MaxLength = 0x17;
            textBoxEndingAndCredits19.MaxLength = 0xE;
            textBoxEndingAndCredits20.MaxLength = 0xE;

            textBoxEndingAndCredits21.MaxLength = 0x13;
            textBoxEndingAndCredits22.MaxLength = 0x11;
            textBoxEndingAndCredits23.MaxLength = 0x6;
            textBoxEndingAndCredits24.MaxLength = 0x17;
            textBoxEndingAndCredits25.MaxLength = 0xE;

        }

        private void FormEndingAndCredits_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }
    }
}
