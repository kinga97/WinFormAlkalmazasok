namespace MasodikWinForm
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
            this.KekSzin = new System.Windows.Forms.RadioButton();
            this.PirosSzin = new System.Windows.Forms.RadioButton();
            this.ZoldSzin = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NoGomb = new System.Windows.Forms.RadioButton();
            this.FerfiGomb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Jobblabas = new System.Windows.Forms.CheckBox();
            this.Ballabas = new System.Windows.Forms.CheckBox();
            this.Falabu = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // KekSzin
            // 
            this.KekSzin.AutoSize = true;
            this.KekSzin.Location = new System.Drawing.Point(16, 30);
            this.KekSzin.Name = "KekSzin";
            this.KekSzin.Size = new System.Drawing.Size(44, 17);
            this.KekSzin.TabIndex = 0;
            this.KekSzin.Text = "Kék";
            this.KekSzin.UseVisualStyleBackColor = true;
            // 
            // PirosSzin
            // 
            this.PirosSzin.AutoSize = true;
            this.PirosSzin.Location = new System.Drawing.Point(16, 63);
            this.PirosSzin.Name = "PirosSzin";
            this.PirosSzin.Size = new System.Drawing.Size(48, 17);
            this.PirosSzin.TabIndex = 1;
            this.PirosSzin.Text = "Piros";
            this.PirosSzin.UseVisualStyleBackColor = true;
            // 
            // ZoldSzin
            // 
            this.ZoldSzin.AutoSize = true;
            this.ZoldSzin.Location = new System.Drawing.Point(16, 96);
            this.ZoldSzin.Name = "ZoldSzin";
            this.ZoldSzin.Size = new System.Drawing.Size(46, 17);
            this.ZoldSzin.TabIndex = 2;
            this.ZoldSzin.Text = "Zöld";
            this.ZoldSzin.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(346, 148);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 29);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kattints rám";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NoGomb
            // 
            this.NoGomb.AutoSize = true;
            this.NoGomb.Location = new System.Drawing.Point(20, 33);
            this.NoGomb.Name = "NoGomb";
            this.NoGomb.Size = new System.Drawing.Size(64, 17);
            this.NoGomb.TabIndex = 5;
            this.NoGomb.TabStop = true;
            this.NoGomb.Text = "Hölgyek";
            this.NoGomb.UseVisualStyleBackColor = true;
            // 
            // FerfiGomb
            // 
            this.FerfiGomb.AutoSize = true;
            this.FerfiGomb.Location = new System.Drawing.Point(20, 74);
            this.FerfiGomb.Name = "FerfiGomb";
            this.FerfiGomb.Size = new System.Drawing.Size(48, 17);
            this.FerfiGomb.TabIndex = 6;
            this.FerfiGomb.TabStop = true;
            this.FerfiGomb.Text = "Urak";
            this.FerfiGomb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KekSzin);
            this.groupBox1.Controls.Add(this.PirosSzin);
            this.groupBox1.Controls.Add(this.ZoldSzin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 120);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Színek választása";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NoGomb);
            this.groupBox2.Controls.Add(this.FerfiGomb);
            this.groupBox2.Location = new System.Drawing.Point(114, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 107);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nemek";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Falabu);
            this.groupBox3.Controls.Add(this.Ballabas);
            this.groupBox3.Controls.Add(this.Jobblabas);
            this.groupBox3.Location = new System.Drawing.Point(12, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(94, 104);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Jobblabas
            // 
            this.Jobblabas.AutoSize = true;
            this.Jobblabas.Location = new System.Drawing.Point(9, 19);
            this.Jobblabas.Name = "Jobblabas";
            this.Jobblabas.Size = new System.Drawing.Size(74, 17);
            this.Jobblabas.TabIndex = 0;
            this.Jobblabas.Text = "Jobblábas";
            this.Jobblabas.UseVisualStyleBackColor = true;
            // 
            // Ballabas
            // 
            this.Ballabas.AutoSize = true;
            this.Ballabas.Location = new System.Drawing.Point(9, 42);
            this.Ballabas.Name = "Ballabas";
            this.Ballabas.Size = new System.Drawing.Size(66, 17);
            this.Ballabas.TabIndex = 1;
            this.Ballabas.Text = "Ballábas";
            this.Ballabas.UseVisualStyleBackColor = true;
            // 
            // Falabu
            // 
            this.Falabu.AutoSize = true;
            this.Falabu.Location = new System.Drawing.Point(9, 65);
            this.Falabu.Name = "Falabu";
            this.Falabu.Size = new System.Drawing.Size(58, 17);
            this.Falabu.TabIndex = 2;
            this.Falabu.Text = "Falábú";
            this.Falabu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 376);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton KekSzin;
        private System.Windows.Forms.RadioButton PirosSzin;
        private System.Windows.Forms.RadioButton ZoldSzin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton NoGomb;
        private System.Windows.Forms.RadioButton FerfiGomb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox Falabu;
        private System.Windows.Forms.CheckBox Ballabas;
        private System.Windows.Forms.CheckBox Jobblabas;
    }
}

