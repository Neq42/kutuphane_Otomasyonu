using System;
using System.Collections.Generic;
using System.Text;

namespace kutuphane_Otomasyonu
{
    internal class Kutuphane
    {
        internal List<Kitap> kitapList = new List<Kitap>() { new Kitap("399388388", "Suç ve Ceza", "Dostoyevski", true), new Kitap("288934278", "1984", "George Orwell", true), new Kitap("478982378", "Sefiller", "Victor Hugo", true) };
        internal List<Uye> uyelerList = new List<Uye>();
   
    }
}