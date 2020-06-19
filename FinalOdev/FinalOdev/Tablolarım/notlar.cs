using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdev.Tablolarım
{
    class notlar
    {
        private int id;
        private int dersId;
        private int ogrenciıd;
        private int notu;


        public notlar(int dersId, int ogrenciıd, int notu)
        {
            this.dersId = dersId;
            this.ogrenciıd = ogrenciıd;
            this.notu = notu;
        }
        public int Id { get => id; set => id = value; }
        public int DersId { get => dersId; set => dersId = value; }
        public int Ogrenciıd { get => ogrenciıd; set => ogrenciıd = value; }
        public int Notu { get => notu; set => notu = value; }
    }
}
