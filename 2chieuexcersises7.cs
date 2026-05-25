using System;

class MangHaiChieu
{
    static void Main(string[] args)
    {

        Console.Write("Nhập số hàng m và số cột n: ");
        string[] size = Console.ReadLine().Split(' ');
        int m = int.Parse(size[0]);
        int n = int.Parse(size[1]);
        int[,] matrix = NhapMaTran(m, n);
        Bai21_XuatMaTran(matrix);

        Bai22_TongDongCot(matrix);

        Bai23_MaxVaViTri(matrix);

        
        if (m == n)
        {
            Bai24_DuongCheoChinh(matrix);

            Bai25_TongDuongCheoPhu(matrix);
        }
        else
        {
            Console.WriteLine("\n[Lưu ý] Các bài 24, 25 yêu cầu Ma trận vuông (m phải bằng n).");
        }

        Console.Write("Nhập số X cần tìm: ");
        int x26 = int.Parse(Console.ReadLine());
        Bai26_TimKiemX(matrix, x26);

        Bai27_DemAmBien(matrix);

        Console.WriteLine($"Mời nhập tiếp ma trận B cùng kích thước {m}x{n}:");
        int[,] matrixB = NhapMaTran(m, n);
        Bai28_CongHaiMaTran(matrix, matrixB);

        Bai29_MaTranChuyenVi(matrix);

        if (m == n)
        {
            Bai30_KiemTraDoiXung(matrix);
        }

        Bai31_SapXepTungDong(matrix);

        Console.Write("Nhập 2 chỉ số dòng r1 và r2 cần đổi chỗ: ");
        string[] rows = Console.ReadLine().Split(' ');
        int r1 = int.Parse(rows[0]);
        int r2 = int.Parse(rows[1]);
        Bai32_DoiChoHaiDong(matrix, r1, r2);

        if (m == n)
        {
            Bai33_MatrixTamGiacTren(matrix);
        }

        Bai34_DongTongLonNhat(matrix);
    }

    static int[,] NhapMaTran(int m, int n)
    {
        int[,] matrix = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(tokens[j]);
            }
        }
        return matrix;
    }

    static void Bai21_XuatMaTran(int[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Bai22_TongDongCot(int[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        int[] tongDong = new int[m];
        int[] tongCot = new int[n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                tongDong[i] += matrix[i, j];
                tongCot[j] += matrix[i, j];
            }
        }
        Console.WriteLine(string.Join(" ", tongDong));
        Console.WriteLine(string.Join(" ", tongCot));
    }

    static void Bai23_MaxVaViTri(int[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        int maxVal = matrix[0, 0];
        int hang = 0, cot = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] > maxVal)
                {
                    maxVal = matrix[i, j];
                    hang = i;
                    cot = j;
                }
            }
        }
        Console.WriteLine($"{maxVal} tại hàng {hang}, cột {cot}");
    }

    static void Bai24_DuongCheoChinh(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            Console.Write(matrix[i, i] + " ");
        }
        Console.WriteLine();
    }

    static void Bai25_TongDuongCheoPhu(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int tong = 0;
        for (int i = 0; i < n; i++)
        {
            tong += matrix[i, n - 1 - i];
        }
        Console.WriteLine(tong);
    }

    static void Bai26_TimKiemX(int[,] matrix, int x)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        bool found = false;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] == x)
                {
                    Console.Write($"({i},{j}) ");
                    found = true;
                }
            }
        }
        if (!found) Console.Write("NOT FOUND");
        Console.WriteLine();
    }

    static void Bai27_DemAmBien(int[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        int count = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 || i == m - 1 || j == 0 || j == n - 1)
                {
                    if (matrix[i, j] < 0) count++;
                }
            }
        }
        Console.WriteLine(count);
    }

    static void Bai28_CongHaiMaTran(int[,] matrixA, int[,] matrixB)
    {
        int m = matrixA.GetLength(0);
        int n = matrixA.GetLength(1);
        int[,] matrixC = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                Console.Write(matrixC[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Bai29_MaTranChuyenVi(int[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        int[,] AT = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                AT[i, j] = matrix[j, i];
                Console.Write(AT[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Bai30_KiemTraDoiXung(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        bool doiXung = true;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (matrix[i, j] != matrix[j, i])
                {
                    doiXung = false;
                    break;
                }
            }
        }
        Console.WriteLine(doiXung ? "YES" : "NO");
    }

    static void Bai31_SapXepTungDong(int[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        int[,] tempMatrix = (int[,])matrix.Clone();

        for (int i = 0; i < m; i++)
        {
            int[] row = new int[n];
            for (int j = 0; j < n; j++) row[j] = tempMatrix[i, j];

            Array.Sort(row);

            for (int j = 0; j < n; j++)
            {
                tempMatrix[i, j] = row[j];
                Console.Write(tempMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Bai32_DoiChoHaiDong(int[,] matrix, int r1, int r2)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        if (r1 < 0 || r1 >= m || r2 < 0 || r2 >= m) return;

        int[,] tempMatrix = (int[,])matrix.Clone();
        for (int j = 0; j < n; j++)
        {
            int temp = tempMatrix[r1, j];
            tempMatrix[r1, j] = tempMatrix[r2, j];
            tempMatrix[r2, j] = temp;
        }
        Bai21_XuatMaTran(tempMatrix);
    }

    static void Bai33_MatrixTamGiacTren(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        bool laTamGiacTren = true;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++) // Xét các phần tử nằm phía dưới đường chéo chính (j < i)
            {
                if (matrix[i, j] != 0)
                {
                    laTamGiacTren = false;
                    break;
                }
            }
        }
        Console.WriteLine(laTamGiacTren ? "YES" : "NO");
    }

    static void Bai34_DongTongLonNhat(int[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        int maxTong = int.MinValue;
        int chiSoDong = 0;

        for (int i = 0; i < m; i++)
        {
            int tongDong = 0;
            for (int j = 0; j < n; j++)
            {
                tongDong += matrix[i, j];
            }
            if (tongDong > maxTong)
            {
                maxTong = tongDong;
                chiSoDong = i;
            }
        }
        Console.WriteLine($"Dòng {chiSoDong} có tổng lớn nhất là {maxTong}");
    }
}