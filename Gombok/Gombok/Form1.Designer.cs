namespace Gombok
{
    partial class Gombok
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
            this.X = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.LathatatlanSzoveg = new System.Windows.Forms.Label();
            this.Xmezo = new System.Windows.Forms.TextBox();
            this.Ymezo = new System.Windows.Forms.TextBox();
            this.Ugrik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(15, 30);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(17, 13);
            this.X.TabIndex = 0;
            this.X.Text = "X:";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(176, 30);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(17, 13);
            this.Y.TabIndex = 1;
            this.Y.Text = "Y:";
            // 
            // LathatatlanSzoveg
            // 
            this.LathatatlanSzoveg.AutoSize = true;
            this.LathatatlanSzoveg.Location = new System.Drawing.Point(335, 30);
            this.LathatatlanSzoveg.Name = "LathatatlanSzoveg";
            this.LathatatlanSzoveg.Size = new System.Drawing.Size(213, 13);
            this.LathatatlanSzoveg.TabIndex = 2;
            this.LathatatlanSzoveg.Text = "A megadott koordinátákra nem lehet ugrani.";
            this.LathatatlanSzoveg.Visible = false;
            // 
            // Xmezo
            // 
            this.Xmezo.Location = new System.Drawing.Point(56, 27);
            this.Xmezo.Name = "Xmezo";
            this.Xmezo.Size = new System.Drawing.Size(100, 20);
            this.Xmezo.TabIndex = 3;
            // 
            // Ymezo
            // 
            this.Ymezo.Location = new System.Drawing.Point(217, 27);
            this.Ymezo.Name = "Ymezo";
            this.Ymezo.Size = new System.Drawing.Size(100, 20);
            this.Ymezo.TabIndex = 4;
            // 
            // Ugrik
            // 
            this.Ugrik.Location = new System.Drawing.Point(188, 173);
            this.Ugrik.Name = "Ugrik";
            this.Ugrik.Size = new System.Drawing.Size(75, 23);
            this.Ugrik.TabIndex = 5;
            this.Ugrik.Text = "Ugrik";
            this.Ugrik.UseVisualStyleBackColor = true;
            this.Ugrik.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Ugrik_MouseClick);
            // 
            // Gombok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 306);
            this.Controls.Add(this.Ugrik);
            this.Controls.Add(this.Ymezo);
            this.Controls.Add(this.Xmezo);
            this.Controls.Add(this.LathatatlanSzoveg);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Name = "Gombok";
            this.Text = "Gombok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label LathatatlanSzoveg;
        private System.Windows.Forms.TextBox Xmezo;
        private System.Windows.Forms.TextBox Ymezo;
        private System.Windows.Forms.Button Ugrik;
    }
}

