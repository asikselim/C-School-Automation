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
    class notveritabanı : TemelVeriTabanı
    {
        public override void Ekle(object obj)
        {
            notlar not = (notlar)obj;

            Baglan();

            komut = new SqlCommand("notekle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@OgrenciId", not.Ogrenciıd);
            komut.Parameters.AddWithValue("@DersId", not.DersId);
            komut.Parameters.AddWithValue("@notu", not.Notu);

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override void Guncelle(object obj)
        {
            notlar not = (notlar)obj;

            Baglan();

            komut = new SqlCommand("notlarıguncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@DersId",not.DersId );
            komut.Parameters.AddWithValue("@OgrenciId", not.Ogrenciıd);
            komut.Parameters.AddWithValue("@notu", not.Notu);

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
            notlar not = (notlar)obj;
            Baglan();
            string sorgu = "select de.Adı,ogr.Adi,notu.Notu from tbl_notlar notu inner join tbl_ders de on notu.DersId=de.id inner join tbl_ogrenci ogr on notu.OgrenciId=ogr.id where ogr.id=" + not.Ogrenciıd;

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
            notlar not = (notlar)obj;

            Baglan();

            komut = new SqlCommand("notlarsil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            
            komut.Parameters.AddWithValue("@OgrenciId", not.Ogrenciıd);
            

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}
