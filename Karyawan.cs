using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4290
{
    public class Karyawan
    {
        private string NIK;
        private string nama;
        private int gaji;

        public string Nik
        {
            get { return NIK; }
            set { NIK = value; }
        }
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        public int GajiBulanan
        {
            get { return gaji; }
            set { gaji = value; }
        }

        public Karyawan(string nik, string nama, int gajiBulanan)
        {
            this.NIK = nik;
            this.nama = nama;
            this.gaji = gajiBulanan < 0 ? 0 : gajiBulanan;
        }

        public void tampilkanData()
        {
            Console.WriteLine("{0} {1}      {2}", NIK, nama, gaji);
        }

        public void naikGajiKaryawan()
        {
            int kenaikan;

            kenaikan = gaji * 110;
            gaji = kenaikan / 100;

            Console.WriteLine("asyik naik gaji 10%");
        }
    }
}
