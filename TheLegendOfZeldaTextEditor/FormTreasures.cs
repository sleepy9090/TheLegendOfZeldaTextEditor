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
    public partial class FormTreasures : Form {

        string path = "";

        public FormTreasures() {
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

                // 35 treasures plus "ALL OF TREASURES" (36) on 29 lines for editing
                backend.getText(absoluteFilename, textBoxTreasure1, 0x12, 0x92B2, 1);
                backend.getText(absoluteFilename, textBoxTreasure2, 0x13, 0x92CD, 1);
                backend.getText(absoluteFilename, textBoxTreasure3, 0x5, 0x92E2, 1);
                backend.getText(absoluteFilename, textBoxTreasure4, 0x12, 0x92E9, 1);
                backend.getText(absoluteFilename, textBoxTreasure5, 0x13, 0x92FD, 1);
                backend.getText(absoluteFilename, textBoxTreasure6, 0x12, 0x9312, 1);
                backend.getText(absoluteFilename, textBoxTreasure7, 0x5, 0x9326, 1);
                backend.getText(absoluteFilename, textBoxTreasure8, 0x14, 0x932D, 1);
                backend.getText(absoluteFilename, textBoxTreasure9, 0x13, 0x9343, 1);
                backend.getText(absoluteFilename, textBoxTreasure10, 0x15, 0x9358, 1);
                backend.getText(absoluteFilename, textBoxTreasure11, 0x9, 0x936F, 1);
                backend.getText(absoluteFilename, textBoxTreasure12, 0x11, 0x937A, 1);
                backend.getText(absoluteFilename, textBoxTreasure13, 0x13, 0x938D, 1);
                backend.getText(absoluteFilename, textBoxTreasure14, 0x5, 0x93A2, 1);
                backend.getText(absoluteFilename, textBoxTreasure15, 0x11, 0x93A9, 1);
                backend.getText(absoluteFilename, textBoxTreasure16, 0x14, 0x93BC, 1);
                backend.getText(absoluteFilename, textBoxTreasure17, 0x11, 0x93D2, 1);
                backend.getText(absoluteFilename, textBoxTreasure18, 0x12, 0x93E5, 1);
                backend.getText(absoluteFilename, textBoxTreasure19, 0x14, 0x93F9, 1);
                backend.getText(absoluteFilename, textBoxTreasure20, 0x8, 0x940F, 1);
                backend.getText(absoluteFilename, textBoxTreasure21, 0x15, 0x9419, 1);
                backend.getText(absoluteFilename, textBoxTreasure22, 0x14, 0x9430, 1);
                backend.getText(absoluteFilename, textBoxTreasure23, 0x11, 0x9446, 1);
                backend.getText(absoluteFilename, textBoxTreasure24, 0x12, 0x9459, 1);
                backend.getText(absoluteFilename, textBoxTreasure25, 0x3, 0x946D, 1);
                backend.getText(absoluteFilename, textBoxTreasure26, 0x12, 0x9472, 1);
                backend.getText(absoluteFilename, textBoxTreasure27, 0x8, 0x9486, 1);
                backend.getText(absoluteFilename, textBoxTreasure28, 0x18, 0x9490, 1);
                backend.getText(absoluteFilename, textBoxTreasure29, 0x13, 0x94AA, 1);


            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x12, textBoxTreasure1, 0x92B2, 1);
                backend.updateROMText(absoluteFilename, 0x13, textBoxTreasure2, 0x92CD, 1);
                backend.updateROMText(absoluteFilename, 0x5, textBoxTreasure3, 0x92E2, 1);
                backend.updateROMText(absoluteFilename, 0x12, textBoxTreasure4, 0x92E9, 1);
                backend.updateROMText(absoluteFilename, 0x13, textBoxTreasure5, 0x92FD, 1);
                backend.updateROMText(absoluteFilename, 0x12, textBoxTreasure6, 0x9312, 1);
                backend.updateROMText(absoluteFilename, 0x5, textBoxTreasure7, 0x9326, 1);
                backend.updateROMText(absoluteFilename, 0x14, textBoxTreasure8, 0x932D, 1);
                backend.updateROMText(absoluteFilename, 0x13, textBoxTreasure9, 0x9343, 1);
                backend.updateROMText(absoluteFilename, 0x15, textBoxTreasure10, 0x9358, 1);
                backend.updateROMText(absoluteFilename, 0x9, textBoxTreasure11, 0x936F, 1);
                backend.updateROMText(absoluteFilename, 0x11, textBoxTreasure12, 0x937A, 1);
                backend.updateROMText(absoluteFilename, 0x13, textBoxTreasure13, 0x938D, 1);
                backend.updateROMText(absoluteFilename, 0x5, textBoxTreasure14, 0x93A2, 1);
                backend.updateROMText(absoluteFilename, 0x11, textBoxTreasure15, 0x93A9, 1);
                backend.updateROMText(absoluteFilename, 0x14, textBoxTreasure16, 0x93BC, 1);
                backend.updateROMText(absoluteFilename, 0x11, textBoxTreasure17, 0x93D2, 1);
                backend.updateROMText(absoluteFilename, 0x12, textBoxTreasure18, 0x93E5, 1);
                backend.updateROMText(absoluteFilename, 0x14, textBoxTreasure19, 0x93F9, 1);
                backend.updateROMText(absoluteFilename, 0x8, textBoxTreasure20, 0x940F, 1);
                backend.updateROMText(absoluteFilename, 0x15, textBoxTreasure21, 0x9419, 1);
                backend.updateROMText(absoluteFilename, 0x14, textBoxTreasure22, 0x9430, 1);
                backend.updateROMText(absoluteFilename, 0x11, textBoxTreasure23, 0x9446, 1);
                backend.updateROMText(absoluteFilename, 0x13, textBoxTreasure24, 0x9459, 1);
                backend.updateROMText(absoluteFilename, 0x3, textBoxTreasure25, 0x946D, 1);
                backend.updateROMText(absoluteFilename, 0x12, textBoxTreasure26, 0x9472, 1);
                backend.updateROMText(absoluteFilename, 0x8, textBoxTreasure27, 0x9486, 1);
                backend.updateROMText(absoluteFilename, 0x18, textBoxTreasure28, 0x9490, 1);
                backend.updateROMText(absoluteFilename, 0x13, textBoxTreasure29, 0x94AA, 1);

                MessageBox.Show("Updated Text!", "The Legend of Zelda Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxTreasure1.MaxLength = 0x12;
            textBoxTreasure2.MaxLength = 0x13;
            textBoxTreasure3.MaxLength = 0x5;
            textBoxTreasure4.MaxLength = 0x12;
            textBoxTreasure5.MaxLength = 0x13;
            textBoxTreasure6.MaxLength = 0x12;
            textBoxTreasure7.MaxLength = 0x5;
            textBoxTreasure8.MaxLength = 0x14;
            textBoxTreasure9.MaxLength = 0x13;
            textBoxTreasure10.MaxLength = 0x15;
            textBoxTreasure11.MaxLength = 0x9;
            textBoxTreasure12.MaxLength = 0x11;
            textBoxTreasure13.MaxLength = 0x13;
            textBoxTreasure14.MaxLength = 0x5;
            textBoxTreasure15.MaxLength = 0x11;
            textBoxTreasure16.MaxLength = 0x14;
            textBoxTreasure17.MaxLength = 0x11;
            textBoxTreasure18.MaxLength = 0x12;
            textBoxTreasure19.MaxLength = 0x14;
            textBoxTreasure20.MaxLength = 0x8;
            textBoxTreasure21.MaxLength = 0x15;
            textBoxTreasure22.MaxLength = 0x14;
            textBoxTreasure23.MaxLength = 0x11;
            textBoxTreasure24.MaxLength = 0x13;
            textBoxTreasure25.MaxLength = 0x3;
            textBoxTreasure26.MaxLength = 0x12;
            textBoxTreasure27.MaxLength = 0x8;
            textBoxTreasure28.MaxLength = 0x18;
            textBoxTreasure29.MaxLength = 0x13;

        }

        private void FormTreasure_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }
    }
}
