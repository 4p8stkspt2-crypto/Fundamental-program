namespace Exercises_3;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- MENU BÀI TẬP C# ---");
            Console.WriteLine("1. Máy tính cơ bản (+, -, *, /)");
            Console.WriteLine("2. Tính hàm số x = y² + 2y + 1 (y từ -5 đến 5)");
            Console.WriteLine("3. Tính tốc độ (km/h và mph)");
            Console.WriteLine("4. Tính diện tích và thể tích hình cầu");
            Console.WriteLine("5. Kiểm tra ký tự (Nguyên âm, số, ký hiệu)");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn bài tập (0-5): ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1": RunCalculator(); break;
                case "2": RunFunctionTable(); break;
                case "3": RunSpeedConverter(); break;
                case "4": RunSphereCalc(); break;
                case "5": RunCharCheck(); break;
                case "0": return;
                default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
            }
        }
    }

    // 1. Máy tính cơ bản
    static void RunCalculator()
    {
        Console.Write("Nhập số thứ nhất: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập phép tính (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.Write("Nhập số thứ hai: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        if (op == '+') Console.WriteLine($"Kết quả: {n1 + n2}");
        else if (op == '-') Console.WriteLine($"Kết quả: {n1 - n2}");
        else if (op == '*' || op == 'x') Console.WriteLine($"Kết quả: {n1 * n2}");
        else if (op == '/') Console.WriteLine(n2 != 0 ? $"Kết quả: {n1 / n2}" : "Lỗi: Không thể chia cho 0");
    }

    // 2. Hàm số x = y² + 2y + 1
    static void RunFunctionTable()
    {
        Console.WriteLine("y\tx = y² + 2y + 1");
        for (int y = -5; y <= 5; y++)
        {
            int x = (y * y) + (2 * y) + 1;
            Console.WriteLine($"{y}\t{x}");
        }
    }

    // 3. Tính tốc độ
    static void RunSpeedConverter()
    {
        Console.Write("Nhập khoảng cách (mét): ");
        float dist = Convert.ToSingle(Console.ReadLine());
        Console.Write("Giờ: "); float h = Convert.ToSingle(Console.ReadLine());
        Console.Write("Phút: "); float m = Convert.ToSingle(Console.ReadLine());
        Console.Write("Giây: "); float s = Convert.ToSingle(Console.ReadLine());

        float totalHours = h + (m / 60f) + (s / 3600f);
        float kmph = (dist / 1000f) / totalHours;
        float miph = kmph / 1.609344f;

        Console.WriteLine($"Tốc độ km/h: {kmph}");
        Console.WriteLine($"Tốc độ miles/h: {miph}");
    }

    // 4. Hình cầu
    static void RunSphereCalc()
    {
        Console.Write("Nhập bán kính: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double surface = 4 * Math.PI * Math.Pow(r, 2);
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
        Console.WriteLine($"Diện tích bề mặt: {surface:F2}");
        Console.WriteLine($"Thể tích: {volume:F2}");
    }

    // 5. Kiểm tra ký tự
    static void RunCharCheck()
    {
        Console.Write("Nhập một ký tự: ");
        char symbol = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (char.IsDigit(symbol))
            Console.WriteLine("Đây là một chữ số.");
        else if ("aeiouAEIOU".Contains(symbol))
            Console.WriteLine("Đây là một nguyên âm.");
        else
            Console.WriteLine("Đây là một ký hiệu hoặc phụ âm.");
    }
}

