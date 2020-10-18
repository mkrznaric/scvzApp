namespace scvzApp.Forme_studenti
{
    partial class frmEvidencijaStudenata
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
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zupanijaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ternarniDataSet = new scvzApp.ternarniDataSet();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sobaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fakultetBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sekundarniDataSet = new scvzApp.sekundarniDataSet();
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fakultetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zupanijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primarni_DataSet = new scvzApp.Primarni_DataSet();
            this.sobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fakultetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajStudenta = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSmjestiUSobu = new System.Windows.Forms.Button();
            this.zupanijaTableAdapter = new scvzApp.Primarni_DataSetTableAdapters.zupanijaTableAdapter();
            this.sobaTableAdapter = new scvzApp.Primarni_DataSetTableAdapters.sobaTableAdapter();
            this.fakultetTableAdapter = new scvzApp.Primarni_DataSetTableAdapters.fakultetTableAdapter();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new scvzApp.ternarniDataSetTableAdapters.studentTableAdapter();
            this.zupanijaTableAdapter1 = new scvzApp.ternarniDataSetTableAdapters.zupanijaTableAdapter();
            this.sobaTableAdapter1 = new scvzApp.ternarniDataSetTableAdapters.sobaTableAdapter();
            this.fakultetTableAdapter1 = new scvzApp.ternarniDataSetTableAdapters.fakultetTableAdapter();
            this.fakultetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fakultetTableAdapter2 = new scvzApp.sekundarniDataSetTableAdapters.fakultetTableAdapter();
            this.lblPomoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zupanijaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ternarniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultetBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekundarniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zupanijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primarni_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.AutoGenerateColumns = false;
            this.dgvStudenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvStudenti.DataSource = this.studentBindingSource2;
            this.dgvStudenti.Location = new System.Drawing.Point(9, 66);
            this.dgvStudenti.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.RowTemplate.Height = 24;
            this.dgvStudenti.Size = new System.Drawing.Size(710, 207);
            this.dgvStudenti.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idstudent";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "adresa";
            this.dataGridViewTextBoxColumn4.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "zupanija";
            this.dataGridViewTextBoxColumn5.DataSource = this.zupanijaBindingSource1;
            this.dataGridViewTextBoxColumn5.DisplayMember = "naziv";
            this.dataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn5.HeaderText = "Županija";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "idzupanija";
            // 
            // zupanijaBindingSource1
            // 
            this.zupanijaBindingSource1.DataMember = "zupanija";
            this.zupanijaBindingSource1.DataSource = this.ternarniDataSet;
            // 
            // ternarniDataSet
            // 
            this.ternarniDataSet.DataSetName = "ternarniDataSet";
            this.ternarniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "spol";
            this.dataGridViewTextBoxColumn6.HeaderText = "Spol";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "datum_rodjenja";
            this.dataGridViewTextBoxColumn7.HeaderText = "Datum rođenja";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "student_soba";
            this.dataGridViewTextBoxColumn8.DataSource = this.sobaBindingSource1;
            this.dataGridViewTextBoxColumn8.DisplayMember = "broj_sobe";
            this.dataGridViewTextBoxColumn8.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn8.HeaderText = "Soba";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "idsoba";
            // 
            // sobaBindingSource1
            // 
            this.sobaBindingSource1.DataMember = "soba";
            this.sobaBindingSource1.DataSource = this.ternarniDataSet;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "fakultet";
            this.dataGridViewTextBoxColumn9.DataSource = this.fakultetBindingSource3;
            this.dataGridViewTextBoxColumn9.DisplayMember = "naziv";
            this.dataGridViewTextBoxColumn9.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn9.HeaderText = "Fakultet";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "idfakultet";
            // 
            // fakultetBindingSource3
            // 
            this.fakultetBindingSource3.DataMember = "fakultet";
            this.fakultetBindingSource3.DataSource = this.sekundarniDataSet;
            // 
            // sekundarniDataSet
            // 
            this.sekundarniDataSet.DataSetName = "sekundarniDataSet";
            this.sekundarniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataSource = typeof(scvzApp.student);
            // 
            // fakultetBindingSource1
            // 
            this.fakultetBindingSource1.DataMember = "fakultet";
            this.fakultetBindingSource1.DataSource = this.ternarniDataSet;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            // 
            // zupanijaBindingSource
            // 
            this.zupanijaBindingSource.DataMember = "zupanija";
            this.zupanijaBindingSource.DataSource = this.primarni_DataSet;
            // 
            // primarni_DataSet
            // 
            this.primarni_DataSet.DataSetName = "Primarni_DataSet";
            this.primarni_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sobaBindingSource
            // 
            this.sobaBindingSource.DataMember = "soba";
            this.sobaBindingSource.DataSource = this.primarni_DataSet;
            // 
            // fakultetBindingSource
            // 
            this.fakultetBindingSource.DataMember = "fakultet";
            this.fakultetBindingSource.DataSource = this.primarni_DataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(262, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis studenata:";
            // 
            // btnDodajStudenta
            // 
            this.btnDodajStudenta.BackColor = System.Drawing.Color.SlateGray;
            this.btnDodajStudenta.FlatAppearance.BorderSize = 2;
            this.btnDodajStudenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajStudenta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDodajStudenta.Location = new System.Drawing.Point(490, 284);
            this.btnDodajStudenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajStudenta.Name = "btnDodajStudenta";
            this.btnDodajStudenta.Size = new System.Drawing.Size(123, 41);
            this.btnDodajStudenta.TabIndex = 2;
            this.btnDodajStudenta.Text = "Dodaj studenta";
            this.btnDodajStudenta.UseVisualStyleBackColor = false;
            this.btnDodajStudenta.Click += new System.EventHandler(this.btnDodajStudenta_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.SlateGray;
            this.btnIzbrisi.FlatAppearance.BorderSize = 2;
            this.btnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnIzbrisi.Location = new System.Drawing.Point(9, 285);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(121, 41);
            this.btnIzbrisi.TabIndex = 3;
            this.btnIzbrisi.Text = "Izbriši studenta";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.SlateGray;
            this.btnUredi.FlatAppearance.BorderSize = 2;
            this.btnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUredi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUredi.Location = new System.Drawing.Point(134, 285);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(2);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(119, 41);
            this.btnUredi.TabIndex = 4;
            this.btnUredi.Text = "Uredi studenta";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdustani.FlatAppearance.BorderSize = 2;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOdustani.Location = new System.Drawing.Point(617, 284);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(102, 41);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Izađi";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSmjestiUSobu
            // 
            this.btnSmjestiUSobu.BackColor = System.Drawing.Color.SlateGray;
            this.btnSmjestiUSobu.FlatAppearance.BorderSize = 2;
            this.btnSmjestiUSobu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSmjestiUSobu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSmjestiUSobu.Location = new System.Drawing.Point(258, 285);
            this.btnSmjestiUSobu.Margin = new System.Windows.Forms.Padding(2);
            this.btnSmjestiUSobu.Name = "btnSmjestiUSobu";
            this.btnSmjestiUSobu.Size = new System.Drawing.Size(119, 41);
            this.btnSmjestiUSobu.TabIndex = 6;
            this.btnSmjestiUSobu.Text = "Smjesti u sobu";
            this.btnSmjestiUSobu.UseVisualStyleBackColor = false;
            this.btnSmjestiUSobu.Click += new System.EventHandler(this.btnSmjestiUSobu_Click);
            // 
            // zupanijaTableAdapter
            // 
            this.zupanijaTableAdapter.ClearBeforeFill = true;
            // 
            // sobaTableAdapter
            // 
            this.sobaTableAdapter.ClearBeforeFill = true;
            // 
            // fakultetTableAdapter
            // 
            this.fakultetTableAdapter.ClearBeforeFill = true;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.ternarniDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // zupanijaTableAdapter1
            // 
            this.zupanijaTableAdapter1.ClearBeforeFill = true;
            // 
            // sobaTableAdapter1
            // 
            this.sobaTableAdapter1.ClearBeforeFill = true;
            // 
            // fakultetTableAdapter1
            // 
            this.fakultetTableAdapter1.ClearBeforeFill = true;
            // 
            // fakultetBindingSource2
            // 
            this.fakultetBindingSource2.DataMember = "fakultet";
            this.fakultetBindingSource2.DataSource = this.ternarniDataSet;
            // 
            // fakultetTableAdapter2
            // 
            this.fakultetTableAdapter2.ClearBeforeFill = true;
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.Location = new System.Drawing.Point(9, 7);
            this.lblPomoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(40, 13);
            this.lblPomoc.TabIndex = 13;
            this.lblPomoc.Text = "Pomoć";
            this.lblPomoc.Click += new System.EventHandler(this.lblPomoc_Click);
            // 
            // frmEvidencijaStudenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 366);
            this.Controls.Add(this.lblPomoc);
            this.Controls.Add(this.btnSmjestiUSobu);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnDodajStudenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudenti);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEvidencijaStudenata";
            this.ShowIcon = false;
            this.Text = "Evidencija studenata";
            this.Load += new System.EventHandler(this.frmEvidencijaStudenata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zupanijaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ternarniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultetBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekundarniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zupanijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primarni_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultetBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajStudenta;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSmjestiUSobu;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Primarni_DataSet primarni_DataSet;
        private System.Windows.Forms.BindingSource zupanijaBindingSource;
        private Primarni_DataSetTableAdapters.zupanijaTableAdapter zupanijaTableAdapter;
        private System.Windows.Forms.BindingSource sobaBindingSource;
        private Primarni_DataSetTableAdapters.sobaTableAdapter sobaTableAdapter;
        private System.Windows.Forms.BindingSource fakultetBindingSource;
        private Primarni_DataSetTableAdapters.fakultetTableAdapter fakultetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn zupanijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrodjenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn studentsobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fakultetDataGridViewTextBoxColumn;
        private ternarniDataSet ternarniDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private ternarniDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource zupanijaBindingSource1;
        private ternarniDataSetTableAdapters.zupanijaTableAdapter zupanijaTableAdapter1;
        private System.Windows.Forms.BindingSource sobaBindingSource1;
        private ternarniDataSetTableAdapters.sobaTableAdapter sobaTableAdapter1;
        private System.Windows.Forms.BindingSource fakultetBindingSource1;
        private ternarniDataSetTableAdapters.fakultetTableAdapter fakultetTableAdapter1;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private System.Windows.Forms.BindingSource fakultetBindingSource2;
        private sekundarniDataSet sekundarniDataSet;
        private System.Windows.Forms.BindingSource fakultetBindingSource3;
        private sekundarniDataSetTableAdapters.fakultetTableAdapter fakultetTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label lblPomoc;
    }
}