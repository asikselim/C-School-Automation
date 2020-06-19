using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdev.Tablolarım
{
    class dersler
    {
        private int id;
        private string adi;


        public dersler(string adi)
        {
            this.Adi = adi;
        }
        public int Id { get => id; set => id = value; }
        public string Adi { get => adi; set => adi = value; }
    }
}
