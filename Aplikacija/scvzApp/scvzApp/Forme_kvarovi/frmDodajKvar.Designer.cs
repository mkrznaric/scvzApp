namespace scvzApp.Forme_kvarovi
{
    partial class frmDodajKvar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.DateTimePicker();
            this.cmbSoba = new System.Windows.Forms.ComboBox();
            this.sobaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sekundarniDataSet = new scvzApp.sekundarniDataSet();
            this.sobaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.primarni_DataSet = new scvzApp.Primarni_DataSet();
            this.sobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbKvarPrijavio = new System.Windows.Forms.ComboBox();
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.sobaTableAdapter1 = new scvzApp.Primarni_DataSetTableAdapters.sobaTableAdapter();
            this.sobaTableAdapter2 = new scvzApp.sekundarniDataSetTableAdapters.sobaTableAdapter();
            this.studentTableAdapter1 = new scvzApp.sekundarniDataSetTableAdapters.studentTableAdapter();
            this.zaposlenikTableAdapter1 = new scvzApp.sekundarniDataSetTableAdapters.zaposlenikTableAdapter();
            this.lblPomoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekundarniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primarni_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(226, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dodavanje kvara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(143, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpis.Location = new System.Drawing.Point(204, 72);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(188, 71);
            this.txtOpis.TabIndex = 8;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdustani.FlatAppearance.BorderSize = 2;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOdustani.Location = new System.Drawing.Point(300, 382);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(146, 41);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.SlateGray;
            this.btnDodaj.FlatAppearance.BorderSize = 2;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDodaj.Location = new System.Drawing.Point(118, 382);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(146, 41);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj kvar";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(92, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Datum prijave";
            // 
            // txtDatum
            // 
            this.txtDatum.CustomFormat = "yyyy-mm-dd";
            this.txtDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDatum.Location = new System.Drawing.Point(204, 163);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(188, 26);
            this.txtDatum.TabIndex = 21;
            // 
            // cmbSoba
            // 
            this.cmbSoba.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbSoba.DataSource = this.sobaBindingSource2;
            this.cmbSoba.DisplayMember = "broj_sobe";
            this.cmbSoba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbSoba.FormattingEnabled = true;
            this.cmbSoba.Location = new System.Drawing.Point(204, 204);
            this.cmbSoba.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSoba.Name = "cmbSoba";
            this.cmbSoba.Size = new System.Drawing.Size(188, 28);
            this.cmbSoba.TabIndex = 24;
            this.cmbSoba.ValueMember = "idsoba";
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
            // sobaBindingSource1
            // 
            this.sobaBindingSource1.DataMember = "soba";
            this.sobaBindingSource1.DataSource = this.primarni_DataSet;
            // 
            // primarni_DataSet
            // 
            this.primarni_DataSet.DataSetName = "Primarni_DataSet";
            this.primarni_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbKvarPrijavio
            // 
            this.cmbKvarPrijavio.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbKvarPrijavio.DataSource = this.studentBindingSource2;
            this.cmbKvarPrijavio.DisplayMember = "prezime";
            this.cmbKvarPrijavio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbKvarPrijavio.FormattingEnabled = true;
            this.cmbKvarPrijavio.Location = new System.Drawing.Point(204, 245);
            this.cmbKvarPrijavio.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKvarPrijavio.Name = "cmbKvarPrijavio";
            this.cmbKvarPrijavio.Size = new System.Drawing.Size(188, 28);
            this.cmbKvarPrijavio.TabIndex = 25;
            this.cmbKvarPrijavio.ValueMember = "idstudent";
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataMember = "student";
            this.studentBindingSource2.DataSource = this.sekundarniDataSet;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(scvzApp.student);
            // 
            // zaposlenikBindingSource1
            // 
            this.zaposlenikBindingSource1.DataMember = "zaposlenik";
            this.zaposlenikBindingSource1.DataSource = this.sekundarniDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(141, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Soba";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(100, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Kvar prijavio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(134, 296);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Prijavljen",
            "Riješen"});
            this.cmbStatus.Location = new System.Drawing.Point(204, 285);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(188, 28);
            this.cmbStatus.TabIndex = 32;
            // 
            // sobaTableAdapter1
            // 
            this.sobaTableAdapter1.ClearBeforeFill = true;
            // 
            // sobaTableAdapter2
            // 
            this.sobaTableAdapter2.ClearBeforeFill = true;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // zaposlenikTableAdapter1
            // 
            this.zaposlenikTableAdapter1.ClearBeforeFill = true;
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.Location = new System.Drawing.Point(9, 7);
            this.lblPomoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(40, 13);
            this.lblPomoc.TabIndex = 33;
            this.lblPomoc.Text = "Pomoć";
            this.lblPomoc.Click += new System.EventHandler(this.lblPomoc_Click);
            // 
            // frmDodajKvar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 433);
            this.Controls.Add(this.lblPomoc);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbKvarPrijavio);
            this.Controls.Add(this.cmbSoba);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDodajKvar";
            this.ShowIcon = false;
            this.Text = "Dodaj kvar";
            this.Load += new System.EventHandler(this.frmDodajKvar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekundarniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primarni_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtDatum;
        private System.Windows.Forms.ComboBox cmbSoba;
        private System.Windows.Forms.ComboBox cmbKvarPrijavio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.BindingSource studentBindingSource;
       
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        
        private System.Windows.Forms.BindingSource studentBindingSource1;
        
        private System.Windows.Forms.BindingSource sobaBindingSource;
        
        private Primarni_DataSet primarni_DataSet;
        private System.Windows.Forms.BindingSource sobaBindingSource1;
        private Primarni_DataSetTableAdapters.sobaTableAdapter sobaTableAdapter1;
        private sekundarniDataSet sekundarniDataSet;
        private System.Windows.Forms.BindingSource sobaBindingSource2;
        private sekundarniDataSetTableAdapters.sobaTableAdapter sobaTableAdapter2;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private sekundarniDataSetTableAdapters.studentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource1;
        private sekundarniDataSetTableAdapters.zaposlenikTableAdapter zaposlenikTableAdapter1;
        private System.Windows.Forms.Label lblPomoc;
    }
}