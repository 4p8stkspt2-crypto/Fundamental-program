namespace Exercises_4;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("================ MENU BÀI TẬP C# ================");
            Console.WriteLine("1.  Máy tính cơ bản (+, -, *, /) với 2 số.");
            Console.WriteLine("2.  Tính giá trị hàm x = y^2 + 2y + 1 (y từ -5 đến 5).");
            Console.WriteLine("3.  Tính vận tốc (km/h và miles/h).");
            Console.WriteLine("4.  Tính diện tích bề mặt và thể tích hình cầu.");
            Console.WriteLine("5.  Kiểm tra ký tự (Nguyên âm, chữ số, hay ký hiệu).");
            Console.WriteLine("6.  Kiểm tra loại tam giác (Đều, Cân, Thường).");
            Console.WriteLine("7.  Đọc 10 số, tính tổng và trung bình.");
            Console.WriteLine("8.  In bảng cửu chương của một số.");
            Console.WriteLine("9.  In mẫu hình tam giác bằng số.");
            Console.WriteLine("10. In mẫu hình kim tự tháp bằng dấu sao (*).");
            Console.WriteLine("11. In n phần tử của chuỗi điều hòa và tính tổng.");
            Console.WriteLine("12. Tìm số hoàn hảo trong một khoảng.");
            Console.WriteLine("13. Kiểm tra số nguyên tố.");
            Console.WriteLine("0.  Thoát chương trình.");
            Console.WriteLine("=================================================");
            Console.Write("Nhập số thứ tự bài tập bạn muốn chạy (0-13): ");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1": Bai1(); break;
                case "2": Bai2(); break;
                case "3": Bai3(); break;
                case "4": Bai4(); break;
                case "5": Bai5(); break;
                case "6": Bai6(); break;
                case "7": Bai7(); break;
                case "8": Bai8(); break;
                case "9": Bai9(); break;
                case "10": Bai10(); break;
                case "11": Bai11(); break;
                case "12": Bai12(); break;
                case "13": Bai13(); break;
                case "0":return;
                default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
            }
            Console.WriteLine("Nhấn phím bất kỳ để quay lại Menu...");
            Console.ReadKey();
        }
        static void Bai1()
        {
            Console.Write("Nhập a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập phép toán +,-,*,/:");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Nhập b:");
            double b = double.Parse(Console.ReadLine());
            if (op == '+') Console.WriteLine($"Kết quả:{a + b}");
            else if (op == '-') Console.WriteLine($"Kết quả:{a - b}");
            else if (op == '*') Console.WriteLine($"Kết quả:{a * b}");
            else if (op == '/')
            {
                if (b != 0) Console.WriteLine($"Kết quả:{a / b}");
                else Console.WriteLine("lỗi b");
            }
            else Console.WriteLine("không hợp lệ");
        }
        static void Bai2()
        {
            Console.WriteLine("x=y^2+2y+1 với y từ -5 đến 5");
            for (int y=-5;y<=5;y++)
            {
                int x = y * y + 2 * y + 1;
                    Console.WriteLine ($"{ x}");
            }
        }
        static void Bai3()
        {
            Console.Write("Nhập khoảng cách (mét):");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập giờ:");
            Double h = double.Parse(Console.ReadLine());
            Console.Write("Nhập phút:");
            Double m = double.Parse(Console.ReadLine());
            Console.Write("Nhập giây:");
            Double s = double.Parse(Console.ReadLine());
            double t = h + m / 60 + s / 3600;
            Console.WriteLine($"{a/1000.0/h} km/h");
            Console.WriteLine($"{a/1000.0/h/1.609} miles/h");
        }
        static void Bai4()
        {
            Console.Write("Nhập bán kính:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine($"Diện tích bề mặt:{4 * Math.PI * a * a}");
            Console.WriteLine($"Thể tích:{4.0 / 3.0 * Math.PI * Math.Pow(a, 3)}");
        }
        static void Bai5()
        {
            Console.Write("Nhập 1 ký tự: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.IsDigit(c)) Console.WriteLine("Đây là chữ số.");
            else if ("aeiouAEIOU".Contains(c)) Console.WriteLine("Đây là nguyên âm.");
            else Console.WriteLine("Đây là phụ âm hoặc ký hiệu.");
        }
        static void Bai6()
        {
            Console.Write("Cạnh 1: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Cạnh 2: "); int b = int.Parse(Console.ReadLine());
            Console.Write("Cạnh 3: "); int c = int.Parse(Console.ReadLine());
            if (a == b && b == c) Console.WriteLine("Tam giác đều.");
            else if (a == b || b == c || a == c) Console.WriteLine("Tam giác cân.");
            else Console.WriteLine("Tam giác thường.");
        }
        static void Bai7()
        {
            double sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Nhập số {i}: ");
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Tổng: {sum}, Trung bình: {sum / 10}");
        }
        static void Bai8()
        {
            Console.Write("Nhập số: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++) Console.WriteLine($"{n} x {i} = {n * i}");
        }
        static void Bai9()
        {
            Console.Write("Số hàng: ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++) Console.Write(j);
                Console.WriteLine();
            }
        }
        static void Bai10()
        {
            Console.Write("Số hàng: ");
            int r = int.Parse(Console.ReadLine());
            for (int i = 1; i <= r; i++)
            {
                for (int s = 1; s <= r - i; s++) Console.Write(" ");
                for (int st = 1; st <= 2 * i - 1; st++) Console.Write("*");
                Console.WriteLine();
            }
        }
        static void Bai11()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i} ");
                s += 1.0 / i;
            }
            Console.WriteLine($"Tổng: {s}");
        }
        static void Bai12()
        {
            Console.Write("Bắt đầu: "); int s = int.Parse(Console.ReadLine());
            Console.Write("Kết thúc: "); int e = int.Parse(Console.ReadLine());
            for (int i = s; i <= e; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++) if (i % j == 0) sum += j;
                if (sum == i && i != 0) Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Bai13()
        {
            Console.Write("Nhập số: ");
            int n = int.Parse(Console.ReadLine());
            bool ok = n > 1;
            for (int i = 2; i <= Math.Sqrt(n); i++) if (n % i == 0) ok = false;
            Console.WriteLine(ok ? "Là số nguyên tố." : "Không là số nguyên tố.");
        }
    }
}

