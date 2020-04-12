/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........: 1.Ödev
** ÖĞRENCİ ADI............: Osman PURÇAK
** ÖĞRENCİ NUMARASI.......: b191200373
** DERSİN ALINDIĞI GRUP...: A 
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplik_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        KitapVT vtsinif = new KitapVT();

        private void button1_Click(object sender, EventArgs e)
        {
            
            /* Burada daha önce nasıl ki accessin bağlantısını oluşturdum, bu sefer de list'in bağlantısını ekledim. */
            dataGridView1.DataSource = vtsinif.Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* kitap veritabanından ktpsinif nesnesini türettim ve AD ile YAZAR a ulaştım */
            Kitap ktpsinif = new Kitap();
            ktpsinif.ADI = textBox1.Text;
            ktpsinif.YAZARI = textBox2.Text;
            vtsinif.KitapEkle(ktpsinif);

            /* Kullanici kitap adi ve yazari girip kaydete basdıktan sonra ekrana kaydettigini belirten bir mesaj çıkardım */
            MessageBox.Show("Kitap başarıyla kaydedildi!");
        }
    }
}
