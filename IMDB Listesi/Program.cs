using IMDB_Listesi;

class Program
{
    static void Main(string[] args)
    {
        List<Film> filmListesi = new List<Film>();
        bool devamEtmekIstiyorMu = true;

        while (devamEtmekIstiyorMu)
        {
            Console.Write("Film ismi: ");
            string isim = Console.ReadLine();

            Console.Write("Imdb puanı: ");
            double imdbPuani;
            while (!double.TryParse(Console.ReadLine(), out imdbPuani) || imdbPuani < 0 || imdbPuani > 10)
            {
                Console.WriteLine("Geçersiz imdb puanı! Lütfen 0 ile 10 arasında bir puan giriniz.");
                Console.Write("Imdb puanı: ");
            }

            filmListesi.Add(new Film(isim, imdbPuani));

            Console.Write("Yeni bir film eklemek ister misiniz? (evet/hayir): ");
            string cevap = Console.ReadLine().ToLower();

            if (cevap != "evet")
            {
                devamEtmekIstiyorMu = false;
            }
        }

        // Tüm filmleri listele
        Console.WriteLine("\nTüm Filmler:");
        foreach (var film in filmListesi)
        {
            Console.WriteLine($"{film.Isim} - Imdb Puanı: {film.ImdbPuani}");
        }

        // Imdb puanı 4 ile 9 arasında olan filmler
        Console.WriteLine("\nImdb puanı 4 ile 9 arasında olan filmler:");
        var imdbArasindakiFilmler = filmListesi.Where(f => f.ImdbPuani >= 4 && f.ImdbPuani <= 9).ToList();
        foreach (var film in imdbArasindakiFilmler)
        {
            Console.WriteLine($"{film.Isim} - Imdb Puanı: {film.ImdbPuani}");
        }

        // İsmi 'A' ile başlayan filmler
        Console.WriteLine("\nİsmi 'A' ile başlayan filmler:");
        var aIleBaslayanFilmler = filmListesi.Where(f => f.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
        foreach (var film in aIleBaslayanFilmler)
        {
            Console.WriteLine($"{film.Isim} - Imdb Puanı: {film.ImdbPuani}");
        }
    }
}