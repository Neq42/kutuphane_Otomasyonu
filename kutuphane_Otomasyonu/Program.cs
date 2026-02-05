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
                    Console.WriteLine("Kitap adı giriniz:");
                    string kitapAdi = Console.ReadLine();
                    Console.WriteLine("yazar adı giriniz:");
                    string yazar = Console.ReadLine();
                    Console.WriteLine("ısbn giriniz:");
                    string isbn = Console.ReadLine();
                    Kitap eklenecekKitap = new Kitap(isbn, kitapAdi, yazar, "Ödünç alınabilir");
                    geceYarisiKutuphanesi.kitapList.Add(eklenecekKitap);
                }
                else if (secim == "2")
                {
                    foreach (var kitap in geceYarisiKutuphanesi.kitapList)
                    {
                        Console.WriteLine(kitap.AD);
                        Console.WriteLine(kitap.YAZAR);
                        Console.WriteLine(kitap.DURUM);
                    }
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
                    Console.WriteLine("Silmek istediğiniz kitabın ismi nedir?");
                    string silinecekKitap = Console.ReadLine();
                    bool varMi = false;
                    foreach (var kitap in geceYarisiKutuphanesi.kitapList)
                    {
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
                    Console.WriteLine("Üye numaranızı giriniz.");
                    int girilenUyeNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Adınızı ve Soyadınızı giriniz.");
                    string girilenAdSoyad = Console.ReadLine();

                    Uye eklenecekUye = new Uye(girilenUyeNo, girilenAdSoyad);

                    geceYarisiKutuphanesi.uyelerList.Add(eklenecekUye);
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

                }
                else if (secim == "8")
                {

                }
                else if (secim == "0")
                {

                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama yaptınız!!!");
                }
            }
        }
    }
}
