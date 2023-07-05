
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace TwojaBiblioteka
{
    /*
     *  @"CREATE TABLE tblKsiazki (
     * Id             INT          NOT NULL,
                                Tytul          VARCHAR (100) NULL,
                                Autor           VARCHAR (100) NULL,
                                RokWydania         VARCHAR (4) NULL,
                                Ocena  INT NULL,
                                Gatunek          VARCHAR (100) NULL,
                                Opis           VARCHAR (250) NULL,
                                PRIMARY KEY ([Id] ASC)
     */
    public class Ksiazki
    {
        public SQLiteCommand cmd = BazaDanych.polaczenie.CreateCommand();

        public string Tytul { get; set; }
        public string Autor { get; set; }
        public string RokWydania { get; set; }
        public int Ocena { get; set; }
        public string Gatunek { get; set; }
        public string Opis { get; set; }

        public Ksiazki(string tytul, string autor, string rokWydania, int ocena, string gatunek, string opis)
        {
            Tytul = tytul;
            Autor = autor;
            RokWydania = rokWydania;
            Ocena = ocena;
            Gatunek = gatunek;
            Opis = opis;
        }
        public Ksiazki()
        {

        }

        public int IloscRecordow()
        {
            BazaDanych.polaczenie.Open();
            // var cmd = BazaDanych.polaczenie.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT MAX(id) FROM [tblKsiazki]";
            var countResult = cmd.ExecuteScalar();
            int count = countResult is System.DBNull ? 0 : (int)(long)countResult;
            cmd.ExecuteNonQuery();
            BazaDanych.polaczenie.Close();
            return count + 1;
        }

        public void DodajDobazyDanych()
        {
            int id = IloscRecordow();
            if (CzyIstnieje())
            {
                MessageBox.Show($"Książka  o tytule: '{Tytul}' autorstwa {Autor}.  Istnieje juz w bazie danych");
            }
            else
            {
                BazaDanych.polaczenie.Open();
                // var cmd = BazaDanych.polaczenie.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"INSERT INTO [tblKsiazki] (Id,Tytul,Autor, RokWydania ,Ocena ,Gatunek ,Opis) VALUES" +
                    $" ({id},'{Tytul}','{Autor}','{RokWydania}',{Ocena},'{Gatunek}','{Opis}')";
                cmd.ExecuteNonQuery();
                BazaDanych.polaczenie.Close();
                MessageBox.Show("Dodano książkę");
            }

        }
        public string WyszukiwaniePoParametrach(string sortuj)
        {


            string zapytanie = "WHERE ";
            if (Tytul != "")
            {
                zapytanie += $"Tytul LIKE '%{Tytul}%' AND ";
            }
            if (Autor != "")
            {
                zapytanie += $"Autor LIKE '%{Autor}%' AND ";
            }
           
            if (Gatunek != "")
            {
                zapytanie += $"Gatunek LIKE '%{Gatunek}%' AND ";
            }
            


            if (zapytanie == "WHERE ")
            {
                zapytanie = " AND";
            }
            int pocztek = (int)(zapytanie.Length) - 4;

            zapytanie = zapytanie.Remove(pocztek, 4);
            if (sortuj != "")
            {
                zapytanie += $" ORDER BY Ocena " + sortuj;
            }

            return zapytanie;

        }
        public void ModyfikacjaTabeli(string id, string nazwaPola, string pole)
        {

            BazaDanych.polaczenie.Open();

            cmd.CommandType = CommandType.Text;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"UPDATE [tblKsiazki] SET {nazwaPola} = " + pole + " WHERE Id=" + id;
            cmd.ExecuteNonQuery();


            BazaDanych.polaczenie.Close();


        }
        public void Szczegoly(string id)
        {



            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM [tblKsiazki]  WHERE Id=" + id;

            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
            {
                try
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);



                    foreach (DataRow row in dt.Rows)
                    {
                        Tytul = row["Tytul"].ToString();
                        Autor = row["Autor"].ToString();
                        RokWydania = row["RokWydania"].ToString();
                        Ocena = (int)row["Ocena"];
                        Gatunek = row["Gatunek"].ToString();
                        Opis = row["Opis"].ToString();

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("bywa " + ex);
                }

            }
        }
        public bool CzyIstnieje()
        {

            bool czyIstniej;
            BazaDanych.polaczenie.Open();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT COUNT(Id) FROM  [tblKsiazki] WHERE Tytul = '{Autor}' AND Autor='{Autor}'";
            var countResult = cmd.ExecuteScalar();
            if ((int)(long)countResult != 0)
            {
                czyIstniej = true;
            }
            else
            {
                czyIstniej = false;
            }
            cmd.ExecuteNonQuery();
            BazaDanych.polaczenie.Close();
            return czyIstniej;

        }

        public string ZapytaniaUsuwania(int id)
        {
            string zapytania = $" WHERE Id=" + id;
            return zapytania;
        }

        public void Usuwanie(string id)
        {
            BazaDanych.polaczenie.Open();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"DELETE FROM  [tblKsiazki] WHERE Id = {id}";
            cmd.ExecuteNonQuery();
            BazaDanych.polaczenie.Close();

        }

        public void WyswietlanieTabeli(string zapytanie, ListView lista = null)
        {

            lista.Clear();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM [tblKsiazki]  " + zapytanie;

            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
            {
                try
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    lista.View = View.Details;


                    lista.Columns.Add("Id");
                    lista.Columns.Add("Tytul                       ");
                    lista.Columns.Add("Autor                        ");
                    lista.Columns.Add("RokWydania         ");
                    lista.Columns.Add("Ocena ");
                    lista.Columns.Add("Gatunek               ");


                    lista.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                    lista.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                    foreach (DataRow row in dt.Rows)
                    {

                        ListViewItem item1 = new ListViewItem(row["Id"].ToString());
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, row["Tytul"].ToString()));
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, row["Autor"].ToString()));
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, row["RokWydania"].ToString()));
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, row["Ocena"].ToString()));
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, row["Gatunek"].ToString()));



                        lista.Items.Add(item1);


                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("bywa" + ex);
                }

            }
        }
    }
}
