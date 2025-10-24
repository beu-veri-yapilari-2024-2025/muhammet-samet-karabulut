namespace Linked_List_2_odev
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.txtHarfNotu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnOgrenciDersListele = new System.Windows.Forms.Button();
            this.btnDersOgrenciListele = new System.Windows.Forms.Button();
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = false;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1 (sol panel - girişler)
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpInput);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(12);
            // 
            // splitContainer1.Panel2 (sağ panel - sonuçlar)
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstSonuc);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(12);
            this.splitContainer1.Size = new System.Drawing.Size(800, 357);
            this.splitContainer1.SplitterDistance = 240;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.txtOgrenciNo);
            this.grpInput.Controls.Add(this.txtDersKodu);
            this.grpInput.Controls.Add(this.txtHarfNotu);
            this.grpInput.Controls.Add(this.label1);
            this.grpInput.Controls.Add(this.label2);
            this.grpInput.Controls.Add(this.label3);
            this.grpInput.Controls.Add(this.btnEkle);
            this.grpInput.Controls.Add(this.btnSil);
            this.grpInput.Controls.Add(this.btnOgrenciDersListele);
            this.grpInput.Controls.Add(this.btnDersOgrenciListele);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(216, 333);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Kayıt Bilgileri";
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOgrenciNo.Location = new System.Drawing.Point(15, 36);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(183, 23);
            this.txtOgrenciNo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtOgrenciNo, "Öğrenci numarasını girin (ör: 2021001)");
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDersKodu.Location = new System.Drawing.Point(15, 93);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(183, 23);
            this.txtDersKodu.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtDersKodu, "Ders kodunu girin (ör: MAT101)");
            // 
            // txtHarfNotu
            // 
            this.txtHarfNotu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHarfNotu.Location = new System.Drawing.Point(15, 154);
            this.txtHarfNotu.Name = "txtHarfNotu";
            this.txtHarfNotu.Size = new System.Drawing.Size(183, 23);
            this.txtHarfNotu.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtHarfNotu, "Harf notu (ör: AA, BB, CC)");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Öğrenci No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ders Kodu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Harf Notu:";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(15, 194);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(183, 30);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "EKLE";
            this.toolTip1.SetToolTip(this.btnEkle, "Yeni kaydı ekle");
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(15, 231);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(183, 30);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.toolTip1.SetToolTip(this.btnSil, "Seçili kaydı sil");
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnOgrenciDersListele
            // 
            this.btnOgrenciDersListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btnOgrenciDersListele.FlatAppearance.BorderSize = 0;
            this.btnOgrenciDersListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciDersListele.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOgrenciDersListele.ForeColor = System.Drawing.Color.White;
            this.btnOgrenciDersListele.Location = new System.Drawing.Point(15, 268);
            this.btnOgrenciDersListele.Name = "btnOgrenciDersListele";
            this.btnOgrenciDersListele.Size = new System.Drawing.Size(183, 28);
            this.btnOgrenciDersListele.TabIndex = 5;
            this.btnOgrenciDersListele.Text = "ÖĞRENCİ DERS LİSTELE";
            this.toolTip1.SetToolTip(this.btnOgrenciDersListele, "Belirtilen öğrencinin derslerini listele");
            this.btnOgrenciDersListele.UseVisualStyleBackColor = false;
            this.btnOgrenciDersListele.Click += new System.EventHandler(this.btnOgrenciDersListele_Click);
            // 
            // btnDersOgrenciListele
            // 
            this.btnDersOgrenciListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btnDersOgrenciListele.FlatAppearance.BorderSize = 0;
            this.btnDersOgrenciListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDersOgrenciListele.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDersOgrenciListele.ForeColor = System.Drawing.Color.White;
            this.btnDersOgrenciListele.Location = new System.Drawing.Point(15, 302);
            this.btnDersOgrenciListele.Name = "btnDersOgrenciListele";
            this.btnDersOgrenciListele.Size = new System.Drawing.Size(183, 28);
            this.btnDersOgrenciListele.TabIndex = 6;
            this.btnDersOgrenciListele.Text = "DERS ÖĞRENCİ LİSTELE";
            this.toolTip1.SetToolTip(this.btnDersOgrenciListele, "Belirtilen dersin öğrenci listesini göster");
            this.btnDersOgrenciListele.UseVisualStyleBackColor = false;
            this.btnDersOgrenciListele.Click += new System.EventHandler(this.btnDersOgrenciListele_Click);
            // 
            // lstSonuc
            // 
            this.lstSonuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSonuc.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.ItemHeight = 15;
            this.lstSonuc.Location = new System.Drawing.Point(12, 12);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(532, 333);
            this.lstSonuc.TabIndex = 7;
            this.toolTip1.SetToolTip(this.lstSonuc, "Sonuçlar burada görüntülenir");
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(820, 396);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci - Ders Kayıtları";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.TextBox txtHarfNotu;
        private System.Windows.Forms.TextBox txtDersKodu;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnOgrenciDersListele;
        private System.Windows.Forms.Button btnDersOgrenciListele;
        private System.Windows.Forms.ListBox lstSonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

