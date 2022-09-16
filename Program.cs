using System;
using System.Data;

namespace MCC_SamuelYusa_1
{
    class Program
    {
        static void TambahData()
        {

        }
        static void Main(string[] args)
        {
            bool endApp = false;

            int MenuInput;
            string[,] DataKaryawan = new string[5, 3];
            DataKaryawan = new string[,] { { "Sam", "MT", "Utility" }, { "Yusa", "Manager", "General Affairs" } };


            while (!endApp)
            {
                Console.WriteLine("Aplikasi Data Karyawan\r");
                Console.WriteLine("--------MENU----------\n");
                Console.WriteLine("\n");
                Console.WriteLine("1. Tambah Data Karyawan Baru\n");
                Console.WriteLine("2. Tampilkan Data Karyawan\n");
                Console.WriteLine("3. Keluar\n");
                Console.WriteLine("\n");
                Console.WriteLine("Silahkan masukkan angka sesuai dengan keterangan diatas kemudian tekan Enter.\n");
                MenuInput = Convert.ToInt16(Console.ReadLine());
                Console.Clear();

                if (MenuInput == 1)
                {
                    Console.WriteLine("Aplikasi Data Karyawan\r");
                    Console.WriteLine("--Tambah Data Karyawan Baru--\n");
                    Console.Write("Nama : ");
                    string NamaKaryawanBaru = Console.ReadLine();
                    Console.Write("Jabatan : ");
                    string JabatanKaryawanBaru = Console.ReadLine();
                    Console.Write("Department : ");
                    string DepartmentKaryawanBaru = Console.ReadLine();
                    Console.WriteLine("\n");

                    Console.Write("Apakah data yang anda masukkan sudah benar (y/n) ");

                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        Console.Clear();
                       
                        DataKaryawan = new string[,] { { NamaKaryawanBaru, JabatanKaryawanBaru, DepartmentKaryawanBaru } };

                        Console.WriteLine("\nData Karyawan Baru Telah Disimpan!");
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.Clear();
                        return;
                    }
                }
                else if (MenuInput == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Aplikasi Data Karyawan\r");
                    Console.WriteLine("-----Data Karyawan-----\n");

                    for (int i = 0; i < DataKaryawan.GetLength(0); i++)
                    {
                        for (int j = 0; j < DataKaryawan.GetLength(1); j++)
                        {
                            Console.Write(DataKaryawan[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("\n");

                }
                else if (MenuInput == 3)
                {
                    endApp = true;
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Masukkan angka sesuai dengan pilihan dimenu!");
                }
            }
            return;
        }
    }
}
