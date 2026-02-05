using System;
using System.Collections.Generic;
using System.Text;

namespace kutuphane_Otomasyonu
{
    internal class Kitap
    {
        internal string ISBN;
        internal string AD;
        internal string YAZAR;
        internal string DURUM;
        public Kitap(string _ISBN, string _AD, string _YAZAR, string _DURUM)
        {
            ISBN = _ISBN;
            AD = _AD;
            YAZAR = _YAZAR;
            DURUM = _DURUM;

        }
        public Kitap()
        {

        }

    }
}
