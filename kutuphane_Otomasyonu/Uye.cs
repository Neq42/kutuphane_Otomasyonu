using System;
using System.Collections.Generic;
using System.Text;

namespace kutuphane_Otomasyonu
{
    internal class Uye
    {
        internal int UyeNo;
        internal string adSoyad;
        List<Kitap> aldigiKitaplarList = new List<Kitap>();

        public Uye(int _uyeNo, string _adSoyad)
        {
            this.UyeNo = _uyeNo;
            this.adSoyad = _adSoyad;
            
        }
        public static void uyeEkle(List<Uye> uyelerList)
        {
            Console.WriteLine("Üye numarasını giriniz:");
            int uyeNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üye adını ve soyadını giriniz:");
            string adSoyad = Console.ReadLine();
            Uye yeniUye = new Uye(uyeNo, adSoyad);
            uyelerList.Add(yeniUye);
            Console.WriteLine("Yeni üye eklendi.");

        }
    }
}
