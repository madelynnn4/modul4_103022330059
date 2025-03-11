using System;

namespace modul4_103022330059;
class Program
{
    static void Main()
    {
        KodeProduk.TampilkanDaftarKodeProduk();

        Console.WriteLine("===== Pencarian Kode Produk =====");
        Console.Write("Masukkan nama produk: ");
        string produkElektronik = Console.ReadLine();
        Console.WriteLine($"Kode Produk {produkElektronik}: {KodeProduk.GetKodeProduk(produkElektronik)}\n");

        Console.WriteLine("===== Mode Fan =====");
        FanLaptop mode = new FanLaptop();
        while (true)
        {
            Console.WriteLine("\nKetik 'up' untuk menaikkan mode atau 'down' untuk menurunkan mode atau 'turbo' untuk mode Turbo (ketik 'exit' untuk keluar): ");
            string command = Console.ReadLine()?.ToLower();

            if (command == "up")
                mode.ModeUp();
            else if (command == "down")
                mode.ModeDown();
            else if (command == "turbo")
                mode.TurboShortcut();
            else if (command == "exit")
                break;
            else
                Console.WriteLine("Perintah tidak dikenali.");
        }
    }
}