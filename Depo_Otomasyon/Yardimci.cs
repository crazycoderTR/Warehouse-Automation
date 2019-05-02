using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Class
{
    class Yardimci
    {
        OleDbConnection baglanti;
        OleDbCommand komut;
        public OleDbCommand Komut
        {
            get { return komut; }
            //set { cmd = value; }
        }
        OleDbDataAdapter adapter;

        public Yardimci()
        {
            baglanti = new OleDbConnection();
            komut = baglanti.CreateCommand();
            adapter = new OleDbDataAdapter(komut);
        }

        public bool Baglan(string connStr)
        {
            baglanti.ConnectionString = connStr;
            try
            {
                baglanti.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable GetDataTable(string sql)
        {
            komut.CommandText = sql;
            DataTable tblVeri = new DataTable();
            adapter.Fill(tblVeri);
            return tblVeri;
        }

        public void Komutisle(string sql)
        {
            komut.CommandText = sql;
            komut.ExecuteNonQuery();
        }

        public DataRow GetDataRow(string sql)
        {
            komut.CommandText = sql;
            DataTable tblVeri = new DataTable();
            adapter.Fill(tblVeri);
            if (tblVeri.Rows.Count > 0)
            {
                return tblVeri.Rows[0];
            }
            else
            {
                return null;
            }
        }
        
        public object DegerAl(string sql)
        {
            komut.CommandText = sql;
            object deger = komut.ExecuteScalar();
            return deger;
        }

    }
}
