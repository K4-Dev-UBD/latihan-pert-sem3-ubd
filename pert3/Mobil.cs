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

        public void mulai() {
            Console.WriteLine("Mobil Merk " + mobil.merk);
            Console.WriteLine("Mobil diproduksi tahun " + mobil.thnProduksi);
            Console.WriteLine("Warna mobil " + mobil.warnaKendaraan);
            Console.WriteLine("Tipe mobil " + mobil.tipe);
            Console.WriteLine("Mobil memiliki roda " + mobil.jumlah_roda);
            Console.WriteLine("Mobil memiliki kursi sebanyak " + mobil.kursi);
            Console.WriteLine("Mobil memiliki pintu sebanyak " + mobil.pintu);

            mobil.maju();
            mobil.mundur();
            mobil.belok();
            mobil.berhenti();
        }
    }
}