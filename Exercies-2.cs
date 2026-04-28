/*1. Print Hello and Name
Write a C# Sharp program to print Hello and your name in a separate line.
Expected Output :
Hello: Alexandra Abramov
2. Sum of Two Numbers
Write a C# Sharp program to print the sum of two numbers.
3. Divide Two Numbers
Write a C# Sharp program to print the result of dividing two numbers.
4. Specified Operations Results
Write a C# Sharp program to print the results of the specified operations.
Test data:
• -1 + 4 * 6
• ( 35+ 5 ) % 7
• 14 + -4 * 6 / 11
• 2 + 15 / 6 * 1 - 7 % 2
Expected Output:
23
5
12
3
5. Swap Two Numbers
Write a C# Sharp program to swap two numbers.
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output:
After Swapping :
First Number : 6
Second Number : 5
6. Multiply Three Numbers
1
Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6
Expected Output:
2 x 3 x 6 = 36
7. Arithmetic Operations
Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing
two numbers entered by the user.
Test Data:
Input the first number: 25
Input the second number: 4
Expected Output:
25 + 4 = 29
25 - 4 = 21
25 x 4 = 100
25 / 4 = 6
25 mod 4 = 1
8. Multiplication Table
Write a C# Sharp program that prints the multiplication table of a number as input.
Test Data:
Enter the number: 5
Expected Output:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10
5 * 3 = 15
....
5 * 10 = 50
9. Average of Four Numbers
Write a C# Sharp program that takes four numbers as input to calculate and print the average.
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the four number: 30
2
Expected Output:
The average of 10 , 15 , 20 , 30 is: 18
10. Specified Formula with Three Numbers
Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7
Expected Output:
Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
11. Print Age Message
Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You
look older than 20".
Test Data:
Enter your age - 25
Expected Output:
You look older than 25
12. Repeat Number in Rows
Write a C# program that takes a number as input and displays it four times in a row (separated by blank
spaces), and then four times in the next row, with no separation. You should do it twice: Use the
console. Write and use {0}.
Test Data:
Enter a digit: 25
Expected Output:
25 25 25 25
25252525
25 25 25 25
25252525
13. Rectangle Pattern with Number
Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows
tall using that digit.
Test Data:
Enter a number: 5
Expected Output:
555
3
5 5
5 5
5 5
555
14. Celsius to Kelvin and Fahrenheit
Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
Test Data:
Enter the amount of celsius: 30
Expected Output:
Kelvin = 303
Fahrenheit = 86
15. Remove Character by Index
Write a C# program that removes a specified character from a non-empty string using the index of a
character.
Test Data:
w3resource
Sample Output:
wresource
w3resourc
3resource
16. Swap First and Last Characters
Write a C# program to create a new string from a given string where the first and last characters change
their positions.
Test Data:
w3resource
Python
Sample Output:
e3resourcw
nythoP
x
17. Add First Character to Front and Back
Write a C# program to create a string from a given string (length 1 or more) with the first character
added at the front and back.
Sample Output:
Input a string : The quick brown fox jumps over the lazy dog.
4
TThe quick brown fox jumps over the lazy dog.T
18. Check Positive and Negative Pair
Write a C# program to check a pair of integers and return true if one is negative and one is positive.
Sample Output:
Input first integer:
-5
Input second integer:
25
True
Check if one is negative and one is positive:
19. Sum or Triple Sum of Integers
Write a C# program to compute the sum of two given integers. If two values are the same, return the
triple of their sum.
20. Absolute Difference or Double It
Write a C# program to get the absolute value of the difference between two given numbers. Return
double the absolute value of the difference if the first number is greater than the second number.*/
using System;

namespace Exercises_2;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Print Hello and Name");
            Console.WriteLine("2. Sum of Two Numbers");
            Console.WriteLine("3. Divide Two Numbers");
            Console.WriteLine("4. Specified Operations Results");
            Console.WriteLine("5. Swap Two Numbers");
            Console.WriteLine("6. Multiply Three Numbers");
            Console.WriteLine("7. Arithmetic Operations");
            Console.WriteLine("8. Multiplication Table");
            Console.WriteLine("9. Average of Four Numbers");
            Console.WriteLine("10. Specified Formula with Three Numbers");
            Console.WriteLine("11. Print Age Message");
            Console.WriteLine("12. Repeat Number in Rows");
            Console.WriteLine("13. Rectangle Pattern with Number");
            Console.WriteLine("14. Celsius to Kelvin and Fahrenheit");
            Console.WriteLine("15. Remove Character by Index");
            Console.WriteLine("16. Swap First and Last Characters");
            Console.WriteLine("17. Add First Character to Front and Back");
            Console.WriteLine("18. Check Positive and Negative Pair");
            Console.WriteLine("19. Sum or Triple Sum of Integers");
            Console.WriteLine("20. Absolute Difference or Double It");
            Console.WriteLine("Chọn từ 1 đến 20:");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": PrintName(); break;
                case "2": Sum2Numbers(); break;
                case "3": Divide2Numbers(); break;
                case "4": SpecifiedOperationsResults(); break;
                case "5": Swap2Numbers(); break;
                case "6": Multiply3Numbers(); break;
                case "7": ArithmeticOperations(); break;
                case "8": MultiplicationTable(); break;
                case "9": AverageofFourNumbers(); break;
                case "10": SpecifiedFormulawithThreeNumbers(); break;
                case "11": PrintAgeMessage(); break;
                case "12": RepeatNumberinRows(); break;
                case "13": RectanglePatternwithNumber(); break;
                case "14": CelsiustoKelvinandFahrenheit(); break;
                case "15": RemoveCharacterbyIndex(); break;
                case "16": SwapFirstandLastCharacters(); break;
                case "17": AddFirstCharactertoFrontandBack(); break;
                case "18": CheckPositiveandNegativePair(); break;
                case "19": SumorTripleSumofIntegers(); break;
                case "20": AbsoluteDifferenceorDoubleIt(); break;
                case "0": return;
                default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
            }
        Console.WriteLine("Nhấn phím bất kỳ để quay lại Menu...");
        Console.ReadKey();
        }
    }
    static void PrintName()
    {
        Console.Write("Nhập họ tên:");
        string name = Console.ReadLine();
        Console.Write($"Hello:{name}");
    }
    static void Sum2Numbers()
    {
        Console.Write("nhập a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("nhập b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"Tổng a và b là {a+b}");
    }
    static void Divide2Numbers()
    {
        Console.Write("nhập a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("nhập b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"a chia b b {a/b}");
    }
    static void SpecifiedOperationsResults()
    {
        Console.Write($"-1 + 4 * 6 = {-1 + 4 * 6}");
        Console.WriteLine($"(35 + 5) % 7 = {(35 + 5) % 7}");
        Console.WriteLine($"14 + -4 * 6 / 11 = {14 + -4 * 6 / 11}");
        Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {2 + 15 / 6 * 1 - 7 % 2}");
    }
    static void Swap2Numbers()
    {
        Console.Write("Nhập a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập b: ");
        int b = int.Parse(Console.ReadLine());
        int temp = a; a = b; b = temp;
        Console.WriteLine($"Sau khi hoán đổi: a={a},b={b}");
    }
    static void Multiply3Numbers()
    {
        Console.Write("Nhập a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhập b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhập c:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine($"{a}x{b}x{c}= {a*b*c}");
    }
    static void ArithmeticOperations()
    {
        Console.Write("Nhập a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhập b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"{a}+{b}={a+b}");
        Console.WriteLine($"{a}-{b}={a-b}");
        Console.WriteLine($"{a}x{b}={a*b}");
        Console.WriteLine($"{a}/{b}={a/b}");
        Console.WriteLine($"{a}mod{b}={a%b}");
    }
    static void MultiplicationTable()
    {
        Console.Write("Nhập số: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= 10; i++) Console.WriteLine($"{n} * {i} = {n * i}");
    }
    static void AverageofFourNumbers()
    {
        Console.Write("Nhập a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhập b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhập c:");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Nhập d:");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine($"trung bình cộng {a},{b},{c},{d} là {(a+b+c+d)/4}");
    }
    static void SpecifiedFormulawithThreeNumbers()
    {
        Console.Write("Nhập a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhập b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhập c:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine($"({a}+{b})x{c}={(a+b)*c} và {a}x{b}+{b}x{c}={a*b+b*c}");
    }
    static void PrintAgeMessage()
    {
        Console.Write("Nhập tuối:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine($"bạn quá già so với độ tuổi {a} rồi");
    }
    static void RepeatNumberinRows()
    {
        Console.Write("Nhập số:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine($"{a} {a} {a} {a}");
        Console.WriteLine($"{a}{a}{a}{a}");
        Console.WriteLine($"{a} {a} {a} {a}");
        Console.WriteLine($"{a}{a}{a}{a}");

    }
    static void RectanglePatternwithNumber()
    {
        Console.Write("Nhập số:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine($"{a}{a}{a}");
        Console.WriteLine($"{a} {a}");
        Console.WriteLine($"{a} {a}");
        Console.WriteLine($"{a}{a}{a}");
    }
    static void CelsiustoKelvinandFahrenheit()
    {
        Console.Write("nhập nhiệt độ: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine($"Kelvin: {c + 273.15}");
        Console.WriteLine($"Fahrenheit: {c * 1.8 + 32}");
    }
    static void RemoveCharacterbyIndex()
    {
        Console.Write("Nhập chuỗi:");
        string s = Console.ReadLine();
        Console.WriteLine(s.Remove(1, 1));
        Console.WriteLine(s.Remove(9, 1));
        Console.WriteLine(s.Remove(0, 1));

    }
    static void SwapFirstandLastCharacters()
    {
        Console.Write("Nhập chuỗi:");
        string s = Console.ReadLine();
        Console.WriteLine(s[s.Length - 1] + s[1..^1] + s[0]);
    }
    static void AddFirstCharactertoFrontandBack()
    {
        Console.Write("Nhập chuỗi:");
        string s = Console.ReadLine();
        Console.WriteLine(s[0]+s + s[0]);
    }
    static void CheckPositiveandNegativePair()
    {
        Console.Write("Số 1: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Số 2: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine((a < 0 && b >= 0) || (a >= 0 && b < 0));
    }

    static void SumorTripleSumofIntegers()
    {
    Console.Write("Số 1: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Số 2: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(a == b ? (a + b) * 3 : a + b);
    }
    static void AbsoluteDifferenceorDoubleIt()
    {
        Console.Write("Số 1: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Số 2: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(a>b? Math.Abs(a - b)*2: Math.Abs(a - b));
    }
}


