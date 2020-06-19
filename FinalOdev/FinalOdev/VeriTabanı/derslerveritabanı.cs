using FinalOdev.Tablolarım;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdev.VeriTabanı
{
    class derslerveritabanı : TemelVeriTabanı
    {
        public override void Ekle(object obj)
        {
            dersler ders = (dersler)obj;

            Baglan();

            komut = new SqlCommand("derslerekle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@Adı",ders.Adi );
            

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override void Guncelle(object obj)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listele()
        {
            
            Baglan();
            string sorgu = "select * from tbl_ders";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;

            komut.ExecuteNonQuery();
            adaptor = new SqlDataAdapter(komut);
            tablo = new DataTable();
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public override DataTable Listele(object obj)
        {
            throw new NotImplementedException();
        }

        public override void Sil(object obj)
        {
            dersler ders = (dersler)obj;

            Baglan();

            komut = new SqlCommand("derslersil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@Adı", ders.Adi);


            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}
