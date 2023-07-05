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
    public partial class OknoDodaniaKsiazki : Form
    {
        Ksiazki ksiazki = new Ksiazki();
        public OknoDodaniaKsiazki()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ksiazki.Tytul = txtTytul.Text;
            ksiazki.Autor = txtAutor.Text;
            ksiazki.RokWydania = mtxtRokWydania.Text;
            ksiazki.Gatunek = cmbGatunek.Text;
            ksiazki.Ocena =(int)nOcena.Value;
            ksiazki.Opis = txtOpis.Text;
            ksiazki.DodajDobazyDanych();
            this.Close();

        }
    }
}
