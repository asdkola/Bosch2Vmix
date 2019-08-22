using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bosch2VMix
{
    public partial class MainForm : Form
    {

        private static VMixWrapper vmix = new VMixWrapper();

        public MainForm()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            VMixWrapper vmix = new VMixWrapper(this.vmixHostTextbox.Text, this.vmixPortTextBox.Text);
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string VmixHost
        {
            get { return this.vmixHostTextbox.Text; }
            set { this.vmixHostTextbox.Text = value; }
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            vmix.UpdateHost(this.vmixHostTextbox.Text, this.vmixPortTextBox.Text);
            await vmix.GetXml(vmix.GetUri());

            vmix.UpdateXml();
        }
    }
}
