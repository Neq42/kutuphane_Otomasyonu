using System.Collections;

namespace kutuphane_Otomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----KÜTÜPHANEYE HOŞGELDİNİZ-----");

            Kutuphane geceYarisiKutuphanesi = new Kutuphane();
            while (true)
            {
                Console.WriteLine("1:Yeni kitap ekle\n2:Tüm kitapları listele\n3:Kitap ara\n4:Kitap sil\n5:Üye ekle:");
                Console.WriteLine("6:Üyeleri listele\n7:Kitap ödünç ver:\n8:Ödünç alınan kitapları listele\n0:Çıkış");
                Console.WriteLine("-----Seçiminiz-----");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    Kitap.kitapEkle(geceYarisiKutuphanesi.kitapList);
                }
                else if (secim == "2")
                {
                    Kitap.kitapListele(geceYarisiKutuphanesi.kitapList);
                }
                else if (secim == "3")
                {
                    Console.WriteLine("Kitap ismini giriniz:");
                    string girilenKitapİsmi = Console.ReadLine();
                    bool varMi = false;
                    foreach (var kitap in geceYarisiKutuphanesi.kitapList)
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
                else if (secim == "4")
                {
                    foreach (var kitap in geceYarisiKutuphanesi.kitapList)
                    {
                        Kitap.kitapListele(geceYarisiKutuphanesi.kitapList);

                        bool varMi = false;
                        Console.WriteLine("Silmek istediğiniz kitabın ismi nedir?");
                        string silinecekKitap = Console.ReadLine();
                        varMi = silinecekKitap.Equals(kitap.AD, StringComparison.OrdinalIgnoreCase);
                        if (varMi)
                        {
                            geceYarisiKutuphanesi.kitapList.Remove(kitap);
                            break;
                        }
                    }
                }
                else if (secim == "5")
                {
                    Uye.uyeEkle(geceYarisiKutuphanesi.uyelerList);
                }
                else if (secim == "6")
                {
                    foreach (var uye in geceYarisiKutuphanesi.uyelerList)
                    {
                        Console.WriteLine("Üyemiz:" + uye.adSoyad);
                    }
                }
                else if (secim == "7")
                {
                    Kitap.OduncVer(geceYarisiKutuphanesi.kitapList);
                }
                else if (secim == "8")
                {
                    Kitap.OduncAlinanKitaplariListele(geceYarisiKutuphanesi);
                }
                else if (secim == "0")
                {
                    Console.WriteLine("Programdan çıkılıyor... Güle güle ");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama yaptınız!!!");
                }
            }
        }
    }
}
