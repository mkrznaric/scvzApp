namespace scvzApp
{
    partial class frmStatistikaStudentiSpol
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
            this.chrtStudenti = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Pomoc = new System.Windows.Forms.Button();
            this.pnl_Pomoc = new System.Windows.Forms.Panel();
            this.btn_ZatvoriPomoc = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chrtStudenti)).BeginInit();
            this.pnl_Pomoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // chrtStudenti
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtStudenti.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtStudenti.Legends.Add(legend1);
            this.chrtStudenti.Location = new System.Drawing.Point(12, 12);
            this.chrtStudenti.Name = "chrtStudenti";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chrtStudenti.Series.Add(series1);
            this.chrtStudenti.Size = new System.Drawing.Size(497, 344);
            this.chrtStudenti.TabIndex = 0;
            this.chrtStudenti.Text = "Statistika studenata po spolu";
            // 
            // btn_Pomoc
            // 
            this.btn_Pomoc.Location = new System.Drawing.Point(516, 13);
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
            this.pnl_Pomoc.Location = new System.Drawing.Point(309, 42);
            this.pnl_Pomoc.Name = "pnl_Pomoc";
            this.pnl_Pomoc.Size = new System.Drawing.Size(279, 179);
            this.pnl_Pomoc.TabIndex = 2;
            this.pnl_Pomoc.Visible = false;
            // 
            // btn_ZatvoriPomoc
            // 
            this.btn_ZatvoriPomoc.Location = new System.Drawing.Point(227, 4);
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
            "U obliku grafa pokazuje koliko muških a koliko ženskih ",
            "studenata trenutno prijavljenih u domu. Graf ",
            "se automatski prilagođava promjenama na bazi.",
            "Za zatvaranje izbornika za pomoć pritisnite tipku",
            "X u njegovorm uglu."});
            this.listBox1.Location = new System.Drawing.Point(11, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 134);
            this.listBox1.TabIndex = 0;
            // 
            // frmStatistikaStudentiSpol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 368);
            this.Controls.Add(this.pnl_Pomoc);
            this.Controls.Add(this.btn_Pomoc);
            this.Controls.Add(this.chrtStudenti);
            this.Name = "frmStatistikaStudentiSpol";
            this.ShowIcon = false;
            this.Text = "Statistika studenata po spolu";
            ((System.ComponentModel.ISupportInitialize)(this.chrtStudenti)).EndInit();
            this.pnl_Pomoc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtStudenti;
        private System.Windows.Forms.Button btn_Pomoc;
        private System.Windows.Forms.Panel pnl_Pomoc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_ZatvoriPomoc;
    }
}