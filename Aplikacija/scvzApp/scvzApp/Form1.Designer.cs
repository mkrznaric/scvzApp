namespace scvzApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.evidencijaSobaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretražiSobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledStudenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kvaroviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaKvarovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPomoc = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evidencijaSobaToolStripMenuItem,
            this.studentiToolStripMenuItem1,
            this.kvaroviToolStripMenuItem,
            this.računiToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // evidencijaSobaToolStripMenuItem
            // 
            this.evidencijaSobaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretražiSobeToolStripMenuItem});
            this.evidencijaSobaToolStripMenuItem.Name = "evidencijaSobaToolStripMenuItem";
            this.evidencijaSobaToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.evidencijaSobaToolStripMenuItem.Text = "Sobe";
            // 
            // pretražiSobeToolStripMenuItem
            // 
            this.pretražiSobeToolStripMenuItem.Name = "pretražiSobeToolStripMenuItem";
            this.pretražiSobeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.pretražiSobeToolStripMenuItem.Text = "Evidencija soba";
            this.pretražiSobeToolStripMenuItem.Click += new System.EventHandler(this.PretražiSobeToolStripMenuItem_Click);
            // 
            // studentiToolStripMenuItem1
            // 
            this.studentiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledStudenataToolStripMenuItem});
            this.studentiToolStripMenuItem1.Name = "studentiToolStripMenuItem1";
            this.studentiToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.studentiToolStripMenuItem1.Text = "Studenti";
            // 
            // pregledStudenataToolStripMenuItem
            // 
            this.pregledStudenataToolStripMenuItem.Name = "pregledStudenataToolStripMenuItem";
            this.pregledStudenataToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.pregledStudenataToolStripMenuItem.Text = "Evidencija studenata";
            this.pregledStudenataToolStripMenuItem.Click += new System.EventHandler(this.pregledStudenataToolStripMenuItem_Click);
            // 
            // kvaroviToolStripMenuItem
            // 
            this.kvaroviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evidencijaKvarovaToolStripMenuItem});
            this.kvaroviToolStripMenuItem.Name = "kvaroviToolStripMenuItem";
            this.kvaroviToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.kvaroviToolStripMenuItem.Text = "Kvarovi";
            // 
            // evidencijaKvarovaToolStripMenuItem
            // 
            this.evidencijaKvarovaToolStripMenuItem.Name = "evidencijaKvarovaToolStripMenuItem";
            this.evidencijaKvarovaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.evidencijaKvarovaToolStripMenuItem.Text = "Evidencija kvarova";
            this.evidencijaKvarovaToolStripMenuItem.Click += new System.EventHandler(this.evidencijaKvarovaToolStripMenuItem_Click);
            // 
            // računiToolStripMenuItem
            // 
            this.računiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evidencijaRačunaToolStripMenuItem});
            this.računiToolStripMenuItem.Name = "računiToolStripMenuItem";
            this.računiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.računiToolStripMenuItem.Text = "Računi";
            // 
            // evidencijaRačunaToolStripMenuItem
            // 
            this.evidencijaRačunaToolStripMenuItem.Name = "evidencijaRačunaToolStripMenuItem";
            this.evidencijaRačunaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.evidencijaRačunaToolStripMenuItem.Text = "Evidencija računa";
            this.evidencijaRačunaToolStripMenuItem.Click += new System.EventHandler(this.evidencijaRačunaToolStripMenuItem_Click);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(275, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "scvzApp Recepcioner";
            // 
            // lblPomoc
            // 
            this.lblPomoc.AutoSize = true;
            this.lblPomoc.BackColor = System.Drawing.Color.LightBlue;
            this.lblPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPomoc.Location = new System.Drawing.Point(725, 37);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(63, 15);
            this.lblPomoc.TabIndex = 7;
            this.lblPomoc.Text = "F1 Pomoć";
            this.lblPomoc.Click += new System.EventHandler(this.lblPomoc_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::scvzApp.Properties.Resources.banner;
            this.pictureBox2.Location = new System.Drawing.Point(21, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(767, 237);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.lblPomoc);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "scvzApp";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem evidencijaSobaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretražiSobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pregledStudenataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kvaroviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaKvarovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaRačunaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPomoc;
    }
}

