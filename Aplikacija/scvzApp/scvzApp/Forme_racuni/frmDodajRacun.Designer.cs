namespace scvzApp.Forme_racuni
{
    partial class frmDodajRacun
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
            this.components = new System.ComponentModel.Container();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.cmbStavke = new System.Windows.Forms.ComboBox();
            this.uslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primarni_DataSet = new scvzApp.Primarni_DataSet();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStudenti = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvrusluga = new System.Windows.Forms.DataGridView();
            this.racunidracunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslugaiduslugaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunuslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new scvzApp.Primarni_DataSetTableAdapters.studentTableAdapter();
            this.uslugaTableAdapter = new scvzApp.Primarni_DataSetTableAdapters.uslugaTableAdapter();
            this.cmbNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIzbrisiStavku = new System.Windows.Forms.Button();
            this.racun_uslugaTableAdapter = new scvzApp.Primarni_DataSetTableAdapters.racun_uslugaTableAdapter();
            this.lblPomoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primarni_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrusluga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunuslugaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIspisi
            // 
            this.btnIspisi.BackColor = System.Drawing.Color.SlateGray;
            this.btnIspisi.FlatAppearance.BorderSize = 2;
            this.btnIspisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIspisi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnIspisi.Location = new System.Drawing.Point(96, 250);
            this.btnIspisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(146, 41);
            this.btnIspisi.TabIndex = 37;
            this.btnIspisi.Text = "Ispiši";
            this.btnIspisi.UseVisualStyleBackColor = false;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdustani.FlatAppearance.BorderSize = 2;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOdustani.Location = new System.Drawing.Point(270, 250);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(146, 41);
            this.btnOdustani.TabIndex = 38;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.BackColor = System.Drawing.Color.SlateGray;
            this.btnDodajStavku.FlatAppearance.BorderSize = 2;
            this.btnDodajStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajStavku.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDodajStavku.Location = new System.Drawing.Point(12, 167);
            this.btnDodajStavku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(118, 41);
            this.btnDodajStavku.TabIndex = 39;
            this.btnDodajStavku.Text = "Dodaj na račun";
            this.btnDodajStavku.UseVisualStyleBackColor = false;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // cmbStavke
            // 
            this.cmbStavke.DataSource = this.uslugaBindingSource;
            this.cmbStavke.DisplayMember = "naziv";
            this.cmbStavke.FormattingEnabled = true;
            this.cmbStavke.Location = new System.Drawing.Point(12, 97);
            this.cmbStavke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStavke.Name = "cmbStavke";
            this.cmbStavke.Size = new System.Drawing.Size(119, 21);
            this.cmbStavke.TabIndex = 40;
            this.cmbStavke.ValueMember = "idusluga";
            // 
            // uslugaBindingSource
            // 
            this.uslugaBindingSource.DataMember = "usluga";
            this.uslugaBindingSource.DataSource = this.primarni_DataSet;
            // 
            // primarni_DataSet
            // 
            this.primarni_DataSet.DataSetName = "Primarni_DataSet";
            this.primarni_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(142, 98);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(49, 20);
            this.txtKolicina.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Odaberi studenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Odaberi stavku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(139, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Količina";
            // 
            // cmbStudenti
            // 
            this.cmbStudenti.DataSource = this.studentBindingSource;
            this.cmbStudenti.DisplayMember = "prezime";
            this.cmbStudenti.FormattingEnabled = true;
            this.cmbStudenti.Location = new System.Drawing.Point(12, 50);
            this.cmbStudenti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStudenti.Name = "cmbStudenti";
            this.cmbStudenti.Size = new System.Drawing.Size(119, 21);
            this.cmbStudenti.TabIndex = 45;
            this.cmbStudenti.ValueMember = "idstudent";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.primarni_DataSet;
            // 
            // dgvrusluga
            // 
            this.dgvrusluga.AllowUserToAddRows = false;
            this.dgvrusluga.AllowUserToDeleteRows = false;
            this.dgvrusluga.AutoGenerateColumns = false;
            this.dgvrusluga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrusluga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.racunidracunDataGridViewTextBoxColumn,
            this.uslugaiduslugaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dgvrusluga.DataSource = this.racunuslugaBindingSource;
            this.dgvrusluga.Location = new System.Drawing.Point(298, 20);
            this.dgvrusluga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvrusluga.Name = "dgvrusluga";
            this.dgvrusluga.ReadOnly = true;
            this.dgvrusluga.RowTemplate.Height = 24;
            this.dgvrusluga.Size = new System.Drawing.Size(180, 181);
            this.dgvrusluga.TabIndex = 46;
            // 
            // racunidracunDataGridViewTextBoxColumn
            // 
            this.racunidracunDataGridViewTextBoxColumn.DataPropertyName = "racun_idracun";
            this.racunidracunDataGridViewTextBoxColumn.HeaderText = "racun_idracun";
            this.racunidracunDataGridViewTextBoxColumn.Name = "racunidracunDataGridViewTextBoxColumn";
            this.racunidracunDataGridViewTextBoxColumn.ReadOnly = true;
            this.racunidracunDataGridViewTextBoxColumn.Visible = false;
            // 
            // uslugaiduslugaDataGridViewTextBoxColumn
            // 
            this.uslugaiduslugaDataGridViewTextBoxColumn.DataPropertyName = "usluga_idusluga";
            this.uslugaiduslugaDataGridViewTextBoxColumn.DataSource = this.uslugaBindingSource;
            this.uslugaiduslugaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.uslugaiduslugaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.uslugaiduslugaDataGridViewTextBoxColumn.HeaderText = "Usluga";
            this.uslugaiduslugaDataGridViewTextBoxColumn.Name = "uslugaiduslugaDataGridViewTextBoxColumn";
            this.uslugaiduslugaDataGridViewTextBoxColumn.ReadOnly = true;
            this.uslugaiduslugaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.uslugaiduslugaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.uslugaiduslugaDataGridViewTextBoxColumn.ValueMember = "idusluga";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // racunuslugaBindingSource
            // 
            this.racunuslugaBindingSource.DataMember = "racun_usluga";
            this.racunuslugaBindingSource.DataSource = this.primarni_DataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // uslugaTableAdapter
            // 
            this.uslugaTableAdapter.ClearBeforeFill = true;
            // 
            // cmbNacinPlacanja
            // 
            this.cmbNacinPlacanja.FormattingEnabled = true;
            this.cmbNacinPlacanja.Items.AddRange(new object[] {
            "Gotovina",
            "Kartica"});
            this.cmbNacinPlacanja.Location = new System.Drawing.Point(142, 50);
            this.cmbNacinPlacanja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbNacinPlacanja.Name = "cmbNacinPlacanja";
            this.cmbNacinPlacanja.Size = new System.Drawing.Size(101, 21);
            this.cmbNacinPlacanja.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(139, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Odaberi način plaćanja";
            // 
            // btnIzbrisiStavku
            // 
            this.btnIzbrisiStavku.BackColor = System.Drawing.Color.SlateGray;
            this.btnIzbrisiStavku.FlatAppearance.BorderSize = 2;
            this.btnIzbrisiStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiStavku.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnIzbrisiStavku.Location = new System.Drawing.Point(142, 167);
            this.btnIzbrisiStavku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzbrisiStavku.Name = "btnIzbrisiStavku";
            this.btnIzbrisiStavku.Size = new System.Drawing.Size(118, 41);
            this.btnIzbrisiStavku.TabIndex = 49;
            this.btnIzbrisiStavku.Text = "Izbriši s računa";
            this.btnIzbrisiStavku.UseVisualStyleBackColor = false;
            this.btnIzbrisiStavku.Click += new System.EventHandler(this.btnIzbrisiStavku_Click);
            // 
            // racun_uslugaTableAdapter
            // 
            this.racun_uslugaTableAdapter.ClearBeforeFill = true;
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.Location = new System.Drawing.Point(2, 6);
            this.lblPomoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(40, 13);
            this.lblPomoc.TabIndex = 50;
            this.lblPomoc.Text = "Pomoć";
            this.lblPomoc.Click += new System.EventHandler(this.lblPomoc_Click);
            // 
            // frmDodajRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 347);
            this.Controls.Add(this.lblPomoc);
            this.Controls.Add(this.btnIzbrisiStavku);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbNacinPlacanja);
            this.Controls.Add(this.dgvrusluga);
            this.Controls.Add(this.cmbStudenti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.cmbStavke);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIspisi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDodajRacun";
            this.ShowIcon = false;
            this.Text = "frmDodajRacun";
            this.Load += new System.EventHandler(this.frmDodajRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primarni_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrusluga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunuslugaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.ComboBox cmbStavke;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStudenti;
        private System.Windows.Forms.DataGridView dgvrusluga;
        private Primarni_DataSet primarni_DataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Primarni_DataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource uslugaBindingSource;
        private Primarni_DataSetTableAdapters.uslugaTableAdapter uslugaTableAdapter;
        private System.Windows.Forms.ComboBox cmbNacinPlacanja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIzbrisiStavku;
        private System.Windows.Forms.BindingSource racunuslugaBindingSource;
        private Primarni_DataSetTableAdapters.racun_uslugaTableAdapter racun_uslugaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunidracunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn uslugaiduslugaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPomoc;
    }
}