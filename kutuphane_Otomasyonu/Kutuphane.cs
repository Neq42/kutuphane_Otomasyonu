using System;
using System.Collections.Generic;
using System.Text;

namespace kutuphane_Otomasyonu
{
    internal class Kutuphane
    {
        internal List<Kitap> kitapList = new List<Kitap>() { new Kitap("399388388", "Suç ve Ceza", "Dostoyevski", true), new Kitap("288934278", "1984", "George Orwell", true), new Kitap("478982378", "Sefiller", "Victor Hugo", true) };
        internal List<Uye> uyelerList = new List<Uye>();
        public static Kitap kitapSil(Kitap book, Kutuphane library)
        {
            bool varMi = false;
            Console.WriteLine("Silmek istediğiniz kitabın ismi nedir?");
            string silinecekKitap = Console.ReadLine();
            varMi = silinecekKitap.Equals(book.AD, StringComparison.OrdinalIgnoreCase);
            if (varMi)
            {
                library.kitapList.Remove(book);
            }
            return book;
        }
        public static void kitapAra(List<Kitap> bookList)
        {
            Console.WriteLine("Kitap ismini giriniz:");
            string girilenKitapİsmi = Console.ReadLine();
            bool varMi = false;
            foreach (var kitap in bookList)
            {
                varMi = girilenKitapİsmi.Equals(kitap.AD, StringComparison.OrdinalIgnoreCase);
                if (varMi)
                {
                    break;
                }
            }
            if (varMi)
            {
                Console.WriteLine("Buyrun efendim:" + girilenKitapİsmi);
            }
            else
            {
                Console.WriteLine("Aradığınız kitap elimizde yok.");
            }
        }
    }
}