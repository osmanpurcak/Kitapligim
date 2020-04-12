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

namespace Kitaplik_Test
{
    class Kitap
    {
        
        /* Burada veritabanına eklemiş olduğumuz id, ad ve yazarı tanımlıyoruz. */

        int id;
        string ad;
        string yazar;
        
        /* Ve sınıfımızı oluşturuyoruz*/

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string ADI
        {
            get { return ad; }
            set { ad = value; }
        }
        public string YAZARI
        {
            get { return yazar; }
            set { yazar = value; }
        }
    }
}
