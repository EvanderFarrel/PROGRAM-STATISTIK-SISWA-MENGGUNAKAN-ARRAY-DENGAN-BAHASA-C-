internal class Program
{
     static string[] nama = {"Alice","Bob","Charlie","Andi","Pal"};
     static int[] nilai = {85,90,78,65,100};
    static void TampilkanDataMahasiswa()
    {
     Console.WriteLine("=== DATA MAHASISWA ===");
     Console.WriteLine("");
     for (int i = 0; i < nama.Length;i ++)
     {
        Console.WriteLine("Nama : " + nama[i]+", Nilai : "+ nilai[i]);
     }

     Console.WriteLine("");
     Console.WriteLine("Ingin kembali ke menu ? , klik enter");
     Console.ReadKey();
    }
    static void TampilkanNilai()
    {
     int maxnilai = nilai[0];
     int minnilai = nilai[0];
     string namamax = nama[0];
     string namamin = nama[0];

     for (int i = 1; i < nilai.Length ; i++)
     {
     if (nilai[i] > maxnilai)
            {
                maxnilai = nilai[i];
                namamax = nama[i];
            }

     if (nilai[i] < minnilai)
            {
                minnilai = nilai[i];
                namamin = nama[i];
            }
     }
     Console.WriteLine("=== DATA MAHASISWA ===");
     Console.WriteLine("");
     Console.WriteLine("Nilai Tertinggi = " + maxnilai+ " ( "+ namamax +" ) " );
     Console.WriteLine("Nilai Terendah = " + minnilai+ " ( "+ namamin +" ) ");

     Console.WriteLine("");
     Console.WriteLine("Ingin kembali ke menu ? , klik enter");
     Console.ReadKey();
    }
    static void  ratarata()
    {
     int totalnilai = 0;
     for (int i = 0; i < nilai.Length; i++)
        {
            totalnilai += nilai[i];
        }

     Console.WriteLine("=== DATA MAHASISWA ===");
     Console.WriteLine("");
     double hasil = totalnilai / nilai.Length;
     Console.WriteLine("Nilai Rata - rata mahasiswa adalah "+(hasil));

     Console.WriteLine("");
     Console.WriteLine("Ingin kembali ke menu ? , klik enter");
     Console.ReadKey();
    }

    static void  UrutkanNilai()
    {
     Console.WriteLine("=== DATA MAHASISWA ===");
     Console.WriteLine("");
     string[] namasorted = nama.ToArray();
     int[] nilaisorted = nilai.ToArray();
     Array.Sort(nilaisorted, namasorted); 
     Array.Reverse(nilaisorted);         
     Array.Reverse(namasorted);          
     for (int i = 0; i < nilaisorted.Length; i++)
     {
        Console.WriteLine("Nama :" + (namasorted[i]) + ", Nilai : " + (nilaisorted[i]));
     }

     Console.WriteLine("");
     Console.WriteLine("Ingin kembali ke menu ? , klik enter");
     Console.ReadKey();
    } 


    private static void Main(string[] args)
    {
     int pilihan;
     do
     {
     Console.WriteLine("=== CONTOH PROGRAM STATISTIK SISWA ===");
     Console.WriteLine("");
     Console.WriteLine("Pilih Tindakan : ");
     Console.WriteLine("1. Tampilkan Semua Data Mahasiswa");
     Console.WriteLine("2. Tampilkan nilai tertinggi dan terendah");
     Console.WriteLine("3. Hitung Rata-rata nilai");
     Console.WriteLine("4. Tampilkan data mahasiswa berdasarkan nilai (descending)");
     Console.WriteLine("5. Keluar");
     Console.Write("Masukkan Pilihan Tindakan : ");
     pilihan = Convert.ToInt32(Console.ReadLine());
     switch (pilihan)
     {
      case 1:
      TampilkanDataMahasiswa();
      break;
      case 2:
      TampilkanNilai();
      break;
      case 3:
      ratarata();
      break;
      case 4:
      UrutkanNilai();
      break;
      case 5:
      Console.WriteLine("==== Terimakasih Sudah Menggunakan ====");
      break;
      default:
      Console.WriteLine("");
      Console.WriteLine("Maaf, pilihan 1-5 saja, silahkan ulang kembali");
      Console.WriteLine("");
      break;
     }
     }
     while (pilihan >= 6);
    }
}