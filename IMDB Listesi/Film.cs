using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB_Listesi
{
    class Film
    {
        public string Isim { get; set; }
        public double ImdbPuani { get; set; }

        public Film(string isim, double imdbPuani)
        {
            Isim = isim;
            ImdbPuani = imdbPuani;
        }
    }
}
