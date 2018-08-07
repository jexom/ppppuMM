using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppppuMM
{
    public partial class RTFM : Form
    {
        public RTFM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            if (!(label3.Text == "<- Did you? Answer me") || (!label3.Enabled))
            {
                label3.Enabled = true;
                label3.Text = "<- Did you? Answer me";
                return;
            }
            if(label3.Text == "<- Did you? Answer me" && label3.Enabled)
            {
                label3.Text = "Well read it then";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            if (!(label3.Text == "<- Did you? Answer me") || (!label3.Enabled))
            {
                label3.Enabled = true;
                label3.Text = "Well read it then";
                return;
            }
            if(label3.Text == "<- Did you? Answer me")
            {
                this.Close();
            }
        }
    }
}
