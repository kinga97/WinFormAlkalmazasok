namespace ElsoWinForm
{
    partial class ChicagoUrlap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChicagoUrlap));
            this.Szoveg = new System.Windows.Forms.Label();
            this.BeviteliMezo = new System.Windows.Forms.TextBox();
            this.ModositoGomb = new System.Windows.Forms.Button();
            this.KimenoSzoveg = new System.Windows.Forms.TextBox();
            this.ModositoGomb2 = new System.Windows.Forms.Button();
            this.ModositoGomb3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Szoveg
            // 
            this.Szoveg.AutoSize = true;
            this.Szoveg.BackColor = System.Drawing.Color.White;
            this.Szoveg.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Szoveg.ForeColor = System.Drawing.Color.Crimson;
            this.Szoveg.Location = new System.Drawing.Point(48, 47);
            this.Szoveg.Name = "Szoveg";
            this.Szoveg.Size = new System.Drawing.Size(56, 20);
            this.Szoveg.TabIndex = 0;
            this.Szoveg.Text = "Szöveg";
            // 
            // BeviteliMezo
            // 
            this.BeviteliMezo.Location = new System.Drawing.Point(158, 47);
            this.BeviteliMezo.Multiline = true;
            this.BeviteliMezo.Name = "BeviteliMezo";
            this.BeviteliMezo.Size = new System.Drawing.Size(100, 20);
            this.BeviteliMezo.TabIndex = 1;
            // 
            // ModositoGomb
            // 
            this.ModositoGomb.BackColor = System.Drawing.Color.LightPink;
            this.ModositoGomb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModositoGomb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ModositoGomb.ForeColor = System.Drawing.Color.Crimson;
            this.ModositoGomb.Location = new System.Drawing.Point(301, 3);
            this.ModositoGomb.Name = "ModositoGomb";
            this.ModositoGomb.Size = new System.Drawing.Size(78, 48);
            this.ModositoGomb.TabIndex = 2;
            this.ModositoGomb.Text = "Módosító gomb";
            this.ModositoGomb.UseVisualStyleBackColor = false;
            this.ModositoGomb.Click += new System.EventHandler(this.ModositoGomb_Click);
            this.ModositoGomb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModositoGomb_MouseClick);
            this.ModositoGomb.MouseEnter += new System.EventHandler(this.ModositoGomb_MouseEnter);
            this.ModositoGomb.MouseLeave += new System.EventHandler(this.ModositoGomb_MouseLeave);
            // 
            // KimenoSzoveg
            // 
            this.KimenoSzoveg.Location = new System.Drawing.Point(158, 83);
            this.KimenoSzoveg.Name = "KimenoSzoveg";
            this.KimenoSzoveg.Size = new System.Drawing.Size(100, 20);
            this.KimenoSzoveg.TabIndex = 3;
            // 
            // ModositoGomb2
            // 
            this.ModositoGomb2.BackColor = System.Drawing.Color.LightPink;
            this.ModositoGomb2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ModositoGomb2.ForeColor = System.Drawing.Color.Crimson;
            this.ModositoGomb2.Location = new System.Drawing.Point(301, 66);
            this.ModositoGomb2.Name = "ModositoGomb2";
            this.ModositoGomb2.Size = new System.Drawing.Size(78, 50);
            this.ModositoGomb2.TabIndex = 4;
            this.ModositoGomb2.Text = "Második gomb";
            this.ModositoGomb2.UseVisualStyleBackColor = false;
            this.ModositoGomb2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModositoGomb2_MouseClick);
            // 
            // ModositoGomb3
            // 
            this.ModositoGomb3.BackColor = System.Drawing.Color.LightPink;
            this.ModositoGomb3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ModositoGomb3.ForeColor = System.Drawing.Color.Crimson;
            this.ModositoGomb3.Location = new System.Drawing.Point(301, 138);
            this.ModositoGomb3.Name = "ModositoGomb3";
            this.ModositoGomb3.Size = new System.Drawing.Size(78, 50);
            this.ModositoGomb3.TabIndex = 5;
            this.ModositoGomb3.Text = "Harmadik gomb";
            this.ModositoGomb3.UseVisualStyleBackColor = false;
            this.ModositoGomb3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModositoGomb3_MouseClick);
            this.ModositoGomb3.MouseEnter += new System.EventHandler(this.ModositoGomb3_MouseEnter);
            // 
            // ChicagoUrlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 243);
            this.Controls.Add(this.ModositoGomb3);
            this.Controls.Add(this.ModositoGomb2);
            this.Controls.Add(this.KimenoSzoveg);
            this.Controls.Add(this.ModositoGomb);
            this.Controls.Add(this.BeviteliMezo);
            this.Controls.Add(this.Szoveg);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "ChicagoUrlap";
            this.Text = "Chicago Űrlap";
            this.Load += new System.EventHandler(this.ChicagoUrlap_Load);
            this.TextChanged += new System.EventHandler(this.ChicagoUrlap_TextChanged);
            this.MouseEnter += new System.EventHandler(this.ChicagoUrlap_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ChicagoUrlap_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChicagoUrlap_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Szoveg;
        private System.Windows.Forms.TextBox BeviteliMezo;
        private System.Windows.Forms.Button ModositoGomb;
        private System.Windows.Forms.TextBox KimenoSzoveg;
        private System.Windows.Forms.Button ModositoGomb2;
        private System.Windows.Forms.Button ModositoGomb3;
    }
}

