using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022330059
{
    internal class KodeProduk
    {
        private static Dictionary<string, string> kodeProdukTable = new Dictionary<string, string>
    {
        {"Laptop", "E100"},
        {"Smartphone", "E101"},
        {"Tablet", "E102"},
        {"Headset", "E103"},
        {"Keyboard", "E104"},
        {"Mouse", "E105"},
        {"Printer", "E106"},
        {"Monitor", "E107"},
        {"Smartwatch", "E108"},
        {"Kamera", "E109"},
    };

        public static void TampilkanDaftarKodeProduk()
        {
            Console.WriteLine("===== Daftar Kode Produk Elektronik =====");
            foreach (var entry in kodeProdukTable)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }
            Console.WriteLine();
        }

        public static string GetKodeProduk(string produkElektronik)
        {
            if (kodeProdukTable.ContainsKey(produkElektronik))
            {
                return kodeProdukTable[produkElektronik];
            }
            return "Kode Produk tidak ditemukan";
        }
    }
}
