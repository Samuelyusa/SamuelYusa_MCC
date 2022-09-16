using System;
using System.Data;

namespace MCC_SamuelYusa_1
{
    class Program
    {
        static void KeMenu()
        {
            Console.WriteLine("Tekan Enter untuk kembali ke Menu\n");

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
            Console.Clear();
        }



        static void Main(string[] args)
        {
            bool endApp = false;

            int MenuInput;
            string[,] DataKaryawan = new string[5, 3];
            DataKaryawan = new string[,] { { "Nama", "Jabatan", "Department" },
                { "Sam", "MT", "Utility" },
                { "Yusa", "Manager", "General Affairs" },
                {null,null,null },
                {null,null,null },
                {null,null,null },
            };


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
                    bool TambahData = false;
                    int slotData = 0;

                    for (int DataArray = 0; DataArray <= 5; DataArray++)
                    {
                        if (DataKaryawan[DataArray, 0] == null)
                        {
                            slotData++;
                        }
                    }
                    if (slotData !=0)
                    {
                        TambahData = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n Penyimpanan Data Karyawan Penuh!");
                        KeMenu();
                    }

                    while (TambahData)
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
                            Console.WriteLine("\n");
                            Console.WriteLine("============================================\n");

                            for (int DataArray = 0; DataArray <= 5; DataArray++)
                            {
                                if(DataKaryawan[DataArray,0] == null)
                                {
                                    DataKaryawan[DataArray, 0] = NamaKaryawanBaru;
                                    DataKaryawan[DataArray, 1] = JabatanKaryawanBaru;
                                    DataKaryawan[DataArray, 2] = DepartmentKaryawanBaru;
                                    DataArray = 6;
                                }
                            }

                            Console.WriteLine("\nData Karyawan Baru Telah Disimpan!");
                            KeMenu();
                            TambahData = false;
                        }
                        else
                        {
                            Console.Clear();
                        }
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

                    KeMenu();

                }
                else if (MenuInput == 3)
                {
                    endApp = true;
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
