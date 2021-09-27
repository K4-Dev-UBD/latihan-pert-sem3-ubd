using System;

namespace pert3 {
    class Motor : Kendaraan {
        public string merk, thnProduksi, tipe;

        public Motor() {
            warnaKendaraan = "Coklat";
            jumlah_roda = 2;
            merk = "Honda";
            thnProduksi = "2020";
            tipe = "Matic";
        }

        public void belok() {
            Console.WriteLine("Motor bisa belok kekanan & kekiri");
        }
    }
}
