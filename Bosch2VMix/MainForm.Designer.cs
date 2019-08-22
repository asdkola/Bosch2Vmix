namespace Bosch2VMix
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vmixHostlabel = new System.Windows.Forms.Label();
            this.vmixHostTextbox = new System.Windows.Forms.TextBox();
            this.vmixPortLabel = new System.Windows.Forms.Label();
            this.vmixPortTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1154, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // vmixHostlabel
            // 
            this.vmixHostlabel.AutoSize = true;
            this.vmixHostlabel.Location = new System.Drawing.Point(41, 53);
            this.vmixHostlabel.Name = "vmixHostlabel";
            this.vmixHostlabel.Size = new System.Drawing.Size(66, 13);
            this.vmixHostlabel.TabIndex = 1;
            this.vmixHostlabel.Text = "VMix host/ip";
            // 
            // vmixHostTextbox
            // 
            this.vmixHostTextbox.Location = new System.Drawing.Point(44, 69);
            this.vmixHostTextbox.MaxLength = 50;
            this.vmixHostTextbox.Name = "vmixHostTextbox";
            this.vmixHostTextbox.Size = new System.Drawing.Size(121, 20);
            this.vmixHostTextbox.TabIndex = 2;
            this.vmixHostTextbox.Text = "127.0.0.1";
            // 
            // vmixPortLabel
            // 
            this.vmixPortLabel.AutoSize = true;
            this.vmixPortLabel.Location = new System.Drawing.Point(172, 53);
            this.vmixPortLabel.Name = "vmixPortLabel";
            this.vmixPortLabel.Size = new System.Drawing.Size(51, 13);
            this.vmixPortLabel.TabIndex = 3;
            this.vmixPortLabel.Text = "VMix port";
            // 
            // vmixPortTextBox
            // 
            this.vmixPortTextBox.Location = new System.Drawing.Point(175, 69);
            this.vmixPortTextBox.MaxLength = 6;
            this.vmixPortTextBox.Name = "vmixPortTextBox";
            this.vmixPortTextBox.Size = new System.Drawing.Size(48, 20);
            this.vmixPortTextBox.TabIndex = 4;
            this.vmixPortTextBox.Text = "8088";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 360);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.vmixPortTextBox);
            this.Controls.Add(this.vmixPortLabel);
            this.Controls.Add(this.vmixHostTextbox);
            this.Controls.Add(this.vmixHostlabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label vmixHostlabel;
        private System.Windows.Forms.Label vmixPortLabel;
        private System.Windows.Forms.TextBox vmixHostTextbox;
        private System.Windows.Forms.TextBox vmixPortTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

