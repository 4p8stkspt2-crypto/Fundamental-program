using System;
using System.Collections.Generic;

class MangMotChieu
{
    static void Main1(string[] args)
    {

        Console.Write("Nhập n và các phần tử: ");
        int n1 = int.Parse(Console.ReadLine());
        int[] arr1 = NhapMangNguyen(n1);
        Bai01_XuatMang(arr1);

        Console.Write("Nhập n và các phần tử số thực: ");
        int n2 = int.Parse(Console.ReadLine());
        double[] arr2 = NhapMangThuc(n2);
        Bai02_TongVaTrungBinhCong(arr2);

        Bai03_TimMaxMin(arr1);

        Bai04_DemChanLe(arr1);

        Console.Write("Nhập số x cần tìm: ");
        int x5 = int.Parse(Console.ReadLine());
        Bai05_TimKiem(arr1, x5);

        Bai06_DaoNguocMang(arr1);

        Bai07_KiemTraDoiXung(arr1);

        Bai08_LietKeSoNguyenTo(arr1);

        Bai09_TachMangChanLe(arr1);

        Bai10_SapXepTangGiam(arr1);

        Console.Write("Nhập số x cần chèn: ");
        int x11 = int.Parse(Console.ReadLine());
        Bai11_ChenPhanTu(arr1, x11); // arr1 lúc này đã được sắp xếp tăng từ Bài 10

        Console.Write("Nhập vị trí k cần xóa (0 <= k < n): ");
        int k12 = int.Parse(Console.ReadLine());
        Bai12_XoaPhanTu(arr1, k12);

        Bai13_DemTanSuat(arr1);

        Bai14_XuatHienNhieuNhat(arr1);
    }

    static int[] NhapMangNguyen(int n)
    {
        int[] arr = new int[n];
        string[] tokens = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++) arr[i] = int.Parse(tokens[i]);
        return arr;
    }

    static double[] NhapMangThuc(int n)
    {
        double[] arr = new double[n];
        string[] tokens = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++) arr[i] = double.Parse(tokens[i]);
        return arr;
    }

    static void Bai01_XuatMang(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }

    static void Bai02_TongVaTrungBinhCong(double[] arr)
    {
        double tong = 0;
        foreach (double x in arr) tong += x;
        double tbc = tong / arr.Length;
        Console.WriteLine($"{tong:F2} {tbc:F2}");
    }

    static void Bai03_TimMaxMin(int[] arr)
    {
        int max = arr[0], min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }
        Console.WriteLine($"{max} {min}");
    }

    static void Bai04_DemChanLe(int[] arr)
    {
        int chan = 0, le = 0;
        foreach (int x in arr)
        {
            if (x % 2 == 0) chan++;
            else le++;
        }
        Console.WriteLine($"{chan} {le}");
    }

    static void Bai05_TimKiem(int[] arr, int x)
    {
        int vt = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                vt = i;
                break;
            }
        }
        Console.WriteLine(vt);
    }

    static void Bai06_DaoNguocMang(int[] arr)
    {
        int[] tempArr = (int[])arr.Clone(); 
        int i = 0, j = tempArr.Length - 1;
        while (i < j)
        {
            int temp = tempArr[i];
            tempArr[i] = tempArr[j];
            tempArr[j] = temp;
            i++; j--;
        }
        Console.WriteLine(string.Join(" ", tempArr));
    }

    static void Bai07_KiemTraDoiXung(int[] arr)
    {
        bool doiXung = true;
        int n = arr.Length;
        for (int i = 0; i < n / 2; i++)
        {
            if (arr[i] != arr[n - 1 - i])
            {
                doiXung = false;
                break;
            }
        }
        Console.WriteLine(doiXung ? "YES" : "NO");
    }

    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }
    static void Bai08_LietKeSoNguyenTo(int[] arr)
    {
        List<int> snt = new List<int>();
        foreach (int x in arr)
        {
            if (LaSoNguyenTo(x)) snt.Add(x);
        }
        if (snt.Count == 0) Console.WriteLine("EMPTY");
        else Console.WriteLine(string.Join(" ", snt));
    }

    static void Bai09_TachMangChanLe(int[] arr)
    {
        List<int> chan = new List<int>();
        List<int> le = new List<int>();
        foreach (int x in arr)
        {
            if (x % 2 == 0) chan.Add(x);
            else le.Add(x);
        }
        Console.WriteLine(string.Join(" ", chan));
        Console.WriteLine(string.Join(" ", le));
    }

    static void Bai10_SapXepTangGiam(int[] arr)
    {
        Array.Sort(arr);
        Console.WriteLine(string.Join(" ", arr));

        int[] giam = (int[])arr.Clone();
        Array.Reverse(giam);
        Console.WriteLine(string.Join(" ", giam));
    }

    static void Bai11_ChenPhanTu(int[] arr, int x)
    {
        int n = arr.Length;
        int[] newArr = new int[n + 1];
        int i = 0, j = 0;
        bool daChen = false;

        while (i < n)
        {
            if (!daChen && x < arr[i])
            {
                newArr[j++] = x;
                daChen = true;
            }
            newArr[j++] = arr[i++];
        }
        if (!daChen) newArr[j] = x;

        Console.WriteLine(string.Join(" ", newArr));
    }

    static void Bai12_XoaPhanTu(int[] arr, int k)
    {
        if (k < 0 || k >= arr.Length) return;
        int[] newArr = new int[arr.Length - 1];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == k) continue;
            newArr[j++] = arr[i];
        }
        Console.WriteLine(string.Join(" ", newArr));
    }

    static void Bai13_DemTanSuat(int[] arr)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        foreach (int x in arr)
        {
            if (dic.ContainsKey(x)) dic[x]++;
            else dic[x] = 1;
        }
        foreach (var item in dic)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }

    static void Bai14_XuatHienNhieuNhat(int[] arr)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        foreach (int x in arr)
        {
            if (dic.ContainsKey(x)) dic[x]++;
            else dic[x] = 1;
        }

        int maxFreq = 0;
        int res = int.MaxValue;

        foreach (var item in dic)
        {
            if (item.Value > maxFreq)
            {
                maxFreq = item.Value;
                res = item.Key;
            }
            else if (item.Value == maxFreq)
            {
                if (item.Key < res) res = item.Key;
            }
        }
        Console.WriteLine(res);
    }
}