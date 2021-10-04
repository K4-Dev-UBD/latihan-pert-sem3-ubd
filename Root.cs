using System;

namespace pert4 {
	class Root {
		abstract class Bangun2D {
			public abstract double hitungLuas();

			public void cetakLuas(string namaBangunan) {
				Console.WriteLine("Luas " + namaBangunan + " = " + hitungLuas());
			}
		}

		class SegiEmpat : Bangun2D {
			private double panjang;
			private double lebar;

			public SegiEmpat(double p, double l) {
				panjang = p;
				lebar = l;
			}

			public override double hitungLuas() {
				return panjang * lebar;
			}
		}

		class Segitiga : Bangun2D {
			private double alas;
			private double tinggi;

			public Segitiga(double a, double t) {
				alas = a;
				tinggi = t;
			}

			public override double hitungLuas() {
				return (alas * tinggi) / 2;
			}
		}

		class Lingkaran : Bangun2D {
			private const double phi = 3.14;
			private double jariJari;

			public Lingkaran(double jr) {
				jariJari = jr;
			}

			public override double hitungLuas() {
				return phi * jariJari * jariJari;
			}
		}

		static void Main(string[] args) {
			SegiEmpat se = new SegiEmpat(10, 10);
			Segitiga sg = new Segitiga(20, 5);
			Lingkaran lg = new Lingkaran(30);

			se.cetakLuas("Persegi");
			sg.cetakLuas("Segitiga");
			lg.cetakLuas("Lingkaran");
		}
	}
}