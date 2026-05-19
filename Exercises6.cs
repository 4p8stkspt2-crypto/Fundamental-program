using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiTapMangVaThuatToan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;


            Random rand = new Random();
            int[] mangGoc = new int[10];
            for (int i = 0; i < mangGoc.Length; i++)
            {
                mangGoc[i] = rand.Next(1, 21); 
            }

            Console.Write("Mảng ngẫu nhiên vừa tạo là: ");
            InMang(mangGoc);

            double trungBinh = TinhTrungBinh(mangGoc);
            Console.WriteLine($"1. Giá trị trung bình của mảng: {trungBinh}");

            int giaTriCanTim = 10; 
            bool coChua = KiemTraChuaGiaTri(mangGoc, giaTriCanTim);
            Console.WriteLine($"2. Mảng có chứa số {giaTriCanTim} không?: {coChua}");

            int viTri = TimViTri(mangGoc, giaTriCanTim);
            Console.WriteLine($"3. Vị trí đầu tiên của số {giaTriCanTim} trong mảng là: {viTri} (Nếu là -1 nghĩa là không có)");

            int giaTriCanXoa = mangGoc[0]; 
            int[] mangSauXoa = XoaPhanTu(mangGoc, giaTriCanXoa);
            Console.Write($"4. Mảng sau khi xóa hết số {giaTriCanXoa}: ");
            InMang(mangSauXoa);

            TimMaxMin(mangGoc, out int max, out int min);
            Console.WriteLine($"5. Giá trị lớn nhất: {max} | Giá trị nhỏ nhất: {min}");

            int[] mangDaoNguoc = DaoNguocMang(mangGoc);
            Console.Write("6. Mảng sau khi đảo ngược: ");
            InMang(mangDaoNguoc);

            int[] cacSoTrung = TimPhanTuTrung(mangGoc);
            Console.Write("7. Các giá trị xuất hiện từ 2 lần trở lên: ");
            InMang(cacSoTrung);

            int[] mangKhongTrung = XoaTrungLap(mangGoc);
            Console.Write("8. Mảng sau khi lọc bỏ các số trùng lặp: ");
            InMang(mangKhongTrung);






            int[] mangSắpXếp = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhập số nguyên thứ {i + 1}: ");
                mangSắpXếp[i] = int.Parse(Console.ReadLine());
            }

            BubbleSort(mangSắpXếp);
            Console.Write("Mảng sau khi sắp xếp tăng dần (Bubble Sort): ");
            InMang(mangSắpXếp);

            Console.Write("Nhập vào một câu văn: ");
            string cauVan = Console.ReadLine();
            Console.Write("Nhập vào từ cần tìm kiếm: ");
            string tuCanTim = Console.ReadLine();

            bool timThay = LinearSearch(cauVan, tuCanTim);
            if (timThay)
            {
                Console.WriteLine($"=> Kết quả: Từ \"{tuCanTim}\" CÓ xuất hiện trong câu.");
            }
            else
            {
                Console.WriteLine($"=> Kết quả: Từ \"{tuCanTim}\" KHÔNG xuất hiện trong câu.");
            }
        }


        static double TinhTrungBinh(int[] arr) =>  arr.Sum() / arr.Length;

        static bool KiemTraChuaGiaTri(int[] arr, int value) => arr.Contains(value);

        static int TimViTri(int[] arr, int value) => Array.IndexOf(arr, value);

        static int[] XoaPhanTu(int[] arr, int value) => arr.Where(num => num != value).ToArray();

        static void TimMaxMin(int[] arr, out int max, out int min)
        {
            max = arr.Max();
            min = arr.Min();
        }

        static int[] DaoNguocMang(int[] arr)
        {
            int[] clone = (int[])arr.Clone(); 
            Array.Reverse(clone);
            return clone;
        }

        static int[] TimPhanTuTrung(int[] arr)
        {
            return arr.GroupBy(x => x)
                      .Where(g => g.Count() > 1)
                      .Select(g => g.Key)
                      .ToArray();
        }

        static int[] XoaTrungLap(int[] arr) => arr.Distinct().ToArray();

        static void InMang(int[] arr) => Console.WriteLine(string.Join(" ", arr));

   

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static bool LinearSearch(string sentence, string word)
        {
            if (string.IsNullOrWhiteSpace(sentence) || string.IsNullOrWhiteSpace(word)) return false;

            string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string w in words)
            {
                if (string.Equals(w, word, StringComparison.OrdinalIgnoreCase))
                {
                    return true; 
                }
            }
            return false; 
        }
    }
}