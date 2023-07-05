using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwojaBiblioteka
{
    public partial class OknoKsiazki : Form
    {
        Ksiazki ksiazka = new Ksiazki();
      public  string Id;
        public OknoKsiazki( string id)
        {
            InitializeComponent();
            Id = id;
        }

        private void btnModyfikuj_Click(object sender, EventArgs e)
        {
            Form okno = new OknoModyfiakcjiKsiazki( ksiazka,Id);
            okno.Show();
            this.Close();
        }

        private void OknoKsiazki_Load(object sender, EventArgs e)
        {
            ksiazka.Szczegoly(Id);
            ltytul.Text = ksiazka.Tytul;
            lautor.Text = ksiazka.Autor;
            lrokWydania.Text = ksiazka.RokWydania;
            locena.Text = ksiazka.Ocena.ToString();
            lopis.Text = ksiazka.Opis;

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Czy napewno chcesz usunąc książkę o tytule  {ksiazka.Tytul} i autorze {ksiazka.Autor}", "Czy chcesz usunąć?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ksiazka.Usuwanie(Id);
                Form okno = new OknoListyKsiazek();
                okno.Show();
                this.Close();


            }
        }
    }
}
