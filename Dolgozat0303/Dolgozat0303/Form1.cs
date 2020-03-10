using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolgozat0303
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Nevek> lista = new List<Nevek>();
        private void FeltoltBtn_Click(object sender, EventArgs e)
        {
            string tanuloneve = textBox1.Text;
            string igazolt = textBox2.Text;
            string igazolatlan = textBox3.Text;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                Nevek nevek = new Nevek(tanuloneve, igazolt, igazolatlan);
                lista.Add(nevek);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("Valamelyik mező üres!", "Üres mező", MessageBoxButtons.OK);
            }
        }

        private void LekerBtn_Click(object sender, EventArgs e)
        {
            string tanuloneve2 = textBox4.Text;
            for (int i = 0; i < lista.Count; i++)
            {
                if (tanuloneve2 == lista[i].Tanulo)
                {
                    label7.Text = lista[i].Igazolt;
                    label8.Text = lista[i].Igazolatlan;
                }
            }
            
            
        }
    }
}
