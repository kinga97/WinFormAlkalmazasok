using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzamolasiAlapok
{
    public partial class SzamolasiAlapok : Form
    {
        public SzamolasiAlapok()
        {
            InitializeComponent();
        }

        private void Szamolas_MouseClick(object sender, MouseEventArgs e)
        {
            double aOldal = Double.Parse(Szoveg1.Text);
            double bOldal = Double.Parse(Szoveg2.Text);

            double c = Math.Sqrt(Math.Pow(aOldal, 2) + Math.Pow(bOldal, 2));
            double kerulet = aOldal + bOldal + c;
            double terulet = aOldal * bOldal / 2;

            string kiiras = $"C-oldal: {c:F2}\nKerület: {kerulet:F2}\nTerület: {terulet:F2}";
            Szoveg3.Text = kiiras;

        }
    }
}
