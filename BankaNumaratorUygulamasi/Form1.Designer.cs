namespace BankaNumaratorUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gdvBekleyenler = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            cmbMusteriTipi = new ComboBox();
            btnEkle = new Button();
            label3 = new Label();
            txtTcNo = new TextBox();
            btnSiraNumarasiAl = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblIslemdekiMusteri = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)gdvBekleyenler).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // gdvBekleyenler
            // 
            gdvBekleyenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdvBekleyenler.Location = new Point(340, 45);
            gdvBekleyenler.Name = "gdvBekleyenler";
            gdvBekleyenler.RowTemplate.Height = 25;
            gdvBekleyenler.Size = new Size(408, 365);
            gdvBekleyenler.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Kozuka Gothic Pr6N R", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(340, 3);
            label1.Name = "label1";
            label1.Size = new Size(408, 43);
            label1.TabIndex = 1;
            label1.Text = "Bekleyen Müşteriler";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 35);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "Müşteri Türü:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbMusteriTipi
            // 
            cmbMusteriTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteriTipi.FormattingEnabled = true;
            cmbMusteriTipi.Location = new Point(147, 32);
            cmbMusteriTipi.Name = "cmbMusteriTipi";
            cmbMusteriTipi.Size = new Size(121, 23);
            cmbMusteriTipi.TabIndex = 3;
            cmbMusteriTipi.SelectedIndexChanged += cmbMusteriTipi_SelectedIndexChanged;
            // 
            // btnEkle
            // 
            btnEkle.Enabled = false;
            btnEkle.Location = new Point(20, 94);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(248, 30);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "SIRA NUMARASI AL";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 68);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 5;
            label3.Text = "TC Kimlik No:";
            // 
            // txtTcNo
            // 
            txtTcNo.Location = new Point(147, 65);
            txtTcNo.Name = "txtTcNo";
            txtTcNo.Size = new Size(121, 23);
            txtTcNo.TabIndex = 6;
            // 
            // btnSiraNumarasiAl
            // 
            btnSiraNumarasiAl.Enabled = false;
            btnSiraNumarasiAl.Location = new Point(20, 39);
            btnSiraNumarasiAl.Name = "btnSiraNumarasiAl";
            btnSiraNumarasiAl.Size = new Size(248, 36);
            btnSiraNumarasiAl.TabIndex = 7;
            btnSiraNumarasiAl.Text = "SIRADAKİ";
            btnSiraNumarasiAl.UseVisualStyleBackColor = true;
            btnSiraNumarasiAl.Click += btnSiraNumarasiAl_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTcNo);
            groupBox1.Controls.Add(cmbMusteriTipi);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 152);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kiosk";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSiraNumarasiAl);
            groupBox2.Location = new Point(12, 280);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(304, 130);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gişe Paneli";
            // 
            // lblIslemdekiMusteri
            // 
            lblIslemdekiMusteri.BorderStyle = BorderStyle.Fixed3D;
            lblIslemdekiMusteri.Location = new Point(121, 428);
            lblIslemdekiMusteri.Name = "lblIslemdekiMusteri";
            lblIslemdekiMusteri.Size = new Size(627, 41);
            lblIslemdekiMusteri.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 438);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 11;
            label5.Text = "İşlemdeki Müşteri:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 501);
            Controls.Add(label5);
            Controls.Add(lblIslemdekiMusteri);
            Controls.Add(gdvBekleyenler);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sıra Numarası";
            ((System.ComponentModel.ISupportInitialize)gdvBekleyenler).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gdvBekleyenler;
        private Label label1;
        private Label label2;
        private ComboBox cmbMusteriTipi;
        private Button btnEkle;
        private Label label3;
        private TextBox txtTcNo;
        private Button btnSiraNumarasiAl;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblIslemdekiMusteri;
        private Label label5;
    }
}