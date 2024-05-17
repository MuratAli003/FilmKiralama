using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmKiralama
{
    internal class Film : Dükkan
    {
        public string Isim { get; set; }
        public string Yonetmen { get; set; }
        public int GunlukUcret { get; set; }

    }
}
