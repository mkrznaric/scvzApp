namespace scvzApp.Forme_racuni
{
    partial class frmIspisRacuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIspisRacuna));
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.idracunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumvrijemeracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupnacijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacinplacanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ternarniDataSet = new scvzApp.ternarniDataSet();
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunTableAdapter = new scvzApp.ternarniDataSetTableAdapters.racunTableAdapter();
            this.studentTableAdapter = new scvzApp.ternarniDataSetTableAdapters.studentTableAdapter();
            this.zupanijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zupanijaTableAdapter = new scvzApp.ternarniDataSetTableAdapters.zupanijaTableAdapter();
            this.zaposlenikTableAdapter = new scvzApp.ternarniDataSetTableAdapters.zaposlenikTableAdapter();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.racunidracunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslugaiduslugaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.uslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunuslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racun_uslugaTableAdapter = new scvzApp.ternarniDataSetTableAdapters.racun_uslugaTableAdapter();
            this.uslugaTableAdapter = new scvzApp.ternarniDataSetTableAdapters.uslugaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ternarniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zupanijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunuslugaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRacun
            // 
            this.dgvRacun.AllowUserToAddRows = false;
            this.dgvRacun.AllowUserToDeleteRows = false;
            this.dgvRacun.AutoGenerateColumns = false;
            this.dgvRacun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacun.BackgroundColor = System.Drawing.Color.White;
            this.dgvRacun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRacun.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRacun.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idracunDataGridViewTextBoxColumn,
            this.datumvrijemeracunaDataGridViewTextBoxColumn,
            this.ukupnacijenaDataGridViewTextBoxColumn,
            this.nacinplacanjaDataGridViewTextBoxColumn,
            this.racunstudentDataGridViewTextBoxColumn,
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn});
            this.dgvRacun.DataSource = this.racunBindingSource1;
            this.dgvRacun.GridColor = System.Drawing.Color.White;
            this.dgvRacun.Location = new System.Drawing.Point(29, 12);
            this.dgvRacun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.ReadOnly = true;
            this.dgvRacun.RowTemplate.Height = 24;
            this.dgvRacun.Size = new System.Drawing.Size(680, 80);
            this.dgvRacun.TabIndex = 0;
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
            this.datumvrijemeracunaDataGridViewTextBoxColumn.HeaderText = "Datum izdavanja";
            this.datumvrijemeracunaDataGridViewTextBoxColumn.Name = "datumvrijemeracunaDataGridViewTextBoxColumn";
            this.datumvrijemeracunaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ukupnacijenaDataGridViewTextBoxColumn
            // 
            this.ukupnacijenaDataGridViewTextBoxColumn.DataPropertyName = "ukupna_cijena";
            this.ukupnacijenaDataGridViewTextBoxColumn.HeaderText = "ukupna_cijena";
            this.ukupnacijenaDataGridViewTextBoxColumn.Name = "ukupnacijenaDataGridViewTextBoxColumn";
            this.ukupnacijenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ukupnacijenaDataGridViewTextBoxColumn.Visible = false;
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
            this.studentBindingSource.DataSource = this.ternarniDataSet;
            // 
            // ternarniDataSet
            // 
            this.ternarniDataSet.DataSetName = "ternarniDataSet";
            this.ternarniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaposlenikidzaposlenikDataGridViewTextBoxColumn
            // 
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik_idzaposlenik";
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.DataSource = this.zaposlenikBindingSource;
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.DisplayMember = "prezime";
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.Name = "zaposlenikidzaposlenikDataGridViewTextBoxColumn";
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zaposlenikidzaposlenikDataGridViewTextBoxColumn.ValueMember = "idzaposlenik";
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataMember = "zaposlenik";
            this.zaposlenikBindingSource.DataSource = this.ternarniDataSet;
            // 
            // racunBindingSource1
            // 
            this.racunBindingSource1.DataMember = "racun";
            this.racunBindingSource1.DataSource = this.ternarniDataSet;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "racun";
            this.racunBindingSource.DataSource = this.ternarniDataSet;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // zupanijaBindingSource
            // 
            this.zupanijaBindingSource.DataMember = "zupanija";
            this.zupanijaBindingSource.DataSource = this.ternarniDataSet;
            // 
            // zupanijaTableAdapter
            // 
            this.zupanijaTableAdapter.ClearBeforeFill = true;
            // 
            // zaposlenikTableAdapter
            // 
            this.zaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // dgvStavke
            // 
            this.dgvStavke.AllowUserToAddRows = false;
            this.dgvStavke.AllowUserToDeleteRows = false;
            this.dgvStavke.AutoGenerateColumns = false;
            this.dgvStavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavke.BackgroundColor = System.Drawing.Color.White;
            this.dgvStavke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStavke.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStavke.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.racunidracunDataGridViewTextBoxColumn,
            this.uslugaiduslugaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dgvStavke.DataSource = this.racunuslugaBindingSource;
            this.dgvStavke.GridColor = System.Drawing.Color.White;
            this.dgvStavke.Location = new System.Drawing.Point(29, 110);
            this.dgvStavke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.ReadOnly = true;
            this.dgvStavke.RowTemplate.Height = 24;
            this.dgvStavke.Size = new System.Drawing.Size(349, 150);
            this.dgvStavke.TabIndex = 1;
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
            // uslugaBindingSource
            // 
            this.uslugaBindingSource.DataMember = "usluga";
            this.uslugaBindingSource.DataSource = this.ternarniDataSet;
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
            this.racunuslugaBindingSource.DataSource = this.ternarniDataSet;
            // 
            // racun_uslugaTableAdapter
            // 
            this.racun_uslugaTableAdapter.ClearBeforeFill = true;
            // 
            // uslugaTableAdapter
            // 
            this.uslugaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(73, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ukupna cijena:";
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupno.Location = new System.Drawing.Point(301, 262);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(93, 32);
            this.lblUkupno.TabIndex = 3;
            this.lblUkupno.Text = "label2";
            // 
            // btnIspisi
            // 
            this.btnIspisi.BackColor = System.Drawing.Color.SlateGray;
            this.btnIspisi.FlatAppearance.BorderSize = 2;
            this.btnIspisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIspisi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnIspisi.Location = new System.Drawing.Point(393, 510);
            this.btnIspisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(148, 45);
            this.btnIspisi.TabIndex = 38;
            this.btnIspisi.Text = "Ispiši";
            this.btnIspisi.UseVisualStyleBackColor = false;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(75, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Potpis zaposlenika: ________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(389, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Potpis studenta: ________________";
            // 
            // frmIspisRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 566);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.dgvRacun);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmIspisRacuna";
            this.ShowIcon = false;
            this.Text = "frmIspisRacuna";
            this.Load += new System.EventHandler(this.frmIspisRacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ternarniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zupanijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunuslugaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRacun;
        private ternarniDataSet ternarniDataSet;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private ternarniDataSetTableAdapters.racunTableAdapter racunTableAdapter;
        private System.Windows.Forms.BindingSource racunBindingSource1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ternarniDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource zupanijaBindingSource;
        private ternarniDataSetTableAdapters.zupanijaTableAdapter zupanijaTableAdapter;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private ternarniDataSetTableAdapters.zaposlenikTableAdapter zaposlenikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idracunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumvrijemeracunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupnacijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacinplacanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn racunstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn zaposlenikidzaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.BindingSource racunuslugaBindingSource;
        private ternarniDataSetTableAdapters.racun_uslugaTableAdapter racun_uslugaTableAdapter;
        private System.Windows.Forms.BindingSource uslugaBindingSource;
        private ternarniDataSetTableAdapters.uslugaTableAdapter uslugaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunidracunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn uslugaiduslugaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Button btnIspisi;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}