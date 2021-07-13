using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Tampilkan Penjualan");
            Console.WriteLine("4. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Penjualan penjualan = new Penjualan();
            List<Penjualan> list = new List<Penjualan>();
            Console.Write("Nota: ");
            penjualan.Nota = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tanggal: ");
            penjualan.Tanggal = Console.ReadLine();

            Console.Write("Customer: ");
            penjualan.Customer = Console.ReadLine();

            Console.Write("Jenis [T/K]: ");
            penjualan.Jenis = Console.ReadLine();

            Console.Write("Total Nota: ");
            penjualan.Total = Convert.ToInt32(Console.ReadLine());
            daftarPenjualan.Add(penjualan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
            Penjualan penjualan = new Penjualan();
            Console.Write("Nota: ");
            int searchedNota = Convert.ToInt32(Console.ReadLine());

            int removeIndex = daftarPenjualan.FindIndex(penjualan => penjualan.Nota == searchedNota);
            if (removeIndex != -1)
            {
                daftarPenjualan.RemoveAt(removeIndex);
                Console.WriteLine("Data Penjualan Berhasil di Hapus");
            }
            else
            {
                Console.WriteLine("Nota Tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                if (penjualan.Jenis == "T")
                {
                    penjualan.Jenis = "Tunai";
                }
                if (penjualan.Jenis == "K")
                {
                    penjualan.Jenis = "Kredit";
                }
                Console.WriteLine("{0},{1},{2},{3},{4}", penjualan.Nota, penjualan.Tanggal, penjualan.Customer, penjualan.Jenis, penjualan.Total);
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
