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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void buttonOpenROM_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open file...";
            ofd.Filter = "nes files (*.nes)|*.nes|All files (*.*)|*.*";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK) {
                textBoxAbsoluteFilename.Text = ofd.FileName;

                clearTextBoxes();
                readRomText();
            }
        }

        private void clearTextBoxes() {
            textBoxStory1.Clear();
            textBoxStory2.Clear();
            textBoxStory3.Clear();
            textBoxStory4.Clear();
            textBoxStory5.Clear();
            textBoxStory6.Clear();
            textBoxStory7.Clear();
            textBoxStory8.Clear();
            textBoxStory9.Clear();
            textBoxStory10.Clear();
            textBoxStory11.Clear();
            textBoxStory12.Clear();
            textBoxStory13.Clear();
            textBoxStory14.Clear();
            textBoxStory15.Clear();
            textBoxStory16.Clear();
            textBoxStory17.Clear();
            textBoxStory18.Clear();
            textBoxStory19.Clear();
            textBoxStory20.Clear();
            textBoxStory21.Clear();
            textBoxStory22.Clear();
            textBoxStory23.Clear();
            textBoxStory24.Clear();
        }

        private void readRomText() {
            try {
                string absoluteFilename = textBoxAbsoluteFilename.Text;

                Backend backend = new Backend();

                // Beginning of story: THE LEGEND OF ZELDA 
                // rest is 26 bytes length, 0x1A
                backend.getText(absoluteFilename, textBoxStory1, 0x15, 0x1A4A2, 1);
                backend.getText(absoluteFilename, textBoxStory2, 0x1A, 0x1A4E6, 1);
                backend.getText(absoluteFilename, textBoxStory3, 0x1A, 0x1A509, 1);
                backend.getText(absoluteFilename, textBoxStory4, 0x1A, 0x1A52C, 1);
                backend.getText(absoluteFilename, textBoxStory5, 0x1A, 0x1A54F, 1);
                backend.getText(absoluteFilename, textBoxStory6, 0x1A, 0x1A572, 1);
                backend.getText(absoluteFilename, textBoxStory7, 0x1A, 0x1A595, 1);
                backend.getText(absoluteFilename, textBoxStory8, 0x1A, 0x1A5B8, 1);
                backend.getText(absoluteFilename, textBoxStory9, 0x1A, 0x1A5DB, 1);
                backend.getText(absoluteFilename, textBoxStory10, 0x1A, 0x1A5FE, 1);
                backend.getText(absoluteFilename, textBoxStory11, 0x1A, 0x1A621, 1);
                backend.getText(absoluteFilename, textBoxStory12, 0x1A, 0x1A644, 1);
                backend.getText(absoluteFilename, textBoxStory13, 0x1A, 0x1A667, 1);
                backend.getText(absoluteFilename, textBoxStory14, 0x1A, 0x1A68A, 1);
                backend.getText(absoluteFilename, textBoxStory15, 0x1A, 0x1A6AD, 1);
                backend.getText(absoluteFilename, textBoxStory16, 0x1A, 0x1A6D0, 1);
                backend.getText(absoluteFilename, textBoxStory17, 0x1A, 0x1A6F3, 1);
                backend.getText(absoluteFilename, textBoxStory18, 0x1A, 0x1A716, 1);
                backend.getText(absoluteFilename, textBoxStory19, 0x1A, 0x1A739, 1);
                backend.getText(absoluteFilename, textBoxStory20, 0x1A, 0x1A75C, 1);
                backend.getText(absoluteFilename, textBoxStory21, 0x1A, 0x1A77F, 1);
                backend.getText(absoluteFilename, textBoxStory22, 0x1A, 0x1A7A2, 1);
                backend.getText(absoluteFilename, textBoxStory23, 0x1A, 0x1A7C5, 1);
                backend.getText(absoluteFilename, textBoxStory24, 0x1A, 0x1A7E8, 1);

                enableButtons();
                enableMenuItems();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enableButtons() {
            buttonUpdateText.Enabled = true;
        }

        private void enableMenuItems() {
            updateTextToolStripMenuItem.Enabled = true;
            registrationTextToolStripMenuItem.Enabled = true;
            inGameTextToolStripMenuItem.Enabled = true;
            treasuresTextToolStripMenuItem.Enabled = true;
            creditsTextToolStripMenuItem.Enabled = true;
            titleScreenTextToolStripMenuItem.Enabled = true;
            gameOverTextToolStripMenuItem.Enabled = true;
            hUDTextToolStripMenuItem.Enabled = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void openROMToolStripMenuItem_Click(object sender, EventArgs e) {
            buttonOpenROM_Click(sender, e);
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {

            try {
                string absoluteFilename = textBoxAbsoluteFilename.Text;
                Backend backend = new Backend();

                // Beginning of story: THE LEGEND OF ZELDA 
                // rest is 26 bytes length, 0x1A
                backend.updateROMText(absoluteFilename, 0x15, textBoxStory1, 0x1A4A2, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory2, 0x1A4E6, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory3, 0x1A509, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory4, 0x1A52C, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory5, 0x1A54F, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory6, 0x1A572, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory7, 0x1A595, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory8, 0x1A5B8, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory9, 0x1A5DB, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory10, 0x1A5FE, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory11, 0x1A621, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory12, 0x1A644, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory13, 0x1A667, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory14, 0x1A68A, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory15, 0x1A6AD, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory16, 0x1A6D0, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory17, 0x1A6F3, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory18, 0x1A716, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory19, 0x1A739, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory20, 0x1A75C, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory21, 0x1A77F, 1);//
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory22, 0x1A7A2, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory23, 0x1A7C5, 1);
                backend.updateROMText(absoluteFilename, 0x1A, textBoxStory24, 0x1A7E8, 1);

                MessageBox.Show("Updated Text!", "The Legend of Zelda Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxStory1.MaxLength = 0x15;
            textBoxStory2.MaxLength = 0x1A;
            textBoxStory3.MaxLength = 0x1A;
            textBoxStory4.MaxLength = 0x1A;
            textBoxStory5.MaxLength = 0x1A;
            textBoxStory6.MaxLength = 0x1A;
            textBoxStory7.MaxLength = 0x1A;
            textBoxStory8.MaxLength = 0x1A;
            textBoxStory9.MaxLength = 0x1A;
            textBoxStory10.MaxLength = 0x1A;
            textBoxStory11.MaxLength = 0x1A;
            textBoxStory12.MaxLength = 0x1A;
            textBoxStory13.MaxLength = 0x1A;
            textBoxStory14.MaxLength = 0x1A;
            textBoxStory15.MaxLength = 0x1A;
            textBoxStory16.MaxLength = 0x1A;
            textBoxStory17.MaxLength = 0x1A;
            textBoxStory18.MaxLength = 0x1A;
            textBoxStory19.MaxLength = 0x1A;
            textBoxStory20.MaxLength = 0x1A;
            textBoxStory21.MaxLength = 0x1A;
            textBoxStory22.MaxLength = 0x1A;
            textBoxStory23.MaxLength = 0x1A;
            textBoxStory24.MaxLength = 0x1A;

        }

        private void Form1_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
        }

        private void inGameTextToolStripMenuItem_Click(object sender, EventArgs e) {
            FormGameText formGameText = new FormGameText();
            formGameText.sendPathToOtherForm = textBoxAbsoluteFilename.Text;
            formGameText.ShowDialog();
        }

        private void updateTextToolStripMenuItem_Click(object sender, EventArgs e) {
            buttonUpdateText_Click(sender, e);
        }

        private void registrationTextToolStripMenuItem_Click(object sender, EventArgs e) {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.sendPathToOtherForm = textBoxAbsoluteFilename.Text;
            formRegistration.ShowDialog();
        }

        private void treasuresTextToolStripMenuItem_Click(object sender, EventArgs e) {
            FormTreasures formTreasures = new FormTreasures();
            formTreasures.sendPathToOtherForm = textBoxAbsoluteFilename.Text;
            formTreasures.ShowDialog();
        }

        private void creditsTextToolStripMenuItem_Click(object sender, EventArgs e) {
            FormEndingAndCredits formCredits = new FormEndingAndCredits();
            formCredits.sendPathToOtherForm = textBoxAbsoluteFilename.Text;
            formCredits.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void titleScreenTextToolStripMenuItem_Click(object sender, EventArgs e) {
            FormTitle formTitle = new FormTitle();
            formTitle.sendPathToOtherForm = textBoxAbsoluteFilename.Text;
            formTitle.ShowDialog();
        }

        private void gameOverTextToolStripMenuItem_Click(object sender, EventArgs e) {
            FormGameOver formGameOver = new FormGameOver();
            formGameOver.sendPathToOtherForm = textBoxAbsoluteFilename.Text;
            formGameOver.ShowDialog();
        }

        private void hUDTextToolStripMenuItem_Click(object sender, EventArgs e) {
            FormHUD formHUD = new FormHUD();
            formHUD.sendPathToOtherForm = textBoxAbsoluteFilename.Text;
            formHUD.ShowDialog();
        }
    }
}
