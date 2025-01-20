namespace MyFinancialCRM
{
    partial class FrmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnfaturalar = new System.Windows.Forms.Button();
            this.btnbanks = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbltotalbalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblbilingtıtle = new System.Windows.Forms.Label();
            this.lblbillamount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbllasthavale = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnfaturalar);
            this.panel1.Controls.Add(this.btnbanks);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 592);
            this.panel1.TabIndex = 2;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(41, 448);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(171, 41);
            this.button8.TabIndex = 7;
            this.button8.Text = "Çıkış";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(41, 270);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "Banka Hareketleri\r\n\r\n\r\n\r\n";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(41, 388);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(171, 41);
            this.button7.TabIndex = 6;
            this.button7.Text = "Ayarlar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(41, 328);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 41);
            this.button6.TabIndex = 5;
            this.button6.Text = "Dashboard";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(41, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Giderler";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnfaturalar
            // 
            this.btnfaturalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfaturalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfaturalar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfaturalar.Location = new System.Drawing.Point(41, 153);
            this.btnfaturalar.Name = "btnfaturalar";
            this.btnfaturalar.Size = new System.Drawing.Size(171, 41);
            this.btnfaturalar.TabIndex = 2;
            this.btnfaturalar.Text = "Faturalar";
            this.btnfaturalar.UseVisualStyleBackColor = true;
            this.btnfaturalar.Click += new System.EventHandler(this.btnfaturalar_Click);
            // 
            // btnbanks
            // 
            this.btnbanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbanks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbanks.Location = new System.Drawing.Point(41, 97);
            this.btnbanks.Name = "btnbanks";
            this.btnbanks.Size = new System.Drawing.Size(171, 41);
            this.btnbanks.TabIndex = 1;
            this.btnbanks.Text = "Bankalar";
            this.btnbanks.UseVisualStyleBackColor = true;
            this.btnbanks.Click += new System.EventHandler(this.btnbanks_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(41, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kategoriler";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(261, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 79);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "İstatistik Paneli";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LimeGreen;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbltotalbalance);
            this.panel3.Location = new System.Drawing.Point(261, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 155);
            this.panel3.TabIndex = 4;
            // 
            // lbltotalbalance
            // 
            this.lbltotalbalance.AutoSize = true;
            this.lbltotalbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalbalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltotalbalance.Location = new System.Drawing.Point(23, 78);
            this.lbltotalbalance.Name = "lbltotalbalance";
            this.lbltotalbalance.Size = new System.Drawing.Size(128, 42);
            this.lbltotalbalance.TabIndex = 1;
            this.lbltotalbalance.Text = "0.00 ₺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toplam Bakiyem";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblbilingtıtle);
            this.panel4.Controls.Add(this.lblbillamount);
            this.panel4.Location = new System.Drawing.Point(517, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 155);
            this.panel4.TabIndex = 5;
            // 
            // lblbilingtıtle
            // 
            this.lblbilingtıtle.AutoSize = true;
            this.lblbilingtıtle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbilingtıtle.ForeColor = System.Drawing.Color.Red;
            this.lblbilingtıtle.Location = new System.Drawing.Point(3, 27);
            this.lblbilingtıtle.Name = "lblbilingtıtle";
            this.lblbilingtıtle.Size = new System.Drawing.Size(194, 31);
            this.lblbilingtıtle.TabIndex = 2;
            this.lblbilingtıtle.Text = "Fatura Başlığı";
            // 
            // lblbillamount
            // 
            this.lblbillamount.AutoSize = true;
            this.lblbillamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbillamount.ForeColor = System.Drawing.Color.Red;
            this.lblbillamount.Location = new System.Drawing.Point(9, 78);
            this.lblbillamount.Name = "lblbillamount";
            this.lblbillamount.Size = new System.Drawing.Size(110, 42);
            this.lblbillamount.TabIndex = 1;
            this.lblbillamount.Text = "Tutar";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.lbllasthavale);
            this.panel5.Location = new System.Drawing.Point(775, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 155);
            this.panel5.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Gelen Son Havale";
            // 
            // lbllasthavale
            // 
            this.lbllasthavale.AutoSize = true;
            this.lbllasthavale.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllasthavale.ForeColor = System.Drawing.Color.White;
            this.lbllasthavale.Location = new System.Drawing.Point(23, 78);
            this.lbllasthavale.Name = "lbllasthavale";
            this.lbllasthavale.Size = new System.Drawing.Size(128, 42);
            this.lbllasthavale.TabIndex = 1;
            this.lbllasthavale.Text = "0.00 ₺";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(261, 333);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(357, 261);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(668, 333);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(357, 258);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(261, 252);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(357, 75);
            this.panel6.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(668, 252);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(357, 75);
            this.panel7.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bankalar ve banka hesaplarındaki para \r\nmiktarlarına aşağıdaki grafikten ulaşabil" +
    "irsiniz.\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ödenen ve ödenmesi gereken fatura tutarlarına\r\naşağıdaki grafikten ulaşabilirsini" +
    "z.\r\n";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 592);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnfaturalar;
        private System.Windows.Forms.Button btnbanks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotalbalance;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblbilingtıtle;
        private System.Windows.Forms.Label lblbillamount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbllasthavale;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
    }
}