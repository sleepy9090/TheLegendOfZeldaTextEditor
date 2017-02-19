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
    public partial class FormRegistration : Form {

        string path = "";

        public FormRegistration() {
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

                backend.getText(absoluteFilename, textBoxRegistration1, 0x11, 0x9D58, 1);
                backend.getText(absoluteFilename, textBoxRegistration2, 0x12, 0x9D6E, 1);
                backend.getText(absoluteFilename, textBoxRegistration3, 0xF, 0x9DAF, 1);
                backend.getText(absoluteFilename, textBoxRegistration4, 0x29, 0x9DC3, 1);
                backend.getText(absoluteFilename, textBoxRegistration5, 0x5, 0x9EFB, 1);

                // Not sure on this one, the "-" are "62"
                backend.getText(absoluteFilename, textBoxRegistration6, 0xF, 0x1A129, 1);
                //backend.getText(absoluteFilename, textBoxRegistration6, 0x1, 0x1A129, 3); // - S E L E C T -
                //backend.getText(absoluteFilename, textBoxRegistration6, 0xE, 0x1A12A, 1);
                //backend.getText(absoluteFilename, textBoxRegistration6, 0x1, 0x1A138, 3);

                backend.getText(absoluteFilename, textBoxRegistration7, 0x15, 0x1A1B6, 1);
                backend.getText(absoluteFilename, textBoxRegistration8, 0x15, 0x1A1CE, 1);
                backend.getText(absoluteFilename, textBoxRegistration9, 0x15, 0x1A1E6, 1);
                backend.getText(absoluteFilename, textBoxRegistration10, 0x13, 0x1A1FE, 1);
                backend.getText(absoluteFilename, textBoxRegistration11, 0x6, 0x1A15B, 1);
                backend.getText(absoluteFilename, textBoxRegistration12, 0x6, 0x1A164, 1);
                backend.getText(absoluteFilename, textBoxRegistration13, 0x12, 0x1A16D, 1);
                backend.getText(absoluteFilename, textBoxRegistration14, 0x11, 0x1A182, 1);
                backend.getText(absoluteFilename, textBoxRegistration15, 0x8, 0x9D80, 1);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x11, textBoxRegistration1, 0x9D58, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxRegistration2, 0x9D6E, 1);
                backend.updateROMText(absoluteFilename, 0xF, textBoxRegistration3, 0x9DAF, 1);
                backend.updateROMText(absoluteFilename, 0x29, textBoxRegistration4, 0x9DC3, 1);
                backend.updateROMText(absoluteFilename, 0x5, textBoxRegistration5, 0x9EFB, 1);
                backend.updateROMText(absoluteFilename, 0xF, textBoxRegistration6, 0x1A129, 1);
                backend.updateROMText(absoluteFilename, 0x15, textBoxRegistration7, 0x1A1B6, 1);
                backend.updateROMText(absoluteFilename, 0x15, textBoxRegistration8, 0x1A1CE, 1);
                backend.updateROMText(absoluteFilename, 0x15, textBoxRegistration9, 0x1A1E6, 1);
                backend.updateROMText(absoluteFilename, 0x13, textBoxRegistration10, 0x1A1FE, 1);
                backend.updateROMText(absoluteFilename, 0x6, textBoxRegistration11, 0x1A15B, 1);
                backend.updateROMText(absoluteFilename, 0x6, textBoxRegistration12, 0x1A164, 1);
                backend.updateROMText(absoluteFilename, 0x12, textBoxRegistration13, 0x1A16D, 1);
                backend.updateROMText(absoluteFilename, 0x11, textBoxRegistration14, 0x1A182, 1);
                backend.updateROMText(absoluteFilename, 0x8, textBoxRegistration15, 0x9D80, 1);

                MessageBox.Show("Updated Text!", "The Legend of Zelda Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxRegistration1.MaxLength = 0x11;
            textBoxRegistration2.MaxLength = 0x1A;
            textBoxRegistration3.MaxLength = 0xF;
            textBoxRegistration4.MaxLength = 0x29;
            textBoxRegistration5.MaxLength = 0x5;
            textBoxRegistration6.MaxLength = 0xF;
            textBoxRegistration7.MaxLength = 0x15;
            textBoxRegistration8.MaxLength = 0x15;
            textBoxRegistration9.MaxLength = 0x15;
            textBoxRegistration10.MaxLength = 0x13;
            textBoxRegistration11.MaxLength = 0x6;
            textBoxRegistration12.MaxLength = 0x6;
            textBoxRegistration13.MaxLength = 0x12;
            textBoxRegistration14.MaxLength = 0x11;
            textBoxRegistration15.MaxLength = 0x8;
        }

        private void FormRegistration_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }
    }
}
