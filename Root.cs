using System;

namespace pert5 {
	class Root {
		static void Main(string[] args) {
			int pil,TotalBayar = 0,harga;
            Console.WriteLine("Aplikasi Menu Makanan");

            do
            {
                Console.WriteLine("\nDaftar Menu");
                Console.WriteLine("1. Makanan");
                Console.WriteLine("2. Minuman");
                Console.WriteLine("3. Pembayaran");
                Console.Write("Masukkan Pilihan : ");
                pil = int.Parse(Console.ReadLine());

                switch (pil)
                {
                    case 1:
                        int mkn, jml;
                        Console.WriteLine("\nMenu Makanan");
                        Console.WriteLine("1. Nasi Goreng - Rp.15.000");
                        Console.WriteLine("2. Bihun Goreng - Rp.12.000");
                        Console.WriteLine("3. Kwetiau Goreng - Rp.18.000");
                        Console.WriteLine("4. Mie Goreng - Rp.10.000");
                        Console.Write("Masukkan Pilihan Makanan : ");
                        mkn = int.Parse(Console.ReadLine());
                        Console.Write("Jumlah Pesanan : ");
                        jml = int.Parse(Console.ReadLine());
                        if (mkn == 1)
                        {
                            harga = jml * 15000;
                            Console.WriteLine("Nasi Goreng sebanyak : " + jml);
                            Console.WriteLine("Total Harga : Rp." + harga.ToString("#,##"));
                            TotalBayar = TotalBayar + harga;
                        }
                        else if (mkn == 2)
                        {
                            harga = jml * 12000;
                            Console.WriteLine("Bihun Goreng sebanyak : " + jml);
                            Console.WriteLine("Total Harga : Rp." + harga.ToString("#,##"));
                            TotalBayar = TotalBayar + harga;
                        }
                        else if (mkn == 3)
                        {
                            harga = jml * 18000;
                            Console.WriteLine("Kwetiau Goreng sebanyak : " + jml);
                            Console.WriteLine("Total Harga : Rp." + harga.ToString("#,##"));
                            TotalBayar = TotalBayar + harga;
                        }
                        else
                        {
                            harga = jml * 10000;
                            Console.WriteLine("Mie Goreng sebanyak : " + jml);
                            Console.WriteLine("Total Harga : Rp." + harga.ToString("#,##"));
                            TotalBayar = TotalBayar + harga;
                        }

                        break;

                    case 2:
                        int mn, jmlM;
                        Console.WriteLine("\nMenu Minuman");
                        Console.WriteLine("1. Air Mineral - Rp.5.000");
                        Console.WriteLine("2. Teh Hangat Tawar - Rp.3.000");
                        Console.WriteLine("3. Es Teh Manis - Rp.5.000");
                        Console.WriteLine("4. Es Jeruk - Rp.15.000");
                        Console.Write("Masukkan Pilihan Minuman : ");
                        mn = int.Parse(Console.ReadLine());
                        Console.Write("Jumlah Pesanan : ");
                        jmlM = int.Parse(Console.ReadLine());
                        if (mn == 1)
                        {
                            harga = jmlM * 5000;
                            Console.WriteLine("Air Mineral sebanyak : " + jmlM);
                            Console.WriteLine("Total Harga : Rp." + harga.ToString("#,##"));
                            TotalBayar = TotalBayar + harga;
                        }
                        else if (mn == 2)
                        {
                            harga = jmlM * 3000;
                            Console.WriteLine("Teh Tawar Hangat sebanyak : " + jmlM);
                            Console.WriteLine("Total Harga : Rp." + harga.ToString("#,##"));
                            TotalBayar = TotalBayar + harga;
                        }
                        else if (mn == 3)
                        {
                            harga = jmlM * 5000;
                            Console.WriteLine("Es Teh Manis Goreng sebanyak : " + jmlM);
                            Console.WriteLine("Total Harga : Rp." + harga.ToString("#,##"));
                            TotalBayar = TotalBayar + harga;
                        }
                        else
                        {
                            harga = jmlM * 15000;
                            Console.WriteLine("Es Jeruk sebanyak : " + jmlM);
                            Console.WriteLine("Total Harga : Rp." + harga.ToString("#,##"));
                            TotalBayar = TotalBayar + harga;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Total Bayar : "+TotalBayar);
                        break;
                    default:
                        Console.WriteLine("Pilihan anda tidak terdaftar!");
                        break;
                }
            } while (pil <= 3);
            Console.ReadKey(true);
		}
	}
}