using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdev.Tablolarım
{
    class verilecekdersler
    {
        private int id;
        private int ogretmenId;
        private int dersId;



        public verilecekdersler(int ogretmenId, int dersId)
        {
            this.dersId = dersId;
            this.ogretmenId = ogretmenId;

        }
        public int Id { get => id; set => id = value; }
        public int OgretmenId { get => ogretmenId; set => ogretmenId = value; }
        public int DersId { get => dersId; set => dersId = value; }
    }
}
