using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCW2D3.OOP_Shapes
{
    class Trapezoid : Triangle
    {
        private double sisi1;
        private double sisi2;

        public double Sisi1 { get; set; }
        public double Sisi2 { get; set; }

        public double sumSejajar(double sisi1, double sisi2)
        {
            return (sisi1 + sisi2);
        }

        public double hitungLuas(double sisi1, double sisi2, double tinggi)
        {
            return ((sisi1 + sisi2) * tinggi);
        }
    }
}
