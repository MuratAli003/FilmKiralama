using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmKiralama
{
    internal class KiralıkFilm : Film
    {
        Musteri musteri = new Musteri();

        private int ucret;
        public int KiralikGunSayisi { get; set; }
        public int GunlukUcret { get; set; }

        public string KiralayanIsım { get { return musteri.Isim; } set { musteri.Isim = value; } }

        public string KiralayanSoyisim { get { return musteri.Soyisim; } set { musteri.Soyisim = value; } }

        public int Ucret { get { return gunlukUcretHesapla(); } set {ucret = value; } }

        public int gunlukUcretHesapla()
        {
            return KiralikGunSayisi * GunlukUcret;
        }

    }
 
}
