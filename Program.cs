using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayısı);
            Calisan calisan=new Calisan("Ayşe","Yılmaz","İK");
            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayısı);
            Calisan calisan1=new Calisan("Deniz","Arda","İK");
            Calisan calisan2=new Calisan("Ece","Kökyar","İK");

            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayısı);
            
            Console.WriteLine("Toplama işlemi sonucu: {0}",Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma işlemi sonucu: {0}",Islemler.Çıkar(400,50));
           
        }
    }
    class Calisan
    {
        private static int calisanSayısı;
        public static int CalisanSayısı{get=>calisanSayısı;}

        private string Isim;
        private string Soyisim;
        private string Departman;
        static Calisan()
        {
            calisanSayısı=0;
        }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim=isim;
            this.Soyisim=soyisim;
            this.Departman=departman;
            calisanSayısı++;
        }

     
        
    }
    static class Islemler
    {
         public static long Topla(int sayi1,int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Çıkar(int sayi1,int sayi2)
        {
            return sayi1-sayi2;
        }
        
    }
}
