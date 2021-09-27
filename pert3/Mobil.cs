using System;

namespace pert3 {
    class Mobil : Kendaraan {
        public string merk, tipe, thnProduksi;
        public int kursi, pintu;

        public Mobil() {
            warnaKendaraan = "Merah";
            jumlah_roda = 4;
            merk = "Honda Yaris";
            thnProduksi = "2014";
            kursi = 6;
            pintu = 4;
        }

        public void belok() {
            Console.WriteLine("Mobil dapat belok kanan dan kiri");
        }

        public void mundur() {
            Console.WriteLine("Mobil dapat mundur");
        }

        public override void berhenti() {
            Console.WriteLine("Mobil berhenti");
        }
    }
}
