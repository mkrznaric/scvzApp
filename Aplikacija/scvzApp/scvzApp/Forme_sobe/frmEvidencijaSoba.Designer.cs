namespace scvzApp
{
    partial class frmEvidencijaSoba
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
            this.dgvSobe = new System.Windows.Forms.DataGridView();
            this.brojsobeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojkrevetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvar = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.student = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sobaDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPopisSoba = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.sobaTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Pomoc = new System.Windows.Forms.Button();
            this.pnl_Pomoc = new System.Windows.Forms.Panel();
            this.btn_ZatvoriPomoc = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kvarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSobe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaTableAdapterBindingSource)).BeginInit();
            this.pnl_Pomoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSobe
            // 
            this.dgvSobe.AutoGenerateColumns = false;
            this.dgvSobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSobe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brojsobeDataGridViewTextBoxColumn,
            this.brojkrevetaDataGridViewTextBoxColumn,
            this.idsobaDataGridViewTextBoxColumn,
            this.kvar,
            this.student});
            this.dgvSobe.DataSource = this.sobaDataTableBindingSource;
            this.dgvSobe.Location = new System.Drawing.Point(22, 161);
            this.dgvSobe.Name = "dgvSobe";
            this.dgvSobe.Size = new System.Drawing.Size(585, 280);
            this.dgvSobe.TabIndex = 0;
            this.dgvSobe.SelectionChanged += new System.EventHandler(this.DgvSobe_SelectionChanged);
            // 
            // brojsobeDataGridViewTextBoxColumn
            // 
            this.brojsobeDataGridViewTextBoxColumn.DataPropertyName = "broj_sobe";
            this.brojsobeDataGridViewTextBoxColumn.HeaderText = "broj_sobe";
            this.brojsobeDataGridViewTextBoxColumn.Name = "brojsobeDataGridViewTextBoxColumn";
            // 
            // brojkrevetaDataGridViewTextBoxColumn
            // 
            this.brojkrevetaDataGridViewTextBoxColumn.DataPropertyName = "broj_kreveta";
            this.brojkrevetaDataGridViewTextBoxColumn.HeaderText = "broj_kreveta";
            this.brojkrevetaDataGridViewTextBoxColumn.Name = "brojkrevetaDataGridViewTextBoxColumn";
            // 
            // idsobaDataGridViewTextBoxColumn
            // 
            this.idsobaDataGridViewTextBoxColumn.DataPropertyName = "idsoba";
            this.idsobaDataGridViewTextBoxColumn.HeaderText = "idsoba";
            this.idsobaDataGridViewTextBoxColumn.Name = "idsobaDataGridViewTextBoxColumn";
            this.idsobaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsobaDataGridViewTextBoxColumn.Visible = false;
            // 
            // kvar
            // 
            this.kvar.AutoComplete = false;
            this.kvar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.kvar.HeaderText = "kvar";
            this.kvar.Name = "kvar";
            this.kvar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kvar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kvar.Width = 170;
            // 
            // student
            // 
            this.student.AutoComplete = false;
            this.student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.student.HeaderText = "student";
            this.student.Name = "student";
            this.student.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.student.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.student.Width = 170;
            // 
            // sobaDataTableBindingSource
            // 
            this.sobaDataTableBindingSource.DataSource = typeof(scvzApp.sekundarniDataSet.sobaDataTable);
            // 
            // lblPopisSoba
            // 
            this.lblPopisSoba.AutoSize = true;
            this.lblPopisSoba.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisSoba.Location = new System.Drawing.Point(12, 13);
            this.lblPopisSoba.Name = "lblPopisSoba";
            this.lblPopisSoba.Size = new System.Drawing.Size(218, 25);
            this.lblPopisSoba.TabIndex = 1;
            this.lblPopisSoba.Text = "Pregled svih soba u domu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pretraži:";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(77, 62);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(111, 20);
            this.txtPretrazi.TabIndex = 3;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.TxtPretrazi_TextChanged);
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(296, 60);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(111, 21);
            this.cmbFilter.TabIndex = 4;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(208, 62);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(82, 20);
            this.lblFilter.TabIndex = 5;
            this.lblFilter.Text = "Pretraži  po:";
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.Location = new System.Drawing.Point(518, 52);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(111, 22);
            this.btnPrikaziSve.TabIndex = 6;
            this.btnPrikaziSve.Text = "Prikaži sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = true;
            this.btnPrikaziSve.Click += new System.EventHandler(this.BtnPrikaziSve_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "soba";
            this.dataGridViewTextBoxColumn1.HeaderText = "soba";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(518, 109);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(111, 23);
            this.btnIzmjeni.TabIndex = 7;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Visible = false;
            this.btnIzmjeni.Click += new System.EventHandler(this.BtnIzmjeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(518, 80);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(111, 23);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj sobu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // sobaTableAdapterBindingSource
            // 
            this.sobaTableAdapterBindingSource.DataSource = typeof(scvzApp.sekundarniDataSetTableAdapters.sobaTableAdapter);
            // 
            // btn_Pomoc
            // 
            this.btn_Pomoc.Location = new System.Drawing.Point(518, 23);
            this.btn_Pomoc.Name = "btn_Pomoc";
            this.btn_Pomoc.Size = new System.Drawing.Size(111, 23);
            this.btn_Pomoc.TabIndex = 9;
            this.btn_Pomoc.Text = "Pomoć";
            this.btn_Pomoc.UseVisualStyleBackColor = true;
            this.btn_Pomoc.Click += new System.EventHandler(this.Btn_Pomoc_Click);
            // 
            // pnl_Pomoc
            // 
            this.pnl_Pomoc.Controls.Add(this.btn_ZatvoriPomoc);
            this.pnl_Pomoc.Controls.Add(this.listBox1);
            this.pnl_Pomoc.Location = new System.Drawing.Point(104, 41);
            this.pnl_Pomoc.Name = "pnl_Pomoc";
            this.pnl_Pomoc.Size = new System.Drawing.Size(512, 114);
            this.pnl_Pomoc.TabIndex = 10;
            this.pnl_Pomoc.Visible = false;
            // 
            // btn_ZatvoriPomoc
            // 
            this.btn_ZatvoriPomoc.Location = new System.Drawing.Point(479, 0);
            this.btn_ZatvoriPomoc.Name = "btn_ZatvoriPomoc";
            this.btn_ZatvoriPomoc.Size = new System.Drawing.Size(24, 23);
            this.btn_ZatvoriPomoc.TabIndex = 1;
            this.btn_ZatvoriPomoc.Text = "X";
            this.btn_ZatvoriPomoc.UseVisualStyleBackColor = true;
            this.btn_ZatvoriPomoc.Click += new System.EventHandler(this.Btn_ZatvoriPomoc_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Za pretraživanje soba upišite broj u polje pretraži i u padajućem izborniku odabe" +
                "rite po ćemu ",
            "želite pretražiti sobe. Ako nakon pretraživanja ponovno želite vidjeti sve sobe p" +
                "ritisnite gub Prikaži sve",
            "Ako želite dodati sobu koja ne postoji trenutno pritisnite gumb Dodaj sobu. Priti" +
                "skom na neku",
            "od ponuđenih soba prikazat će se gumb Izmjeni pritiskom kojeg će se otvoriti form" +
                "a za izmjenu",
            "označene sobe. Za zatvaranje izbornika za pomoć pritisnite tipku X u njegovom ugl" +
                "u."});
            this.listBox1.Location = new System.Drawing.Point(3, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(500, 82);
            this.listBox1.TabIndex = 0;
            // 
            // sobaBindingSource
            // 
            this.sobaBindingSource.DataSource = typeof(scvzApp.soba);
            // 
            // kvarBindingSource
            // 
            this.kvarBindingSource.DataSource = typeof(scvzApp.kvar);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(scvzApp.student);
            // 
            // frmEvidencijaSoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.dgvSobe);
            this.Controls.Add(this.pnl_Pomoc);
            this.Controls.Add(this.btn_Pomoc);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnPrikaziSve);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPopisSoba);
            this.Name = "frmEvidencijaSoba";
            this.ShowIcon = false;
            this.Text = "Evidencija soba";
            this.Load += new System.EventHandler(this.FrmEvidencijaSoba2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSobe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaTableAdapterBindingSource)).EndInit();
            this.pnl_Pomoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSobe;
        private System.Windows.Forms.BindingSource sobaBindingSource;
        private System.Windows.Forms.Label lblPopisSoba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnPrikaziSve;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.BindingSource kvarBindingSource;
        private System.Windows.Forms.BindingSource sobaDataTableBindingSource;
        private System.Windows.Forms.BindingSource sobaTableAdapterBindingSource;
        private System.Windows.Forms.Button btn_Pomoc;
        private System.Windows.Forms.Panel pnl_Pomoc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_ZatvoriPomoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojsobeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojkrevetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn kvar;
        private System.Windows.Forms.DataGridViewComboBoxColumn student;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsobaDataGridViewTextBoxColumn;
    }
}