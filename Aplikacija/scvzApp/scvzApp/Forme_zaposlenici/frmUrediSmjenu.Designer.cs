namespace scvzApp.Forme_zaposlenici
{
    partial class frmUrediSmjenu
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
            this.cmbMjesec = new System.Windows.Forms.ComboBox();
            this.cmbZaposlenik = new System.Windows.Forms.ComboBox();
            this.cmbVrstaSmjene = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDanUMjesecu = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.lblPomoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbMjesec
            // 
            this.cmbMjesec.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbMjesec.DisplayMember = "naziv";
            this.cmbMjesec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbMjesec.FormattingEnabled = true;
            this.cmbMjesec.Location = new System.Drawing.Point(172, 69);
            this.cmbMjesec.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMjesec.Name = "cmbMjesec";
            this.cmbMjesec.Size = new System.Drawing.Size(188, 28);
            this.cmbMjesec.TabIndex = 69;
            this.cmbMjesec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMjesec_KeyDown);
            // 
            // cmbZaposlenik
            // 
            this.cmbZaposlenik.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbZaposlenik.DisplayMember = "naziv";
            this.cmbZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbZaposlenik.FormattingEnabled = true;
            this.cmbZaposlenik.Location = new System.Drawing.Point(172, 196);
            this.cmbZaposlenik.Margin = new System.Windows.Forms.Padding(2);
            this.cmbZaposlenik.Name = "cmbZaposlenik";
            this.cmbZaposlenik.Size = new System.Drawing.Size(188, 28);
            this.cmbZaposlenik.TabIndex = 68;
            this.cmbZaposlenik.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbZaposlenik_KeyDown);
            // 
            // cmbVrstaSmjene
            // 
            this.cmbVrstaSmjene.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbVrstaSmjene.DisplayMember = "naziv";
            this.cmbVrstaSmjene.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbVrstaSmjene.FormattingEnabled = true;
            this.cmbVrstaSmjene.Location = new System.Drawing.Point(172, 150);
            this.cmbVrstaSmjene.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVrstaSmjene.Name = "cmbVrstaSmjene";
            this.cmbVrstaSmjene.Size = new System.Drawing.Size(188, 28);
            this.cmbVrstaSmjene.TabIndex = 67;
            this.cmbVrstaSmjene.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVrstaSmjene_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(112, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "Mjesec:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(87, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "Zaposlenik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(74, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Vrsta smjene:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(62, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Dan u mjesecu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(168, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Izmijeni smjenu";
            // 
            // txtDanUMjesecu
            // 
            this.txtDanUMjesecu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDanUMjesecu.Location = new System.Drawing.Point(172, 110);
            this.txtDanUMjesecu.Margin = new System.Windows.Forms.Padding(2);
            this.txtDanUMjesecu.Name = "txtDanUMjesecu";
            this.txtDanUMjesecu.Size = new System.Drawing.Size(37, 26);
            this.txtDanUMjesecu.TabIndex = 61;
            this.txtDanUMjesecu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDanUMjesecu_KeyDown);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdustani.FlatAppearance.BorderSize = 2;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOdustani.Location = new System.Drawing.Point(252, 259);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(146, 41);
            this.btnOdustani.TabIndex = 60;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.BackColor = System.Drawing.Color.SlateGray;
            this.btnIzmijeni.FlatAppearance.BorderSize = 2;
            this.btnIzmijeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmijeni.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnIzmijeni.Location = new System.Drawing.Point(71, 259);
            this.btnIzmijeni.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(146, 41);
            this.btnIzmijeni.TabIndex = 59;
            this.btnIzmijeni.Text = "Izmijeni smjenu";
            this.btnIzmijeni.UseVisualStyleBackColor = false;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            this.btnIzmijeni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnIzmijeni_KeyDown);
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.BackColor = System.Drawing.Color.LightBlue;
            this.lblPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPomoc.Location = new System.Drawing.Point(12, 9);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(63, 15);
            this.lblPomoc.TabIndex = 70;
            this.lblPomoc.Text = "F1 Pomoć";
            this.lblPomoc.Click += new System.EventHandler(this.lblPomoc_Click);
            // 
            // frmUrediSmjenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 336);
            this.Controls.Add(this.lblPomoc);
            this.Controls.Add(this.cmbMjesec);
            this.Controls.Add(this.cmbZaposlenik);
            this.Controls.Add(this.cmbVrstaSmjene);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDanUMjesecu);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzmijeni);
            this.Name = "frmUrediSmjenu";
            this.ShowIcon = false;
            this.Text = "Uredi smjenu";
            this.Load += new System.EventHandler(this.frmUrediSmjenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMjesec;
        private System.Windows.Forms.ComboBox cmbZaposlenik;
        private System.Windows.Forms.ComboBox cmbVrstaSmjene;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDanUMjesecu;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Label lblPomoc;
    }
}