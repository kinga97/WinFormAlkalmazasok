using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolgozat0218
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Utasitas_Click(object sender, EventArgs e)
        {

            
            string szo = SzoMezo.Text;
            int karakterszam = Int32.Parse(KarakterszamMezo.Text);

            

            if (szo.Length < karakterszam || karakterszam <= 0)
            {
                KimenetMezo.Text = "Nincs ilyen helyiérték a szóban.";
            }
            else if (karakterszam == 1)
            {
                
                string elso = szo.Substring(0, 1).ToUpper();
                string masodik = szo.Substring(1);
                string kimenet = elso + masodik;
                KimenetMezo.Text = kimenet;
            }
            else if (karakterszam == szo.Length)
            {
                string elso= szo.Substring(0, szo.Length - 1);
                string masodik = szo.Substring(szo.Length - 1).ToUpper();
                string kimenet = elso + masodik;
                KimenetMezo.Text = kimenet;
            }
            else if (karakterszam > 1 && karakterszam < szo.Length)
            {
                string elso = szo.Substring(0, karakterszam - 1);
                string masodik = szo.Substring(karakterszam - 1, 1).ToUpper();
                string harmadik = szo.Substring(karakterszam);
                string kimenet = elso + masodik + harmadik;
                KimenetMezo.Text = kimenet;
            }

        }
    }
}
