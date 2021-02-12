using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCW2D3.OOP_Shapes
{
    class Triangle : Shapes
    {
        private double tinggi;

        public double Tinggi { get; set; }
        public override double hitungLuas(double alas, double tinggi)
        {
            double luas = 0.5 * alas * tinggi;
            return luas;
        }
    }
}
