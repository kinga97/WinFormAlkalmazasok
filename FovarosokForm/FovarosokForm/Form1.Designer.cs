namespace FovarosokForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.orszag = new System.Windows.Forms.Label();
            this.fovaros = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tippeloBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ujorszagBtn = new System.Windows.Forms.Button();
            this.kilepesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orszag
            // 
            this.orszag.AutoSize = true;
            this.orszag.Location = new System.Drawing.Point(12, 44);
            this.orszag.Name = "orszag";
            this.orszag.Size = new System.Drawing.Size(70, 13);
            this.orszag.TabIndex = 0;
            this.orszag.Text = "Ország neve:";
            // 
            // fovaros
            // 
            this.fovaros.AutoSize = true;
            this.fovaros.Location = new System.Drawing.Point(12, 86);
            this.fovaros.Name = "fovaros";
            this.fovaros.Size = new System.Drawing.Size(80, 13);
            this.fovaros.TabIndex = 1;
            this.fovaros.Text = "Főváros tipped:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // tippeloBtn
            // 
            this.tippeloBtn.Location = new System.Drawing.Point(253, 22);
            this.tippeloBtn.Name = "tippeloBtn";
            this.tippeloBtn.Size = new System.Drawing.Size(75, 23);
            this.tippeloBtn.TabIndex = 4;
            this.tippeloBtn.Text = "Tippelő";
            this.tippeloBtn.UseVisualStyleBackColor = true;
            this.tippeloBtn.Click += new System.EventHandler(this.tippeloBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // ujorszagBtn
            // 
            this.ujorszagBtn.Location = new System.Drawing.Point(253, 70);
            this.ujorszagBtn.Name = "ujorszagBtn";
            this.ujorszagBtn.Size = new System.Drawing.Size(75, 23);
            this.ujorszagBtn.TabIndex = 6;
            this.ujorszagBtn.Text = "Új ország";
            this.ujorszagBtn.UseVisualStyleBackColor = true;
            this.ujorszagBtn.Visible = false;
            this.ujorszagBtn.Click += new System.EventHandler(this.ujorszagBtn_Click);
            // 
            // kilepesBtn
            // 
            this.kilepesBtn.Location = new System.Drawing.Point(253, 118);
            this.kilepesBtn.Name = "kilepesBtn";
            this.kilepesBtn.Size = new System.Drawing.Size(75, 23);
            this.kilepesBtn.TabIndex = 7;
            this.kilepesBtn.Text = "Kilépés";
            this.kilepesBtn.UseVisualStyleBackColor = true;
            this.kilepesBtn.Visible = false;
            this.kilepesBtn.Click += new System.EventHandler(this.kilepesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 360);
            this.Controls.Add(this.kilepesBtn);
            this.Controls.Add(this.ujorszagBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tippeloBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.fovaros);
            this.Controls.Add(this.orszag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orszag;
        private System.Windows.Forms.Label fovaros;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button tippeloBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ujorszagBtn;
        private System.Windows.Forms.Button kilepesBtn;
    }
}

