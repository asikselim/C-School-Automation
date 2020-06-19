using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdev.VeriTabanı
{
   abstract class TemelVeriTabanı
    {
        private string yol = "";
        public SqlDataAdapter adaptor;
        public SqlDataReader okuyucu;
        public SqlConnection baglanti;
        public SqlCommand komut;
        public DataTable tablo;

        public TemelVeriTabanı()
        {
            yol = "Server=SELIMPC\\SQLEXPRESS;Database=UgurOkullarıDB;Trusted_Connection=True;";
        }

        public void Baglan()
        {
            baglanti = new SqlConnection(yol);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }


        abstract public DataTable Listele();
        abstract public DataTable Listele(object obj);
        abstract public void Guncelle(object obj);
        abstract public void Sil(object obj);
        abstract public void Ekle(object obj);
    }
}
