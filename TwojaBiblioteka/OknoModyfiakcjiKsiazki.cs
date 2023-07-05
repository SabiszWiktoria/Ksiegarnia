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
    public partial class OknoModyfiakcjiKsiazki : Form
    {
        Ksiazki ksiazka;
        string Id;
        public OknoModyfiakcjiKsiazki(Ksiazki ksiazki, string id)
        {
            ksiazka = ksiazki;
            Id = id;
            InitializeComponent();
        }

        private void btnModyfikuj_Click(object sender, EventArgs e)
        {

            if (txtTytul.Text != "")
            {

                ksiazka.ModyfikacjaTabeli(Id, "Tytul", $"'{txtTytul.Text}'");
            }
            if (txtAutor.Text != "")
            {
                ksiazka.ModyfikacjaTabeli(Id, "Autor", $"'{ txtAutor.Text}'");
            }
            if (txtOpis.Text != "")
            {
                ksiazka.ModyfikacjaTabeli(Id, "Opis", $"'{ txtOpis.Text}'");
            }
            if (cmbGatunek.Text != "")
            {
                ksiazka.ModyfikacjaTabeli(Id, "Gatunek", $"'{ cmbGatunek.Text}'");
            }
            if (mtxtRokWydania.Text != "    ")
            {
                ksiazka.ModyfikacjaTabeli(Id, "RokWydania", $"'{mtxtRokWydania.Text}'");
            }
            if (nOcena.Value != 0)
            {
                ksiazka.ModyfikacjaTabeli(Id, "Ocena", nOcena.Value.ToString());
            }


            txtTytul.Text = "";
            txtAutor.Text = "";
            txtOpis.Text = "";
            cmbGatunek.Text = "";
            mtxtRokWydania.Text = "";

            nOcena.Value = 0;
            Form o = new OknoKsiazki(Id);
            o.Show();
            this.Close();

        }

        private void OknoModyfiakcjiKsiazki_Load(object sender, EventArgs e)
        {
            ltytul.Text = ksiazka.Tytul;
            lautor.Text = ksiazka.Autor;
            lrokWydania.Text = ksiazka.RokWydania;
            locena.Text = ksiazka.Ocena.ToString();
            lopis.Text = ksiazka.Opis;

        }
    }
}
