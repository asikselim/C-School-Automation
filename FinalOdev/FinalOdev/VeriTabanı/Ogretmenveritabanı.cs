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
    class Ogretmenveritabanı : TemelVeriTabanı
    {
        public override void Ekle(object obj)
        {
            ogretmen ogretmen = (ogretmen)obj;

            Baglan();

            komut = new SqlCommand("ogretmenekle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@Adı", ogretmen.Adi);
            komut.Parameters.AddWithValue("@Soyadı", ogretmen.Soyadi);


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
            string sorgu = "select * from tbl_ogretmen";
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
            ogretmen ogretmen = (ogretmen)obj;

            Baglan();

            komut = new SqlCommand("ogretmensil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@Adı", ogretmen.Adi);
            


            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}
