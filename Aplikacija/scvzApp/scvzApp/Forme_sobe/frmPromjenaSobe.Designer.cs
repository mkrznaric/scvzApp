namespace scvzApp
{
    partial class frmPromjenaSobe
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBrojSobe = new System.Windows.Forms.Label();
            this.lblBrojKreveta = new System.Windows.Forms.Label();
            this.txtBrojSobe = new System.Windows.Forms.TextBox();
            this.btnPromijeni = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnObriši = new System.Windows.Forms.Button();
            this.cmbKreveti = new System.Windows.Forms.ComboBox();
            this.btn_Pomoc = new System.Windows.Forms.Button();
            this.pnl_Pomoc = new System.Windows.Forms.Panel();
            this.btn_ZatvoriPomoc = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Pomoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::scvzApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(29, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Promjena sobe";
            // 
            // lblBrojSobe
            // 
            this.lblBrojSobe.AutoSize = true;
            this.lblBrojSobe.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojSobe.Location = new System.Drawing.Point(166, 83);
            this.lblBrojSobe.Name = "lblBrojSobe";
            this.lblBrojSobe.Size = new System.Drawing.Size(72, 20);
            this.lblBrojSobe.TabIndex = 2;
            this.lblBrojSobe.Text = "Broj sobe:";
            // 
            // lblBrojKreveta
            // 
            this.lblBrojKreveta.AutoSize = true;
            this.lblBrojKreveta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojKreveta.Location = new System.Drawing.Point(166, 129);
            this.lblBrojKreveta.Name = "lblBrojKreveta";
            this.lblBrojKreveta.Size = new System.Drawing.Size(85, 20);
            this.lblBrojKreveta.TabIndex = 3;
            this.lblBrojKreveta.Text = "Broj kreveta:";
            // 
            // txtBrojSobe
            // 
            this.txtBrojSobe.Location = new System.Drawing.Point(270, 83);
            this.txtBrojSobe.Name = "txtBrojSobe";
            this.txtBrojSobe.Size = new System.Drawing.Size(100, 20);
            this.txtBrojSobe.TabIndex = 5;
            this.txtBrojSobe.TextChanged += new System.EventHandler(this.TxtBrojSobe_TextChanged);
            // 
            // btnPromijeni
            // 
            this.btnPromijeni.Enabled = false;
            this.btnPromijeni.Location = new System.Drawing.Point(170, 171);
            this.btnPromijeni.Name = "btnPromijeni";
            this.btnPromijeni.Size = new System.Drawing.Size(90, 23);
            this.btnPromijeni.TabIndex = 8;
            this.btnPromijeni.Text = "Promijeni";
            this.btnPromijeni.UseVisualStyleBackColor = true;
            this.btnPromijeni.Click += new System.EventHandler(this.BtnPromijeni_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(280, 171);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(90, 23);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // btnObriši
            // 
            this.btnObriši.BackColor = System.Drawing.Color.Red;
            this.btnObriši.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObriši.Location = new System.Drawing.Point(170, 212);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(195, 39);
            this.btnObriši.TabIndex = 10;
            this.btnObriši.Text = "Obriši";
            this.btnObriši.UseVisualStyleBackColor = false;
            this.btnObriši.Click += new System.EventHandler(this.BtnObriši_Click);
            // 
            // cmbKreveti
            // 
            this.cmbKreveti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKreveti.FormattingEnabled = true;
            this.cmbKreveti.Location = new System.Drawing.Point(270, 129);
            this.cmbKreveti.Name = "cmbKreveti";
            this.cmbKreveti.Size = new System.Drawing.Size(100, 21);
            this.cmbKreveti.TabIndex = 11;
            this.cmbKreveti.SelectedIndexChanged += new System.EventHandler(this.CmbKreveti_SelectedIndexChanged);
            // 
            // btn_Pomoc
            // 
            this.btn_Pomoc.Location = new System.Drawing.Point(407, 13);
            this.btn_Pomoc.Name = "btn_Pomoc";
            this.btn_Pomoc.Size = new System.Drawing.Size(19, 23);
            this.btn_Pomoc.TabIndex = 12;
            this.btn_Pomoc.Text = "?";
            this.btn_Pomoc.UseVisualStyleBackColor = true;
            this.btn_Pomoc.Click += new System.EventHandler(this.Btn_Pomoc_Click);
            // 
            // pnl_Pomoc
            // 
            this.pnl_Pomoc.Controls.Add(this.btn_ZatvoriPomoc);
            this.pnl_Pomoc.Controls.Add(this.listBox1);
            this.pnl_Pomoc.Location = new System.Drawing.Point(91, 53);
            this.pnl_Pomoc.Name = "pnl_Pomoc";
            this.pnl_Pomoc.Size = new System.Drawing.Size(335, 121);
            this.pnl_Pomoc.TabIndex = 13;
            this.pnl_Pomoc.Visible = false;
            // 
            // btn_ZatvoriPomoc
            // 
            this.btn_ZatvoriPomoc.Location = new System.Drawing.Point(314, 3);
            this.btn_ZatvoriPomoc.Name = "btn_ZatvoriPomoc";
            this.btn_ZatvoriPomoc.Size = new System.Drawing.Size(23, 23);
            this.btn_ZatvoriPomoc.TabIndex = 1;
            this.btn_ZatvoriPomoc.Text = "X";
            this.btn_ZatvoriPomoc.UseVisualStyleBackColor = true;
            this.btn_ZatvoriPomoc.Click += new System.EventHandler(this.Btn_ZatvoriPomoc_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Za promjenu broja sobe obrišite stari broj i unesite novi.",
            "Za promjenu broja kreveta odaberite novi broj kreveta.",
            "Prilikom prve promjene gumb promijeni ćete moči pritisnuti,",
            "ako ne želite spremiti promjene pritisnite odustani. Ako želite",
            "obrisati sobu iz baze pritisnite Obriši. Ako želite zatvoriti izbornik",
            "za pomoć pritisnite X u njegovom uglu."});
            this.listBox1.Location = new System.Drawing.Point(21, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(306, 82);
            this.listBox1.TabIndex = 0;
            // 
            // frmPromjenaSobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 297);
            this.Controls.Add(this.pnl_Pomoc);
            this.Controls.Add(this.btn_Pomoc);
            this.Controls.Add(this.cmbKreveti);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPromijeni);
            this.Controls.Add(this.txtBrojSobe);
            this.Controls.Add(this.lblBrojKreveta);
            this.Controls.Add(this.lblBrojSobe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPromjenaSobe";
            this.ShowIcon = false;
            this.Text = "Promjena Sobe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Pomoc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBrojSobe;
        private System.Windows.Forms.Label lblBrojKreveta;
        private System.Windows.Forms.TextBox txtBrojSobe;
        private System.Windows.Forms.Button btnPromijeni;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.ComboBox cmbKreveti;
        private System.Windows.Forms.Button btn_Pomoc;
        private System.Windows.Forms.Panel pnl_Pomoc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_ZatvoriPomoc;
    }
}