using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data.SQLite;


namespace TwojaBiblioteka
{
    public class BazaDanych
    {
        private static SQLiteConnection _polaczenie;

        public static SQLiteConnection polaczenie
        {
            get
            {
                if (_polaczenie == null)
                {
                    var sciezka = Path.GetFullPath($@"{Environment.CurrentDirectory}\..\..\BazaDanych.sqlite");// zwaraca obecna sciezke do bazy danych 
                    _polaczenie = new SQLiteConnection($@"Data Source={sciezka};");


                    StworzTabele1();

                }
                return _polaczenie;
            }
        }

        private static void StworzTabele1()
        {
            try
            {
                _polaczenie.Open();

                var sprawdzCzyIstniejeTabela = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' AND name='tblKsiazki';", _polaczenie);
                var czyIstnieje = sprawdzCzyIstniejeTabela.ExecuteScalar();

                if (czyIstnieje == null)
                {

                    var str = @"CREATE TABLE tblKsiazki (
                                Id             INT          NOT NULL,
                                Tytul          VARCHAR (100) NULL,
                                Autor           VARCHAR (100) NULL,
                                RokWydania         VARCHAR (4) NULL,
                                Ocena  INT NULL,
                                Gatunek          VARCHAR (100) NULL,
                                Opis           VARCHAR (250) NULL,
                                PRIMARY KEY ([Id] ASC)
                                                            );";

                    var stworzTabele = new SQLiteCommand(str, _polaczenie);
                    stworzTabele.ExecuteNonQuery();
                }
                
            }


            finally
            {
                _polaczenie.Close();
            }


        }

    }

}


