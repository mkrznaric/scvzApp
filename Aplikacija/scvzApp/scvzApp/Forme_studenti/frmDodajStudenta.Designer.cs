namespace scvzApp.Forme_studenti
{
    partial class frmDodajStudenta
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.cmbZupanija = new System.Windows.Forms.ComboBox();
            this.zupanijaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ternarniDataSet = new scvzApp.ternarniDataSet();
            this.zupanijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19026_DBDataSet = new scvzApp._19026_DBDataSet();
            this.zupanijaTableAdapter = new scvzApp._19026_DBDataSetTableAdapters.zupanijaTableAdapter();
            this.cmbFakultet = new System.Windows.Forms.ComboBox();
            this.fakultetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fakultetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.zupanijaTableAdapter1 = new scvzApp.ternarniDataSetTableAdapters.zupanijaTableAdapter();
            this.fakultetTableAdapter = new scvzApp.ternarniDataSetTableAdapters.fakultetTableAdapter();
            this.lblPomoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zupanijaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ternarniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zupanijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19026_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.SlateGray;
            this.btnDodaj.FlatAppearance.BorderSize = 2;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDodaj.Location = new System.Drawing.Point(122, 393);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(146, 41);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj studenta";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdustani.FlatAppearance.BorderSize = 2;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOdustani.Location = new System.Drawing.Point(303, 393);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(146, 41);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIme.Location = new System.Drawing.Point(231, 70);
            this.txtIme.Margin = new System.Windows.Forms.Padding(2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(188, 26);
            this.txtIme.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(245, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dodavanje studenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(153, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(127, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(134, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(127, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Županija";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(145, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Spol";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(91, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Datum rođenja";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(129, 322);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fakultet";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrezime.Location = new System.Drawing.Point(231, 110);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(188, 26);
            this.txtPrezime.TabIndex = 14;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAdresa.Location = new System.Drawing.Point(231, 151);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(188, 26);
            this.txtAdresa.TabIndex = 15;
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.CustomFormat = "yyyy-mm-dd";
            this.txtDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDatumRodjenja.Location = new System.Drawing.Point(231, 275);
            this.txtDatumRodjenja.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            this.txtDatumRodjenja.Size = new System.Drawing.Size(188, 26);
            this.txtDatumRodjenja.TabIndex = 20;
            // 
            // cmbZupanija
            // 
            this.cmbZupanija.DataSource = this.zupanijaBindingSource1;
            this.cmbZupanija.DisplayMember = "naziv";
            this.cmbZupanija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbZupanija.FormattingEnabled = true;
            this.cmbZupanija.Location = new System.Drawing.Point(231, 189);
            this.cmbZupanija.Margin = new System.Windows.Forms.Padding(2);
            this.cmbZupanija.Name = "cmbZupanija";
            this.cmbZupanija.Size = new System.Drawing.Size(188, 28);
            this.cmbZupanija.TabIndex = 21;
            this.cmbZupanija.ValueMember = "idzupanija";
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
            // zupanijaBindingSource
            // 
            this.zupanijaBindingSource.DataMember = "zupanija";
            this.zupanijaBindingSource.DataSource = this._19026_DBDataSet;
            // 
            // _19026_DBDataSet
            // 
            this._19026_DBDataSet.DataSetName = "_19026_DBDataSet";
            this._19026_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zupanijaTableAdapter
            // 
            this.zupanijaTableAdapter.ClearBeforeFill = true;
            // 
            // cmbFakultet
            // 
            this.cmbFakultet.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbFakultet.DataSource = this.fakultetBindingSource1;
            this.cmbFakultet.DisplayMember = "naziv";
            this.cmbFakultet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbFakultet.FormattingEnabled = true;
            this.cmbFakultet.Location = new System.Drawing.Point(231, 311);
            this.cmbFakultet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFakultet.Name = "cmbFakultet";
            this.cmbFakultet.Size = new System.Drawing.Size(188, 28);
            this.cmbFakultet.TabIndex = 22;
            this.cmbFakultet.ValueMember = "idfakultet";
            // 
            // fakultetBindingSource1
            // 
            this.fakultetBindingSource1.DataMember = "fakultet";
            this.fakultetBindingSource1.DataSource = this.ternarniDataSet;
            // 
            // cmbSpol
            // 
            this.cmbSpol.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbSpol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.cmbSpol.Location = new System.Drawing.Point(231, 230);
            this.cmbSpol.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(188, 28);
            this.cmbSpol.TabIndex = 23;
            // 
            // zupanijaTableAdapter1
            // 
            this.zupanijaTableAdapter1.ClearBeforeFill = true;
            // 
            // fakultetTableAdapter
            // 
            this.fakultetTableAdapter.ClearBeforeFill = true;
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.Location = new System.Drawing.Point(9, 15);
            this.lblPomoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(40, 13);
            this.lblPomoc.TabIndex = 24;
            this.lblPomoc.Text = "Pomoć";
            this.lblPomoc.Click += new System.EventHandler(this.lblPomoc_Click);
            // 
            // frmDodajStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 453);
            this.Controls.Add(this.lblPomoc);
            this.Controls.Add(this.cmbSpol);
            this.Controls.Add(this.cmbFakultet);
            this.Controls.Add(this.cmbZupanija);
            this.Controls.Add(this.txtDatumRodjenja);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDodajStudenta";
            this.ShowIcon = false;
            this.Text = "Dodaj studenta";
            this.Load += new System.EventHandler(this.frmDodajStudenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zupanijaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ternarniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zupanijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19026_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.DateTimePicker txtDatumRodjenja;
        private System.Windows.Forms.ComboBox cmbZupanija;
        private _19026_DBDataSet _19026_DBDataSet;
        private System.Windows.Forms.BindingSource zupanijaBindingSource;
        private _19026_DBDataSetTableAdapters.zupanijaTableAdapter zupanijaTableAdapter;
        private System.Windows.Forms.ComboBox cmbFakultet;
        private System.Windows.Forms.BindingSource fakultetBindingSource;
        private System.Windows.Forms.ComboBox cmbSpol;
        private ternarniDataSet ternarniDataSet;
        private System.Windows.Forms.BindingSource zupanijaBindingSource1;
        private ternarniDataSetTableAdapters.zupanijaTableAdapter zupanijaTableAdapter1;
        private System.Windows.Forms.BindingSource fakultetBindingSource1;
        private ternarniDataSetTableAdapters.fakultetTableAdapter fakultetTableAdapter;
        private System.Windows.Forms.Label lblPomoc;
    }
}