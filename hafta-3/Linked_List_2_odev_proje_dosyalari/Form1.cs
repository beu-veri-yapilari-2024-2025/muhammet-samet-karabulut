﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linked_List_2_odev
{
    public partial class Form1 : Form
    {
        private NotSistemi benimNotSistemim = new NotSistemi();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int ogrenciNo = Convert.ToInt32(txtOgrenciNo.Text);
                string dersKodu = txtDersKodu.Text;
                string harfNotu = txtHarfNotu.Text;

                if (string.IsNullOrWhiteSpace(dersKodu) || string.IsNullOrWhiteSpace(harfNotu))
                {
                    MessageBox.Show("Ders kodu ve harf notu boş olamaz!");
                    return;
                }

                bool basarili = benimNotSistemim.NotEkle(ogrenciNo, dersKodu, harfNotu);

                if (basarili)
                {
                    MessageBox.Show("Not başarıyla eklendi.");
                    // Temizlik
                    txtOgrenciNo.Clear();
                    txtDersKodu.Clear();
                    txtHarfNotu.Clear();
                }
                else
                {
                    MessageBox.Show("Hata: Bu not zaten kayıtlı olabilir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int ogrenciNo = Convert.ToInt32(txtOgrenciNo.Text);
                string dersKodu = txtDersKodu.Text;

                bool basarili = benimNotSistemim.NotSil(ogrenciNo, dersKodu);

                if (basarili)
                {
                    MessageBox.Show("Kayıt başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Hata: Silinecek kayıt bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnOgrenciDersListele_Click(object sender, EventArgs e)
        {
            try
            {
                int ogrenciNo = Convert.ToInt32(txtOgrenciNo.Text);
                var sonuclar = benimNotSistemim.OgrencininDersleriniListele(ogrenciNo);

                // Sonuçları ListBox'a (lstSonuc) aktar
                lstSonuc.Items.Clear(); // Önceki sonuçları temizle
                foreach (string satir in sonuclar)
                {
                    lstSonuc.Items.Add(satir);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnDersOgrenciListele_Click(object sender, EventArgs e)
        {
            try
            {
                string dersKodu = txtDersKodu.Text;
                var sonuclar = benimNotSistemim.DerstekiOgrencileriListele(dersKodu);

                // Sonuçları ListBox'a (lstSonuc) aktar
                lstSonuc.Items.Clear(); // Önceki sonuçları temizle
                foreach (string satir in sonuclar)
                {
                    lstSonuc.Items.Add(satir);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
