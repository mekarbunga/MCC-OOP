using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCW2D3
{
    class Shapes
    {
        private double lebar;
        private double panjang;


        public Shapes()
        {

        }

        public Shapes(double lebar, double panjang)
        {
            this.lebar = lebar;
            this.panjang = panjang;
        }

        public virtual double hitungLuas(double panjang, double lebar)
        {
            return (panjang * lebar);
        }

        public double Lebar { get; set; }
        public double Panjang { get; set; }

    }
}
