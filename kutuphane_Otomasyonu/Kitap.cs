using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace kutuphane_Otomasyonu
{
    internal class Kitap
    {

        internal string ISBN;
        internal string AD;
        internal string YAZAR;
        internal bool DURUM;
        public Kitap(string _ISBN, string _AD, string _YAZAR, bool _DURUM)
        {
            ISBN = _ISBN;
            AD = _AD;
            YAZAR = _YAZAR;
            DURUM = _DURUM;

        }
        public Kitap()
        {

        }

        public static void OduncVer(List<Kitap> kitaps)
        {
            foreach (Kitap item in kitaps)
            {
                if (item.DURUM)
                {
                    Console.WriteLine("Kitap Adı: " + item.AD + " Yazar: " + item.YAZAR + " ISBN: " + item.ISBN);
                }
            }

            Console.WriteLine("Ödünç alınacak kitap ISBN no:");
            string isbn = Console.ReadLine();

            if (isbn != null)
            {
                foreach (Kitap item in kitaps)
                {
                    if (item.ISBN == isbn)
                    {
                        if (item.DURUM)
                        {
                            item.DURUM = false;
                            Console.WriteLine("Kitap ödünç alındı.");
                            return;
                        }
                    }
                }
            }
            else if (isbn == null)
                Console.WriteLine("Girilen ISBN numarasına sahip kitap bulunamadı.");
        }




        public static void OduncAlinanKitaplariListele(Kutuphane geceYarisiKutuphanesi)
        {
            bool oduncKitapVarMi = false;

            foreach (var kitap in geceYarisiKutuphanesi.kitapList)
            {
                if (kitap.DURUM == false)
                {
                    Console.WriteLine("Kitap Adı: " + kitap.AD);
                    Console.WriteLine("Yazar: " + kitap.YAZAR);
                    Console.WriteLine("Durum: Ödünçte");
                    Console.WriteLine("-------------------");
                    oduncKitapVarMi = true;
                }
            }

            if (!oduncKitapVarMi)
            {
                Console.WriteLine("Şu anda ödünç alınmış kitap yok.");
            }
        }
        public static void kitapListele(List<Kitap> kitapList)
        {
            foreach (Kitap kitap in kitapList)
            {
                Console.WriteLine(kitap.AD);
                Console.WriteLine(kitap.YAZAR);
                Console.WriteLine(kitap.DURUM == true ? "Alınabilir" : "Ödünç Verildi");
            }
        }
        public static void kitapEkle(List<Kitap> kitapList)
        {
            Kutuphane geceYarisiKutuphanesi = new Kutuphane();
            Console.WriteLine("Kitap adı giriniz:");
            string kitapAdi = Console.ReadLine();
            Console.WriteLine("yazar adı giriniz:");
            string yazar = Console.ReadLine();
            Console.WriteLine("ısbn giriniz:");
            string isbn = Console.ReadLine();
            Kitap yeniKitap = new Kitap(isbn, kitapAdi, yazar, true);
            kitapList.Add(yeniKitap);

            Console.WriteLine("Kitap eklendi.");
        }






    }
}


