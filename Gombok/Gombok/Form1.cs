using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gombok
{
    public partial class Gombok : Form
    {
        public Gombok()
        {
            InitializeComponent();
        }

        private void Ugrik_MouseClick(object sender, MouseEventArgs e)
        {
            int elsoKoor = Int32.Parse(Xmezo.Text);
            int masodikKoor = Int32.Parse(Ymezo.Text);
            //this.Size.Width - LathatatlanSzoveg.Width - 10;

            if (elsoKoor >= 0 && elsoKoor < this.Size.Height - Ugrik.Height - 10 && masodikKoor >= 0 && masodikKoor < this.Size.Height - Ugrik.Height - 10)
            {
                LathatatlanSzoveg.Visible = false;
                Ugrik.Location = new Point(elsoKoor, masodikKoor);
            }
            else
            {
                LathatatlanSzoveg.Visible = true;
            }

            

        }
    }
}
