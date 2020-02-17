namespace SzamolasiAlapok
{
    partial class SzamolasiAlapok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SzamolasiAlapok));
            this.Aoldal = new System.Windows.Forms.Label();
            this.Szoveg1 = new System.Windows.Forms.TextBox();
            this.Boldal = new System.Windows.Forms.Label();
            this.Szoveg2 = new System.Windows.Forms.TextBox();
            this.Eredmenyek = new System.Windows.Forms.Label();
            this.Szoveg3 = new System.Windows.Forms.TextBox();
            this.Szamolas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Aoldal
            // 
            this.Aoldal.AutoSize = true;
            this.Aoldal.Location = new System.Drawing.Point(45, 38);
            this.Aoldal.Name = "Aoldal";
            this.Aoldal.Size = new System.Drawing.Size(42, 13);
            this.Aoldal.TabIndex = 0;
            this.Aoldal.Text = "A-oldal:";
            // 
            // Szoveg1
            // 
            this.Szoveg1.Location = new System.Drawing.Point(168, 38);
            this.Szoveg1.Multiline = true;
            this.Szoveg1.Name = "Szoveg1";
            this.Szoveg1.Size = new System.Drawing.Size(100, 20);
            this.Szoveg1.TabIndex = 1;
            // 
            // Boldal
            // 
            this.Boldal.AutoSize = true;
            this.Boldal.Location = new System.Drawing.Point(45, 81);
            this.Boldal.Name = "Boldal";
            this.Boldal.Size = new System.Drawing.Size(42, 13);
            this.Boldal.TabIndex = 2;
            this.Boldal.Text = "B-oldal:";
            // 
            // Szoveg2
            // 
            this.Szoveg2.Location = new System.Drawing.Point(168, 74);
            this.Szoveg2.Multiline = true;
            this.Szoveg2.Name = "Szoveg2";
            this.Szoveg2.Size = new System.Drawing.Size(100, 20);
            this.Szoveg2.TabIndex = 3;
            // 
            // Eredmenyek
            // 
            this.Eredmenyek.AutoSize = true;
            this.Eredmenyek.Location = new System.Drawing.Point(45, 135);
            this.Eredmenyek.Name = "Eredmenyek";
            this.Eredmenyek.Size = new System.Drawing.Size(69, 13);
            this.Eredmenyek.TabIndex = 4;
            this.Eredmenyek.Text = "Eredmények:";
            // 
            // Szoveg3
            // 
            this.Szoveg3.Location = new System.Drawing.Point(168, 128);
            this.Szoveg3.Multiline = true;
            this.Szoveg3.Name = "Szoveg3";
            this.Szoveg3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Szoveg3.Size = new System.Drawing.Size(100, 63);
            this.Szoveg3.TabIndex = 5;
            // 
            // Szamolas
            // 
            this.Szamolas.Location = new System.Drawing.Point(320, 55);
            this.Szamolas.Name = "Szamolas";
            this.Szamolas.Size = new System.Drawing.Size(75, 23);
            this.Szamolas.TabIndex = 6;
            this.Szamolas.Text = "Számolás";
            this.Szamolas.UseVisualStyleBackColor = true;
            this.Szamolas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Szamolas_MouseClick);
            // 
            // SzamolasiAlapok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 292);
            this.Controls.Add(this.Szamolas);
            this.Controls.Add(this.Szoveg3);
            this.Controls.Add(this.Eredmenyek);
            this.Controls.Add(this.Szoveg2);
            this.Controls.Add(this.Boldal);
            this.Controls.Add(this.Szoveg1);
            this.Controls.Add(this.Aoldal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SzamolasiAlapok";
            this.Text = "Számolási Alapok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Aoldal;
        private System.Windows.Forms.TextBox Szoveg1;
        private System.Windows.Forms.Label Boldal;
        private System.Windows.Forms.TextBox Szoveg2;
        private System.Windows.Forms.Label Eredmenyek;
        private System.Windows.Forms.TextBox Szoveg3;
        private System.Windows.Forms.Button Szamolas;
    }
}

