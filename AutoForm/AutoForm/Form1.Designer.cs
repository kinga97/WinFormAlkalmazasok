namespace AutoForm
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
            this.rendszam = new System.Windows.Forms.Label();
            this.marka = new System.Windows.Forms.Label();
            this.tipus = new System.Windows.Forms.Label();
            this.evjarat = new System.Windows.Forms.Label();
            this.uzemanyag = new System.Windows.Forms.Label();
            this.tipusTxt = new System.Windows.Forms.TextBox();
            this.AutoLista = new System.Windows.Forms.ListBox();
            this.evjaratNud = new System.Windows.Forms.NumericUpDown();
            this.markaCb = new System.Windows.Forms.ComboBox();
            this.uzemanyagCb = new System.Windows.Forms.ComboBox();
            this.felveszBtn = new System.Windows.Forms.Button();
            this.listazBtn = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.evjaratNud)).BeginInit();
            this.SuspendLayout();
            // 
            // rendszam
            // 
            this.rendszam.AutoSize = true;
            this.rendszam.Location = new System.Drawing.Point(16, 27);
            this.rendszam.Name = "rendszam";
            this.rendszam.Size = new System.Drawing.Size(60, 13);
            this.rendszam.TabIndex = 0;
            this.rendszam.Text = "Rendszám:";
            // 
            // marka
            // 
            this.marka.AutoSize = true;
            this.marka.Location = new System.Drawing.Point(16, 65);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(40, 13);
            this.marka.TabIndex = 1;
            this.marka.Text = "Márka:";
            // 
            // tipus
            // 
            this.tipus.AutoSize = true;
            this.tipus.Location = new System.Drawing.Point(16, 103);
            this.tipus.Name = "tipus";
            this.tipus.Size = new System.Drawing.Size(38, 13);
            this.tipus.TabIndex = 2;
            this.tipus.Text = "Típus:";
            // 
            // evjarat
            // 
            this.evjarat.AutoSize = true;
            this.evjarat.Location = new System.Drawing.Point(16, 141);
            this.evjarat.Name = "evjarat";
            this.evjarat.Size = new System.Drawing.Size(43, 13);
            this.evjarat.TabIndex = 3;
            this.evjarat.Text = "Évjárat:";
            // 
            // uzemanyag
            // 
            this.uzemanyag.AutoSize = true;
            this.uzemanyag.Location = new System.Drawing.Point(16, 179);
            this.uzemanyag.Name = "uzemanyag";
            this.uzemanyag.Size = new System.Drawing.Size(66, 13);
            this.uzemanyag.TabIndex = 4;
            this.uzemanyag.Text = "Üzemanyag:";
            // 
            // tipusTxt
            // 
            this.tipusTxt.Location = new System.Drawing.Point(82, 101);
            this.tipusTxt.Name = "tipusTxt";
            this.tipusTxt.Size = new System.Drawing.Size(100, 20);
            this.tipusTxt.TabIndex = 6;
            // 
            // AutoLista
            // 
            this.AutoLista.FormattingEnabled = true;
            this.AutoLista.Location = new System.Drawing.Point(312, 12);
            this.AutoLista.Name = "AutoLista";
            this.AutoLista.Size = new System.Drawing.Size(277, 199);
            this.AutoLista.TabIndex = 7;
            // 
            // evjaratNud
            // 
            this.evjaratNud.Location = new System.Drawing.Point(82, 139);
            this.evjaratNud.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.evjaratNud.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.evjaratNud.Name = "evjaratNud";
            this.evjaratNud.Size = new System.Drawing.Size(120, 20);
            this.evjaratNud.TabIndex = 8;
            this.evjaratNud.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // markaCb
            // 
            this.markaCb.FormattingEnabled = true;
            this.markaCb.Items.AddRange(new object[] {
            "Opel",
            "Volkswagen",
            "Fiat",
            "Toyota",
            "Ford",
            "Renault"});
            this.markaCb.Location = new System.Drawing.Point(82, 62);
            this.markaCb.Name = "markaCb";
            this.markaCb.Size = new System.Drawing.Size(121, 21);
            this.markaCb.TabIndex = 9;
            // 
            // uzemanyagCb
            // 
            this.uzemanyagCb.FormattingEnabled = true;
            this.uzemanyagCb.Items.AddRange(new object[] {
            "Benzin",
            "Gázolaj"});
            this.uzemanyagCb.Location = new System.Drawing.Point(82, 177);
            this.uzemanyagCb.Name = "uzemanyagCb";
            this.uzemanyagCb.Size = new System.Drawing.Size(121, 21);
            this.uzemanyagCb.TabIndex = 10;
            // 
            // felveszBtn
            // 
            this.felveszBtn.Location = new System.Drawing.Point(221, 21);
            this.felveszBtn.Name = "felveszBtn";
            this.felveszBtn.Size = new System.Drawing.Size(85, 38);
            this.felveszBtn.TabIndex = 11;
            this.felveszBtn.Text = "Felvesz";
            this.felveszBtn.UseVisualStyleBackColor = true;
            this.felveszBtn.Click += new System.EventHandler(this.felveszBtn_Click);
            // 
            // listazBtn
            // 
            this.listazBtn.Location = new System.Drawing.Point(221, 78);
            this.listazBtn.Name = "listazBtn";
            this.listazBtn.Size = new System.Drawing.Size(85, 38);
            this.listazBtn.TabIndex = 12;
            this.listazBtn.Text = "Listáz";
            this.listazBtn.UseVisualStyleBackColor = true;
            this.listazBtn.Click += new System.EventHandler(this.listazBtn_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(82, 24);
            this.maskedTextBox1.Mask = "AAA-000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 234);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.listazBtn);
            this.Controls.Add(this.felveszBtn);
            this.Controls.Add(this.uzemanyagCb);
            this.Controls.Add(this.markaCb);
            this.Controls.Add(this.evjaratNud);
            this.Controls.Add(this.AutoLista);
            this.Controls.Add(this.tipusTxt);
            this.Controls.Add(this.uzemanyag);
            this.Controls.Add(this.evjarat);
            this.Controls.Add(this.tipus);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.rendszam);
            this.Name = "Form1";
            this.Text = "Autók";
            ((System.ComponentModel.ISupportInitialize)(this.evjaratNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rendszam;
        private System.Windows.Forms.Label marka;
        private System.Windows.Forms.Label tipus;
        private System.Windows.Forms.Label evjarat;
        private System.Windows.Forms.Label uzemanyag;
        private System.Windows.Forms.TextBox tipusTxt;
        private System.Windows.Forms.ListBox AutoLista;
        private System.Windows.Forms.NumericUpDown evjaratNud;
        private System.Windows.Forms.ComboBox markaCb;
        private System.Windows.Forms.ComboBox uzemanyagCb;
        private System.Windows.Forms.Button felveszBtn;
        private System.Windows.Forms.Button listazBtn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

