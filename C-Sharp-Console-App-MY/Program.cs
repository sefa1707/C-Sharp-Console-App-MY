using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Console_App_MY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Video Başlangıcı

            //İlk komutumuz Merha Dünya
            //Console.Write("Merhaba Dünya"); //Bu komutu tek başına kullanırsak siyah ekranda merhaba dünya yazısı gelir ve hemen kapanır.

            //Console.Write("Merhaba Dünya"); 
            //Console.Read(); //Klavyeden bir tuşa basılmasını bekler.Bizim burada bu kodu kullanma amacımız merhaba dünya yazısı biz bir tuşa basana kadar kalması için.

            //Console.WriteLine("Merhaba Dünya");//Yazdığımız ifadenin tüm satırı kaplamasını ve bir sonraki işlemin bir alt satırdan başlamasını sağlar.
            //Console.Read();

            //1.Video Bitişi

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //2.Video Başlangıcı

            //Ad isminde bir değişken oluşturan ve bu değişken içerisine sefa değerinin atamasını yapan sonrasında ise bu değeri console ekranına yazdırdıktan sonra bir tuşa basılmasını bekleyen kod bloğu.
            //string Ad; //metinsel türde bir değişken tanımlama.
            //Ad = "sefa"; //değişkene metinsel bir değer atama.
            //Console.WriteLine(Ad); //değişkeni ekrana yazdırma.
            //Console.Read(); //yazdırılan değerden sonra bir tuşa basılmasını beklenmesini sağlayan kod bloğu.

            //Kullanıcıdan alınan değeri değişkene atayan  ve sonrasında ekrana yazdıran kod bloğu.
            //string ad;
            //Console.WriteLine("Adınızı Yazınız : ");
            //ad = Console.ReadLine();
            //Console.WriteLine("Hoşgeldin " +  ad);
            //Console.Read();

            //string ad, soyad, yas, meslek, sehir;
            //Console.WriteLine("Adınızı Giriniz : ");
            //ad= Console.ReadLine();
            //Console.WriteLine("Soyadınızı Giriniz : ");
            //soyad = Console.ReadLine();
            //Console.WriteLine("Yaşınızı Giriniz : ");
            //yas = Console.ReadLine();
            //Console.WriteLine("Mesleğinizi Giriniz : ");
            //meslek = Console.ReadLine();
            //Console.WriteLine("Şehrinizi Giriniz : ");
            //sehir = Console.ReadLine();
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Adınız : " + ad);
            //Console.WriteLine("Soyadınız : " + soyad);
            //Console.WriteLine("Yaşınız : " + yas);
            //Console.WriteLine("Mesleğiniz : " + meslek);
            //Console.WriteLine("Şehriniz : " + sehir);
            //Console.Read();


            //string ad, soyad, yas, meslek, sehir;
            //Console.WriteLine("Adınızı Giriniz : ");
            //ad = Console.ReadLine();
            //Console.WriteLine("Soyadınızı Giriniz : ");
            //soyad = Console.ReadLine();
            //Console.WriteLine("Yaşınızı Giriniz : ");
            //yas = Console.ReadLine();
            //Console.WriteLine("Mesleğinizi Giriniz : ");
            //meslek = Console.ReadLine();
            //Console.WriteLine("Şehrinizi Giriniz : ");
            //sehir = Console.ReadLine();
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Adınız : {0} Soyadınız : {1} Yaşınız : {2} Mesleğiniz : {3} Şehri : {4} " , ad,soyad, yas, meslek, sehir);
            //Console.Read();
            //2.Video Bitişi

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //3.Video Başlangıcı

            //int sayi1, sayi2, toplam;
            //sayi1 = 10;
            //sayi2 = 15;
            //toplam=sayi1 + sayi2;
            //Console.WriteLine(toplam);
            //Console.Read();

            //int a, b, c;
            //a = 8;
            //b = 7;
            //c = a * b;
            //Console.WriteLine("a*b=" + c) ;
            //Console.Read();

            //int a, b, c;
            //a = 8;
            //b = 7;
            //c = a * b;
            //Console.WriteLine("{0} * {1} = {2}", a,b,c);
            //Console.Read();

            //int deger1, deger2, bolum;
            //deger1 = 12;
            //deger2 = 22;
            //bolum=(deger1+deger2)/2;
            //Console.WriteLine(bolum);
            //Console.Read();

            //string ad, soyad, numara;
            //int sinav1, sinav2, sinav3, proje, ortalama;
            //ad = "mehmet";
            //soyad = "yücedağ";
            //numara = "123456";
            //sinav1 = 60;
            //sinav2 = 70;
            //sinav3 = 100;
            //proje = 90;
            //ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            //Console.WriteLine("****Öğrenci Bilgileri****");
            //Console.WriteLine();
            //Console.WriteLine("Ad = "+ad);
            //Console.WriteLine("Soyad = "+soyad);
            //Console.WriteLine("Numara = "+numara);
            //Console.WriteLine();
            //Console.WriteLine("****Not Bilgileri****");
            //Console.WriteLine();
            //Console.WriteLine("Sınav 1= " + sinav1);
            //Console.WriteLine("Sınav 2= " + sinav2);
            //Console.WriteLine("Sınav 3= " + sinav3);
            //Console.WriteLine("Proje 1= " + proje);
            //Console.WriteLine();
            //Console.WriteLine("****Ortalama Notu****");
            //Console.WriteLine();
            //Console.WriteLine("Ders notu Ortalaması = " + ortalama);
            //Console.Read();

            //3.Video Bitişi

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //4.Video Başlangıcı

            //int sayi1, sayi2, toplam;
            //Console.WriteLine("***Toplama İşlemi****");
            //Console.WriteLine("1.Sayıyı Giriniz: ");
            //sayi1=Convert.ToInt32(Console.ReadLine()); //metinsel olarak alınan değerin sayısal değere çevrilmesini sonrasında değişkene atanmasını sağlıyor.
            //Console.WriteLine("2.Sayıyı Giriniz: ");
            //sayi2=Convert.ToInt32(Console.ReadLine()); //metinsel olarak alınan değerin sayısal değere çevrilmesini sonrasında değişkene atanmasını sağlıyor.
            //toplam = sayi1 + sayi2;
            //Console.WriteLine("Toplam = " + toplam);
            //Console.Read();

            //int sayi1, sayi2, toplam, fark, carpim, bolum;
            //Console.WriteLine("****Aritmetik 4 İşlem****");
            //Console.WriteLine();
            //Console.Write("1.Sayıyı giriniz : ");
            //sayi1=Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.Sayıyı giriniz : ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine() ;
            //toplam = sayi1 + sayi2; 
            //carpim = sayi1 * sayi2; 
            //bolum = sayi1 / sayi2; 
            //fark = sayi1 - sayi2; 
            //Console.WriteLine("Toplam   = " + toplam) ;
            //Console.WriteLine("Fark     = " + fark) ;
            //Console.WriteLine("Çarpım   = " + carpim) ;
            //Console.WriteLine("Bölüm    = " + bolum) ;
            //Console.Read(); 

            //int kenar, karealani, karecevresi;
            //Console.WriteLine("***Klavyeden bir kenarı girilen karenin Alanı ve Çevresi Bulan Programın Kodları***");
            //Console.WriteLine();
            //Console.Write("Karenin bir kenar uzunluğunu giriniz. :");
            //kenar = Convert.ToInt32(Console.ReadLine());
            //karealani = kenar * kenar;
            //karecevresi = kenar * 4;
            //Console.WriteLine("Karenin Alanı : " + karealani);
            //Console.WriteLine("Karenin Çevresi : " + karecevresi);
            //Console.Read();

            //int kisakenar, uzunkenar, alan, cevre;
            //Console.WriteLine("***Klavyeden girilen bilgiye göre dikdörtgenin Alanı ve Çevresi Bulan Programın Kodları***");
            //Console.WriteLine();
            //Console.WriteLine("Kısa Kenari Giriniz : ");
            //kisakenar= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Uzun Kenari Giriniz : ");
            //uzunkenar = Convert.ToInt32(Console.ReadLine());
            //alan=kisakenar * uzunkenar;
            //cevre = (kisakenar * 2) + (uzunkenar * 2);
            //Console.WriteLine("Alan = " + alan + " Çevre = " + cevre);
            //Console.Read();

            //4.Video Bitişi

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //5.Video Başlangıcı

            //double sinav1, sinav2, sinav3, proje, ortalama; // double değişken tanımlama.
            //string ad, soyad, numara;
            //Console.WriteLine("****Öğrenci Notu Hesaplama****");
            //Console.Write("Öğrenci Adını Yazınız : ");
            //ad = Console.ReadLine();
            //Console.Write("Öğrenci soyadını Yazınız : ");
            //soyad = Console.ReadLine();
            //Console.Write("Öğrenci Numarasını Yazınız : ");
            //numara = Console.ReadLine();
            //Console.Write("Sınav 1 Notunu Yazınız :");
            //sinav1 = Convert.ToDouble(Console.ReadLine()); //klavyeden girilen ifadenin double değişekene atanması.
            //Console.Write("Sınav 2 Notunu Yazınız :");
            //sinav2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Sınav 3 Notunu Yazınız :");
            //sinav3 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Proje Notunu Yazınız :");
            //proje = Convert.ToDouble(Console.ReadLine());
            //ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            //Console.WriteLine("***Öğrenci Ders Karnesi***");
            //Console.WriteLine("Ad = " + ad);
            //Console.WriteLine("Soyad = " + soyad);
            //Console.WriteLine("Numara = " + numara);
            //Console.WriteLine("Öğrencinin ders notu ortalaması : " + ortalama);
            //Console.Read(); 
            //5.Video Bitişi

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //6.Video Başlangıcı

            //string isim;
            //isim = "mehmet  ";
            //if (isim == "mehmet")
            //{
            //    Console.WriteLine("Doğru isim.");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış isim.");
            //}
            //Console.Read();

            //string isim;
            //Console.WriteLine("***Kullanıcı Adı Doğrulama Sistemi***");
            //Console.WriteLine();
            //Console.Write("Kullanıcı Adını Yazınız : ");
            //isim=Console.ReadLine();
            //if (isim == "mehmet")
            //{
            //    Console.WriteLine("Kullanıcı Adı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı Adı Yanlış");
            //}
            //Console.Read();

            //string sehir;
            //Console.WriteLine("Türkiyenin Başkenti Neresidir ?");
            //Console.Write("Cevap : ");
            //sehir=Console.ReadLine();
            //if (sehir == "ankara") 
            //{
            //    Console.WriteLine("Doğru Cevap " + sehir);
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış Cevap "+sehir);
            //}
            //Console.Read();

            //int sayi;
            //Console.WriteLine("Pozitif / Negatif Sorgusu Yapmak için Tam Bir Sayı Giriniz ?");
            //Console.Write("Sayı = ");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 0)
            //{
            //    Console.WriteLine("Sayı Pozitif.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Negatif.");
            //}
            //Console.Read();

            //int sayi;
            //Console.WriteLine("Pozitif / Negatif Sorgusu Yapmak için Tam Bir Sayı Giriniz ?");
            //Console.Write("Sayı = ");
            //sayi=Convert.ToInt32(Console.ReadLine());
            //if (sayi >= 0)
            //{
            //    Console.WriteLine("Sayı Pozitif.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Negatif.");
            //}
            //Console.Read();

            //double sinav1, sinav2, ortalama;
            //Console.WriteLine("****Öğrenci Notu Hesaplama****");
            //Console.Write("Sınav 1 = ");
            //sinav1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Sınav 2 = ");
            //sinav2 = Convert.ToDouble(Console.ReadLine());
            //ortalama = (sinav1 + sinav2) / 2;
            //Console.WriteLine("***Geçme Kalma Durumu Sonucu***");
            //if (ortalama >= 50)
            //{
            //    Console.WriteLine("Öğrenci Dersi {0} Notuyla Başarılı Geçti", ortalama);
            //}
            //else
            //{
            //    Console.WriteLine("Öğrenci Dersten {0} Notuyla Başarısız Oldu", ortalama);
            //}
            //Console.Read();


            //6.Video Bitişi

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //7.Video Başlangıcı












            //7.Video Bitişi

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //5.Video Başlangıcı


            //5.Video Bitişi

        }
    }
}
