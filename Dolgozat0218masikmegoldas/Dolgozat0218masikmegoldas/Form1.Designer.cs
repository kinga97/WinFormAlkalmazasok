namespace Dolgozat0218masikmegoldas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bemeno = new System.Windows.Forms.Label();
            this.Eleje = new System.Windows.Forms.Label();
            this.Vege = new System.Windows.Forms.Label();
            this.Betucsere = new System.Windows.Forms.Label();
            this.Reszsztringcsere = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.MuveletGomb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bemeno
            // 
            this.Bemeno.AutoSize = true;
            this.Bemeno.Location = new System.Drawing.Point(36, 9);
            this.Bemeno.Name = "Bemeno";
            this.Bemeno.Size = new System.Drawing.Size(68, 13);
            this.Bemeno.TabIndex = 0;
            this.Bemeno.Text = "Bemenő szó:";
            // 
            // Eleje
            // 
            this.Eleje.AutoSize = true;
            this.Eleje.Location = new System.Drawing.Point(36, 61);
            this.Eleje.Name = "Eleje";
            this.Eleje.Size = new System.Drawing.Size(30, 13);
            this.Eleje.TabIndex = 1;
            this.Eleje.Text = "Eleje";
            // 
            // Vege
            // 
            this.Vege.AutoSize = true;
            this.Vege.Location = new System.Drawing.Point(36, 117);
            this.Vege.Name = "Vege";
            this.Vege.Size = new System.Drawing.Size(32, 13);
            this.Vege.TabIndex = 2;
            this.Vege.Text = "Vége";
            // 
            // Betucsere
            // 
            this.Betucsere.AutoSize = true;
            this.Betucsere.Location = new System.Drawing.Point(36, 169);
            this.Betucsere.Name = "Betucsere";
            this.Betucsere.Size = new System.Drawing.Size(55, 13);
            this.Betucsere.TabIndex = 3;
            this.Betucsere.Text = "Betűcsere";
            // 
            // Reszsztringcsere
            // 
            this.Reszsztringcsere.AutoSize = true;
            this.Reszsztringcsere.Location = new System.Drawing.Point(36, 223);
            this.Reszsztringcsere.Name = "Reszsztringcsere";
            this.Reszsztringcsere.Size = new System.Drawing.Size(90, 13);
            this.Reszsztringcsere.TabIndex = 4;
            this.Reszsztringcsere.Text = "Részsztring csere";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(145, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(221, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(145, 216);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(221, 20);
            this.textBox5.TabIndex = 9;
            // 
            // MuveletGomb
            // 
            this.MuveletGomb.Location = new System.Drawing.Point(319, 107);
            this.MuveletGomb.Name = "MuveletGomb";
            this.MuveletGomb.Size = new System.Drawing.Size(75, 23);
            this.MuveletGomb.TabIndex = 10;
            this.MuveletGomb.Text = "Művelet";
            this.MuveletGomb.UseVisualStyleBackColor = true;
            this.MuveletGomb.Click += new System.EventHandler(this.MuveletGomb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 391);
            this.Controls.Add(this.MuveletGomb);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Reszsztringcsere);
            this.Controls.Add(this.Betucsere);
            this.Controls.Add(this.Vege);
            this.Controls.Add(this.Eleje);
            this.Controls.Add(this.Bemeno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bemeno;
        private System.Windows.Forms.Label Eleje;
        private System.Windows.Forms.Label Vege;
        private System.Windows.Forms.Label Betucsere;
        private System.Windows.Forms.Label Reszsztringcsere;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button MuveletGomb;
    }
}

