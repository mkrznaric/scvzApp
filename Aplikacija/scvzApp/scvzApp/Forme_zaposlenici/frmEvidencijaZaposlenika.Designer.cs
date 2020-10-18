namespace scvzApp.Forme_zaposlenici
{
    partial class frmEvidencijaZaposlenika
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
            this.btnOdustaniZaposlenik = new System.Windows.Forms.Button();
            this.btnUrediZaposlenika = new System.Windows.Forms.Button();
            this.btnIzbrisiZaposlenika = new System.Windows.Forms.Button();
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.lblPopisZaposlenika = new System.Windows.Forms.Label();
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLegenda = new System.Windows.Forms.GroupBox();
            this.lblPomoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.gbLegenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOdustaniZaposlenik
            // 
            this.btnOdustaniZaposlenik.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdustaniZaposlenik.FlatAppearance.BorderSize = 2;
            this.btnOdustaniZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustaniZaposlenik.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOdustaniZaposlenik.Location = new System.Drawing.Point(416, 279);
            this.btnOdustaniZaposlenik.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustaniZaposlenik.Name = "btnOdustaniZaposlenik";
            this.btnOdustaniZaposlenik.Size = new System.Drawing.Size(102, 53);
            this.btnOdustaniZaposlenik.TabIndex = 12;
            this.btnOdustaniZaposlenik.Text = "Odustani";
            this.btnOdustaniZaposlenik.UseVisualStyleBackColor = false;
            this.btnOdustaniZaposlenik.Click += new System.EventHandler(this.btnOdustaniZaposlenik_Click);
            // 
            // btnUrediZaposlenika
            // 
            this.btnUrediZaposlenika.BackColor = System.Drawing.Color.SlateGray;
            this.btnUrediZaposlenika.FlatAppearance.BorderSize = 2;
            this.btnUrediZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUrediZaposlenika.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUrediZaposlenika.Location = new System.Drawing.Point(166, 280);
            this.btnUrediZaposlenika.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrediZaposlenika.Name = "btnUrediZaposlenika";
            this.btnUrediZaposlenika.Size = new System.Drawing.Size(119, 52);
            this.btnUrediZaposlenika.TabIndex = 11;
            this.btnUrediZaposlenika.Text = "Uredi zaposlenika";
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
            this.btnIzbrisiZaposlenika.Location = new System.Drawing.Point(289, 280);
            this.btnIzbrisiZaposlenika.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzbrisiZaposlenika.Name = "btnIzbrisiZaposlenika";
            this.btnIzbrisiZaposlenika.Size = new System.Drawing.Size(121, 52);
            this.btnIzbrisiZaposlenika.TabIndex = 10;
            this.btnIzbrisiZaposlenika.Text = "Izbriši zaposlenika";
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
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(41, 279);
            this.btnDodajZaposlenika.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(123, 53);
            this.btnDodajZaposlenika.TabIndex = 9;
            this.btnDodajZaposlenika.Text = "Dodaj novog zaposlenika";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = false;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            this.btnDodajZaposlenika.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDodajZaposlenika_KeyDown);
            // 
            // lblPopisZaposlenika
            // 
            this.lblPopisZaposlenika.AutoSize = true;
            this.lblPopisZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPopisZaposlenika.Location = new System.Drawing.Point(303, 22);
            this.lblPopisZaposlenika.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPopisZaposlenika.Name = "lblPopisZaposlenika";
            this.lblPopisZaposlenika.Size = new System.Drawing.Size(158, 20);
            this.lblPopisZaposlenika.TabIndex = 8;
            this.lblPopisZaposlenika.Text = "Popis zaposlenika:";
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AllowUserToAddRows = false;
            this.dgvZaposlenici.AllowUserToDeleteRows = false;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Location = new System.Drawing.Point(41, 66);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.ReadOnly = true;
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(710, 190);
            this.dgvZaposlenici.TabIndex = 13;
            this.dgvZaposlenici.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvZaposlenici_CellFormatting);
            this.dgvZaposlenici.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvZaposlenici_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recepcioner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator";
            // 
            // gbLegenda
            // 
            this.gbLegenda.Controls.Add(this.label2);
            this.gbLegenda.Controls.Add(this.label1);
            this.gbLegenda.Location = new System.Drawing.Point(569, 262);
            this.gbLegenda.Name = "gbLegenda";
            this.gbLegenda.Size = new System.Drawing.Size(182, 103);
            this.gbLegenda.TabIndex = 15;
            this.gbLegenda.TabStop = false;
            this.gbLegenda.Text = "Tip korisnika";
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.BackColor = System.Drawing.Color.LightBlue;
            this.lblPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPomoc.Location = new System.Drawing.Point(12, 9);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(63, 15);
            this.lblPomoc.TabIndex = 16;
            this.lblPomoc.Text = "F1 Pomoć";
            this.lblPomoc.Click += new System.EventHandler(this.lblPomoc_Click);
            // 
            // frmEvidencijaZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.lblPomoc);
            this.Controls.Add(this.gbLegenda);
            this.Controls.Add(this.dgvZaposlenici);
            this.Controls.Add(this.btnOdustaniZaposlenik);
            this.Controls.Add(this.btnUrediZaposlenika);
            this.Controls.Add(this.btnIzbrisiZaposlenika);
            this.Controls.Add(this.btnDodajZaposlenika);
            this.Controls.Add(this.lblPopisZaposlenika);
            this.Name = "frmEvidencijaZaposlenika";
            this.ShowIcon = false;
            this.Text = "Evidencija zaposlenika";
            this.Load += new System.EventHandler(this.frmEvidencijaZaposlenika_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEvidencijaZaposlenika_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.gbLegenda.ResumeLayout(false);
            this.gbLegenda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOdustaniZaposlenik;
        private System.Windows.Forms.Button btnUrediZaposlenika;
        private System.Windows.Forms.Button btnIzbrisiZaposlenika;
        private System.Windows.Forms.Button btnDodajZaposlenika;
        private System.Windows.Forms.Label lblPopisZaposlenika;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbLegenda;
        private System.Windows.Forms.Label lblPomoc;
    }
}