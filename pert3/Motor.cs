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

        public void mulai() {
            Console.WriteLine("\n==================================\n");
            Console.WriteLine("Motor merk " + motor.merk);
            Console.WriteLine("Motor diproduksi tahun " + motor.thnProduksi);
            Console.WriteLine("Warna motor " + motor.warnaKendaraan);
            Console.WriteLine("Tipe motor " + motor.tipe);
            Console.WriteLine("Motor memiliki roda " + motor.jumlah_roda);

            motor.maju();
            motor.berhenti();
            motor.belok();
        }
    }
}