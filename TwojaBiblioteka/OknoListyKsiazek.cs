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
    public partial class OknoListyKsiazek : Form
    {
        Ksiazki ksiazki = new Ksiazki();
        public OknoListyKsiazek()
        {
            InitializeComponent();
        }

        private void OknoListyKsiazek_Load(object sender, EventArgs e)
        {
            ksiazki.WyswietlanieTabeli("", listView1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    
            try
            {
                int l = Int32.Parse(listView1.SelectedItems[0].Text);
                string id = l.ToString();
                Form okno = new OknoKsiazki(id);
                okno.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bywa " + ex);
            }

        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            ksiazki.Tytul = txtTytul.Text;
            ksiazki.Autor = txtAutor.Text;
            ksiazki.Gatunek = cmbGatunek.Text;
            string sortuj = cmbOcena.Text;
            if (sortuj == "Rosnąco")
            {
                sortuj = "ASC";
            }
            if (sortuj == "Malejąco")
            {
                sortuj = "DESC";
            }
            else
            {
                sortuj = "";
            }

            string zapytanie = ksiazki.WyszukiwaniePoParametrach(sortuj);

            ksiazki.WyswietlanieTabeli(zapytanie, listView1);
        }
    }
}
