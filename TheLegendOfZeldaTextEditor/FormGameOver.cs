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
    public partial class FormGameOver : Form {
        string path = "";

        public FormGameOver() {
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

                backend.getText(absoluteFilename, textBoxGameOver1, 0x8, 0x1A2CB, 1);
                backend.getText(absoluteFilename, textBoxGameOver2, 0x4, 0x1A2D6, 1);
                backend.getText(absoluteFilename, textBoxGameOver3, 0x5, 0x1A2DD, 1);
                backend.getText(absoluteFilename, textBoxGameOver4, 0x9, 0x1A3E9, 1);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x8, textBoxGameOver1, 0x1A2CB, 1);
                backend.updateROMText(absoluteFilename, 0x4, textBoxGameOver2, 0x1A2D6, 1);
                backend.updateROMText(absoluteFilename, 0x5, textBoxGameOver3, 0x1A2DD, 1);
                backend.updateROMText(absoluteFilename, 0x9, textBoxGameOver4, 0x1A3E9, 1);

                MessageBox.Show("Updated Text!", "The Legend of Zelda Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxGameOver1.MaxLength = 0x8;
            textBoxGameOver2.MaxLength = 0x4;
            textBoxGameOver3.MaxLength = 0x5;
            textBoxGameOver4.MaxLength = 0x9;

        }

        private void FormTreasure_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }
    }
}
