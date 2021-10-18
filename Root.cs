using System;

namespace pert6 {
	class Root {
		static void Main(string[] args) {
			int[,,] a = new int[2, 3, 3] {
				{
					{ 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }
				},
				{
					{ 11, 12, 13 }, { 14, 15, 16 }, { 17, 18, 19 }
				}
			};

			Console.WriteLine("Isi array tiga dimensi");
			for (int halaman = 0; halaman < 2; halaman++) {
				Console.WriteLine("Ini halaman ke - " + (halaman + 1));

				for (int baris = 0; baris < 3; baris++) {
					for (int kolom = 0; kolom < 3; kolom++) {
						Console.Write(a[halaman, baris, kolom] + " ");
					}
					Console.WriteLine();
				}
			}

			inpUser();
		}

		public static void inpUser() {
			int i,j,a;

			int[,,] arr1 = new int [2,3,3];

			Console.Write("========3D Array dengan Inputan======\n");

			for (i=0; i<2; i++) {
				for (j=0; j<3; j++) {
					for (a=0; a<3; a++) {
						Console.Write("Index [{0},{1},{2}]: ",i,j,a);
						arr1[i,j,a] = int.Parse(Console.ReadLine());
					}
				}
			}

			Console.Write("\nHasilnya adalah:\n");
			for (i=0; i<2; i++) {
				Console.Write("\n");
				for (j=0; j<3; j++) {
					Console.Write("\n");
					for (a=0; a<3; a++) {
						Console.Write("{0}\t",arr1[i,j,a]);
					}
				}
				Console.Write("\n\n");
			}

			Console.ReadKey(true);
		}
	}
}
