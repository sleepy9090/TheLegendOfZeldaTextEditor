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
    public partial class FormHUD : Form {

        string path = "";

        public FormHUD() {
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

                backend.getText(absoluteFilename, textBoxHUD1, 0x8, 0x1A2FD, 1);
                backend.getText(absoluteFilename, textBoxHUD2, 0x9, 0x1A329, 1);
                backend.getText(absoluteFilename, textBoxHUD3, 0xC, 0x1A363, 1);
                backend.getText(absoluteFilename, textBoxHUD4, 0x8, 0x1A373, 1);
                backend.getText(absoluteFilename, textBoxHUD5, 0x7, 0x1A38B, 1);
                backend.getText(absoluteFilename, textBoxHUD6, 0x3, 0x1A395, 1);
                backend.getText(absoluteFilename, textBoxHUD7, 0x8, 0x19D6E, 1);
                backend.getText(absoluteFilename, textBoxHUD8, 0x6, 0x19D17, 1);
                backend.getText(absoluteFilename, textBoxHUD9, 0x1, 0x1A2F8, 1);
                backend.getText(absoluteFilename, textBoxHUD10, 0x1, 0x1A2FB, 1);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x8, textBoxHUD1, 0x1A2FD, 1);
                backend.updateROMText(absoluteFilename, 0x9, textBoxHUD2, 0x1A329, 1);
                backend.updateROMText(absoluteFilename, 0xC, textBoxHUD3, 0x1A363, 1);
                backend.updateROMText(absoluteFilename, 0x8, textBoxHUD4, 0x1A373, 1);
                backend.updateROMText(absoluteFilename, 0x7, textBoxHUD5, 0x1A38B, 1);
                backend.updateROMText(absoluteFilename, 0x3, textBoxHUD6, 0x1A395, 1);
                backend.updateROMText(absoluteFilename, 0x8, textBoxHUD7, 0x19D6E, 1);
                backend.updateROMText(absoluteFilename, 0x6, textBoxHUD8, 0x19D17, 1);
                backend.updateROMText(absoluteFilename, 0x1, textBoxHUD9, 0x1A2F8, 1);
                backend.updateROMText(absoluteFilename, 0x1, textBoxHUD10, 0x1A2FB, 1);

                MessageBox.Show("Updated Text!", "The Legend of Zelda Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxHUD1.MaxLength = 0x8;
            textBoxHUD1.MaxLength = 0x9;
            textBoxHUD1.MaxLength = 0xC;
            textBoxHUD1.MaxLength = 0x8;
            textBoxHUD1.MaxLength = 0x7;
            textBoxHUD1.MaxLength = 0x3;
            textBoxHUD1.MaxLength = 0x8;
            textBoxHUD1.MaxLength = 0x6;
            textBoxHUD1.MaxLength = 0x1;
            textBoxHUD1.MaxLength = 0x1;

        }

        private void FormTreasure_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }
    }
}
