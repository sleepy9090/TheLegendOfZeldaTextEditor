namespace TheLegendOfZeldaTextEditor {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAbsoluteFilename = new System.Windows.Forms.TextBox();
            this.buttonUpdateText = new System.Windows.Forms.Button();
            this.buttonOpenROM = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleScreenTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hUDTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inGameTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treasuresTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameOverTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.updateTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxStory24 = new System.Windows.Forms.TextBox();
            this.textBoxStory22 = new System.Windows.Forms.TextBox();
            this.textBoxStory20 = new System.Windows.Forms.TextBox();
            this.textBoxStory18 = new System.Windows.Forms.TextBox();
            this.textBoxStory16 = new System.Windows.Forms.TextBox();
            this.textBoxStory14 = new System.Windows.Forms.TextBox();
            this.textBoxStory12 = new System.Windows.Forms.TextBox();
            this.textBoxStory10 = new System.Windows.Forms.TextBox();
            this.textBoxStory8 = new System.Windows.Forms.TextBox();
            this.textBoxStory6 = new System.Windows.Forms.TextBox();
            this.textBoxStory4 = new System.Windows.Forms.TextBox();
            this.textBoxStory2 = new System.Windows.Forms.TextBox();
            this.textBoxStory23 = new System.Windows.Forms.TextBox();
            this.textBoxStory21 = new System.Windows.Forms.TextBox();
            this.textBoxStory19 = new System.Windows.Forms.TextBox();
            this.textBoxStory17 = new System.Windows.Forms.TextBox();
            this.textBoxStory15 = new System.Windows.Forms.TextBox();
            this.textBoxStory13 = new System.Windows.Forms.TextBox();
            this.textBoxStory11 = new System.Windows.Forms.TextBox();
            this.textBoxStory9 = new System.Windows.Forms.TextBox();
            this.textBoxStory7 = new System.Windows.Forms.TextBox();
            this.textBoxStory5 = new System.Windows.Forms.TextBox();
            this.textBoxStory3 = new System.Windows.Forms.TextBox();
            this.textBoxStory1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAbsoluteFilename);
            this.groupBox1.Controls.Add(this.buttonUpdateText);
            this.groupBox1.Controls.Add(this.buttonOpenROM);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBoxAbsoluteFilename
            // 
            this.textBoxAbsoluteFilename.Location = new System.Drawing.Point(6, 19);
            this.textBoxAbsoluteFilename.Name = "textBoxAbsoluteFilename";
            this.textBoxAbsoluteFilename.ReadOnly = true;
            this.textBoxAbsoluteFilename.Size = new System.Drawing.Size(425, 20);
            this.textBoxAbsoluteFilename.TabIndex = 1;
            // 
            // buttonUpdateText
            // 
            this.buttonUpdateText.Enabled = false;
            this.buttonUpdateText.Location = new System.Drawing.Point(518, 17);
            this.buttonUpdateText.Name = "buttonUpdateText";
            this.buttonUpdateText.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateText.TabIndex = 2;
            this.buttonUpdateText.Text = "&Update Text";
            this.buttonUpdateText.UseVisualStyleBackColor = true;
            this.buttonUpdateText.Click += new System.EventHandler(this.buttonUpdateText_Click);
            // 
            // buttonOpenROM
            // 
            this.buttonOpenROM.Location = new System.Drawing.Point(437, 17);
            this.buttonOpenROM.Name = "buttonOpenROM";
            this.buttonOpenROM.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenROM.TabIndex = 0;
            this.buttonOpenROM.Text = "&Open ROM";
            this.buttonOpenROM.UseVisualStyleBackColor = true;
            this.buttonOpenROM.Click += new System.EventHandler(this.buttonOpenROM_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openROMToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openROMToolStripMenuItem
            // 
            this.openROMToolStripMenuItem.Name = "openROMToolStripMenuItem";
            this.openROMToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openROMToolStripMenuItem.Text = "&Open ROM";
            this.openROMToolStripMenuItem.Click += new System.EventHandler(this.openROMToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleScreenTextToolStripMenuItem,
            this.registrationTextToolStripMenuItem,
            this.hUDTextToolStripMenuItem,
            this.inGameTextToolStripMenuItem,
            this.treasuresTextToolStripMenuItem,
            this.gameOverTextToolStripMenuItem,
            this.creditsTextToolStripMenuItem,
            this.toolStripSeparator2,
            this.updateTextToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // titleScreenTextToolStripMenuItem
            // 
            this.titleScreenTextToolStripMenuItem.Enabled = false;
            this.titleScreenTextToolStripMenuItem.Name = "titleScreenTextToolStripMenuItem";
            this.titleScreenTextToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.titleScreenTextToolStripMenuItem.Text = "Title &Screen Text";
            this.titleScreenTextToolStripMenuItem.Click += new System.EventHandler(this.titleScreenTextToolStripMenuItem_Click);
            // 
            // registrationTextToolStripMenuItem
            // 
            this.registrationTextToolStripMenuItem.Enabled = false;
            this.registrationTextToolStripMenuItem.Name = "registrationTextToolStripMenuItem";
            this.registrationTextToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.registrationTextToolStripMenuItem.Text = "&Registration Text";
            this.registrationTextToolStripMenuItem.Click += new System.EventHandler(this.registrationTextToolStripMenuItem_Click);
            // 
            // hUDTextToolStripMenuItem
            // 
            this.hUDTextToolStripMenuItem.Enabled = false;
            this.hUDTextToolStripMenuItem.Name = "hUDTextToolStripMenuItem";
            this.hUDTextToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.hUDTextToolStripMenuItem.Text = "&H.U.D. Text";
            this.hUDTextToolStripMenuItem.Click += new System.EventHandler(this.hUDTextToolStripMenuItem_Click);
            // 
            // inGameTextToolStripMenuItem
            // 
            this.inGameTextToolStripMenuItem.Enabled = false;
            this.inGameTextToolStripMenuItem.Name = "inGameTextToolStripMenuItem";
            this.inGameTextToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.inGameTextToolStripMenuItem.Text = "&In-game Text";
            this.inGameTextToolStripMenuItem.Click += new System.EventHandler(this.inGameTextToolStripMenuItem_Click);
            // 
            // treasuresTextToolStripMenuItem
            // 
            this.treasuresTextToolStripMenuItem.Enabled = false;
            this.treasuresTextToolStripMenuItem.Name = "treasuresTextToolStripMenuItem";
            this.treasuresTextToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.treasuresTextToolStripMenuItem.Text = "&Treasures Text";
            this.treasuresTextToolStripMenuItem.Click += new System.EventHandler(this.treasuresTextToolStripMenuItem_Click);
            // 
            // gameOverTextToolStripMenuItem
            // 
            this.gameOverTextToolStripMenuItem.Enabled = false;
            this.gameOverTextToolStripMenuItem.Name = "gameOverTextToolStripMenuItem";
            this.gameOverTextToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.gameOverTextToolStripMenuItem.Text = "&Game Over Text";
            this.gameOverTextToolStripMenuItem.Click += new System.EventHandler(this.gameOverTextToolStripMenuItem_Click);
            // 
            // creditsTextToolStripMenuItem
            // 
            this.creditsTextToolStripMenuItem.Enabled = false;
            this.creditsTextToolStripMenuItem.Name = "creditsTextToolStripMenuItem";
            this.creditsTextToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.creditsTextToolStripMenuItem.Text = "Ending and &Credits Text";
            this.creditsTextToolStripMenuItem.Click += new System.EventHandler(this.creditsTextToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // updateTextToolStripMenuItem
            // 
            this.updateTextToolStripMenuItem.Enabled = false;
            this.updateTextToolStripMenuItem.Name = "updateTextToolStripMenuItem";
            this.updateTextToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.updateTextToolStripMenuItem.Text = "&Update Text";
            this.updateTextToolStripMenuItem.Click += new System.EventHandler(this.updateTextToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxStory24);
            this.groupBox2.Controls.Add(this.textBoxStory22);
            this.groupBox2.Controls.Add(this.textBoxStory20);
            this.groupBox2.Controls.Add(this.textBoxStory18);
            this.groupBox2.Controls.Add(this.textBoxStory16);
            this.groupBox2.Controls.Add(this.textBoxStory14);
            this.groupBox2.Controls.Add(this.textBoxStory12);
            this.groupBox2.Controls.Add(this.textBoxStory10);
            this.groupBox2.Controls.Add(this.textBoxStory8);
            this.groupBox2.Controls.Add(this.textBoxStory6);
            this.groupBox2.Controls.Add(this.textBoxStory4);
            this.groupBox2.Controls.Add(this.textBoxStory2);
            this.groupBox2.Controls.Add(this.textBoxStory23);
            this.groupBox2.Controls.Add(this.textBoxStory21);
            this.groupBox2.Controls.Add(this.textBoxStory19);
            this.groupBox2.Controls.Add(this.textBoxStory17);
            this.groupBox2.Controls.Add(this.textBoxStory15);
            this.groupBox2.Controls.Add(this.textBoxStory13);
            this.groupBox2.Controls.Add(this.textBoxStory11);
            this.groupBox2.Controls.Add(this.textBoxStory9);
            this.groupBox2.Controls.Add(this.textBoxStory7);
            this.groupBox2.Controls.Add(this.textBoxStory5);
            this.groupBox2.Controls.Add(this.textBoxStory3);
            this.groupBox2.Controls.Add(this.textBoxStory1);
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 344);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // textBoxStory24
            // 
            this.textBoxStory24.Location = new System.Drawing.Point(302, 305);
            this.textBoxStory24.Name = "textBoxStory24";
            this.textBoxStory24.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory24.TabIndex = 24;
            // 
            // textBoxStory22
            // 
            this.textBoxStory22.Location = new System.Drawing.Point(302, 279);
            this.textBoxStory22.Name = "textBoxStory22";
            this.textBoxStory22.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory22.TabIndex = 23;
            // 
            // textBoxStory20
            // 
            this.textBoxStory20.Location = new System.Drawing.Point(302, 253);
            this.textBoxStory20.Name = "textBoxStory20";
            this.textBoxStory20.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory20.TabIndex = 22;
            // 
            // textBoxStory18
            // 
            this.textBoxStory18.Location = new System.Drawing.Point(302, 227);
            this.textBoxStory18.Name = "textBoxStory18";
            this.textBoxStory18.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory18.TabIndex = 21;
            // 
            // textBoxStory16
            // 
            this.textBoxStory16.Location = new System.Drawing.Point(302, 201);
            this.textBoxStory16.Name = "textBoxStory16";
            this.textBoxStory16.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory16.TabIndex = 20;
            // 
            // textBoxStory14
            // 
            this.textBoxStory14.Location = new System.Drawing.Point(302, 175);
            this.textBoxStory14.Name = "textBoxStory14";
            this.textBoxStory14.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory14.TabIndex = 19;
            // 
            // textBoxStory12
            // 
            this.textBoxStory12.Location = new System.Drawing.Point(302, 149);
            this.textBoxStory12.Name = "textBoxStory12";
            this.textBoxStory12.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory12.TabIndex = 18;
            // 
            // textBoxStory10
            // 
            this.textBoxStory10.Location = new System.Drawing.Point(302, 123);
            this.textBoxStory10.Name = "textBoxStory10";
            this.textBoxStory10.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory10.TabIndex = 17;
            // 
            // textBoxStory8
            // 
            this.textBoxStory8.Location = new System.Drawing.Point(302, 97);
            this.textBoxStory8.Name = "textBoxStory8";
            this.textBoxStory8.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory8.TabIndex = 16;
            // 
            // textBoxStory6
            // 
            this.textBoxStory6.Location = new System.Drawing.Point(302, 71);
            this.textBoxStory6.Name = "textBoxStory6";
            this.textBoxStory6.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory6.TabIndex = 15;
            // 
            // textBoxStory4
            // 
            this.textBoxStory4.Location = new System.Drawing.Point(302, 45);
            this.textBoxStory4.Name = "textBoxStory4";
            this.textBoxStory4.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory4.TabIndex = 14;
            // 
            // textBoxStory2
            // 
            this.textBoxStory2.Location = new System.Drawing.Point(302, 19);
            this.textBoxStory2.Name = "textBoxStory2";
            this.textBoxStory2.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory2.TabIndex = 13;
            // 
            // textBoxStory23
            // 
            this.textBoxStory23.Location = new System.Drawing.Point(6, 305);
            this.textBoxStory23.Name = "textBoxStory23";
            this.textBoxStory23.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory23.TabIndex = 12;
            // 
            // textBoxStory21
            // 
            this.textBoxStory21.Location = new System.Drawing.Point(6, 279);
            this.textBoxStory21.Name = "textBoxStory21";
            this.textBoxStory21.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory21.TabIndex = 11;
            // 
            // textBoxStory19
            // 
            this.textBoxStory19.Location = new System.Drawing.Point(6, 253);
            this.textBoxStory19.Name = "textBoxStory19";
            this.textBoxStory19.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory19.TabIndex = 10;
            // 
            // textBoxStory17
            // 
            this.textBoxStory17.Location = new System.Drawing.Point(6, 227);
            this.textBoxStory17.Name = "textBoxStory17";
            this.textBoxStory17.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory17.TabIndex = 9;
            // 
            // textBoxStory15
            // 
            this.textBoxStory15.Location = new System.Drawing.Point(6, 201);
            this.textBoxStory15.Name = "textBoxStory15";
            this.textBoxStory15.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory15.TabIndex = 8;
            // 
            // textBoxStory13
            // 
            this.textBoxStory13.Location = new System.Drawing.Point(6, 175);
            this.textBoxStory13.Name = "textBoxStory13";
            this.textBoxStory13.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory13.TabIndex = 7;
            // 
            // textBoxStory11
            // 
            this.textBoxStory11.Location = new System.Drawing.Point(6, 149);
            this.textBoxStory11.Name = "textBoxStory11";
            this.textBoxStory11.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory11.TabIndex = 6;
            // 
            // textBoxStory9
            // 
            this.textBoxStory9.Location = new System.Drawing.Point(6, 123);
            this.textBoxStory9.Name = "textBoxStory9";
            this.textBoxStory9.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory9.TabIndex = 5;
            // 
            // textBoxStory7
            // 
            this.textBoxStory7.Location = new System.Drawing.Point(6, 97);
            this.textBoxStory7.Name = "textBoxStory7";
            this.textBoxStory7.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory7.TabIndex = 4;
            // 
            // textBoxStory5
            // 
            this.textBoxStory5.Location = new System.Drawing.Point(6, 71);
            this.textBoxStory5.Name = "textBoxStory5";
            this.textBoxStory5.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory5.TabIndex = 3;
            // 
            // textBoxStory3
            // 
            this.textBoxStory3.Location = new System.Drawing.Point(6, 45);
            this.textBoxStory3.Name = "textBoxStory3";
            this.textBoxStory3.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory3.TabIndex = 2;
            // 
            // textBoxStory1
            // 
            this.textBoxStory1.Location = new System.Drawing.Point(6, 19);
            this.textBoxStory1.Name = "textBoxStory1";
            this.textBoxStory1.Size = new System.Drawing.Size(290, 20);
            this.textBoxStory1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "The Legend of Zelda Text Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonUpdateText;
        private System.Windows.Forms.TextBox textBoxAbsoluteFilename;
        private System.Windows.Forms.Button buttonOpenROM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem openROMToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxStory1;
        private System.Windows.Forms.TextBox textBoxStory23;
        private System.Windows.Forms.TextBox textBoxStory21;
        private System.Windows.Forms.TextBox textBoxStory19;
        private System.Windows.Forms.TextBox textBoxStory17;
        private System.Windows.Forms.TextBox textBoxStory15;
        private System.Windows.Forms.TextBox textBoxStory13;
        private System.Windows.Forms.TextBox textBoxStory11;
        private System.Windows.Forms.TextBox textBoxStory9;
        private System.Windows.Forms.TextBox textBoxStory7;
        private System.Windows.Forms.TextBox textBoxStory5;
        private System.Windows.Forms.TextBox textBoxStory3;
        private System.Windows.Forms.TextBox textBoxStory24;
        private System.Windows.Forms.TextBox textBoxStory22;
        private System.Windows.Forms.TextBox textBoxStory20;
        private System.Windows.Forms.TextBox textBoxStory18;
        private System.Windows.Forms.TextBox textBoxStory16;
        private System.Windows.Forms.TextBox textBoxStory14;
        private System.Windows.Forms.TextBox textBoxStory12;
        private System.Windows.Forms.TextBox textBoxStory10;
        private System.Windows.Forms.TextBox textBoxStory8;
        private System.Windows.Forms.TextBox textBoxStory6;
        private System.Windows.Forms.TextBox textBoxStory4;
        private System.Windows.Forms.TextBox textBoxStory2;
        private System.Windows.Forms.ToolStripMenuItem registrationTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inGameTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treasuresTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem updateTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleScreenTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hUDTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameOverTextToolStripMenuItem;
    }
}

