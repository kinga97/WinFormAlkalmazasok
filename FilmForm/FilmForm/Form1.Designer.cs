namespace FilmForm
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
            this.TopMoziLb = new System.Windows.Forms.ListBox();
            this.MoziLatottLb = new System.Windows.Forms.ListBox();
            this.SzovegTxt = new System.Windows.Forms.TextBox();
            this.ElemszamNud = new System.Windows.Forms.NumericUpDown();
            this.FelveszBtn = new System.Windows.Forms.Button();
            this.BeszurBtn = new System.Windows.Forms.Button();
            this.TorolBtn = new System.Windows.Forms.Button();
            this.TorolMindBtn = new System.Windows.Forms.Button();
            this.AtmasolBtn = new System.Windows.Forms.Button();
            this.AtmozgatBtn = new System.Windows.Forms.Button();
            this.KeresBtn = new System.Windows.Forms.Button();
            this.EvTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ElemszamNud)).BeginInit();
            this.SuspendLayout();
            // 
            // TopMoziLb
            // 
            this.TopMoziLb.FormattingEnabled = true;
            this.TopMoziLb.Location = new System.Drawing.Point(12, 67);
            this.TopMoziLb.Name = "TopMoziLb";
            this.TopMoziLb.Size = new System.Drawing.Size(155, 251);
            this.TopMoziLb.TabIndex = 0;
            // 
            // MoziLatottLb
            // 
            this.MoziLatottLb.FormattingEnabled = true;
            this.MoziLatottLb.Location = new System.Drawing.Point(275, 69);
            this.MoziLatottLb.Name = "MoziLatottLb";
            this.MoziLatottLb.Size = new System.Drawing.Size(165, 251);
            this.MoziLatottLb.TabIndex = 1;
            // 
            // SzovegTxt
            // 
            this.SzovegTxt.Location = new System.Drawing.Point(12, 21);
            this.SzovegTxt.Multiline = true;
            this.SzovegTxt.Name = "SzovegTxt";
            this.SzovegTxt.Size = new System.Drawing.Size(141, 20);
            this.SzovegTxt.TabIndex = 2;
            // 
            // ElemszamNud
            // 
            this.ElemszamNud.Location = new System.Drawing.Point(225, 21);
            this.ElemszamNud.Name = "ElemszamNud";
            this.ElemszamNud.Size = new System.Drawing.Size(120, 20);
            this.ElemszamNud.TabIndex = 3;
            this.ElemszamNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FelveszBtn
            // 
            this.FelveszBtn.Location = new System.Drawing.Point(185, 69);
            this.FelveszBtn.Name = "FelveszBtn";
            this.FelveszBtn.Size = new System.Drawing.Size(75, 23);
            this.FelveszBtn.TabIndex = 4;
            this.FelveszBtn.Text = "Felvesz";
            this.FelveszBtn.UseVisualStyleBackColor = true;
            this.FelveszBtn.Click += new System.EventHandler(this.FelveszBtn_Click);
            // 
            // BeszurBtn
            // 
            this.BeszurBtn.Location = new System.Drawing.Point(185, 109);
            this.BeszurBtn.Name = "BeszurBtn";
            this.BeszurBtn.Size = new System.Drawing.Size(75, 23);
            this.BeszurBtn.TabIndex = 5;
            this.BeszurBtn.Text = "Beszúr";
            this.BeszurBtn.UseVisualStyleBackColor = true;
            this.BeszurBtn.Click += new System.EventHandler(this.BeszurBtn_Click);
            // 
            // TorolBtn
            // 
            this.TorolBtn.Location = new System.Drawing.Point(185, 145);
            this.TorolBtn.Name = "TorolBtn";
            this.TorolBtn.Size = new System.Drawing.Size(75, 23);
            this.TorolBtn.TabIndex = 6;
            this.TorolBtn.Text = "Töröl";
            this.TorolBtn.UseVisualStyleBackColor = true;
            this.TorolBtn.Click += new System.EventHandler(this.TorolBtn_Click);
            // 
            // TorolMindBtn
            // 
            this.TorolMindBtn.Location = new System.Drawing.Point(185, 183);
            this.TorolMindBtn.Name = "TorolMindBtn";
            this.TorolMindBtn.Size = new System.Drawing.Size(75, 23);
            this.TorolMindBtn.TabIndex = 7;
            this.TorolMindBtn.Text = "Töröl mind";
            this.TorolMindBtn.UseVisualStyleBackColor = true;
            this.TorolMindBtn.Click += new System.EventHandler(this.TorolMindBtn_Click);
            // 
            // AtmasolBtn
            // 
            this.AtmasolBtn.Location = new System.Drawing.Point(185, 217);
            this.AtmasolBtn.Name = "AtmasolBtn";
            this.AtmasolBtn.Size = new System.Drawing.Size(75, 23);
            this.AtmasolBtn.TabIndex = 8;
            this.AtmasolBtn.Text = "Átmásol";
            this.AtmasolBtn.UseVisualStyleBackColor = true;
            this.AtmasolBtn.Click += new System.EventHandler(this.AtmasolBtn_Click);
            // 
            // AtmozgatBtn
            // 
            this.AtmozgatBtn.Location = new System.Drawing.Point(185, 256);
            this.AtmozgatBtn.Name = "AtmozgatBtn";
            this.AtmozgatBtn.Size = new System.Drawing.Size(75, 23);
            this.AtmozgatBtn.TabIndex = 9;
            this.AtmozgatBtn.Text = "Átmozgat";
            this.AtmozgatBtn.UseVisualStyleBackColor = true;
            this.AtmozgatBtn.Click += new System.EventHandler(this.AtmozgatBtn_Click);
            // 
            // KeresBtn
            // 
            this.KeresBtn.Location = new System.Drawing.Point(185, 294);
            this.KeresBtn.Name = "KeresBtn";
            this.KeresBtn.Size = new System.Drawing.Size(75, 23);
            this.KeresBtn.TabIndex = 10;
            this.KeresBtn.Text = "Keres";
            this.KeresBtn.UseVisualStyleBackColor = true;
            this.KeresBtn.Click += new System.EventHandler(this.KeresBtn_Click);
            // 
            // EvTxt
            // 
            this.EvTxt.Location = new System.Drawing.Point(159, 21);
            this.EvTxt.Name = "EvTxt";
            this.EvTxt.Size = new System.Drawing.Size(60, 20);
            this.EvTxt.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 342);
            this.Controls.Add(this.EvTxt);
            this.Controls.Add(this.KeresBtn);
            this.Controls.Add(this.AtmozgatBtn);
            this.Controls.Add(this.AtmasolBtn);
            this.Controls.Add(this.TorolMindBtn);
            this.Controls.Add(this.TorolBtn);
            this.Controls.Add(this.BeszurBtn);
            this.Controls.Add(this.FelveszBtn);
            this.Controls.Add(this.ElemszamNud);
            this.Controls.Add(this.SzovegTxt);
            this.Controls.Add(this.MoziLatottLb);
            this.Controls.Add(this.TopMoziLb);
            this.Name = "Form1";
            this.Text = "Filmlista";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ElemszamNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TopMoziLb;
        private System.Windows.Forms.ListBox MoziLatottLb;
        private System.Windows.Forms.TextBox SzovegTxt;
        private System.Windows.Forms.NumericUpDown ElemszamNud;
        private System.Windows.Forms.Button FelveszBtn;
        private System.Windows.Forms.Button BeszurBtn;
        private System.Windows.Forms.Button TorolBtn;
        private System.Windows.Forms.Button TorolMindBtn;
        private System.Windows.Forms.Button AtmasolBtn;
        private System.Windows.Forms.Button AtmozgatBtn;
        private System.Windows.Forms.Button KeresBtn;
        private System.Windows.Forms.TextBox EvTxt;
    }
}

