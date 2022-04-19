using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4290
{
    public class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("190302123", "Paijo", 4000000);
            Karyawan karyawan2 = new Karyawan("190302124", "Jono", 2000000);

            Console.WriteLine("No Nik/Nama      Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.Write("1 "); karyawan1.tampilkanData();
            Console.Write("2 "); karyawan2.tampilkanData();
            Console.WriteLine();

            karyawan1.naikGajiKaryawan();
            karyawan2.naikGajiKaryawan();

            Console.WriteLine();
            Console.WriteLine("No Nik/Nama      Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.Write("1 "); karyawan1.tampilkanData();
            Console.Write("2 "); karyawan2.tampilkanData();

            Console.WriteLine();
            Console.WriteLine("Tekan tombol apa saja untuk melanjutkan....");
            Console.ReadKey();
        }
    }
}
