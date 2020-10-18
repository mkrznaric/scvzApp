namespace scvzApp
{
    partial class frmStatistikaZupanije
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrtZupanije = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Pomoc = new System.Windows.Forms.Button();
            this.pnl_Pomoc = new System.Windows.Forms.Panel();
            this.btn_ZatvoriPomoc = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chrtZupanije)).BeginInit();
            this.pnl_Pomoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // chrtZupanije
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtZupanije.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtZupanije.Legends.Add(legend1);
            this.chrtZupanije.Location = new System.Drawing.Point(13, 13);
            this.chrtZupanije.Name = "chrtZupanije";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Naziv zupanije";
            this.chrtZupanije.Series.Add(series1);
            this.chrtZupanije.Size = new System.Drawing.Size(677, 425);
            this.chrtZupanije.TabIndex = 0;
            this.chrtZupanije.Text = "chrtZupanije";
            // 
            // btn_Pomoc
            // 
            this.btn_Pomoc.Location = new System.Drawing.Point(697, 13);
            this.btn_Pomoc.Name = "btn_Pomoc";
            this.btn_Pomoc.Size = new System.Drawing.Size(75, 23);
            this.btn_Pomoc.TabIndex = 1;
            this.btn_Pomoc.Text = "Pomoć";
            this.btn_Pomoc.UseVisualStyleBackColor = true;
            this.btn_Pomoc.Click += new System.EventHandler(this.Btn_Pomoc_Click);
            // 
            // pnl_Pomoc
            // 
            this.pnl_Pomoc.Controls.Add(this.btn_ZatvoriPomoc);
            this.pnl_Pomoc.Controls.Add(this.listBox1);
            this.pnl_Pomoc.Location = new System.Drawing.Point(522, 42);
            this.pnl_Pomoc.Name = "pnl_Pomoc";
            this.pnl_Pomoc.Size = new System.Drawing.Size(250, 189);
            this.pnl_Pomoc.TabIndex = 2;
            this.pnl_Pomoc.Visible = false;
            // 
            // btn_ZatvoriPomoc
            // 
            this.btn_ZatvoriPomoc.Location = new System.Drawing.Point(225, 4);
            this.btn_ZatvoriPomoc.Name = "btn_ZatvoriPomoc";
            this.btn_ZatvoriPomoc.Size = new System.Drawing.Size(19, 23);
            this.btn_ZatvoriPomoc.TabIndex = 1;
            this.btn_ZatvoriPomoc.Text = "X";
            this.btn_ZatvoriPomoc.UseVisualStyleBackColor = true;
            this.btn_ZatvoriPomoc.Click += new System.EventHandler(this.Btn_ZatvoriPomoc_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "U obliku stupčastog grafa pokazuje koliko ima ",
            "studenata i iz koje županije. Na dnu svakog",
            "stupca se nalazi naziv županije, a na vrhu broj ",
            "studenata iz te županije. Graf se automatski ",
            "prilagođava promjenama na bazi. Za zatvaranje",
            "izbornika za pomoć pritisnite tipku X u njegovom",
            "uglu."});
            this.listBox1.Location = new System.Drawing.Point(4, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 121);
            this.listBox1.TabIndex = 0;
            // 
            // frmStatistikaZupanije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.pnl_Pomoc);
            this.Controls.Add(this.btn_Pomoc);
            this.Controls.Add(this.chrtZupanije);
            this.Name = "frmStatistikaZupanije";
            this.ShowIcon = false;
            this.Text = "Statistika županije";
            this.Load += new System.EventHandler(this.FrmStatistikaZupanije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtZupanije)).EndInit();
            this.pnl_Pomoc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtZupanije;
        private System.Windows.Forms.Button btn_Pomoc;
        private System.Windows.Forms.Panel pnl_Pomoc;
        private System.Windows.Forms.Button btn_ZatvoriPomoc;
        private System.Windows.Forms.ListBox listBox1;
    }
}