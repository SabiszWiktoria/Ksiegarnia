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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            Form okno = new OknoListyKsiazek();
            okno.Show();
        }

        private void btnDodajKsiazke_Click(object sender, EventArgs e)
        {
            Form okno = new OknoDodaniaKsiazki();
            okno.Show();
        }
    }
}
