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
    class alınacakdersveritabanı : TemelVeriTabanı
    {
        public override void Ekle(object obj)
        {
            alınacakdersler alders = (alınacakdersler)obj;

            Baglan();

            komut = new SqlCommand("alinacakdersekle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@OgrenciId", alders.Ogrenciıd);
            komut.Parameters.AddWithValue("@DersId", alders.OgretmenId);
            komut.Parameters.AddWithValue("@OgretmenId", alders.DersId);

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();

        }

        public override void Guncelle(object obj)
        {
            alınacakdersler alders = (alınacakdersler)obj;

            Baglan();

            komut = new SqlCommand("alinacakdersleriguncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@OgrenciId", alders.Ogrenciıd);
            komut.Parameters.AddWithValue("@DersId", alders.OgretmenId);
            komut.Parameters.AddWithValue("@OgretmenId", alders.DersId);

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override DataTable Listele()
        {
            throw new NotImplementedException();
        }

        public override DataTable Listele(object obj)
        {
            

            alınacakdersler alders = (alınacakdersler)obj;
            Baglan();
            string sorgu = "select o.Adi,de.Adı,ogr.Adi from tbl_alınacakdersler alders inner join tbl_ogrenci o on alders.OgrenciId = o.id inner join tbl_ders de on alders.DersId = de.id inner join tbl_ogretmen ogr on alders.OgretmenId = ogr.id where o.id = "+alders.Ogrenciıd;
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

        public override void Sil(object obj)
        {
            alınacakdersler alders = (alınacakdersler)obj;

            Baglan();

            komut = new SqlCommand("alinanderslersil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@OgrenciId", alders.Ogrenciıd);
           

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}
