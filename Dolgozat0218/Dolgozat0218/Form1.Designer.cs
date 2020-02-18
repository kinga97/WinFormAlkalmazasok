namespace Dolgozat0218
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
            this.Szo = new System.Windows.Forms.Label();
            this.Karakterszam = new System.Windows.Forms.Label();
            this.Kimenet = new System.Windows.Forms.Label();
            this.SzoMezo = new System.Windows.Forms.TextBox();
            this.KarakterszamMezo = new System.Windows.Forms.TextBox();
            this.KimenetMezo = new System.Windows.Forms.TextBox();
            this.Utasitas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Szo
            // 
            this.Szo.AutoSize = true;
            this.Szo.Location = new System.Drawing.Point(12, 19);
            this.Szo.Name = "Szo";
            this.Szo.Size = new System.Drawing.Size(28, 13);
            this.Szo.TabIndex = 0;
            this.Szo.Text = "Szó:";
            // 
            // Karakterszam
            // 
            this.Karakterszam.AutoSize = true;
            this.Karakterszam.Location = new System.Drawing.Point(12, 65);
            this.Karakterszam.Name = "Karakterszam";
            this.Karakterszam.Size = new System.Drawing.Size(74, 13);
            this.Karakterszam.TabIndex = 1;
            this.Karakterszam.Text = "Karakterszám:";
            // 
            // Kimenet
            // 
            this.Kimenet.AutoSize = true;
            this.Kimenet.Location = new System.Drawing.Point(12, 119);
            this.Kimenet.Name = "Kimenet";
            this.Kimenet.Size = new System.Drawing.Size(48, 13);
            this.Kimenet.TabIndex = 2;
            this.Kimenet.Text = "Kimenet:";
            // 
            // SzoMezo
            // 
            this.SzoMezo.Location = new System.Drawing.Point(91, 12);
            this.SzoMezo.Multiline = true;
            this.SzoMezo.Name = "SzoMezo";
            this.SzoMezo.Size = new System.Drawing.Size(100, 20);
            this.SzoMezo.TabIndex = 3;
            // 
            // KarakterszamMezo
            // 
            this.KarakterszamMezo.Location = new System.Drawing.Point(91, 62);
            this.KarakterszamMezo.Name = "KarakterszamMezo";
            this.KarakterszamMezo.Size = new System.Drawing.Size(100, 20);
            this.KarakterszamMezo.TabIndex = 4;
            // 
            // KimenetMezo
            // 
            this.KimenetMezo.Location = new System.Drawing.Point(91, 112);
            this.KimenetMezo.Multiline = true;
            this.KimenetMezo.Name = "KimenetMezo";
            this.KimenetMezo.Size = new System.Drawing.Size(100, 61);
            this.KimenetMezo.TabIndex = 5;
            // 
            // Utasitas
            // 
            this.Utasitas.Location = new System.Drawing.Point(295, 65);
            this.Utasitas.Name = "Utasitas";
            this.Utasitas.Size = new System.Drawing.Size(75, 23);
            this.Utasitas.TabIndex = 6;
            this.Utasitas.Text = "Utasítás";
            this.Utasitas.UseVisualStyleBackColor = true;
            this.Utasitas.Click += new System.EventHandler(this.Utasitas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 413);
            this.Controls.Add(this.Utasitas);
            this.Controls.Add(this.KimenetMezo);
            this.Controls.Add(this.KarakterszamMezo);
            this.Controls.Add(this.SzoMezo);
            this.Controls.Add(this.Kimenet);
            this.Controls.Add(this.Karakterszam);
            this.Controls.Add(this.Szo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Szo;
        private System.Windows.Forms.Label Karakterszam;
        private System.Windows.Forms.Label Kimenet;
        private System.Windows.Forms.TextBox SzoMezo;
        private System.Windows.Forms.TextBox KarakterszamMezo;
        private System.Windows.Forms.TextBox KimenetMezo;
        private System.Windows.Forms.Button Utasitas;
    }
}

