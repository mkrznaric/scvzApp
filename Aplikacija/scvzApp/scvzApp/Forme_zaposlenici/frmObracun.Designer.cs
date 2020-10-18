namespace scvzApp.Forme_zaposlenici
{
    partial class frmObracun
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbZaposlenik = new System.Windows.Forms.ComboBox();
            this.cmbMjesec = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.lblMjesec = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBrojSmjena = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblZarada = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPomoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(105, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberi zaposlenika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(105, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odaberi mjesec:";
            // 
            // cmbZaposlenik
            // 
            this.cmbZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbZaposlenik.FormattingEnabled = true;
            this.cmbZaposlenik.Location = new System.Drawing.Point(109, 85);
            this.cmbZaposlenik.Name = "cmbZaposlenik";
            this.cmbZaposlenik.Size = new System.Drawing.Size(190, 28);
            this.cmbZaposlenik.TabIndex = 2;
            this.cmbZaposlenik.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbZaposlenik_KeyDown);
            // 
            // cmbMjesec
            // 
            this.cmbMjesec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbMjesec.FormattingEnabled = true;
            this.cmbMjesec.Location = new System.Drawing.Point(109, 177);
            this.cmbMjesec.Name = "cmbMjesec";
            this.cmbMjesec.Size = new System.Drawing.Size(190, 28);
            this.cmbMjesec.TabIndex = 3;
            this.cmbMjesec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMjesec_KeyDown);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdustani.FlatAppearance.BorderSize = 2;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOdustani.Location = new System.Drawing.Point(227, 247);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(146, 41);
            this.btnOdustani.TabIndex = 46;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            this.btnOdustani.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOdustani_KeyDown);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.SlateGray;
            this.btnPrikazi.FlatAppearance.BorderSize = 2;
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPrikazi.Location = new System.Drawing.Point(46, 247);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(146, 41);
            this.btnPrikazi.TabIndex = 45;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            this.btnPrikazi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPrikazi_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(51, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Zaposlenik";
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZaposlenik.ForeColor = System.Drawing.Color.Maroon;
            this.lblZaposlenik.Location = new System.Drawing.Point(153, 322);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(169, 20);
            this.lblZaposlenik.TabIndex = 48;
            this.lblZaposlenik.Text = "________________";
            // 
            // lblMjesec
            // 
            this.lblMjesec.AutoSize = true;
            this.lblMjesec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMjesec.ForeColor = System.Drawing.Color.Maroon;
            this.lblMjesec.Location = new System.Drawing.Point(173, 361);
            this.lblMjesec.Name = "lblMjesec";
            this.lblMjesec.Size = new System.Drawing.Size(149, 20);
            this.lblMjesec.TabIndex = 50;
            this.lblMjesec.Text = "______________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(51, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "je u mjesecu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(51, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "odradio";
            // 
            // lblBrojSmjena
            // 
            this.lblBrojSmjena.AutoSize = true;
            this.lblBrojSmjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojSmjena.ForeColor = System.Drawing.Color.Maroon;
            this.lblBrojSmjena.Location = new System.Drawing.Point(126, 399);
            this.lblBrojSmjena.Name = "lblBrojSmjena";
            this.lblBrojSmjena.Size = new System.Drawing.Size(29, 20);
            this.lblBrojSmjena.TabIndex = 52;
            this.lblBrojSmjena.Text = "__";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(161, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "smjena i zaradio";
            // 
            // lblZarada
            // 
            this.lblZarada.AutoSize = true;
            this.lblZarada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZarada.ForeColor = System.Drawing.Color.Maroon;
            this.lblZarada.Location = new System.Drawing.Point(51, 434);
            this.lblZarada.Name = "lblZarada";
            this.lblZarada.Size = new System.Drawing.Size(99, 20);
            this.lblZarada.TabIndex = 54;
            this.lblZarada.Text = "_________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(161, 434);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 55;
            this.label11.Text = "HRK.";
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.BackColor = System.Drawing.Color.LightBlue;
            this.lblPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPomoc.Location = new System.Drawing.Point(12, 9);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(63, 15);
            this.lblPomoc.TabIndex = 56;
            this.lblPomoc.Text = "F1 Pomoć";
            this.lblPomoc.Click += new System.EventHandler(this.lblPomoc_Click);
            // 
            // frmObracun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 488);
            this.Controls.Add(this.lblPomoc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblZarada);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblBrojSmjena);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMjesec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.cmbMjesec);
            this.Controls.Add(this.cmbZaposlenik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmObracun";
            this.ShowIcon = false;
            this.Text = "Obracun";
            this.Load += new System.EventHandler(this.frmObracun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbZaposlenik;
        private System.Windows.Forms.ComboBox cmbMjesec;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.Label lblMjesec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBrojSmjena;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblZarada;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPomoc;
    }
}