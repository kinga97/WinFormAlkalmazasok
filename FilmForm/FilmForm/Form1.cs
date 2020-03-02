using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ElemszamNud.Maximum = TopMoziLb.Items.Count;
        }

        private void FelveszBtn_Click(object sender, EventArgs e)
        {
            if (SzovegTxt.Text != "" && EvTxt.Text != "")
            {
                string bevitel = $"{SzovegTxt.Text} ({EvTxt.Text})";
                TopMoziLb.Items.Add(bevitel);
                ElemszamNud.Maximum = TopMoziLb.Items.Count;
                SzovegTxt.Text = "";
                EvTxt.Text = "";
            }
            else if (SzovegTxt.Text == "" && EvTxt.Text == "")
            {
                MessageBox.Show("Mindkét beviteli mező üres!", "Beviteli mező üres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (SzovegTxt.Text == "" && EvTxt.Text != "")
            {
                MessageBox.Show("Szöveg beviteli mező üres!", "Beviteli mező üres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (SzovegTxt.Text != "" && EvTxt.Text == "")
            {
                MessageBox.Show("Év beviteli mező üres!", "Beviteli mező üres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BeszurBtn_Click(object sender, EventArgs e)
        {
            if (SzovegTxt.Text != "" && EvTxt.Text != "" && (int)ElemszamNud.Value != 0)
            {
                string bevitel = $"{SzovegTxt.Text} ({EvTxt.Text})";
                TopMoziLb.Items.Insert((int)ElemszamNud.Value - 1, bevitel);
                ElemszamNud.Maximum = TopMoziLb.Items.Count;
                SzovegTxt.Text = "";
                EvTxt.Text = "";
            }
        }

        private void TorolBtn_Click(object sender, EventArgs e)
        {
            if (TopMoziLb.SelectedIndex != -1)
            {
                TopMoziLb.Items.RemoveAt(TopMoziLb.SelectedIndex);
                ElemszamNud.Maximum = TopMoziLb.Items.Count;
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TorolMindBtn_Click(object sender, EventArgs e)
        {
            TopMoziLb.Items.Clear();
            ElemszamNud.Maximum = TopMoziLb.Items.Count;
        }

        private void AtmasolBtn_Click(object sender, EventArgs e)
        {
            if (TopMoziLb.SelectedIndex != -1)
            {
                if (MoziLatottLb.Items.Contains(TopMoziLb.SelectedItem))
                {
                    MessageBox.Show("A kijelölt elem már szerepel a listában!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MoziLatottLb.Items.Add(TopMoziLb.SelectedItem);
                }  
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtmozgatBtn_Click(object sender, EventArgs e)
        {
            if (TopMoziLb.SelectedIndex != -1)
            {
                MoziLatottLb.Items.Add(TopMoziLb.SelectedItem);
                TopMoziLb.Items.RemoveAt(TopMoziLb.SelectedIndex);
                ElemszamNud.Maximum = TopMoziLb.Items.Count;
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void KeresBtn_Click(object sender, EventArgs e)
        {
            if (SzovegTxt.Text != "")
            {
                int index = TopMoziLb.FindString(SzovegTxt.Text);
                if (index != -1)
                {
                    TopMoziLb.SetSelected(index, true);
                }
            }
        }
    }
}
