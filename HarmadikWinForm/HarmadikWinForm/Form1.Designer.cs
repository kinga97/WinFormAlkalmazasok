namespace HarmadikWinForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Felkover = new System.Windows.Forms.CheckBox();
            this.Dolt = new System.Windows.Forms.CheckBox();
            this.Alahuzott = new System.Windows.Forms.CheckBox();
            this.Athuzott = new System.Windows.Forms.CheckBox();
            this.Tizes = new System.Windows.Forms.RadioButton();
            this.Tizenegyes = new System.Windows.Forms.RadioButton();
            this.Tizenkettes = new System.Windows.Forms.RadioButton();
            this.Tizennegyes = new System.Windows.Forms.RadioButton();
            this.Tizenhatos = new System.Windows.Forms.RadioButton();
            this.Tizennyolcas = new System.Windows.Forms.RadioButton();
            this.PirosGomb = new System.Windows.Forms.RadioButton();
            this.KekGomb = new System.Windows.Forms.RadioButton();
            this.FeketeGomb = new System.Windows.Forms.RadioButton();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Felkover);
            this.groupBox1.Controls.Add(this.Dolt);
            this.groupBox1.Controls.Add(this.Alahuzott);
            this.groupBox1.Controls.Add(this.Athuzott);
            this.groupBox1.Location = new System.Drawing.Point(21, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betűtípus";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tizes);
            this.groupBox2.Controls.Add(this.Tizenegyes);
            this.groupBox2.Controls.Add(this.Tizenkettes);
            this.groupBox2.Controls.Add(this.Tizennegyes);
            this.groupBox2.Controls.Add(this.Tizenhatos);
            this.groupBox2.Controls.Add(this.Tizennyolcas);
            this.groupBox2.Location = new System.Drawing.Point(144, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(70, 150);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Betűméret";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FeketeGomb);
            this.panel1.Controls.Add(this.KekGomb);
            this.panel1.Controls.Add(this.PirosGomb);
            this.panel1.Location = new System.Drawing.Point(247, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 119);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Árvíztűrő tükörfúrógép";
            // 
            // Felkover
            // 
            this.Felkover.AutoSize = true;
            this.Felkover.Location = new System.Drawing.Point(6, 19);
            this.Felkover.Name = "Felkover";
            this.Felkover.Size = new System.Drawing.Size(67, 17);
            this.Felkover.TabIndex = 0;
            this.Felkover.Text = "Félkövér";
            this.Felkover.UseVisualStyleBackColor = true;
            this.Felkover.CheckedChanged += new System.EventHandler(this.Felkover_CheckedChanged);
            // 
            // Dolt
            // 
            this.Dolt.AutoSize = true;
            this.Dolt.Location = new System.Drawing.Point(6, 50);
            this.Dolt.Name = "Dolt";
            this.Dolt.Size = new System.Drawing.Size(45, 17);
            this.Dolt.TabIndex = 1;
            this.Dolt.Text = "Dőlt";
            this.Dolt.UseVisualStyleBackColor = true;
            this.Dolt.CheckedChanged += new System.EventHandler(this.Dolt_CheckedChanged);
            // 
            // Alahuzott
            // 
            this.Alahuzott.AutoSize = true;
            this.Alahuzott.Location = new System.Drawing.Point(6, 84);
            this.Alahuzott.Name = "Alahuzott";
            this.Alahuzott.Size = new System.Drawing.Size(70, 17);
            this.Alahuzott.TabIndex = 2;
            this.Alahuzott.Text = "Aláhúzott";
            this.Alahuzott.UseVisualStyleBackColor = true;
            this.Alahuzott.CheckedChanged += new System.EventHandler(this.Alahuzott_CheckedChanged);
            // 
            // Athuzott
            // 
            this.Athuzott.AutoSize = true;
            this.Athuzott.Location = new System.Drawing.Point(6, 116);
            this.Athuzott.Name = "Athuzott";
            this.Athuzott.Size = new System.Drawing.Size(65, 17);
            this.Athuzott.TabIndex = 3;
            this.Athuzott.Text = "Áthúzott";
            this.Athuzott.UseVisualStyleBackColor = true;
            this.Athuzott.CheckedChanged += new System.EventHandler(this.Athuzott_CheckedChanged);
            // 
            // Tizes
            // 
            this.Tizes.AutoSize = true;
            this.Tizes.Location = new System.Drawing.Point(6, 14);
            this.Tizes.Name = "Tizes";
            this.Tizes.Size = new System.Drawing.Size(37, 17);
            this.Tizes.TabIndex = 4;
            this.Tizes.TabStop = true;
            this.Tizes.Text = "10";
            this.Tizes.UseVisualStyleBackColor = true;
            this.Tizes.CheckedChanged += new System.EventHandler(this.Tizes_CheckedChanged);
            // 
            // Tizenegyes
            // 
            this.Tizenegyes.AutoSize = true;
            this.Tizenegyes.Location = new System.Drawing.Point(6, 37);
            this.Tizenegyes.Name = "Tizenegyes";
            this.Tizenegyes.Size = new System.Drawing.Size(37, 17);
            this.Tizenegyes.TabIndex = 5;
            this.Tizenegyes.TabStop = true;
            this.Tizenegyes.Text = "11";
            this.Tizenegyes.UseVisualStyleBackColor = true;
            this.Tizenegyes.CheckedChanged += new System.EventHandler(this.Tizenegyes_CheckedChanged);
            // 
            // Tizenkettes
            // 
            this.Tizenkettes.AutoSize = true;
            this.Tizenkettes.Location = new System.Drawing.Point(6, 60);
            this.Tizenkettes.Name = "Tizenkettes";
            this.Tizenkettes.Size = new System.Drawing.Size(37, 17);
            this.Tizenkettes.TabIndex = 6;
            this.Tizenkettes.TabStop = true;
            this.Tizenkettes.Text = "12";
            this.Tizenkettes.UseVisualStyleBackColor = true;
            this.Tizenkettes.CheckedChanged += new System.EventHandler(this.Tizenkettes_CheckedChanged);
            // 
            // Tizennegyes
            // 
            this.Tizennegyes.AutoSize = true;
            this.Tizennegyes.Location = new System.Drawing.Point(6, 83);
            this.Tizennegyes.Name = "Tizennegyes";
            this.Tizennegyes.Size = new System.Drawing.Size(37, 17);
            this.Tizennegyes.TabIndex = 7;
            this.Tizennegyes.TabStop = true;
            this.Tizennegyes.Text = "14";
            this.Tizennegyes.UseVisualStyleBackColor = true;
            this.Tizennegyes.CheckedChanged += new System.EventHandler(this.Tizennegyes_CheckedChanged);
            // 
            // Tizenhatos
            // 
            this.Tizenhatos.AutoSize = true;
            this.Tizenhatos.Location = new System.Drawing.Point(6, 104);
            this.Tizenhatos.Name = "Tizenhatos";
            this.Tizenhatos.Size = new System.Drawing.Size(37, 17);
            this.Tizenhatos.TabIndex = 8;
            this.Tizenhatos.TabStop = true;
            this.Tizenhatos.Text = "16";
            this.Tizenhatos.UseVisualStyleBackColor = true;
            this.Tizenhatos.CheckedChanged += new System.EventHandler(this.Tizenhatos_CheckedChanged);
            // 
            // Tizennyolcas
            // 
            this.Tizennyolcas.AutoSize = true;
            this.Tizennyolcas.Location = new System.Drawing.Point(6, 127);
            this.Tizennyolcas.Name = "Tizennyolcas";
            this.Tizennyolcas.Size = new System.Drawing.Size(37, 17);
            this.Tizennyolcas.TabIndex = 9;
            this.Tizennyolcas.TabStop = true;
            this.Tizennyolcas.Text = "18";
            this.Tizennyolcas.UseVisualStyleBackColor = true;
            this.Tizennyolcas.CheckedChanged += new System.EventHandler(this.Tizennyolcas_CheckedChanged);
            // 
            // PirosGomb
            // 
            this.PirosGomb.AutoSize = true;
            this.PirosGomb.Location = new System.Drawing.Point(3, 23);
            this.PirosGomb.Name = "PirosGomb";
            this.PirosGomb.Size = new System.Drawing.Size(48, 17);
            this.PirosGomb.TabIndex = 0;
            this.PirosGomb.TabStop = true;
            this.PirosGomb.Text = "Piros";
            this.PirosGomb.UseVisualStyleBackColor = true;
            this.PirosGomb.CheckedChanged += new System.EventHandler(this.PirosGomb_CheckedChanged);
            // 
            // KekGomb
            // 
            this.KekGomb.AutoSize = true;
            this.KekGomb.Location = new System.Drawing.Point(3, 46);
            this.KekGomb.Name = "KekGomb";
            this.KekGomb.Size = new System.Drawing.Size(44, 17);
            this.KekGomb.TabIndex = 1;
            this.KekGomb.TabStop = true;
            this.KekGomb.Text = "Kék";
            this.KekGomb.UseVisualStyleBackColor = true;
            this.KekGomb.CheckedChanged += new System.EventHandler(this.KekGomb_CheckedChanged);
            // 
            // FeketeGomb
            // 
            this.FeketeGomb.AutoSize = true;
            this.FeketeGomb.Location = new System.Drawing.Point(3, 70);
            this.FeketeGomb.Name = "FeketeGomb";
            this.FeketeGomb.Size = new System.Drawing.Size(58, 17);
            this.FeketeGomb.TabIndex = 2;
            this.FeketeGomb.TabStop = true;
            this.FeketeGomb.Text = "Fekete";
            this.FeketeGomb.UseVisualStyleBackColor = true;
            this.FeketeGomb.CheckedChanged += new System.EventHandler(this.FeketeGomb_CheckedChanged);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(72, 234);
            this.hScrollBar1.Maximum = 264;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(135, 21);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(72, 273);
            this.hScrollBar2.Maximum = 264;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(135, 21);
            this.hScrollBar2.TabIndex = 2;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Location = new System.Drawing.Point(72, 308);
            this.hScrollBar3.Maximum = 264;
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(135, 20);
            this.hScrollBar3.TabIndex = 3;
            this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "R:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "G:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "B:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 274);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(210, 308);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(320, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 77);
            this.panel2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 381);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hScrollBar3);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Felkover;
        private System.Windows.Forms.CheckBox Dolt;
        private System.Windows.Forms.CheckBox Alahuzott;
        private System.Windows.Forms.CheckBox Athuzott;
        private System.Windows.Forms.RadioButton Tizes;
        private System.Windows.Forms.RadioButton Tizenegyes;
        private System.Windows.Forms.RadioButton Tizenkettes;
        private System.Windows.Forms.RadioButton Tizennegyes;
        private System.Windows.Forms.RadioButton Tizenhatos;
        private System.Windows.Forms.RadioButton Tizennyolcas;
        private System.Windows.Forms.RadioButton FeketeGomb;
        private System.Windows.Forms.RadioButton KekGomb;
        private System.Windows.Forms.RadioButton PirosGomb;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel2;
    }
}

