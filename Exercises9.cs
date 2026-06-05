using System;
using System.IO;
using System.Linq;

class ChuongTrinhFile
{
    static void Main()
    {
        string duongDanGoc = "tep_tin_goc.txt";
        string duongDanMoi = "tep_tin_moi.txt";
        string thuMucMoi = "ThuMucThuNghiem";

        File.Create(duongDanGoc).Close();
        Console.WriteLine("1. Đã tạo tệp tin trống.");

        File.Delete(duongDanGoc);
        Console.WriteLine("2. Đã xóa tệp tin.");

        File.WriteAllText(duongDanGoc, "Xin chào thế giới!\n");
        Console.WriteLine("3. Đã tạo tệp và ghi chữ.");

        File.WriteAllText(duongDanGoc, "Dòng 1: Học C# rất thú vị.\n");
        string noiDungDoc = File.ReadAllText(duongDanGoc);
        Console.WriteLine($"4. Nội dung đọc được:\n{noiDungDoc}");

        string[] mangChuoi = { "Dòng một", "Dòng hai", "Dòng ba", "Dòng bốn", "Dòng năm" };
        File.WriteAllLines(duongDanGoc, mangChuoi);
        Console.WriteLine("5. Đã ghi mảng chuỗi vào tệp.");

        File.AppendAllText(duongDanGoc, "Đây là dòng được ghi thêm.\n");
        Console.WriteLine("6. Đã ghi thêm chữ vào tệp.");

        File.Copy(duongDanGoc, duongDanMoi, true);
        Console.WriteLine($"7. Nội dung tệp sao chép ({duongDanMoi}):\n{File.ReadAllText(duongDanMoi)}");

        string duongDanDoiTen = "tep_da_doi_ten.txt";
        if (File.Exists(duongDanDoiTen)) File.Delete(duongDanDoiTen);
        File.Move(duongDanMoi, duongDanDoiTen);
        Console.WriteLine($"8. Đã đổi tên {duongDanMoi} thành {duongDanDoiTen}.");

        string dòngDau = File.ReadLines(duongDanGoc).FirstOrDefault();
        Console.WriteLine($"9. Dòng đầu tiên: {dòngDau}");

        string dongCuoi = File.ReadLines(duongDanGoc).LastOrDefault();
        Console.WriteLine($"10. Dòng cuối cùng: {dongCuoi}");

        int soDongCanDoc = 3;
        var nDongCuoi = File.ReadLines(duongDanGoc).TakeLast(soDongCanDoc);
        Console.WriteLine($"11. {soDongCanDoc} dòng cuối cùng:");
        foreach (var dong in nDongCuoi) Console.WriteLine($"- {dong}");

        int viTriDong = 2;
        string dongCuThe = File.ReadLines(duongDanGoc).ElementAtOrDefault(viTriDong - 1);
        Console.WriteLine($"12. Dòng thứ {viTriDong}: {dongCuThe}");

        int tongSoDong = File.ReadLines(duongDanGoc).Count();
        Console.WriteLine($"13. Tổng số dòng trong tệp: {tongSoDong}");

        Directory.CreateDirectory(thuMucMoi);
        File.WriteAllText(Path.Combine(thuMucMoi, "tep1.txt"), "Chao");
        File.WriteAllText(Path.Combine(thuMucMoi, "tep2.txt"), "C#");

        Console.WriteLine($"14. Cấu trúc thư mục '{thuMucMoi}':");
        Console.WriteLine($"[{thuMucMoi}]");
        foreach (string tepTin in Directory.GetFiles(thuMucMoi))
        {
            Console.WriteLine($"  |-- {Path.GetFileName(tepTin)}");
        }

        string vanBanThongKe = File.ReadAllText(duongDanGoc);
        var thongKeKyTu = vanBanThongKe
            .Where(k => char.IsLetterOrDigit(k))
            .GroupBy(k => k)
            .Select(nhom => new { KyTu = nhom.Key, SoLuong = nhom.Count() });

        Console.WriteLine("15. Thống kê ký tự và chữ số xuất hiện trong tệp gốc:");
        foreach (var muc in thongKeKyTu)
        {
            Console.WriteLine($"  Ký tự '{muc.KyTu}': {muc.SoLuong} lần");
        }

        if (File.Exists(duongDanGoc)) File.Delete(duongDanGoc);
        if (File.Exists(duongDanDoiTen)) File.Delete(duongDanDoiTen);
        if (Directory.Exists(thuMucMoi)) Directory.Delete(thuMucMoi, true);
    }
}