namespace scvzApp
{
    partial class frmKreirajSobu
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblBrojKreveta = new System.Windows.Forms.Label();
            this.lblBrojSobe = new System.Windows.Forms.Label();
            this.txtBrojSobe = new System.Windows.Forms.TextBox();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbKreveti = new System.Windows.Forms.ComboBox();
            this.btn_pomoc = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnl_Pomoc = new System.Windows.Forms.Panel();
            this.btn_ZatvoriPomoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Pomoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(110, 13);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(293, 34);
            this.lblNaslov.TabIndex = 1;
            this.lblNaslov.Text = "Kreiranje nove sobe";
            // 
            // lblBrojKreveta
            // 
            this.lblBrojKreveta.AutoSize = true;
            this.lblBrojKreveta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojKreveta.Location = new System.Drawing.Point(130, 118);
            this.lblBrojKreveta.Name = "lblBrojKreveta";
            this.lblBrojKreveta.Size = new System.Drawing.Size(85, 20);
            this.lblBrojKreveta.TabIndex = 2;
            this.lblBrojKreveta.Text = "Broj kreveta:";
            // 
            // lblBrojSobe
            // 
            this.lblBrojSobe.AutoSize = true;
            this.lblBrojSobe.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojSobe.Location = new System.Drawing.Point(130, 70);
            this.lblBrojSobe.Name = "lblBrojSobe";
            this.lblBrojSobe.Size = new System.Drawing.Size(72, 20);
            this.lblBrojSobe.TabIndex = 3;
            this.lblBrojSobe.Text = "Broj sobe:";
            // 
            // txtBrojSobe
            // 
            this.txtBrojSobe.Location = new System.Drawing.Point(227, 70);
            this.txtBrojSobe.Name = "txtBrojSobe";
            this.txtBrojSobe.Size = new System.Drawing.Size(121, 20);
            this.txtBrojSobe.TabIndex = 5;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(134, 163);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(95, 23);
            this.btnKreiraj.TabIndex = 8;
            this.btnKreiraj.Text = "Kreiraj!";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.BtnKreiraj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(257, 163);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(91, 23);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::scvzApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 94);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbKreveti
            // 
            this.cmbKreveti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKreveti.FormattingEnabled = true;
            this.cmbKreveti.Location = new System.Drawing.Point(227, 118);
            this.cmbKreveti.Name = "cmbKreveti";
            this.cmbKreveti.Size = new System.Drawing.Size(121, 21);
            this.cmbKreveti.TabIndex = 10;
            // 
            // btn_pomoc
            // 
            this.btn_pomoc.Location = new System.Drawing.Point(400, 2);
            this.btn_pomoc.Name = "btn_pomoc";
            this.btn_pomoc.Size = new System.Drawing.Size(22, 23);
            this.btn_pomoc.TabIndex = 11;
            this.btn_pomoc.Text = "?";
            this.btn_pomoc.UseVisualStyleBackColor = true;
            this.btn_pomoc.Click += new System.EventHandler(this.Btn_pomoc_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "U polje broj sobe upišite broj sobe, aplikacija vam neće",
            "dozvoliti kreiranje nove sobe ako soba s tim brojem već postoji.",
            "Pod broj kreveta odaberite ponuđeni broj kreveta. ",
            "Ako želite odbaciti promjene pritisnite gumb Odustani.",
            "Ako želite kreirati sobu pritisnite gumb Kreiraj! Za zatvaranje",
            "izbornika za pomoć pritisnite X u njegovom uglu."});
            this.listBox1.Location = new System.Drawing.Point(13, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(306, 95);
            this.listBox1.TabIndex = 0;
            // 
            // pnl_Pomoc
            // 
            this.pnl_Pomoc.Controls.Add(this.btn_ZatvoriPomoc);
            this.pnl_Pomoc.Controls.Add(this.listBox1);
            this.pnl_Pomoc.Location = new System.Drawing.Point(65, 50);
            this.pnl_Pomoc.Name = "pnl_Pomoc";
            this.pnl_Pomoc.Size = new System.Drawing.Size(346, 119);
            this.pnl_Pomoc.TabIndex = 12;
            this.pnl_Pomoc.Visible = false;
            // 
            // btn_ZatvoriPomoc
            // 
            this.btn_ZatvoriPomoc.Location = new System.Drawing.Point(325, 3);
            this.btn_ZatvoriPomoc.Name = "btn_ZatvoriPomoc";
            this.btn_ZatvoriPomoc.Size = new System.Drawing.Size(18, 23);
            this.btn_ZatvoriPomoc.TabIndex = 1;
            this.btn_ZatvoriPomoc.Text = "X";
            this.btn_ZatvoriPomoc.UseVisualStyleBackColor = true;
            this.btn_ZatvoriPomoc.Click += new System.EventHandler(this.Btn_ZatvoriPomoc_Click);
            // 
            // frmKreirajSobu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 299);
            this.Controls.Add(this.pnl_Pomoc);
            this.Controls.Add(this.btn_pomoc);
            this.Controls.Add(this.cmbKreveti);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtBrojSobe);
            this.Controls.Add(this.lblBrojSobe);
            this.Controls.Add(this.lblBrojKreveta);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.pictureBox1);
            this.Enabled = false;
            this.Name = "frmKreirajSobu";
            this.ShowIcon = false;
            this.Text = "Kreiranje sobe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Pomoc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblBrojKreveta;
        private System.Windows.Forms.Label lblBrojSobe;
        private System.Windows.Forms.TextBox txtBrojSobe;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ComboBox cmbKreveti;
        private System.Windows.Forms.Button btn_pomoc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel pnl_Pomoc;
        private System.Windows.Forms.Button btn_ZatvoriPomoc;
    }
}