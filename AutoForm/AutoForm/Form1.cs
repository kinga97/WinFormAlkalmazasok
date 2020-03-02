using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Auto> lista = new List<Auto>();

        private void felveszBtn_Click(object sender, EventArgs e)
        {
            string rendszam = maskedTextBox1.Text;
            maskedTextBox1.Clear();
            string marka = markaCb.SelectedItem.ToString();
            string tipus = tipusTxt.Text;
            tipusTxt.Text = "";
            int evjarat = (int)evjaratNud.Value;
            string uzemanyag = uzemanyagCb.SelectedItem.ToString();

            Auto auto = new Auto(rendszam, marka, tipus, evjarat, uzemanyag);
            lista.Add(auto);
        }

        private void listazBtn_Click(object sender, EventArgs e)
        {
            AutoLista.Items.Clear();
            foreach (var item in lista)
            {
                AutoLista.Items.Add(item.Kiir());
            }
        }
    }
}
