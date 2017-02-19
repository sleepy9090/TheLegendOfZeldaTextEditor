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
    public partial class FormTitle : Form {

        string path = "";

        public FormTitle() {
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

                // Need to use table 4 for the copyright symbol
                //backend.getText(absoluteFilename, textBoxTitle1, 0x17, 0x1AAD3, 1);
                backend.getText(absoluteFilename, textBoxTitle1, 0x9, 0x1AAD3, 1); // Spaces
                backend.getText(absoluteFilename, textBoxTitle1, 0x1, 0x1AADC, 4); // copyright symbol
                backend.getText(absoluteFilename, textBoxTitle1, 0xE, 0x1AADD, 1); // NINTENDO

                backend.getText(absoluteFilename, textBoxTitle2, 0x15, 0x1AB3E, 1);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x17, textBoxTitle1, 0x1AAD3, 1);
                backend.updateROMText(absoluteFilename, 0x15, textBoxTitle2, 0x1AB3E, 1);

                MessageBox.Show("Updated Text!", "The Legend of Zelda Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxTitle1.MaxLength = 0x17;
            textBoxTitle2.MaxLength = 0x15;
        }

        private void FormTitle_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }
    }
}
