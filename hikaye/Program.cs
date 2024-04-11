namespace hikaye;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Adınızı Giriniz: ");
        string ad = Console.ReadLine();
        Console.WriteLine("Soyadınızı Giriniz: ");
        string soyad = Console.ReadLine();
        string tamAd = ad + " " + soyad;
        Console.WriteLine("Oyunumuza Hoşgeldinz " + tamAd);
        
        Console.WriteLine("Yolculuk Başlıyor");
        
        Console.WriteLine("Adada Kaybolan 3 İnsan Çıkış Yolu Arıyorlar.Karşılarına İki Yol Çıktı.");
        Console.WriteLine("1:Sağ 2:Sol");
        int yon = int.Parse(Console.ReadLine());

        if(yon == 1)
        {
            Console.WriteLine("Sağdan Devam Etmeye Karar Verdiler.Yollarına Devam Ederken Bu Sefer Karşılarına Ayı Çıktı.");
            Console.WriteLine("Saldır:1  Kaç:2 ");
            int saldır = int.Parse(Console.ReadLine());
            
            if(saldır == 1)
            {
                Console.WriteLine("Ayıyı Görünce Çok Korktular Ve Hemen Saldırıya Geçtiler Ama Ne Yazık Ki Ayı Hepsini Öldürdü.");
            }

            if (saldır == 2)
            {
                Console.WriteLine("Ayıyı Görünce Hemen Korkarak Kaçtılar Arkalarına Döndüklerinde Ayıdan Kurtulmuşlardı.");
                Console.WriteLine("En Sonunda Karşılarına Adanın Yerlesi Diye Düşündükleri Biri Çıktı.");
                Console.WriteLine("Dertlerini Anlattıktan Sonra Yerli Adam Düz Devam Etmelerini Söyledi.");
                Console.WriteLine("Güven:1 Güvenme:2 ");
                int guven = int.Parse(Console.ReadLine());
                if (guven == 1)
                {
                    Console.WriteLine("Yerli Adama Güvendiler Düz Devam Ettiler Ve Bir Anda Ağ Tuzağın İçine Düştüler.O An Anladılar Ki Adamın Yemeği Oldular.");
                }

                if (guven == 2)
                {
                    Console.WriteLine("Güvenmeyerek Yollarına Devam Ettiler.Sahile Geldiklerinde Arama Kurtarma Ekibini Gördüler Sevinç Çığlıklarıyla Kurtulmalarını Kutladılar.");
                }
            }
        }
        if(yon == 2)
        {
            Console.WriteLine("Soldan Gitmeye Karar Verdiler.Ormanın İçinde Yürüken Bir Mağara Gördüler");
            Console.WriteLine("Mağaraya Gir.1 Yola Devam Et:2 ");
            int gır = int.Parse(Console.ReadLine());

            if(gır == 1)
            {
                Console.WriteLine("Mağaraya Girmeye Karar Veriler Mağaranın İçinde Gezerken Bir Anda Taşlar Düşmeye Başladı Ve Orada ki Herkes Öldü. ");
            }
            if(gır == 2)
            {
                Console.WriteLine("Yolda Giderken Karşılarına Yerli Kasabası Çıktı.Oradaki İnsanlarla İyi Anlaştılar Ama Yemek Yedikten Sonra");
                Console.WriteLine("Bir Anda Başları Dönmeye Başladı Ve Yere Yığıldır.Yerliler Adamlara Yemek Sırası Biz De Dedi :)");
            }
        }
        
        
    }
}