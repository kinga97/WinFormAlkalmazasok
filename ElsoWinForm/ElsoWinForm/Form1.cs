using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElsoWinForm
{
    public partial class ChicagoUrlap : Form
    {
        public string belepoSzoveg = "Chicago Űrlap";
        public ChicagoUrlap()
        {
            InitializeComponent();
            
        }

        private void ModositoGomb_Click(object sender, EventArgs e)
        {
            /* string modositandoSzoveg = BeviteliMezo.Text;
             KimenoSzoveg.Text = modositandoSzoveg.ToUpper(); */
            // this.Close();
           // MessageBox.Show("Hello", "Ez egy üdvözlő üzenet", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void ChicagoUrlap_MouseEnter(object sender, EventArgs e)
        {
            this.Text = "Belépett";
            
        }

        private void ChicagoUrlap_MouseLeave(object sender, EventArgs e)
        {
            this.Text = belepoSzoveg;
            
        }

        private void ChicagoUrlap_Load(object sender, EventArgs e)
        {
            this.Text = belepoSzoveg.ToUpper();
        }

        private void ChicagoUrlap_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "Mozgás";
        }

        private void ChicagoUrlap_TextChanged(object sender, EventArgs e)
        {
           /* Random rnd = new Random();

            int szam = rnd.Next(5);
            switch (szam)
            {
                case 0:
                    {
                        this.BackColor = Color.Purple;
                        break;
                    }
                case 1:
                    {
                        this.BackColor = Color.Pink;
                        break;
                    }
                case 2:
                    {
                        this.BackColor = Color.Cornsilk;
                        break;
                    }
                case 3:
                    {
                        this.BackColor = Color.PaleVioletRed
                            ;
                        break;
                    }
                case 4:
                    {
                        this.BackColor = Color.Crimson;
                        break;
                    }
                
            }*/
            
        }

        private void ModositoGomb_MouseEnter(object sender, EventArgs e)
        {
           // ModositoGomb.Visible = false;
        }

        private void ModositoGomb_MouseLeave(object sender, EventArgs e)
        {
           // ModositoGomb.Visible = true;
        }

        private void ModositoGomb_MouseClick(object sender, MouseEventArgs e)
        {
            /* if (ModositoGomb2.Visible)
             {
                 ModositoGomb2.Visible = false;
             }
             else
             {
                 ModositoGomb2.Visible = true;
             }*/
            ModositoGomb2.Visible = !ModositoGomb2.Visible;
        }

        private void ModositoGomb2_MouseClick(object sender, MouseEventArgs e)
        {
            /* if (ModositoGomb.Enable)
             {
                 ModositoGomb.Enable = false;
             }
             else
             {
                 ModositoGomb.Enable = true;
             }*/
            ModositoGomb.Enabled = !ModositoGomb.Enabled;
        }

        private void ModositoGomb3_MouseClick(object sender, MouseEventArgs e)
        {
            ModositoGomb3.Location = new Point(0, 0);

            //this.Close();
        }

        private void ModositoGomb3_MouseEnter(object sender, EventArgs e)
        {
            int szelesseg = this.Size.Width - ModositoGomb3.Width - 10;
            int magassag = this.Size.Height - ModositoGomb3.Height - 10;

            Random rnd = new Random();

            int x = rnd.Next(szelesseg);
            int y = rnd.Next(magassag);
            ModositoGomb3.Location = new Point(x, y);
            

        }
    }
}
