using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập vào chuỗi thứ nhất (chuỗi chính): ");
        string str = Console.ReadLine();
        Console.WriteLine($"=> Chuỗi vừa nhập là: \"{str}\"");

        int doDai = 0;
        foreach (char ch in str)
        {
            doDai++;
        }
        Console.WriteLine($"=> Độ dài của chuỗi là: {doDai}");


       
        Console.Write("=> Các ký tự tách rời: ");
        for (int i = 0; i < doDai; i++)
        {
            Console.Write(str[i] + " ");
        }


       
        Console.Write("=> Chuỗi đảo ngược là: ");
        for (int i = doDai - 1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }


        
        int soTu = 0;
        bool trongTu = false;
        for (int i = 0; i < doDai; i++)
        {
            // Nếu gặp ký tự không phải khoảng trắng, tab hoặc xuống dòng
            if (str[i] != ' ' && str[i] != '\t' && str[i] != '\n')
            {
                if (!trongTu)
                {
                    soTu++;
                    trongTu = true;
                }
            }
            else
            {
                trongTu = false;
            }
        }
        Console.WriteLine($"=> Tổng số từ trong chuỗi: {soTu}");


        
        Console.Write("Nhập vào chuỗi thứ hai để so sánh: ");
        string str2 = Console.ReadLine();

        int doDai2 = 0;
        foreach (char ch in str2) doDai2++; // Tính độ dài chuỗi 2

        int ketQuaSoSanh = 0; // 0 là bằng nhau, <0 nếu str < str2, >0 nếu str > str2
        int minLen = (doDai < doDai2) ? doDai : doDai2;

        for (int i = 0; i < minLen; i++)
        {
            if (str[i] != str2[i])
            {
                ketQuaSoSanh = str[i] - str2[i];
                break;
            }
        }

        if (ketQuaSoSanh == 0)
        {
            ketQuaSoSanh = doDai - doDai2;
        }

        if (ketQuaSoSanh == 0)
            Console.WriteLine("=> Kết quả so sánh: Hai chuỗi giống nhau hoàn toàn.");
        else if (ketQuaSoSanh < 0)
            Console.WriteLine("=> Kết quả so sánh: Chuỗi thứ nhất nhỏ hơn chuỗi thứ hai.");
        else
            Console.WriteLine("=> Kết quả so sánh: Chuỗi thứ nhất lớn hơn chuỗi thứ hai.");


        
        int chuCai = 0, chuSo = 0, kyTuDacBiet = 0;
        for (int i = 0; i < doDai; i++)
        {
            char c = str[i];
            if ((c >= 'a' && c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                chuCai++;
            }
            else if (c >= '0' && c <= '9')
            {
                chuSo++;
            }
            else
            {
                kyTuDacBiet++;
            }
        }
        Console.WriteLine($"=> Số chữ cái (Alpha): {chuCai}");
        Console.WriteLine($"=> Số chữ số (Digit): {chuSo}");
        Console.WriteLine($"=> Số ký tự đặc biệt: {kyTuDacBiet}");


       
        int nguyenAm = 0, phuAm = 0;
        for (int i = 0; i < doDai; i++)
        {
            char c = str[i];
            // Chỉ xét nếu là chữ cái
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                    c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    nguyenAm++;
                }
                else
                {
                    phuAm++;
                }
            }
        }
        Console.WriteLine($"=> Số nguyên âm: {nguyenAm}");
        Console.WriteLine($"=> Số phụ âm: {phuAm}");


        
        if (doDai > 0)
        {
            char kyTuDau = str[0];
            Console.Write($"=> Kiểm tra ký tự đầu tiên '{kyTuDau}': ");
            if ((kyTuDau >= 'a' && kyTuDau <= 'z') || (kyTuDau >= 'A' && kyTuDau <= 'Z'))
            {
                if (kyTuDau >= 'A' && kyTuDau <= 'Z')
                    Console.WriteLine("Là chữ cái in HOA.");
                else
                {
                    phuAm++;
                }
            }
        }
        Console.WriteLine($"=> Số nguyên âm: {nguyenAm}");
        Console.WriteLine($"=> Số phụ âm: {phuAm}");


       
        if (doDai > 0)
        {
            char kyTuDau = str[0];
            Console.Write($"=> Kiểm tra ký tự đầu tiên '{kyTuDau}': ");
            if ((kyTuDau >= 'a' && kyTuDau <= 'z') || (kyTuDau >= 'A' && kyTuDau <= 'Z'))
            {
                if (kyTuDau >= 'A' && kyTuDau <= 'Z')
                    Console.WriteLine("Là chữ cái in HOA.");
                else
                    Console.WriteLine("Là chữ cái in thường.");
            }
            else
            {
                Console.WriteLine("Không phải là chữ cái.");
            }
        }


       
        Console.Write("Nhập vào một chuỗi con (substring) để tìm kiếm: ");
        string sub = Console.ReadLine();

        int doDaiSub = 0;
        foreach (char ch in sub) doDaiSub++;

        bool timThay = false;
        int viTriDauTien = -1;
        int soLanXuatHien = 0;

        if (doDaiSub > 0 && doDai >= doDaiSub)
        {
            for (int i = 0; i <= doDai - doDaiSub; i++)
            {
                bool khop = true;
                for (int j = 0; j < doDaiSub; j++)
                {
                    if (str[i + j] != sub[j])
                    {
                        khop = false;
                        break;
                    }
                }
                if (khop)
                {
                    soLanXuatHien++;
                    if (!timThay)
                    {
                        timThay = true;
                        viTriDauTien = i; // Lưu vị trí xuất hiện đầu tiên
                    }
                }
            }
        }

        Console.WriteLine(timThay ? "=> Chuỗi con CÓ tồn tại trong chuỗi chính." : "=> Chuỗi con KHÔNG tồn tại trong chuỗi chính.");

        if (timThay)
            Console.WriteLine($"=> Vị trí (chỉ số index) xuất hiện đầu tiên của chuỗi con là: {viTriDauTien}");
        else
            Console.WriteLine("=> Không tìm thấy vị trí của chuỗi con.");

        Console.WriteLine($"=> Số lần chuỗi con xuất hiện trong chuỗi chính là: {soLanXuatHien}");


       
        if (timThay && doDaiSub > 0)
        {
            Console.Write("=> Chuỗi sau khi chèn chuỗi con vào trước chính nó: ");

            for (int i = 0; i < viTriDauTien; i++)
            {
                Console.Write(str[i]);
            }

            Console.Write(sub);

            for (int i = viTriDauTien; i < doDai; i++)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("=> Không thể thực hiện chèn vì chuỗi con không tồn tại trong chuỗi gốc.");
        }

        Console.WriteLine("Chương trình kết thúc. Nhấn phím bất kỳ để thoát...");
        Console.ReadKey();
    }
}