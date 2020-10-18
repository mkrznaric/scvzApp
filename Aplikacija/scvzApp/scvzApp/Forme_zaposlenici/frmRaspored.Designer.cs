namespace scvzApp.Forme_zaposlenici
{
    partial class frmRaspored
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
            this.cmbMjesec = new System.Windows.Forms.ComboBox();
            this.dgvRaspored = new System.Windows.Forms.DataGridView();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnUrediZaposlenika = new System.Windows.Forms.Button();
            this.btnIzbrisiZaposlenika = new System.Windows.Forms.Button();
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.lblPomoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(126, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberi mjesec:";
            // 
            // cmbMjesec
            // 
            this.cmbMjesec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbMjesec.FormattingEnabled = true;
            this.cmbMjesec.Location = new System.Drawing.Point(255, 31);
            this.cmbMjesec.Name = "cmbMjesec";
            this.cmbMjesec.Size = new System.Drawing.Size(169, 28);
            this.cmbMjesec.TabIndex = 1;
            this.cmbMjesec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMjesec_KeyDown);
            // 
            // dgvRaspored
            // 
            this.dgvRaspored.AllowUserToAddRows = false;
            this.dgvRaspored.AllowUserToDeleteRows = false;
            this.dgvRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaspored.Location = new System.Drawing.Point(84, 91);
            this.dgvRaspored.Name = "dgvRaspored";
            this.dgvRaspored.ReadOnly = true;
            this.dgvRaspored.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRaspored.Size = new System.Drawing.Size(543, 265);
            this.dgvRaspored.TabIndex = 2;
            this.dgvRaspored.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRaspored_KeyDown);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdustani.FlatAppearance.BorderSize = 2;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOdustani.Location = new System.Drawing.Point(491, 374);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(102, 53);
            this.btnOdustani.TabIndex = 16;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnUrediZaposlenika
            // 
            this.btnUrediZaposlenika.BackColor = System.Drawing.Color.SlateGray;
            this.btnUrediZaposlenika.FlatAppearance.BorderSize = 2;
            this.btnUrediZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUrediZaposlenika.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUrediZaposlenika.Location = new System.Drawing.Point(241, 375);
            this.btnUrediZaposlenika.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrediZaposlenika.Name = "btnUrediZaposlenika";
            this.btnUrediZaposlenika.Size = new System.Drawing.Size(119, 52);
            this.btnUrediZaposlenika.TabIndex = 15;
            this.btnUrediZaposlenika.Text = "Uredi smjenu";
            this.btnUrediZaposlenika.UseVisualStyleBackColor = false;
            this.btnUrediZaposlenika.Click += new System.EventHandler(this.btnUrediZaposlenika_Click);
            this.btnUrediZaposlenika.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnUrediZaposlenika_KeyDown);
            // 
            // btnIzbrisiZaposlenika
            // 
            this.btnIzbrisiZaposlenika.BackColor = System.Drawing.Color.SlateGray;
            this.btnIzbrisiZaposlenika.FlatAppearance.BorderSize = 2;
            this.btnIzbrisiZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiZaposlenika.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnIzbrisiZaposlenika.Location = new System.Drawing.Point(364, 374);
            this.btnIzbrisiZaposlenika.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzbrisiZaposlenika.Name = "btnIzbrisiZaposlenika";
            this.btnIzbrisiZaposlenika.Size = new System.Drawing.Size(121, 52);
            this.btnIzbrisiZaposlenika.TabIndex = 14;
            this.btnIzbrisiZaposlenika.Text = "Izbriši smjenu";
            this.btnIzbrisiZaposlenika.UseVisualStyleBackColor = false;
            this.btnIzbrisiZaposlenika.Click += new System.EventHandler(this.btnIzbrisiZaposlenika_Click);
            this.btnIzbrisiZaposlenika.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnIzbrisiZaposlenika_KeyDown);
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.BackColor = System.Drawing.Color.SlateGray;
            this.btnDodajZaposlenika.FlatAppearance.BorderSize = 2;
            this.btnDodajZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajZaposlenika.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(116, 374);
            this.btnDodajZaposlenika.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(123, 53);
            this.btnDodajZaposlenika.TabIndex = 13;
            this.btnDodajZaposlenika.Text = "Dodaj smjenu";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = false;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            this.btnDodajZaposlenika.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDodajZaposlenika_KeyDown);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.SlateGray;
            this.btnPrikazi.FlatAppearance.BorderSize = 2;
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPrikazi.Location = new System.Drawing.Point(443, 31);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(121, 28);
            this.btnPrikazi.TabIndex = 17;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            this.btnPrikazi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPrikazi_KeyDown);
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.BackColor = System.Drawing.Color.LightBlue;
            this.lblPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPomoc.Location = new System.Drawing.Point(12, 9);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(63, 15);
            this.lblPomoc.TabIndex = 18;
            this.lblPomoc.Text = "F1 Pomoć";
            this.lblPomoc.Click += new System.EventHandler(this.lblPomoc_Click);
            // 
            // frmRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.lblPomoc);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUrediZaposlenika);
            this.Controls.Add(this.btnIzbrisiZaposlenika);
            this.Controls.Add(this.btnDodajZaposlenika);
            this.Controls.Add(this.dgvRaspored);
            this.Controls.Add(this.cmbMjesec);
            this.Controls.Add(this.label1);
            this.Name = "frmRaspored";
            this.ShowIcon = false;
            this.Text = "Raspored";
            this.Load += new System.EventHandler(this.frmRaspored_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMjesec;
        private System.Windows.Forms.DataGridView dgvRaspored;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnUrediZaposlenika;
        private System.Windows.Forms.Button btnIzbrisiZaposlenika;
        private System.Windows.Forms.Button btnDodajZaposlenika;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label lblPomoc;
    }
}