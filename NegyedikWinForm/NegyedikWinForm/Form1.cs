using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegyedikWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValasztoGomb_Click(object sender, EventArgs e)
        {
            //textBox1.Text = listBox1.SelectedItem.ToString(); //Egy elem kiválasztása esetén
            string kimeno = "";
            foreach (var item in listBox1.SelectedItems)
            {
                //kimeno += item.ToString() + "\r\n"; //Listbox1-be írja ki
                //listBox1.Items.Add(item); //Csak a listbox2-be jelenítse meg
                comboBox1.Items.Add(item);
            }
            textBox1.Text = kimeno;
            
        }

        private void HozzaadGomb_Click(object sender, EventArgs e)
        {
            string hozzaad = textBox2.Text;
            listBox1.Items.Add(hozzaad);
        }
    }
}
