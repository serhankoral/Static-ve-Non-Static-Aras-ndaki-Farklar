using System;

namespace Static_ve_Non_Static_Arasındaki_Farklar
{
    class Program
    {
        /*
         * Static ve non-static arasında en bariz fark static nesneden bağımsızlaşır
         * Non-Static de ise nesneye bağımlı olur
         * Yani bir nesne oluşturup ulaşım yapılır
         * Sürekli kullandığımızı nesneleri yada classları static olarak tanımlanmalı
         * static olarak tanımlanan class da bütün herşey static olmak zorunda
         */
        static void Main(string[] args)
        {
            //burada ekrana yaza ulamak için nesne ve fonksiyon ismi beraber
            Program program = new Program();
            program.ekranaYaz1("Ekrana Yaz 1");
            //Şimdi ekrana yaz fonksiyonu static olarak yapalım bakalım nasıl ulaşılacak
            ekranaYaz2("Ekrana Yaz 2");
            //görüldüğü gibi direk çağrılıyor çünkü program nesnesine ait bağımsız değil    
            //şimdi bir nesne içerisinde kullanalım
            //urun nesnesinden bir kaç tane oluşturulalım ve her seferinde kaç adet class oluşmuş
            Urun urun = new Urun();
            Urun urun1 = new Urun();
            Urun urun2 = new Urun();
            Urun urun3 = new Urun();
            Urun urun4 = new Urun();
            Urun urun5 = new Urun();
            Urun urun6 = new Urun();
            Urun urun7 = new Urun();
            Urun urun8 = new Urun();
            //class sayısı static olarak yapılınca nesneden ayrılıyor ve bağımsız kullanılıyor
        }
        void ekranaYaz1(string msj)
        {
            Console.WriteLine(msj);
        }
        static void ekranaYaz2(string msj)
        {
            Console.WriteLine(msj);
        }
        class Urun
        {
            private static int classSayisi { get; set; } = 0;
            public Urun()
            {
                classSayisi++;
                Console.WriteLine(classSayisi);
            }
            
        }

    }
}
