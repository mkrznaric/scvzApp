namespace scvzApp.Forme_racuni
{
    partial class frmEvidencijaRacuna
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
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.idracunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumvrijemeracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupnacijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacinplacanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primarni_DataSet = new scvzApp.Primarni_DataSet();
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajRacun = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.racunTableAdapter = new scvzApp.Primarni_DataSetTableAdapters.racunTableAdapter();
            this.studentTableAdapter = new scvzApp.Primarni_DataSetTableAdapters.studentTableAdapter();
            this.zaposlenikTableAdapter = new scvzApp.Primarni_DataSetTableAdapters.zaposlenikTableAdapter();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.lblPomoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primarni_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AllowUserToAddRows = false;
            this.dgvRacuni.AllowUserToDeleteRows = false;
            this.dgvRacuni.AutoGenerateColumns = false;
            this.dgvRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idracunDataGridViewTextBoxColumn,
            this.datumvrijemeracunaDataGridViewTextBoxColumn,
            this.ukupnacijenaDataGridViewTextBoxColumn,
            this.nacinplacanjaDataGridViewTextBoxColumn,
            this.racunstudentDataGridViewTextBoxColumn,
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn});
            this.dgvRacuni.DataSource = this.racunBindingSource;
            this.dgvRacuni.Location = new System.Drawing.Point(9, 41);
            this.dgvRacuni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.ReadOnly = true;
            this.dgvRacuni.RowTemplate.Height = 24;
            this.dgvRacuni.Size = new System.Drawing.Size(582, 225);
            this.dgvRacuni.TabIndex = 0;
            // 
            // idracunDataGridViewTextBoxColumn
            // 
            this.idracunDataGridViewTextBoxColumn.DataPropertyName = "idracun";
            this.idracunDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idracunDataGridViewTextBoxColumn.Name = "idracunDataGridViewTextBoxColumn";
            this.idracunDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumvrijemeracunaDataGridViewTextBoxColumn
            // 
            this.datumvrijemeracunaDataGridViewTextBoxColumn.DataPropertyName = "datum_vrijeme_racuna";
            this.datumvrijemeracunaDataGridViewTextBoxColumn.HeaderText = "Datum i vrijeme izdavanja";
            this.datumvrijemeracunaDataGridViewTextBoxColumn.Name = "datumvrijemeracunaDataGridViewTextBoxColumn";
            this.datumvrijemeracunaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ukupnacijenaDataGridViewTextBoxColumn
            // 
            this.ukupnacijenaDataGridViewTextBoxColumn.DataPropertyName = "ukupna_cijena";
            this.ukupnacijenaDataGridViewTextBoxColumn.HeaderText = "Ukupna cijena";
            this.ukupnacijenaDataGridViewTextBoxColumn.Name = "ukupnacijenaDataGridViewTextBoxColumn";
            this.ukupnacijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nacinplacanjaDataGridViewTextBoxColumn
            // 
            this.nacinplacanjaDataGridViewTextBoxColumn.DataPropertyName = "nacin_placanja";
            this.nacinplacanjaDataGridViewTextBoxColumn.HeaderText = "Način plaćanja";
            this.nacinplacanjaDataGridViewTextBoxColumn.Name = "nacinplacanjaDataGridViewTextBoxColumn";
            this.nacinplacanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // racunstudentDataGridViewTextBoxColumn
            // 
            this.racunstudentDataGridViewTextBoxColumn.DataPropertyName = "racun_student";
            this.racunstudentDataGridViewTextBoxColumn.DataSource = this.studentBindingSource;
            this.racunstudentDataGridViewTextBoxColumn.DisplayMember = "prezime";
            this.racunstudentDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.racunstudentDataGridViewTextBoxColumn.HeaderText = "Student";
            this.racunstudentDataGridViewTextBoxColumn.Name = "racunstudentDataGridViewTextBoxColumn";
            this.racunstudentDataGridViewTextBoxColumn.ReadOnly = true;
            this.racunstudentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.racunstudentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.racunstudentDataGridViewTextBoxColumn.ValueMember = "idstudent";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.primarni_DataSet;
            // 
            // primarni_DataSet
            // 
            this.primarni_DataSet.DataSetName = "Primarni_DataSet";
            this.primarni_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaposlenikidzaposlenikDataGridViewTextBoxColumn
            // 
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik_idzaposlenik";
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.DataSource = this.zaposlenikBindingSource;
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.DisplayMember = "prezime";
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.HeaderText = "Račun izdao";
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.Name = "zaposlenikidzaposlenikDataGridViewTextBoxColumn";
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.ValueMember = "idzaposlenik";
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataMember = "zaposlenik";
            this.zaposlenikBindingSource.DataSource = this.primarni_DataSet;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "racun";
            this.racunBindingSource.DataSource = this.primarni_DataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(232, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Popis računa";
            // 
            // btnDodajRacun
            // 
            this.btnDodajRacun.BackColor = System.Drawing.Color.SlateGray;
            this.btnDodajRacun.FlatAppearance.BorderSize = 2;
            this.btnDodajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajRacun.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDodajRacun.Location = new System.Drawing.Point(362, 273);
            this.btnDodajRacun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajRacun.Name = "btnDodajRacun";
            this.btnDodajRacun.Size = new System.Drawing.Size(123, 41);
            this.btnDodajRacun.TabIndex = 9;
            this.btnDodajRacun.Text = "Novi račun";
            this.btnDodajRacun.UseVisualStyleBackColor = false;
            this.btnDodajRacun.Click += new System.EventHandler(this.btnDodajRacun_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdustani.FlatAppearance.BorderSize = 2;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOdustani.Location = new System.Drawing.Point(489, 271);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(102, 41);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Izađi";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // zaposlenikTableAdapter
            // 
            this.zaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.SlateGray;
            this.btnIzbrisi.FlatAppearance.BorderSize = 2;
            this.btnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnIzbrisi.Location = new System.Drawing.Point(9, 273);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(123, 41);
            this.btnIzbrisi.TabIndex = 13;
            this.btnIzbrisi.Text = "Izbriši račun";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.Location = new System.Drawing.Point(9, 7);
            this.lblPomoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(40, 13);
            this.lblPomoc.TabIndex = 34;
            this.lblPomoc.Text = "Pomoć";
            this.lblPomoc.Click += new System.EventHandler(this.lblPomoc_Click);
            // 
            // frmEvidencijaRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblPomoc);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodajRacun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRacuni);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEvidencijaRacuna";
            this.ShowIcon = false;
            this.Text = "frmEvidencijaRacuna";
            this.Load += new System.EventHandler(this.frmEvidencijaRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primarni_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajRacun;
        private System.Windows.Forms.Button btnOdustani;
        private Primarni_DataSet primarni_DataSet;
        private Primarni_DataSetTableAdapters.racunTableAdapter racunTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Primarni_DataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private Primarni_DataSetTableAdapters.zaposlenikTableAdapter zaposlenikTableAdapter;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idracunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumvrijemeracunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupnacijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacinplacanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn racunstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn zaposlenikidzaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPomoc;
    }
}