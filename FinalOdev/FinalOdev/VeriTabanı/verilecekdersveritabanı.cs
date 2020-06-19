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
    class verilecekdersveritabanı : TemelVeriTabanı
    {
        public override void Ekle(object obj)
        {
            verilecekdersler verders = (verilecekdersler)obj;

            Baglan();

            komut = new SqlCommand("verilecekdersler", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            
            komut.Parameters.AddWithValue("@DersId", verders.OgretmenId);
            komut.Parameters.AddWithValue("@OgretmenId", verders.DersId);

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override void Guncelle(object obj)
        {
            alınacakdersler alders = (alınacakdersler)obj;

            Baglan();

            komut = new SqlCommand("verilecekdersleriguncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            
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
            verilecekdersler verders = (verilecekdersler)obj;
            Baglan();
            string sorgu = "select de.Adı,ogr.Adi from tbl_verilecekdersler verders  inner join tbl_ders de on verders.DersId = de.id inner join tbl_ogretmen ogr on verders.OgretmenId = ogr.id where DersId =" + verders.DersId;

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
            verilecekdersler verders = (verilecekdersler)obj;

            Baglan();

            komut = new SqlCommand("verilenderslersil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@OgretmenId", verders.DersId);

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}
