using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtodikWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hozzaad_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            /*
            //Írja ki a szám osztóit a listában
            int bemeno = Int32.Parse(textBox1.Text);
            string masikbemeno = textBox2.Text;
            for (int i = 1; i <= bemeno; i++)
            {
                if (bemeno % i == 0)
                {
                    listBox1.Items.Add(i);
                    //Írja ki a combobox-ban, a számokat ami tartalmazza a masikbemeno értékét
                    if (i.ToString().Contains(masikbemeno))
                    {
                        comboBox1.Items.Add(i);
                    }
                    
                } 
            }
            */

            //Ha a négyzetgyöknél nagyobb az osztó akkor comboboxba menjen, ha kisebb vagy egyenlő akkor a listbox2-be
            int bemeno = Int32.Parse(textBox1.Text);
            int negyzetgyok = (int)Math.Floor(Math.Sqrt(bemeno));
            for (int i = 1; i <= bemeno; i++)
            {
                if (bemeno % i == 0)
                {
                    listBox1.Items.Add(i);
                    if (i <= negyzetgyok)
                    {
                        listBox2.Items.Add(i);
                    }
                    else if (i > negyzetgyok)
                    {
                        comboBox1.Items.Add(i);
                    }
                    
                }
            }

            if (comboBox1.Items.Count == listBox2.Items.Count)
            {
                textBox2.Text = "A szám nem négyzetszám.";
            }
            else
            {
                textBox2.Text = "A szám négyzetszám.";
            }
        }
    }
}
