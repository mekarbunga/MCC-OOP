using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCW2D3.OOP_Shapes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            start:
            try
            {
                Console.WriteLine("Program Hitung Luas Bangun Datar");
                Console.WriteLine("================================");
                string input = "";
                while (input != "99")
                {
                    Console.WriteLine("Pilih bangun datar:");
                    Console.WriteLine("1. Persegi Panjang");
                    Console.WriteLine("2. Segitiga");
                    Console.WriteLine("3. Trapesium");
                    Console.WriteLine("99. Keluar");
                    Console.Write("\nPilihan: ");
                    input = Console.ReadLine();
                    Console.WriteLine();

                    if (input == "1")
                    {
                        Rectangle rectangle = new Rectangle();
                        Console.Write("Masukkan panjang: ");
                        rectangle.Panjang = double.Parse(Console.ReadLine());
                        Console.Write("Masukkan lebar: ");
                        rectangle.Lebar = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nDeskripsi bangun datar: ");
                        Console.WriteLine("Panjang: " + rectangle.Panjang);
                        Console.WriteLine("Lebar: " + rectangle.Lebar);
                        Console.Write("Luas: ");
                        Console.WriteLine(rectangle.hitungLuas(rectangle.Panjang, rectangle.Lebar));
                        Console.WriteLine("\n99. Keluar");
                        Console.WriteLine("Press any key to reload menu...");
                        input = Console.ReadLine();
                    }
                    else if (input == "2")
                    {
                        Triangle triangle = new Triangle();
                        Console.Write("Masukkan alas: ");
                        triangle.Panjang = double.Parse(Console.ReadLine());
                        Console.Write("Masukkan tinggi: ");
                        triangle.Tinggi = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nDeskripsi bangun datar: ");
                        Console.WriteLine("Alas: " + triangle.Panjang);
                        Console.WriteLine("Tinggi: " + triangle.Tinggi);
                        Console.Write("Luas: ");
                        Console.WriteLine(triangle.hitungLuas(triangle.Panjang, triangle.Tinggi));
                        Console.WriteLine("\n99. Keluar");
                        Console.WriteLine("Press any key to reload menu...");
                        input = Console.ReadLine();
                    }
                    else if (input == "3")
                    {
                        Trapezoid trapezoid = new Trapezoid();
                        Console.Write("Masukkan sisi sejajar 1: ");
                        trapezoid.Sisi1 = double.Parse(Console.ReadLine());
                        Console.Write("Masukkan sisi sejajar 2: ");
                        trapezoid.Sisi2 = double.Parse(Console.ReadLine());
                        Console.Write("Masukkan tinggi: ");
                        trapezoid.Tinggi = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nDeskripsi bangun datar: ");
                        Console.WriteLine("Sisi sejajar 1: " + trapezoid.Sisi1);
                        Console.WriteLine("Sisi sejajar 2: " + trapezoid.Sisi2);
                        Console.WriteLine("Tinggi: " + trapezoid.Tinggi);
                        Console.Write("Luas: ");
                        //Console.WriteLine(trapezoid.hitungLuas(trapezoid.sumSejajar(trapezoid.Sisi1, trapezoid.Sisi2), trapezoid.Tinggi));
                        Console.WriteLine(trapezoid.hitungLuas(trapezoid.Sisi1, trapezoid.Sisi2, trapezoid.Tinggi));
                        Console.WriteLine("\n99. Keluar");
                        Console.WriteLine("Press any key to reload menu...");
                        input = Console.ReadLine();
                    }

                }
            }
            catch (Exception e)
            {
                if (e.GetType().FullName == "System.FormatException")
                {

                    Console.WriteLine("Error: Input harus angka");
                    Console.WriteLine("================================\n");
                }
                goto start;
            }
        }
    }
}