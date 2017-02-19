namespace TheLegendOfZeldaTextEditor {
    partial class FormGameOver {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameOver));
            this.groupBoxGameOver = new System.Windows.Forms.GroupBox();
            this.textBoxGameOver4 = new System.Windows.Forms.TextBox();
            this.textBoxGameOver3 = new System.Windows.Forms.TextBox();
            this.textBoxGameOver2 = new System.Windows.Forms.TextBox();
            this.textBoxGameOver1 = new System.Windows.Forms.TextBox();
            this.buttonUpdateText = new System.Windows.Forms.Button();
            this.groupBoxGameOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGameOver
            // 
            this.groupBoxGameOver.Controls.Add(this.textBoxGameOver4);
            this.groupBoxGameOver.Controls.Add(this.textBoxGameOver3);
            this.groupBoxGameOver.Controls.Add(this.textBoxGameOver2);
            this.groupBoxGameOver.Controls.Add(this.textBoxGameOver1);
            this.groupBoxGameOver.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGameOver.Name = "groupBoxGameOver";
            this.groupBoxGameOver.Size = new System.Drawing.Size(223, 80);
            this.groupBoxGameOver.TabIndex = 0;
            this.groupBoxGameOver.TabStop = false;
            // 
            // textBoxGameOver4
            // 
            this.textBoxGameOver4.Location = new System.Drawing.Point(112, 45);
            this.textBoxGameOver4.Name = "textBoxGameOver4";
            this.textBoxGameOver4.Size = new System.Drawing.Size(100, 20);
            this.textBoxGameOver4.TabIndex = 3;
            // 
            // textBoxGameOver3
            // 
            this.textBoxGameOver3.Location = new System.Drawing.Point(6, 45);
            this.textBoxGameOver3.Name = "textBoxGameOver3";
            this.textBoxGameOver3.Size = new System.Drawing.Size(100, 20);
            this.textBoxGameOver3.TabIndex = 2;
            // 
            // textBoxGameOver2
            // 
            this.textBoxGameOver2.Location = new System.Drawing.Point(112, 19);
            this.textBoxGameOver2.Name = "textBoxGameOver2";
            this.textBoxGameOver2.Size = new System.Drawing.Size(100, 20);
            this.textBoxGameOver2.TabIndex = 1;
            // 
            // textBoxGameOver1
            // 
            this.textBoxGameOver1.Location = new System.Drawing.Point(6, 19);
            this.textBoxGameOver1.Name = "textBoxGameOver1";
            this.textBoxGameOver1.Size = new System.Drawing.Size(100, 20);
            this.textBoxGameOver1.TabIndex = 0;
            // 
            // buttonUpdateText
            // 
            this.buttonUpdateText.Location = new System.Drawing.Point(160, 98);
            this.buttonUpdateText.Name = "buttonUpdateText";
            this.buttonUpdateText.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateText.TabIndex = 1;
            this.buttonUpdateText.Text = "&Update Text";
            this.buttonUpdateText.UseVisualStyleBackColor = true;
            this.buttonUpdateText.Click += new System.EventHandler(this.buttonUpdateText_Click);
            // 
            // FormGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 128);
            this.Controls.Add(this.buttonUpdateText);
            this.Controls.Add(this.groupBoxGameOver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGameOver";
            this.Text = "Game Over";
            this.Load += new System.EventHandler(this.FormTreasure_Load);
            this.groupBoxGameOver.ResumeLayout(false);
            this.groupBoxGameOver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGameOver;
        private System.Windows.Forms.Button buttonUpdateText;
        private System.Windows.Forms.TextBox textBoxGameOver4;
        private System.Windows.Forms.TextBox textBoxGameOver3;
        private System.Windows.Forms.TextBox textBoxGameOver2;
        private System.Windows.Forms.TextBox textBoxGameOver1;
    }
}