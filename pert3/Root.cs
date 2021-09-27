using System;

namespace pert3
{
    class Root {
        static void Main(string[] args) {
            Console.WriteLine("Program Inheritance, Access Modifier, Override\n");
            Mobil mobil = new Mobil();
            Motor motor = new Motor();

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

            Console.WriteLine("\n==================================\n");
            Console.WriteLine("Motor merk " + motor.merk);
            Console.WriteLine("Motor diproduksi tahun " + motor.thnProduksi);
            Console.WriteLine("Warna motor " + motor.warnaKendaraan);
            Console.WriteLine("Tipe motor " + motor.tipe);
            Console.WriteLine("Motor memiliki roda " + motor.jumlah_roda);

            motor.maju();
            motor.berhenti();
            motor.belok();

            Console.ReadKey(true);
        }
    }
}
