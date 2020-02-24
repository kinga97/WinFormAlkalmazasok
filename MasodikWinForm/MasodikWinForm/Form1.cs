using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasodikWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KekSzin.Checked && NoGomb.Checked)
            {
                textBox1.Text = "A hölgy szeme kék.";
            }
            else if (PirosSzin.Checked && NoGomb.Checked)
            {
                textBox1.Text = "A hölgy szeme piros.";
            }
            else if (ZoldSzin.Checked && NoGomb.Checked)
            {
                textBox1.Text = "A hölgy szeme zöld.";
            }
            else if (KekSzin.Checked && FerfiGomb.Checked)
            {
                textBox1.Text = "Az úr szeme kék.";
            }
            else if (PirosSzin.Checked && FerfiGomb.Checked)
            {
                textBox1.Text = "Az úr szeme piros.";
            }
            else if (ZoldSzin.Checked && FerfiGomb.Checked)
            {
                textBox1.Text = "Az úr szeme zöld.";
            }
        }
    }
}
