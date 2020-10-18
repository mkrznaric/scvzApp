namespace scvzApp.Forme_studenti
{
    partial class frmSmjestiStudentaUSobu
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
            this.dgvSlobodneSobe = new System.Windows.Forms.DataGridView();
            this.idsobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojsobeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojkrevetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ternarniDataSet = new scvzApp.ternarniDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSmjesti = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sobaTableAdapter = new scvzApp.ternarniDataSetTableAdapters.sobaTableAdapter();
            this.lblPomoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlobodneSobe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ternarniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSlobodneSobe
            // 
            this.dgvSlobodneSobe.AllowUserToAddRows = false;
            this.dgvSlobodneSobe.AllowUserToDeleteRows = false;
            this.dgvSlobodneSobe.AutoGenerateColumns = false;
            this.dgvSlobodneSobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlobodneSobe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsobaDataGridViewTextBoxColumn,
            this.brojsobeDataGridViewTextBoxColumn,
            this.brojkrevetaDataGridViewTextBoxColumn});
            this.dgvSlobodneSobe.DataSource = this.sobaBindingSource;
            this.dgvSlobodneSobe.Location = new System.Drawing.Point(9, 92);
            this.dgvSlobodneSobe.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSlobodneSobe.Name = "dgvSlobodneSobe";
            this.dgvSlobodneSobe.ReadOnly = true;
            this.dgvSlobodneSobe.RowTemplate.Height = 24;
            this.dgvSlobodneSobe.Size = new System.Drawing.Size(370, 266);
            this.dgvSlobodneSobe.TabIndex = 0;
            // 
            // idsobaDataGridViewTextBoxColumn
            // 
            this.idsobaDataGridViewTextBoxColumn.DataPropertyName = "idsoba";
            this.idsobaDataGridViewTextBoxColumn.HeaderText = "ID sobe";
            this.idsobaDataGridViewTextBoxColumn.Name = "idsobaDataGridViewTextBoxColumn";
            this.idsobaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojsobeDataGridViewTextBoxColumn
            // 
            this.brojsobeDataGridViewTextBoxColumn.DataPropertyName = "broj_sobe";
            this.brojsobeDataGridViewTextBoxColumn.HeaderText = "Broj sobe";
            this.brojsobeDataGridViewTextBoxColumn.Name = "brojsobeDataGridViewTextBoxColumn";
            this.brojsobeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojkrevetaDataGridViewTextBoxColumn
            // 
            this.brojkrevetaDataGridViewTextBoxColumn.DataPropertyName = "broj_kreveta";
            this.brojkrevetaDataGridViewTextBoxColumn.HeaderText = "Broj kreveta u sobi";
            this.brojkrevetaDataGridViewTextBoxColumn.Name = "brojkrevetaDataGridViewTextBoxColumn";
            this.brojkrevetaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sobaBindingSource
            // 
            this.sobaBindingSource.DataMember = "soba";
            this.sobaBindingSource.DataSource = this.ternarniDataSet;
            // 
            // ternarniDataSet
            // 
            this.ternarniDataSet.DataSetName = "ternarniDataSet";
            this.ternarniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(89, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Smještanje studenta u sobu";
            // 
            // btnSmjesti
            // 
            this.btnSmjesti.BackColor = System.Drawing.Color.SlateGray;
            this.btnSmjesti.FlatAppearance.BorderSize = 2;
            this.btnSmjesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSmjesti.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSmjesti.Location = new System.Drawing.Point(77, 374);
            this.btnSmjesti.Margin = new System.Windows.Forms.Padding(2);
            this.btnSmjesti.Name = "btnSmjesti";
            this.btnSmjesti.Size = new System.Drawing.Size(119, 41);
            this.btnSmjesti.TabIndex = 11;
            this.btnSmjesti.Text = "Dodaj";
            this.btnSmjesti.UseVisualStyleBackColor = false;
            this.btnSmjesti.Click += new System.EventHandler(this.btnSmjesti_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdustani.FlatAppearance.BorderSize = 2;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOdustani.Location = new System.Drawing.Point(201, 372);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(102, 41);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Izaberi sobu";
            // 
            // sobaTableAdapter
            // 
            this.sobaTableAdapter.ClearBeforeFill = true;
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.Location = new System.Drawing.Point(9, 7);
            this.lblPomoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(40, 13);
            this.lblPomoc.TabIndex = 52;
            this.lblPomoc.Text = "Pomoć";
            this.lblPomoc.Click += new System.EventHandler(this.lblPomoc_Click);
            // 
            // frmSmjestiStudentaUSobu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 445);
            this.Controls.Add(this.lblPomoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSmjesti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSlobodneSobe);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSmjestiStudentaUSobu";
            this.ShowIcon = false;
            this.Text = "Smjesti studenta u sobu";
            this.Load += new System.EventHandler(this.frmSmjestiStudentaUSobu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlobodneSobe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ternarniDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSlobodneSobe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSmjesti;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label2;
        private ternarniDataSet ternarniDataSet;
        private System.Windows.Forms.BindingSource sobaBindingSource;
        private ternarniDataSetTableAdapters.sobaTableAdapter sobaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojsobeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojkrevetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPomoc;
    }
}