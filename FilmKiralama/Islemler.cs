using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace FilmKiralama
{
    internal class Islemler
    {
        public List<Film> filmler = new List<Film>();
        public List<KiralıkFilm> kiralikFilmler = new List<KiralıkFilm>();

        // Aynı filmi listeye tekrar eklememek için kontrol yapılır
        bool filmDosyaEklendiMi = false;
        public List<Film> FilmGoster()
        {
            // Dosyadaki filmler listeye eklenir
            FilmOku();
            filmDosyaEklendiMi = true;
            return filmler;
        }

        public List<string> FilmListele()
        {
            // Form açıldığında film kiralama ve film silme menülerindeki comboboxların içeriğini güncellemek için oluşturuldu
            List<string> list = new List<string>();

            using(StreamReader reader = new StreamReader(filmDosya))
            {
                string kontrol;

                while((kontrol = reader.ReadLine())!= null)
                {
                    string[] icerik = kontrol.Split(',');

                    list.Add(icerik[1]);
                }
            }
            return list;
        }

        // oluşturulacak dosyaların bağlantıları
        string filmDosya = "filmler.txt";
        string kiralikFilmDosya = "kiralikFilmler.txt";

        private string DosyaVeriOlustur(Film film)
        {
            // film nesnesinin içeriğine dosyaya yazılabilecek formata dönüştürür
            string dosya = film.DukkanIsim + "," + film.Isim + "," + film.Yonetmen + "," + film.GunlukUcret;
            return dosya;
        }

        public void FilmEkle(string filmAdı, string yonetmenAdı, int gunlukUcret)
        {
            
            Film film = new Film()
            {
                Isim = filmAdı,
                Yonetmen = yonetmenAdı,
                GunlukUcret = gunlukUcret
            };
            FilmYaz(film); //filmi dosyaya yazar
            filmler.Add(film); // filmi listeye ekler

        }
        private void FilmYaz(Film film)
        {
            // Dosyaya yazma işlemi
            using (StreamWriter writer = new StreamWriter(filmDosya, true))
            {

                writer.WriteLine(DosyaVeriOlustur(film));

                writer.Close();
            }

        }

        public void FilmOku()
        {
            //Dosya Oluşturulmamışsa veya silinmişse dosyayı yeniden oluşturur.
            //Görüntü temizliği açısından varsa boş satırlar silinir
            DosyaOlustur(filmDosya);
            BosSatirSil(filmDosya);

            using (StreamReader reader = new StreamReader(filmDosya))
            {
                string kontrol;

                while ((kontrol = reader.ReadLine()) != null)
                {

                    string[] dosya = kontrol.Split(',');
                    //Film dosyada yoksa listeye veriyi ekler
                    if (!filmDosyaEklendiMi)
                    {
                        filmler.Add(new Film()
                        {
                            Isim = dosya[1],
                            Yonetmen = dosya[2],
                            GunlukUcret = Convert.ToInt32(dosya[3])
                        });
                    }

                }


            }
            
        }

        public void FilmSil(string filmAdi)
        {
            FilmiDosyadanSil(filmAdi);

            Film film = filmler.Find(b => b.Isim == filmAdi);

            filmler.Remove(film);

            

        }

        private void FilmiDosyadanSil(string filmAdi)
        {
            string[] satirlar = System.IO.File.ReadAllLines(filmDosya);
            int indis = 0;
            for (int i = 0; i < satirlar.Length; i++)
            {
                string[] satır = satirlar[i].Split(',');

                if (satır[1].Equals(filmAdi))
                {
                    break;
                }
                else
                {
                    indis++;
                }
            } // bu satıra kadar silinecek dosyanın hangi satırda olduğu bulundu

            string geciciDosya = "bos.txt";

            using (StreamWriter sw = new StreamWriter(geciciDosya))
            {
                // silinecek satır hariç veriler yeni bir dosyaya yazıldı
                for (int i = 0; i < satirlar.Length; i++)
                {
                    if (i != indis)
                    {
                        sw.WriteLine(satirlar[i]);
                    }
                }
            }
           
            System.IO.File.Delete(filmDosya);// eski dosya silindi
            System.IO.File.Move(geciciDosya, filmDosya);//oluşturulan dosyanın verisi eski dosyaya aktarıldı
        }

        bool KiralikDosyaEklendiMi = false;
        public List<KiralıkFilm> KiralıkFilmGoster()
        {
            KiralikFilmOku();
            KiralikDosyaEklendiMi = true;
            return kiralikFilmler;
        }
        private string KiralıkDosyaVeriOlustur(KiralıkFilm film)
        {
            string dosya = film.DukkanIsim + "," + film.Isim + "," + film.Yonetmen + "," + film.GunlukUcret + "," +
                film.KiralayanIsım + "," + film.KiralayanSoyisim + "," + film.KiralikGunSayisi + "," + film.Ucret;

            return dosya;
        }
        private void KiralikFilmYaz(KiralıkFilm film)
        {
            using (StreamWriter writer = new StreamWriter(kiralikFilmDosya, true))
            {
                writer.WriteLine(KiralıkDosyaVeriOlustur(film));
                writer.Close();
            }
        }
        private Film FilmGetir(string filmAd)
        {
            //eklenecek kiralık filmin film özellikleri kod karmaşıklığının önüne geçilmesi için bu metodda oluşturuldu
            Film film = new Film();

            using (StreamReader reader = new StreamReader(filmDosya))
            {
                string kontrol;

                while ((kontrol = reader.ReadLine()) != null)
                {
                    string[] dizi = kontrol.Split(',');

                    if (dizi[1].Equals(filmAd))
                    {
                        film = new Film()
                        {
                            Isim = dizi[1],
                            Yonetmen = dizi[2],
                            GunlukUcret = Convert.ToInt32(dizi[3])
                        };

                    }
                }
            }
            return film;
        }


        private bool KiralikFilmVarMi(string isim, string kiralayanAd, string kiralayanSoyad)
        {
            BosSatirSil(kiralikFilmDosya);

            if (!dosyaBosMu(kiralikFilmDosya))
            {
                using (StreamReader reader = new StreamReader(kiralikFilmDosya))
                {
                    string kontrol;
                    while ((kontrol = reader.ReadLine()) != null)
                    {
                        string[] dizi = kontrol.Split(',');

                        // aynı isim soyisime sahip kişi aynı filmi kiralıyamıyacağı için indisler ona göre belirlendi
                        // indislerin karşılığı KiralıkDosyaVeriOlustur() metodundaki düzenden alınmıştır
                         if (dizi[1].Equals(isim) && dizi[4].Equals(kiralayanAd) && dizi[5].Equals(kiralayanSoyad))
                        {
                            return true;
                        }

                    }
                }
            }
            return false;
        }

        public void KiralikFilmEkle(string kiralayanAd, string kiralayanSoyad, string filmAd, int gün)
        {
            DosyaOlustur(kiralikFilmDosya);

            Film film = FilmGetir(filmAd);//oluşturduğumuz filmi burada atadık

            
                if (!KiralikFilmVarMi(filmAd, kiralayanAd, kiralayanSoyad))
                {
                    KiralıkFilm kiralıkFilm = new KiralıkFilm()
                    {
                        Isim = film.Isim,
                        Yonetmen = film.Yonetmen,
                        GunlukUcret = film.GunlukUcret,
                        KiralayanIsım = kiralayanAd,
                        KiralayanSoyisim = kiralayanSoyad,
                        KiralikGunSayisi = gün
                    };
                    KiralikFilmYaz(kiralıkFilm);// film dosyaya yazıldı
                    kiralikFilmler.Add(kiralıkFilm);// film listeye eklendi
                }
            



        }

        private void KiralikFilmOku()
        {
            DosyaOlustur(kiralikFilmDosya);
            BosSatirSil(kiralikFilmDosya);

            if (!KiralikDosyaEklendiMi)//eğer bir kez eklendiyse bir daha eklenemez. Aksi durum else de belirtildi
            {
                if (!dosyaBosMu(kiralikFilmDosya))
                {
                    using (StreamReader reader = new StreamReader(kiralikFilmDosya))
                    {
                        string kontrol;
                        while ((kontrol = reader.ReadLine()) != null)
                        {
                            string[] dizi = kontrol.Split(',');

                            kiralikFilmler.Add(new KiralıkFilm()
                            {
                                Isim = dizi[1],
                                Yonetmen = dizi[2],
                                GunlukUcret = Convert.ToInt32(dizi[3]),
                                KiralayanIsım = dizi[4],
                                KiralayanSoyisim = dizi[5],
                                KiralikGunSayisi = Convert.ToInt32(dizi[6])
                            });
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Film Daha Önce Kiralanmış");
                }
            }
        }
        private void BosSatirSil(string dosyaYolu)
        {
            string gecici = Path.GetTempFileName();
            using(StreamReader sr = new StreamReader(dosyaYolu))
            using(StreamWriter sw = new StreamWriter(gecici))
            {

                string kontrol;
                while((kontrol = sr.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(kontrol))
                    {
                        sw.WriteLine(kontrol);
                    }
                }
            }
            System.IO.File.Delete(dosyaYolu);
            System.IO.File.Move(gecici, dosyaYolu);

        }
        public bool dosyaBosMu(string dosyaYolu)
        {

            string veri = System.IO.File.ReadAllText(dosyaYolu);

            if (string.IsNullOrEmpty(veri))
            {
                return true;
            }
            return false;

        }
        private void DosyaOlustur(string dosyaYolu)
        {
            using (StreamWriter writer = new StreamWriter(kiralikFilmDosya, true)) { }
        }
       

    }
}

