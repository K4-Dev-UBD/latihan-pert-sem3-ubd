using System;

namespace pert3
{
    class Root {
        static void Main(string[] args) {
            Console.WriteLine("Program Inheritance, Access Modifier, Override\n");
            Mobil mobil = new Mobil();
            Motor motor = new Motor();
            Truk truk = new Truk();
            Pesawat pesawat = new Pesawat();

            mobil.mulai();
            motor.mulai();
            truk.mulai();
            pesawat.mulai();

            Console.ReadKey(true);
        }
    }
}