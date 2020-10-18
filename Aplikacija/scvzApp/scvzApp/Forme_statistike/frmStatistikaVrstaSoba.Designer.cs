namespace scvzApp
{
    partial class frmStatistikaVrstaSoba
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
            this.chrtVrsteSoba = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Pomoc = new System.Windows.Forms.Button();
            this.pnl_Pomoc = new System.Windows.Forms.Panel();
            this.btn_ZatvoriPomoc = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chrtVrsteSoba)).BeginInit();
            this.pnl_Pomoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // chrtVrsteSoba
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtVrsteSoba.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtVrsteSoba.Legends.Add(legend1);
            this.chrtVrsteSoba.Location = new System.Drawing.Point(12, 12);
            this.chrtVrsteSoba.Name = "chrtVrsteSoba";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Broj Soba";
            this.chrtVrsteSoba.Series.Add(series1);
            this.chrtVrsteSoba.Size = new System.Drawing.Size(528, 400);
            this.chrtVrsteSoba.TabIndex = 0;
            this.chrtVrsteSoba.Text = "Statistika vrsta soba";
            // 
            // btn_Pomoc
            // 
            this.btn_Pomoc.Location = new System.Drawing.Point(547, 13);
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
            this.pnl_Pomoc.Location = new System.Drawing.Point(339, 42);
            this.pnl_Pomoc.Name = "pnl_Pomoc";
            this.pnl_Pomoc.Size = new System.Drawing.Size(283, 149);
            this.pnl_Pomoc.TabIndex = 2;
            this.pnl_Pomoc.Visible = false;
            // 
            // btn_ZatvoriPomoc
            // 
            this.btn_ZatvoriPomoc.Location = new System.Drawing.Point(258, 5);
            this.btn_ZatvoriPomoc.Name = "btn_ZatvoriPomoc";
            this.btn_ZatvoriPomoc.Size = new System.Drawing.Size(20, 23);
            this.btn_ZatvoriPomoc.TabIndex = 1;
            this.btn_ZatvoriPomoc.Text = "X";
            this.btn_ZatvoriPomoc.UseVisualStyleBackColor = true;
            this.btn_ZatvoriPomoc.Click += new System.EventHandler(this.Btn_ZatvoriPomoc_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "U obliku stupčastog grafa pokazuje koliko ima soba s ",
            "određenim brojem kreveta. Na dnu stupca piše o",
            "kojoj je vrsti sobe riječ, a na vrhu koliko takvih soba ",
            "trenutno ima u domu. Graf se automatski prilagođava",
            "promjenama na bazi. Za zatvaranje izbornika za pomoć",
            "pritisnite tipku X u njegovom uglu."});
            this.listBox1.Location = new System.Drawing.Point(4, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 95);
            this.listBox1.TabIndex = 0;
            // 
            // frmStatistikaVrstaSoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 427);
            this.Controls.Add(this.pnl_Pomoc);
            this.Controls.Add(this.btn_Pomoc);
            this.Controls.Add(this.chrtVrsteSoba);
            this.Name = "frmStatistikaVrstaSoba";
            this.ShowIcon = false;
            this.Text = "Statistika Vrsta Soba";
            this.Load += new System.EventHandler(this.FrmStatistikaVrstaSoba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtVrsteSoba)).EndInit();
            this.pnl_Pomoc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtVrsteSoba;
        private System.Windows.Forms.Button btn_Pomoc;
        private System.Windows.Forms.Panel pnl_Pomoc;
        private System.Windows.Forms.Button btn_ZatvoriPomoc;
        private System.Windows.Forms.ListBox listBox1;
    }
}