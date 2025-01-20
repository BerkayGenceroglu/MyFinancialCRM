namespace MyFinancialCRM
{
    partial class FrmBanks
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnfaturalar = new System.Windows.Forms.Button();
            this.btnbankalar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblziraatbankbalance = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblyapıkredıbankbalance = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbldenizbankbalance = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblbankProcess5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.llblbankProcess4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblbankProcess3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblbankProcess2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblbankProcess1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Controls.Add(this.btnbankalar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 534);
            this.panel1.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(43, 448);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(171, 41);
            this.button8.TabIndex = 7;
            this.button8.Text = "Çıkış";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(43, 270);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "Banka Hareketleri\r\n\r\n\r\n\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(43, 388);
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
            this.button6.Location = new System.Drawing.Point(43, 328);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 41);
            this.button6.TabIndex = 5;
            this.button6.Text = "Dashboard";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(43, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Giderler";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnfaturalar
            // 
            this.btnfaturalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfaturalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfaturalar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfaturalar.Location = new System.Drawing.Point(43, 153);
            this.btnfaturalar.Name = "btnfaturalar";
            this.btnfaturalar.Size = new System.Drawing.Size(171, 41);
            this.btnfaturalar.TabIndex = 2;
            this.btnfaturalar.Text = "Faturalar";
            this.btnfaturalar.UseVisualStyleBackColor = true;
            this.btnfaturalar.Click += new System.EventHandler(this.btnfaturalar_Click);
            // 
            // btnbankalar
            // 
            this.btnbankalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbankalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbankalar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbankalar.Location = new System.Drawing.Point(43, 97);
            this.btnbankalar.Name = "btnbankalar";
            this.btnbankalar.Size = new System.Drawing.Size(171, 41);
            this.btnbankalar.TabIndex = 1;
            this.btnbankalar.Text = "Bankalar";
            this.btnbankalar.UseVisualStyleBackColor = true;
            this.btnbankalar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(43, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kategoriler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(235)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 64);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Berkay Genceroğlu Banka Formu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.lblziraatbankbalance);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(268, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 155);
            this.panel3.TabIndex = 2;
            // 
            // lblziraatbankbalance
            // 
            this.lblziraatbankbalance.AutoSize = true;
            this.lblziraatbankbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblziraatbankbalance.Location = new System.Drawing.Point(23, 100);
            this.lblziraatbankbalance.Name = "lblziraatbankbalance";
            this.lblziraatbankbalance.Size = new System.Drawing.Size(128, 42);
            this.lblziraatbankbalance.TabIndex = 1;
            this.lblziraatbankbalance.Text = "0.00 ₺";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.lblyapıkredıbankbalance);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(524, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 155);
            this.panel4.TabIndex = 3;
            // 
            // lblyapıkredıbankbalance
            // 
            this.lblyapıkredıbankbalance.AutoSize = true;
            this.lblyapıkredıbankbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyapıkredıbankbalance.Location = new System.Drawing.Point(30, 100);
            this.lblyapıkredıbankbalance.Name = "lblyapıkredıbankbalance";
            this.lblyapıkredıbankbalance.Size = new System.Drawing.Size(128, 42);
            this.lblyapıkredıbankbalance.TabIndex = 1;
            this.lblyapıkredıbankbalance.Text = "0.00 ₺";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.lbldenizbankbalance);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(780, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 155);
            this.panel5.TabIndex = 3;
            // 
            // lbldenizbankbalance
            // 
            this.lbldenizbankbalance.AutoSize = true;
            this.lbldenizbankbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldenizbankbalance.Location = new System.Drawing.Point(35, 100);
            this.lbldenizbankbalance.Name = "lbldenizbankbalance";
            this.lbldenizbankbalance.Size = new System.Drawing.Size(128, 42);
            this.lbldenizbankbalance.TabIndex = 1;
            this.lbldenizbankbalance.Text = "0.00 ₺";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(90)))));
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblbankProcess5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.llblbankProcess4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblbankProcess3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblbankProcess2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblbankProcess1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(268, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 349);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Son 5 İşlem Hareketi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(759, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------------------------------";
            // 
            // lblbankProcess5
            // 
            this.lblbankProcess5.AutoSize = true;
            this.lblbankProcess5.Location = new System.Drawing.Point(1, 278);
            this.lblbankProcess5.Name = "lblbankProcess5";
            this.lblbankProcess5.Size = new System.Drawing.Size(68, 20);
            this.lblbankProcess5.TabIndex = 10;
            this.lblbankProcess5.Text = "Metin 5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(759, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------------------------------";
            // 
            // llblbankProcess4
            // 
            this.llblbankProcess4.AutoSize = true;
            this.llblbankProcess4.Location = new System.Drawing.Point(1, 218);
            this.llblbankProcess4.Name = "llblbankProcess4";
            this.llblbankProcess4.Size = new System.Drawing.Size(68, 20);
            this.llblbankProcess4.TabIndex = 8;
            this.llblbankProcess4.Text = "Metin 4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(759, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------------------------------";
            // 
            // lblbankProcess3
            // 
            this.lblbankProcess3.AutoSize = true;
            this.lblbankProcess3.Location = new System.Drawing.Point(3, 157);
            this.lblbankProcess3.Name = "lblbankProcess3";
            this.lblbankProcess3.Size = new System.Drawing.Size(68, 20);
            this.lblbankProcess3.TabIndex = 6;
            this.lblbankProcess3.Text = "Metin 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(759, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------------------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Metin 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(759, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------------------------------";
            // 
            // lblbankProcess2
            // 
            this.lblbankProcess2.AutoSize = true;
            this.lblbankProcess2.Location = new System.Drawing.Point(3, 100);
            this.lblbankProcess2.Name = "lblbankProcess2";
            this.lblbankProcess2.Size = new System.Drawing.Size(68, 20);
            this.lblbankProcess2.TabIndex = 2;
            this.lblbankProcess2.Text = "Metin 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(759, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------------------------------";
            // 
            // lblbankProcess1
            // 
            this.lblbankProcess1.AutoSize = true;
            this.lblbankProcess1.Location = new System.Drawing.Point(1, 40);
            this.lblbankProcess1.Name = "lblbankProcess1";
            this.lblbankProcess1.Size = new System.Drawing.Size(68, 20);
            this.lblbankProcess1.TabIndex = 0;
            this.lblbankProcess1.Text = "Metin 1";
            // 
            // FrmBanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1037, 592);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBanks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBanks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnfaturalar;
        private System.Windows.Forms.Button btnbankalar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblziraatbankbalance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblyapıkredıbankbalance;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbldenizbankbalance;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblbankProcess1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblbankProcess5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label llblbankProcess4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblbankProcess3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblbankProcess2;
    }
}

