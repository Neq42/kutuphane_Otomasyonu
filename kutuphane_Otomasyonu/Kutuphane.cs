using System;
using System.Collections.Generic;
using System.Text;

namespace kutuphane_Otomasyonu
{
    internal class Kutuphane
    {
       internal List<Kitap> kitapList = new List<Kitap>() { new Kitap("399388388", "Suç ve Ceza", "Dostoyevski", "Ödünç alınabilir"), new Kitap("288934278", "1984", "George Orwell", "Ödünç alınabilir"), new Kitap("478982378", "Sefiller", "Victor Hugo","Ödünç alınabilir")};
       internal List<Uye> uyelerList = new List<Uye>();
       
    }
}
