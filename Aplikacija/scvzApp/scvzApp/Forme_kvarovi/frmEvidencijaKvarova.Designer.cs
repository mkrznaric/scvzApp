namespace scvzApp.Forme_kvarovi
{
    partial class frmEvidencijaKvarova
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodajKvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKvarovi = new System.Windows.Forms.DataGridView();
            this.idkvarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumprijaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvaridsobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sobaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sekundarniDataSet = new scvzApp.sekundarniDataSet();
            this.kvarprijavioidstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primarniDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primarni_DataSet = new scvzApp.Primarni_DataSet();
            this.kvarzaprimioidzaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statuskvaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvarBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.sobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kvarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kvarTableAdapter = new scvzApp.Primarni_DataSetTableAdapters.kvarTableAdapter();
            this.sobaTableAdapter = new scvzApp.Primarni_DataSetTableAdapters.sobaTableAdapter();
            this.studentTableAdapter = new scvzApp.Primarni_DataSetTableAdapters.studentTableAdapter();
            this.zaposlenikTableAdapter = new scvzApp.Primarni_DataSetTableAdapters.zaposlenikTableAdapter();
            this.sobaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sobaTableAdapter1 = new scvzApp.sekundarniDataSetTableAdapters.sobaTableAdapter();
            this.kvarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kvarTableAdapter1 = new scvzApp.sekundarniDataSetTableAdapters.kvarTableAdapter();
            this.sobaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.kvarBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.kvarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lblPomoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKvarovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekundarniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primarniDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primarni_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdustani.FlatAppearance.BorderSize = 2;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOdustani.Location = new System.Drawing.Point(665, 290);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(102, 41);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "Izađi";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.SlateGray;
            this.btnUredi.FlatAppearance.BorderSize = 2;
            this.btnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUredi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUredi.Location = new System.Drawing.Point(137, 290);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(2);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(119, 41);
            this.btnUredi.TabIndex = 10;
            this.btnUredi.Text = "Uredi kvar";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.SlateGray;
            this.btnIzbrisi.FlatAppearance.BorderSize = 2;
            this.btnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnIzbrisi.Location = new System.Drawing.Point(12, 290);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(121, 41);
            this.btnIzbrisi.TabIndex = 9;
            this.btnIzbrisi.Text = "Izbriši kvar";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnDodajKvar
            // 
            this.btnDodajKvar.BackColor = System.Drawing.Color.SlateGray;
            this.btnDodajKvar.FlatAppearance.BorderSize = 2;
            this.btnDodajKvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajKvar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDodajKvar.Location = new System.Drawing.Point(538, 290);
            this.btnDodajKvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajKvar.Name = "btnDodajKvar";
            this.btnDodajKvar.Size = new System.Drawing.Size(123, 41);
            this.btnDodajKvar.TabIndex = 8;
            this.btnDodajKvar.Text = "Dodaj kvar";
            this.btnDodajKvar.UseVisualStyleBackColor = false;
            this.btnDodajKvar.Click += new System.EventHandler(this.btnDodajKvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(269, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Popis kvarova";
            // 
            // dgvKvarovi
            // 
            this.dgvKvarovi.AllowUserToAddRows = false;
            this.dgvKvarovi.AllowUserToDeleteRows = false;
            this.dgvKvarovi.AutoGenerateColumns = false;
            this.dgvKvarovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKvarovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkvarDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.datumprijaveDataGridViewTextBoxColumn,
            this.kvaridsobaDataGridViewTextBoxColumn,
            this.kvarprijavioidstudentDataGridViewTextBoxColumn,
            this.kvarzaprimioidzaposlenikDataGridViewTextBoxColumn,
            this.statuskvaraDataGridViewTextBoxColumn});
            this.dgvKvarovi.DataSource = this.kvarBindingSource4;
            this.dgvKvarovi.Location = new System.Drawing.Point(12, 76);
            this.dgvKvarovi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKvarovi.Name = "dgvKvarovi";
            this.dgvKvarovi.ReadOnly = true;
            this.dgvKvarovi.RowTemplate.Height = 24;
            this.dgvKvarovi.Size = new System.Drawing.Size(755, 207);
            this.dgvKvarovi.TabIndex = 6;
            // 
            // idkvarDataGridViewTextBoxColumn
            // 
            this.idkvarDataGridViewTextBoxColumn.DataPropertyName = "idkvar";
            this.idkvarDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idkvarDataGridViewTextBoxColumn.Name = "idkvarDataGridViewTextBoxColumn";
            this.idkvarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumprijaveDataGridViewTextBoxColumn
            // 
            this.datumprijaveDataGridViewTextBoxColumn.DataPropertyName = "datum_prijave";
            this.datumprijaveDataGridViewTextBoxColumn.HeaderText = "Datum prijave";
            this.datumprijaveDataGridViewTextBoxColumn.Name = "datumprijaveDataGridViewTextBoxColumn";
            this.datumprijaveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kvaridsobaDataGridViewTextBoxColumn
            // 
            this.kvaridsobaDataGridViewTextBoxColumn.DataPropertyName = "kvar_idsoba";
            this.kvaridsobaDataGridViewTextBoxColumn.DataSource = this.sobaBindingSource2;
            this.kvaridsobaDataGridViewTextBoxColumn.DisplayMember = "broj_sobe";
            this.kvaridsobaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.kvaridsobaDataGridViewTextBoxColumn.HeaderText = "Soba";
            this.kvaridsobaDataGridViewTextBoxColumn.Name = "kvaridsobaDataGridViewTextBoxColumn";
            this.kvaridsobaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kvaridsobaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kvaridsobaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kvaridsobaDataGridViewTextBoxColumn.ValueMember = "idsoba";
            // 
            // sobaBindingSource2
            // 
            this.sobaBindingSource2.DataMember = "soba";
            this.sobaBindingSource2.DataSource = this.sekundarniDataSet;
            // 
            // sekundarniDataSet
            // 
            this.sekundarniDataSet.DataSetName = "sekundarniDataSet";
            this.sekundarniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kvarprijavioidstudentDataGridViewTextBoxColumn
            // 
            this.kvarprijavioidstudentDataGridViewTextBoxColumn.DataPropertyName = "kvar__prijavio_idstudent";
            this.kvarprijavioidstudentDataGridViewTextBoxColumn.DataSource = this.studentBindingSource;
            this.kvarprijavioidstudentDataGridViewTextBoxColumn.DisplayMember = "prezime";
            this.kvarprijavioidstudentDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.kvarprijavioidstudentDataGridViewTextBoxColumn.HeaderText = "Kvar prijavio";
            this.kvarprijavioidstudentDataGridViewTextBoxColumn.Name = "kvarprijavioidstudentDataGridViewTextBoxColumn";
            this.kvarprijavioidstudentDataGridViewTextBoxColumn.ReadOnly = true;
            this.kvarprijavioidstudentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kvarprijavioidstudentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kvarprijavioidstudentDataGridViewTextBoxColumn.ValueMember = "idstudent";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.primarniDataSetBindingSource;
            // 
            // primarniDataSetBindingSource
            // 
            this.primarniDataSetBindingSource.DataSource = this.primarni_DataSet;
            this.primarniDataSetBindingSource.Position = 0;
            // 
            // primarni_DataSet
            // 
            this.primarni_DataSet.DataSetName = "Primarni_DataSet";
            this.primarni_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kvarzaprimioidzaposlenikDataGridViewTextBoxColumn
            // 
            this.kvarzaprimioidzaposlenikDataGridViewTextBoxColumn.DataPropertyName = "kvar_zaprimio_idzaposlenik";
            this.kvarzaprimioidzaposlenikDataGridViewTextBoxColumn.DataSource = this.zaposlenikBindingSource;
            this.kvarzaprimioidzaposlenikDataGridViewTextBoxColumn.DisplayMember = "prezime";
            this.kvarzaprimioidzaposlenikDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.kvarzaprimioidzaposlenikDataGridViewTextBoxColumn.HeaderText = "Kvar zaprimio";
            this.kvarzaprimioidzaposlenikDataGridViewTextBoxColumn.Name = "kvarzaprimioidzaposlenikDataGridViewTextBoxColumn";
            this.kvarzaprimioidzaposlenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.kvarzaprimioidzaposlenikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kvarzaprimioidzaposlenikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kvarzaprimioidzaposlenikDataGridViewTextBoxColumn.ValueMember = "idzaposlenik";
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataMember = "zaposlenik";
            this.zaposlenikBindingSource.DataSource = this.primarniDataSetBindingSource;
            // 
            // statuskvaraDataGridViewTextBoxColumn
            // 
            this.statuskvaraDataGridViewTextBoxColumn.DataPropertyName = "status_kvara";
            this.statuskvaraDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statuskvaraDataGridViewTextBoxColumn.Name = "statuskvaraDataGridViewTextBoxColumn";
            this.statuskvaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kvarBindingSource4
            // 
            this.kvarBindingSource4.DataMember = "kvar";
            this.kvarBindingSource4.DataSource = this.sekundarniDataSet;
            // 
            // sobaBindingSource
            // 
            this.sobaBindingSource.DataMember = "soba";
            this.sobaBindingSource.DataSource = this.primarniDataSetBindingSource;
            // 
            // kvarBindingSource
            // 
            this.kvarBindingSource.DataMember = "kvar";
            this.kvarBindingSource.DataSource = this.primarni_DataSet;
            // 
            // kvarTableAdapter
            // 
            this.kvarTableAdapter.ClearBeforeFill = true;
            // 
            // sobaTableAdapter
            // 
            this.sobaTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // zaposlenikTableAdapter
            // 
            this.zaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // sobaBindingSource1
            // 
            this.sobaBindingSource1.DataMember = "soba";
            this.sobaBindingSource1.DataSource = this.primarniDataSetBindingSource;
            // 
            // sobaTableAdapter1
            // 
            this.sobaTableAdapter1.ClearBeforeFill = true;
            // 
            // kvarBindingSource1
            // 
            this.kvarBindingSource1.DataMember = "kvar";
            this.kvarBindingSource1.DataSource = this.sekundarniDataSet;
            // 
            // kvarTableAdapter1
            // 
            this.kvarTableAdapter1.ClearBeforeFill = true;
            // 
            // sobaBindingSource3
            // 
            this.sobaBindingSource3.DataMember = "soba";
            this.sobaBindingSource3.DataSource = this.sekundarniDataSet;
            // 
            // kvarBindingSource3
            // 
            this.kvarBindingSource3.DataMember = "kvar";
            this.kvarBindingSource3.DataSource = this.sekundarniDataSet;
            // 
            // kvarBindingSource2
            // 
            this.kvarBindingSource2.DataSource = typeof(scvzApp.kvar);
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.Location = new System.Drawing.Point(10, 20);
            this.lblPomoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(40, 13);
            this.lblPomoc.TabIndex = 12;
            this.lblPomoc.Text = "Pomoć";
            this.lblPomoc.Click += new System.EventHandler(this.lblPomoc_Click);
            // 
            // frmEvidencijaKvarova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 394);
            this.Controls.Add(this.lblPomoc);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnDodajKvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKvarovi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEvidencijaKvarova";
            this.ShowIcon = false;
            this.Text = "Evidencija kvarova";
            this.Load += new System.EventHandler(this.frmEvidencijaKvarova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKvarovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekundarniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primarniDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primarni_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodajKvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKvarovi;
        private Primarni_DataSet primarni_DataSet;
        private System.Windows.Forms.BindingSource kvarBindingSource;
        private Primarni_DataSetTableAdapters.kvarTableAdapter kvarTableAdapter;
        private System.Windows.Forms.BindingSource primarniDataSetBindingSource;
        private System.Windows.Forms.BindingSource sobaBindingSource;
        private Primarni_DataSetTableAdapters.sobaTableAdapter sobaTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Primarni_DataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private Primarni_DataSetTableAdapters.zaposlenikTableAdapter zaposlenikTableAdapter;
        private System.Windows.Forms.BindingSource sobaBindingSource1;
        private sekundarniDataSet sekundarniDataSet;
        private System.Windows.Forms.BindingSource sobaBindingSource2;
        private sekundarniDataSetTableAdapters.sobaTableAdapter sobaTableAdapter1;
        private System.Windows.Forms.BindingSource kvarBindingSource1;
        private sekundarniDataSetTableAdapters.kvarTableAdapter kvarTableAdapter1;
        private System.Windows.Forms.BindingSource sobaBindingSource3;
        private System.Windows.Forms.BindingSource kvarBindingSource2;
        private System.Windows.Forms.BindingSource kvarBindingSource3;
        private System.Windows.Forms.BindingSource kvarBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkvarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumprijaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn kvaridsobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn kvarprijavioidstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn kvarzaprimioidzaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuskvaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPomoc;
    }
}