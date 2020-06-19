using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdev.Tablolarım
{
    class alınacakdersler
    {
        private int id;
        private int ogrenciıd;
        private int dersId;
        private int ogretmenId;


        public alınacakdersler(int ogrenciıd, int  dersId,int  ogretmenId)
        {
            this.ogrenciıd = ogrenciıd;
            this.ogretmenId = ogretmenId;
            this.dersId = dersId;
        }


        public int Id { get => id; set => id = value; }
        public int Ogrenciıd { get => ogrenciıd; set => ogrenciıd = value; }
        public int DersId { get => dersId; set => dersId = value; }
        public int OgretmenId { get => ogretmenId; set => ogretmenId = value; }
    }
}
