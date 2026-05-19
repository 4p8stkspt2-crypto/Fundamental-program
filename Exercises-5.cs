using System;
using System.Linq;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercies5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            //            Bài 1: Tính tổng hai số nguyên
            //Yêu cầu: Viết hàm `int TinhTong(int a, int b)` nhận vào hai số nguyên và trả về tổng của chúng.
            //Hướng dẫn: Bên trong thân hàm, bạn sử dụng từ khóa `return a + b;`. Trong hàm `Main`, gọi
            //hàm này, truyền vào 2 số cụ thể và in kết quả ra màn hình.
            Console.Write("Nhập a:");
            int b1a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b:");
            int b1b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tổng 2 số nguyên = {TinhTong(b1a, b1b)}");
            //            Bài 2: Kiểm tra số chẵn lẻ
            //Yêu cầu: Viết hàm `bool KiemTraChan(int n)` trả về `true` nếu `n` là số chẵn, `false` nếu là số lẻ.
            //Hướng dẫn: Sử dụng toán tử chia lấy dư `%`. Nếu biểu thức `n % 2 == 0` đúng thì n là số chẵn.
            //Bạn có thể return thẳng biểu thức này.
            Console.Write("Nhập n: ");
            int b2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"N có phải là số chẵn: {KiemTraChan(b2)}");
            //            Bài 3: Tìm số lớn nhất trong ba số
            //Yêu cầu: Viết hàm `int TimMax(int a, int b, int c)` trả về giá trị lớn nhất trong ba số được
            //truyền vào.
            //Hướng dẫn: Bạn có thể sử dụng cấu trúc điều kiện `if-else` lồng nhau. Cách ngắn gọn hơn là
            //tận dụng hàm có sẵn `Math.Max(Math.Max(a, b), c)`.
            Console.Write("Nhập a:");
            int b3a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b:");
            int b3b = int.Parse(Console.ReadLine());
            Console.Write("Nhập c:");
            int b3c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Số lớn nhất là:{TimMax(b3a,b3b,b3c)}");
            //            //Bài 4: Tính giai thừa của một số
            //            Yêu cầu: Viết hàm `long TinhGiaiThua(int n)` tính và trả về giai thừa của số nguyên dương n
            //            (n!).
            //Hướng dẫn: Sử dụng một biến lưu kết quả(khởi tạo bằng 1).Dùng vòng lặp `for` chạy từ 1 đến
            //`n` để nhân dồn vào biến kết quả.Chú ý: dùng kiểu `long` để tránh tràn số lượng giới hạn của
            //`int`.
            Console.Write("Nhập n: ");
            int b4 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{b4}! = {TinhGiaiThua(b4)}");
            //            Bài 5: Đảo ngược chuỗi ký tự
            //Yêu cầu: Viết hàm `string DaoNguocChuoi(string input)` nhận vào một chuỗi và trả về chuỗi bị
            //đảo ngược.
            //Hướng dẫn: Chuyển chuỗi thành mảng ký tự `char[]` bằng phương thức `.ToCharArray()`. Sau
            //đó dùng hàm `Array.Reverse()` để đảo mảng, cuối cùng tạo lại chuỗi mới bằng `new
            //string(char_array)`.
            Console.Write("Nhập chuỗi: ");
            string b5 = Console.ReadLine();
            Console.WriteLine($" Chuỗi sau đảo ngược: {DaoNguocChuoi(b5)}");
            //            Bài 6: Kiểm tra số nguyên tố
            //Yêu cầu: Viết hàm `bool KiemTraNguyenTo(int n)` kiểm tra xem số nguyên n có phải số nguyên
            //tố hay không.
            //Kết quả mẫu: Input: 7->Output: True | Input: 10->Output: False
            Console.Write("Nhập n:");
            int b6 = int.Parse(Console.ReadLine());
            Console.WriteLine($" n có phải là số nguyên tố:{KiemTraSoNguyenTo(b6)}");
            //            Bài 7: In dãy Fibonacci
            //Yêu cầu: Viết hàm `void InFibonacci(int n)` in ra n số đầu tiên của dãy Fibonacci.
            //Kết quả mẫu: Input: 6->Output: 0 1 1 2 3 5
            Console.WriteLine("Nhập n: ");
            int b7 = int.Parse(Console.ReadLine());
            Console.WriteLine($"n số dãy Fibonacci: ");
            InFibonacci(b7);

            Console.Write("Nhập chuỗi văn bản: ");
            string b8 = Console.ReadLine();
            Console.WriteLine($"số nguyên âm: {DemNguyenAm(b8)}");

            Console.Write("Nhập cơ số x: ");
            double b9a = double.Parse(Console.ReadLine());
            Console.Write("Nhập số mũ y: ");
            int b9b = int.Parse(Console.ReadLine());
            Console.WriteLine($" Kết quả luỹ thừa: {TinhLuyThua(b9a, b9b)}");

            Console.Write("Nhập số lượng phần tử của mảng: ");
            int b10a = int.Parse(Console.ReadLine());
            int[] b10_arr = new int[b10a];
            for (int i = 0; i < b10a; i++)
            {
                Console.Write($"Nhập phần tử thứ {i}: ");
                b10_arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Trung bình: {TinhTrungBinh(b10_arr)}");

            Console.Write("Nhập chuỗi: ");
            string b11 = Console.ReadLine();
            Console.WriteLine($"Chuối có đối xứng không: {KiemTraDoiXung(b11)}");

            Console.Write("Nhập nhiệt độ (°C): ");
            double b12 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Nhiệt độ F: {CelsiusToFahrenheit(b12)}°F");

            Console.Write("Nhập số lượng phần tử của mảng: ");
            int b13 = int.Parse(Console.ReadLine());
            int[] b13_arr = new int[b13];
            for (int i = 0; i < b13; i++)
            {
                Console.Write($"Nhập phần tử thứ {i}: ");
                b13_arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Kết quả TimMin = {TimMin(b13_arr)}");

            Console.Write("Nhập số nguyên n: ");
            int b14 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tổng các chữ số: {TongCacChuSo(b14)}");

            Console.Write("Nhập số lượng phần tử của mảng: ");
            int b15 = int.Parse(Console.ReadLine());
            int[] b15_arr = new int[b15];
            for (int i = 0; i < b15; i++)
            {
                Console.Write($"Nhập phần tử thứ {i}: ");
                b15_arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write($"Kết quả SapXepMang: ");
            SapXepMang(b15_arr);

            Console.Write("Nhập chuỗi: ");
            string b16 = Console.ReadLine();
            Console.WriteLine($"sau khi xoá trùng lặp: {XoaTrungLap(b16)}");

            Console.Write("Nhập số a: ");
            int b17a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số b: ");
            int b17b = int.Parse(Console.ReadLine());
            Console.WriteLine($"UCLN l {UCLN(b17a, b17b)}");

            Console.Write("Nhập số thập phân n: ");
            int b18 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sang hệ nhị phân là {DecimalToBinary(b18)}");

            Console.Write("Nhập năm cần kiểm tra: ");
            int b19 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Năm có nhuận không {KiemTraNamNhuan(b19)}");

            Console.Write("Nhập câu: ");
            string b20 = Console.ReadLine();
            Console.WriteLine($"Số từ là {DemSoTu(b20)}");
        }
        //1
        static int TinhTong(int a,int b)
        {
            return a + b;
        }
        //2
        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }
        //3
        static int TimMax(int a,int b,int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        //4
        static long TinhGiaiThua(int n)
        {
            long ans = 1;
            for(int i=1;i<=n;i++)
            {
                ans *= i;
            }
            return ans;
        }
        //5
        static string DaoNguocChuoi(string input)
        {
            char[] char_array = input.ToCharArray();
            Array.Reverse(char_array);
            return new string(char_array);
        }
        //6
        static bool KiemTraSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        //7
        static void InFibonacci(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine();
                return;
            }
            int t1 = 0, t2 = 1;
            for (int i = 1; i <= n; ++i)
            {
                Console.Write(t1 + " ");
                int sum = t1 + t2;
                t1 = t2;
                t2 = sum;
            }
            Console.WriteLine();
        }
        //8
        static int DemNguyenAm(string s)
        {
            int count = 0;
            string nguyenAm = "aeiouAEIOU";
            foreach (char c in s)
            {
                if (nguyenAm.Contains(c)) count++;
            }
            return count;
        }
        //9
        static double TinhLuyThua(double x, int y)
        {
            double ketQua = 1;
            int muTuyetDoi = Math.Abs(y);

            for (int i = 0; i < muTuyetDoi; i++)
            {
                ketQua *= x;
            }

            // Xử lý trường hợp số mũ âm
            return y < 0 ? 1 / ketQua : ketQua;
        }

        // Bài 10
        static double TinhTrungBinh(int[] arr)
        {
            if (arr.Length == 0) return 0;
            int tong = 0;
            foreach (int num in arr)
            {
                tong += num;
            }
            return (double)tong / arr.Length;
        }

        // Bài 11
        static bool KiemTraDoiXung(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right]) return false;
                left++;
                right--;
            }
            return true;
        }

        // Bài 12
        static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }

        // Bài 13
        static int TimMin(int[] arr)
        {
            int min = arr[0];
            foreach (int num in arr)
            {
                if (num < min) min = num;
            }
            return min;
        }

        // Bài 14
        static int TongCacChuSo(int n)
        {
            int tong = 0;
            n = Math.Abs(n); // Xử lý nếu nhập số âm
            while (n > 0)
            {
                tong += n % 10;
                n /= 10;
            }
            return tong;
        }

        // Bài 15
        static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine(string.Join(" ", arr));
        }

        // Bài 16
        static string XoaTrungLap(string s)
        {
            string ketQua = "";
            foreach (char c in s)
            {
                if (!ketQua.Contains(c))
                {
                    ketQua += c;
                }
            }
            return ketQua;
        }

        // Bài 17
        static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Bài 18
        static string DecimalToBinary(int n)
        {
            if (n == 0) return "0";
            string binary = "";
            while (n > 0)
            {
                binary = (n % 2) + binary;
                n /= 2;
            }
            return binary;
        }

        // Bài 19
        static bool KiemTraNamNhuan(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        // Bài 20
        static int DemSoTu(string sentence)
        {
            string[] words = sentence.Split(' ');
            return words.Length;
        }
        //10
        //11
        //12
        //13
        //14
        //15
        //16
        //17
        //18
        //19
        //20
    }
}