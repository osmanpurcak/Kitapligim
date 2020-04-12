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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;  /* Access ile işlem yaptığım için bu kütüphaneyi ekledim */

namespace Kitaplik_Test
{

    class KitapVT /* VT(VeriTabanı) */
    {
        /*Burada access veritabanının bulunduğu klasörü projeye bağladım */

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Osman\Desktop\Projelerim\Kitaplik_Test\Kitaplik_Test\bin\Debug\Kitaplik.mdb");


        /* Listeleme işlemini yaptırmak için public listi ekledim */
        public List<Kitap> Liste() 
        {
            /* ktp listini türettim. */
            List<Kitap> ktp=new List<Kitap>();
            baglanti.Open();


            /* * From ile listeleme için veritabanında Kitaplar kısmından almasını istedim */
            OleDbCommand komut=new OleDbCommand("Select * From Kitaplar", baglanti);
            OleDbDataReader dr=komut.ExecuteReader();
            
            while (dr.Read())
            {
                /* k nesnesini türettim ve aşağısında ise  int olduğu için convert ile dönüşüm uyguladım. */
                Kitap k = new Kitap();
                k.ID = Convert.ToInt16(dr[0].ToString());
                k.ADI = dr[1].ToString();
                k.YAZARI = dr[2].ToString();

                /* burada liste k nesnesinden gelen id, adı ve yazarı ekledim. */
                ktp.Add(k);
            }
            baglanti.Close();
            return ktp;
         }
        
        /* Kitap sınıfından kt adında bir değer türettim. */
        public void KitapEkle(Kitap kt) 
        {
        
            /* insert into ile Kitaplarin içine kitapad ve yazari ekle dedim. Bunlari da @p1 ve @p2 parametreleri ile kitad adı ve yazardan almasını istedim */
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kitaplar (KitapAd,Yazar) values (@p1,@p2)", baglanti);

            /* daha önce tanımladığımız kt.ADI VE kt.YAZARI değişkenlerini parametlere atadım */
            komut.Parameters.AddWithValue("@p1", kt.ADI);
            komut.Parameters.AddWithValue("@p2", kt.YAZARI);
            
            /* Bu metod ile geriye int olarak satır sayısı dödürmesini istedim */
            komut.ExecuteNonQuery();

            baglanti.Close();
        }
     }

 }
