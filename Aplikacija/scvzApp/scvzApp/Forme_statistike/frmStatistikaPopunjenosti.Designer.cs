namespace scvzApp
{
    partial class frmStatistikaPopunjenosti
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
            this.chrtSobe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Pomoć = new System.Windows.Forms.Button();
            this.btn_ZatvoriPomoc = new System.Windows.Forms.Button();
            this.pnl_Pomoc = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chrtSobe)).BeginInit();
            this.pnl_Pomoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // chrtSobe
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtSobe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtSobe.Legends.Add(legend1);
            this.chrtSobe.Location = new System.Drawing.Point(13, 13);
            this.chrtSobe.Name = "chrtSobe";
            this.chrtSobe.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chrtSobe.Series.Add(series1);
            this.chrtSobe.Size = new System.Drawing.Size(517, 348);
            this.chrtSobe.TabIndex = 0;
            this.chrtSobe.Text = "Popunjenost svih soba";
            // 
            // btn_Pomoć
            // 
            this.btn_Pomoć.Location = new System.Drawing.Point(550, 13);
            this.btn_Pomoć.Name = "btn_Pomoć";
            this.btn_Pomoć.Size = new System.Drawing.Size(75, 23);
            this.btn_Pomoć.TabIndex = 1;
            this.btn_Pomoć.Text = "Pomoć";
            this.btn_Pomoć.UseVisualStyleBackColor = true;
            this.btn_Pomoć.Click += new System.EventHandler(this.Btn_Pomoć_Click);
            // 
            // btn_ZatvoriPomoc
            // 
            this.btn_ZatvoriPomoc.Location = new System.Drawing.Point(254, 8);
            this.btn_ZatvoriPomoc.Name = "btn_ZatvoriPomoc";
            this.btn_ZatvoriPomoc.Size = new System.Drawing.Size(19, 23);
            this.btn_ZatvoriPomoc.TabIndex = 2;
            this.btn_ZatvoriPomoc.Text = "X";
            this.btn_ZatvoriPomoc.UseVisualStyleBackColor = true;
            this.btn_ZatvoriPomoc.Click += new System.EventHandler(this.Btn_ZatvoriPomoc_Click);
            // 
            // pnl_Pomoc
            // 
            this.pnl_Pomoc.Controls.Add(this.listBox1);
            this.pnl_Pomoc.Controls.Add(this.btn_ZatvoriPomoc);
            this.pnl_Pomoc.Location = new System.Drawing.Point(346, 42);
            this.pnl_Pomoc.Name = "pnl_Pomoc";
            this.pnl_Pomoc.Size = new System.Drawing.Size(279, 210);
            this.pnl_Pomoc.TabIndex = 3;
            this.pnl_Pomoc.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "U obliku grafa pokazuje koliko ima popunjenih soba",
            "(sobe u kojima nema slobodnih kreveta) i  ",
            "koliko ima slobodnih soba.",
            "Graf se automatski prilagođava promjenama na bazi.",
            "Za zatvaranje izbornika za pomoć pritisnite gumb X",
            "u njegovom uglu."});
            this.listBox1.Location = new System.Drawing.Point(3, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(270, 160);
            this.listBox1.TabIndex = 3;
            // 
            // frmStatistikaPopunjenosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 375);
            this.Controls.Add(this.pnl_Pomoc);
            this.Controls.Add(this.btn_Pomoć);
            this.Controls.Add(this.chrtSobe);
            this.Name = "frmStatistikaPopunjenosti";
            this.ShowIcon = false;
            this.Text = "Statistika popunjenosti soba";
            ((System.ComponentModel.ISupportInitialize)(this.chrtSobe)).EndInit();
            this.pnl_Pomoc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtSobe;
        private System.Windows.Forms.Button btn_Pomoć;
        private System.Windows.Forms.Button btn_ZatvoriPomoc;
        private System.Windows.Forms.Panel pnl_Pomoc;
        private System.Windows.Forms.ListBox listBox1;
    }
}