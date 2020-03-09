using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Snooker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string elsoSor = "";
        List<Versenyzo> versenyzoLista = new List<Versenyzo>();

        private void Form1_Load(object sender, EventArgs e)
        {
            double atlag = 0.0d;
            using (StreamReader sr = new StreamReader("snooker.txt", Encoding.UTF8))
            {
                elsoSor = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    int helyezes = Int32.Parse(sor.Split(';')[0]);
                    string nev = sor.Split(';')[1];
                    string orszag = sor.Split(';')[2];
                    int nyeremeny = Int32.Parse(sor.Split(';')[3]);
                    Versenyzo versenyzo = new Versenyzo(helyezes, nev, orszag, nyeremeny);
                    versenyzoLista.Add(versenyzo);
                    ListViewItem lvi = new ListViewItem(helyezes.ToString());
                    lvi.SubItems.Add(nev);
                    lvi.SubItems.Add(orszag);
                    lvi.SubItems.Add(nyeremeny.ToString());
                    listView1.Items.Add(lvi);
                    //Harmadik megoldás:
                    for (int i = 0; i < elsoSor.Split(';').Length; i++)
                    {
                        listView1.Columns[i].Text = elsoSor.Split(';')[i];
                    }

                    /* //Egyik megoldás:
                    columnHeader0.Text = elsoSor.Split(';')[0];
                    columnHeader1.Text = elsoSor.Split(';')[1];
                    columnHeader2.Text = elsoSor.Split(';')[2];
                    columnHeader3.Text = elsoSor.Split(';')[3];*/
                    /* //Másik megoldás:
                    columnHeader0.Text = "Helyezés";
                    columnHeader1.Text = "Név";
                    columnHeader2.Text = "Ország";
                    columnHeader3.Text = "Nyeremény";*/

                    // 3. feladat
                    textBox1.Text = listView1.Items.Count.ToString();

                    //4. feladat
                    int osszeg = 0;
                    foreach (ListViewItem item in listView1.Items)
                    {
                        osszeg += Int32.Parse(item.SubItems[3].Text);
                    }
                    atlag = (double)osszeg / listView1.Items.Count;
                    textBox2.Text = atlag.ToString();

                    //5. feladat
                    Versenyzo ujVersenyzo = new Versenyzo();
                    int maximumKereset = 0;
                    foreach (var item in versenyzoLista)
                    {
                        if (item.Nyeremeny >= maximumKereset && item.Orszag == "Kína")
                        {
                            maximumKereset = item.Nyeremeny;
                            ujVersenyzo = item;
                        }
                    }
                    textBox3.Text = $"Helyezés: {ujVersenyzo.Helyezes}" +
                                    $"\nNév: {ujVersenyzo.Nev}" +
                                    $"\nOrszág: {ujVersenyzo.Orszag}" +
                                    $"\nNyeremény: {ujVersenyzo.Nyeremeny * 380} Ft";

                    //6. feladat:
                   /* bool norveg = false;
                    foreach (var item in versenyzoLista)
                    {

                    }

                    if (norveg)
                    {
                        label5.Text = "A versenyzők között van norvég versenyző.";
                    }
                    else
                    {
                        label5.Text = "A versenyzők között nincs norvég versenyző.";
                    }*/

                    bool vanE = true;
                    foreach (var item in comboBox1.Items)
                    {
                        if (item.ToString() == orszag)
                        {
                            vanE = false;
                            break;
                        }
                    }
                    if (vanE)
                    {
                        comboBox1.Items.Add(orszag);
                    }

                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[2].Text != comboBox1.SelectedItem.ToString())
                {
                    listView1.Items.Remove(item);
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (Int32.Parse(item.SubItems[3].Text) < 50000)
                {
                    listView1.Items.Remove(item);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int osszeg = Int32.Parse(textBox4.Text);

            foreach (ListViewItem item in listView1.Items)
            {
                if (Int32.Parse(item.SubItems[3].Text) < osszeg)
                {
                    listView1.Items.Remove(item);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int osszeg = Int32.Parse(textBox4.Text);
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[2].Text != comboBox1.SelectedItem.ToString() || Int32.Parse(item.SubItems[3].Text) < osszeg)
                {
                    listView1.Items.Remove(item);
                }
            }
            

        }
    }

}





