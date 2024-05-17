using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmKiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Islemler ıslemler1 = new Islemler();
       

        private void btnRentalMovies_Click(object sender, EventArgs e)
        {
            dgwMovies.DataSource = null;
            dgwMovies.DataSource = ıslemler1.KiralıkFilmGoster();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbxFilmIsim.Text) || string.IsNullOrEmpty(tbxYonetmen.Text) || string.IsNullOrEmpty(tbxGunlukUcret.Text))
            {
                MessageBox.Show("Lutfen Bilgileri Eksiksiz Girin");
            }
            else
            {
                string isim = tbxFilmIsim.Text;
                string yonetmen = tbxYonetmen.Text;
                int ucret = Convert.ToInt32(tbxGunlukUcret.Text);
                ıslemler1.FilmEkle(isim, yonetmen, ucret);

                //Film eklendikten sonra kiralama ve silme comboboxlarınada film adı eklenir
                cbxFilmSil.Items.Add(isim);
                cbxKiralikFilm.Items.Add(isim);
                MessageBox.Show("Film Eklendi");

            }
            // TextBoxlar temizlenir
            tbxFilmIsim.Text = string.Empty;
            tbxGunlukUcret.Text = string.Empty;
            tbxYonetmen.Text = string.Empty;
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            dgwMovies.DataSource = null;// ekranı yenilemek için önce null atadım sonra tekrar filmleri listeledim
            dgwMovies.DataSource = ıslemler1.FilmGoster();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxKiralikIsim.Text) || string.IsNullOrEmpty(tbxKiralikSoyisim.Text) || string.IsNullOrEmpty(cbxKiralikFilm.Text) || string.IsNullOrEmpty(cbxKiralikGun.Text))
            {

                MessageBox.Show("Lutfen Bilgileri Eksiksiz Girin");

            }
            else
            {
                ıslemler1.KiralikFilmEkle(tbxKiralikIsim.Text, tbxKiralikSoyisim.Text, cbxKiralikFilm.SelectedItem.ToString(), Convert.ToInt32(cbxKiralikGun.SelectedItem.ToString()));
                tbxKiralikIsim.Text = string.Empty;
                tbxKiralikSoyisim.Text = string.Empty;
                cbxKiralikGun.Text = string.Empty;
                cbxKiralikFilm.Text = string.Empty;

                MessageBox.Show("Film Kiralandı");
            }
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxFilmSil.Text))
            {
                MessageBox.Show("Lutfen Bilgileri Eksiksiz Girin");
            }
            else
            {
                ıslemler1.FilmSil(cbxFilmSil.SelectedItem.ToString());

                cbxKiralikFilm.Items.Remove(cbxFilmSil.SelectedItem.ToString());//silinen film kiralık listesinden silinir
                cbxFilmSil.Items.Remove(cbxFilmSil.SelectedItem.ToString());//silinen film , silinecek film listesinden kaldırılır
                cbxFilmSil.Text = string.Empty;//silinecek film combobox yazı alanı silinir

                MessageBox.Show("Film Silindi");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form açıldığında Film Dosyasındaki veriler sırasıyla kiralık film ve silinecek film comboboxlarına eklenir
            List<string> list = ıslemler1.FilmListele();

            foreach (string s in list)
            {
                cbxKiralikFilm.Items.Add(s);
                cbxFilmSil.Items.Add(s);
            }
        }
    }
}
