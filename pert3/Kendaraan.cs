using System;

namespace pert3 {
    class Kendaraan {
        private int jumlahRoda;
        private string warna;

        public int jumlah_roda {
            get { return jumlahRoda; }
            set { jumlahRoda = value; }
        }

        public string warnaKendaraan {
            get { return warna; }
            set { warna = value; }
        }

        public void maju() {
            Console.WriteLine("Kendaraan melaju ke depan");
        }

        public virtual void berhenti() {
            Console.WriteLine("Kendaraan berhenti!");
        }
    }
}