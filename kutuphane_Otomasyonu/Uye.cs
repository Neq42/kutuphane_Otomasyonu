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
    }
}
