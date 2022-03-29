using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Kelompok_Aplikasi_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CAFFE MISSQUEEN";
            int pilihan, makanan, minuman, tipemember, harga1, harga2, jumlahmakanan, jumlahminuman, subtotal, totalmakan, totalminum;
            string namapilihan, namamakanan, namaminuman, namamember;
            double diskon, total, pajak, total2;
        inputpilihan:
            Console.Clear();
            Console.WriteLine(new string(' ', 15) + "CAFE MISSQUEN");
            Console.WriteLine(new string('^', 40));
            Console.WriteLine(new string(' ', 5) + "PILIHAN");
            Console.WriteLine("1. Makan Di Tempat");
            Console.WriteLine("2. Bawa Pulang");
            Console.WriteLine(new string('^', 40));
            Console.Write("Masukkan Pilihan [1/2]: ");
            pilihan = int.Parse(Console.ReadLine());
            if (pilihan == 1)
            {
                namapilihan = "1. Makan Di Tempat";
            inputmakanan:
                Console.Clear();
                Console.WriteLine(new string(' ', 5) + "DAFTAR MENU MAKANAN & HARGA");
                Console.WriteLine(new string('^', 40));
                Console.WriteLine("1. Mie Goreng    :   15000");
                Console.WriteLine("2. Nasi Goreng   :   18000");
                Console.WriteLine("3. Bakso         :   10000");
                Console.WriteLine(new string('^', 40));
                Console.Write("Masukkan Menu Makanan [1/2/3]: ");
                makanan = int.Parse(Console.ReadLine());
                if (makanan == 1)
                {
                    namamakanan = " Mie Goreng";
                    harga1 = 15000;
                }
                else if (makanan == 2)
                {
                    namamakanan = " Nasi Goreng";
                    harga1 = 18000;
                }
                else if (makanan == 3)
                {
                    namamakanan = " Bakso";
                    harga1 = 10000;
                }
                else
                {
                    Console.WriteLine("Menu Makanan Tidak Valid!");
                    Console.ReadKey();
                    goto inputmakanan;
                }
            inputminuman:
                Console.Clear();
                Console.WriteLine(new string(' ', 5) + "DAFTAR MENU MINUMAN & HARGA");
                Console.WriteLine(new string('^', 40));
                Console.WriteLine("1. Jus Alpokat   :   10000");
                Console.WriteLine("2. Teh Manis     :   5000");
                Console.WriteLine("3. Sup Buah      :   12000");
                Console.WriteLine(new string('^', 40));
                Console.Write("Masukkan Minuman [1/2/3]: ");
                minuman = int.Parse(Console.ReadLine());
                if (minuman == 1)
                {
                    namaminuman = " Jus Alpokat";
                    harga2 = 10000;
                }
                else if (minuman == 2)
                {
                    namaminuman = " Teh Manis";
                    harga2 = 5000;
                }
                else if (minuman == 3)
                {
                    namaminuman = " Sup Buah ";
                    harga2 = 12000;
                }
                else
                {
                    Console.WriteLine("Menu Minuman Tidak Valid!");
                    Console.ReadKey();
                    goto inputminuman;
                }
            }
            else if (pilihan == 2)
            {
                namapilihan = "2. Bawa Pulang";
            inputmakanan:
                Console.Clear();
                Console.WriteLine(new string(' ', 5) + "DAFTAR MENU MAKANAN & HARGA");
                Console.WriteLine(new string('^', 40));
                Console.WriteLine("1. Mie Goreng    :   15000");
                Console.WriteLine("2. Nasi Goreng   :   18000");
                Console.WriteLine("3. Bakso         :   10000");
                Console.WriteLine(new string('^', 40));
                Console.Write("Masukkan Menu Makanan [1/2/3]: ");
                makanan = int.Parse(Console.ReadLine());
                if (makanan == 1)
                {
                    namamakanan = " Mie Goreng";
                    harga1 = 15000;
                }
                else if (makanan == 2)
                {
                    namamakanan = " Nasi Goreng";
                    harga1 = 18000;
                }
                else if (makanan == 3)
                {
                    namamakanan = " Bakso";
                    harga1 = 10000;
                }
                else
                {
                    Console.WriteLine("Menu Makanan Tidak Valid!");
                    Console.ReadKey();
                    goto inputmakanan;
                }
            inputminuman:
                Console.Clear();
                Console.WriteLine(new string(' ', 5) + "DAFTAR MENU MINUMAN & HARGA");
                Console.WriteLine(new string('^', 40));
                Console.WriteLine("1. Jus Alpokat   :   10000");
                Console.WriteLine("2. Teh Manis     :   5000");
                Console.WriteLine("3. Sup Buah      :   12000");
                Console.WriteLine(new string('^', 40));
                Console.Write("Masukkan Minuman [1/2/3]: ");
                minuman = int.Parse(Console.ReadLine());
                if (minuman == 1)
                {
                    namaminuman = " Jus Alpokat";
                    harga2 = 10000;
                }
                else if (minuman == 2)
                {
                    namaminuman = " Teh Manis";
                    harga2 = 5000;
                }
                else if (minuman == 3)
                {
                    namaminuman = " Sup Buah ";
                    harga2 = 12000;
                }
                else
                {
                    Console.WriteLine("Menu Minuman Tidak Valid!");
                    Console.ReadKey();
                    goto inputminuman;
                }
            }
            else
            {
                Console.WriteLine("Menu Tidak Valid!");
                Console.ReadKey();
                goto inputpilihan;
            }
            Console.Clear();
            Console.WriteLine(new string(' ', 10) + "JUMLAH PESANAN");
            Console.WriteLine(new string('^', 40));
            Console.Write("1. Menu Makanan  :   ");
            jumlahmakanan = int.Parse(Console.ReadLine());
            Console.Write("2. Menu Minuman  :   ");
            jumlahminuman = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('^', 40));
            Console.WriteLine("Total Jumlah Pesanan : " + (jumlahmakanan + jumlahminuman));
            Console.ReadLine();

            subtotal = (harga1 * jumlahmakanan) + (harga2 * jumlahminuman);
            Console.ReadKey();


        inputmember:
            Console.Clear();
            Console.WriteLine(new string(' ', 10) + "TIPE MEMBER");
            Console.WriteLine(new string('^', 40));
            Console.WriteLine("1. Member");
            Console.WriteLine("2. Non Member");
            Console.WriteLine(new string('^', 40));
            Console.Write("Masukkan Minuman [1/2]: ");
            tipemember = int.Parse(Console.ReadLine());
            if (tipemember == 1)
            {
                namamember = "Member";
                diskon = subtotal * 0.1;
            }
            else if (tipemember == 2)
            {
                Console.WriteLine("Anda tidak mendapat Diskon");
                diskon = subtotal * 0;
                namamember = "Non Member";
            }
            else
            {
                Console.WriteLine("Input tidak valid");
                Console.ReadKey();
                goto inputmember;
            }
            total = subtotal - diskon;
            Console.WriteLine("PEMBELIAN ANDA = " + subtotal);
            Console.WriteLine("Anda mendapatkan diskon " + diskon.ToString("Rp #,##0.00"));
            Console.WriteLine("Total Pembelian anda = " + total.ToString("Rp #,##0.00"));


            Console.ReadKey();

            Console.Clear();
            totalmakan = jumlahmakanan * harga1;
            totalminum = jumlahminuman * harga2;
            pajak = total * 0.05;
            Console.WriteLine(new string('-', 13) + "STRUK PEMBELIAN" + new string('-', 13));
            total2 = total + pajak;
            Console.WriteLine(jumlahmakanan + namamakanan + "Dengan Harga @" + harga1.ToString("Rp #,##0.00"));
            Console.SetCursorPosition(41, 1); Console.WriteLine(" : " + totalmakan.ToString("Rp #,##0.00"));
            Console.WriteLine(jumlahminuman + namaminuman + "Dengan Harga @" + harga2.ToString("Rp #,##0.00"));
            Console.SetCursorPosition(41, 2); Console.WriteLine(" : " + totalminum.ToString("Rp #,##0.00"));
            Console.WriteLine(new string('_', 57));
            Console.WriteLine(new string(' ', 33) + "Pajak :" + new string(' ', 5) + pajak.ToString("Rp #,##0.00"));
            Console.WriteLine(new string(' ', 33) + new string(' ', 5) + total.ToString("Rp #,##0.00"));
            Console.WriteLine(new string(' ', 33) + "Total :" + new string(' ', 5) + total2.ToString("Rp #,##0.00"));

            Console.ReadKey();
        }
    }
}
