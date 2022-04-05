using System;

namespace NguyenQuangHuy_1911505310224_Mang
{
    class Program
    {
        static void DuongAm(int n)
        {
            string[] can = new string[10] { "canh", "tân", "nhâm", "qúy", "giáp", "ất", "bính", "đinh", "mậu", "kỉ" };
            string[] chi = new string[12] { "thân", "dậu", "tuất", "hợi", "tí", "sửu", "dần", "mão", "thìn", "tị", "ngọ", "mùi" };
            Console.WriteLine("{0} - {1} {2}", n, can[n % 10], chi[n % 12]);
            Console.WriteLine("{0} - {1} {2}", n + 60, can[n % 10], chi[n % 12]);
        }

        static int Max = 100;

        static int gcd(int a, int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }
        static void Main(string[] args)
        {
            int sobai;
            Console.WriteLine("Nhap so bai: ");
            sobai = Int32.Parse(Console.ReadLine());
            switch (sobai)
            {
                case 59:
                    int nam;
                    Console.WriteLine("Nhap so nam: ");
                    nam = Int32.Parse(Console.ReadLine());
                    DuongAm(nam);
                    break;
                case 61:
                    int[] a = new int[Max];
                    int n, i, s, p;
                    Random random = new Random();
                    do
                    {
                        Console.WriteLine("Nhap n[1, {0}]: ", Max - 1);
                        n = Int32.Parse(Console.ReadLine());

                    } while (n < 1 || n > Max - 1);
                    for (i = 0; i < n; ++i)
                        Console.Write("{0} ", a[i] = random.Next() % 201 - 100);
                    for (s = i = 0; i < n; ++i)
                        if (a[i] > 0) s += a[i];
                    Console.WriteLine("\nTong cac so nguyen duong = " + s);
                    do
                    {
                        Console.WriteLine("Nhap p [0, {0}]: ", n - 1);
                        p = Int32.Parse(Console.ReadLine());
                    } while (p < 0 || p > n - 1);
                    for (i = p + 1; i < n; ++i)
                        a[i - 1] = a[i];
                    n--;

                    for (i = 0; i < n; ++i)
                        Console.Write("{0} ", a[i]);
                    break;
                case 62:
                    int[] a1 = new int[Max];
                    int n1, i1, j1, s1, s2;
                    Random random1 = new Random();
                    do
                    {
                        Console.WriteLine("Nhap n[1, {0}]: ", Max - 1);
                        n1 = Int32.Parse(Console.ReadLine());

                    } while (n1 < 1 || n1 > Max - 1);
                    for (i1 = 0; i1 < n1; ++i1)
                        Console.Write("{0} ", a1[i1] = random1.Next() % 11 + 10);
                    for (s1 = s2 = i1 = 0; i1 < n1; ++i1)
                    {
                        if (i1 % 2 == 0 && a1[i1] % 2 == 0) s1 += a1[i1];
                        if (i1 % 2 == 0 && a1[i1] % 2 == 0) s2 += a1[i1];
                    }
                    Console.Write("\nTong le vi tri chan ({0}) ", s1);
                    Console.Write(s1 == s2 ? "bang" : "khac");
                    Console.Write(" tong chan vi tri le ({0})\n", s2);

                    Console.Write("Cac cap nguyen to cung nhau:\n");
                    for (i1 = 0; i1 < n1; ++i1)
                        for (j1 = i1 + 1; j1 < n1; ++j1)
                            if (gcd(a1[i1], a1[j1]) == 1)
                                Console.Write("({0}, {1})\n", a1[i1], a1[j1]);
                    break;
                case 63:
                    int[] a2 = new int[Max];
                    int n2, i2, c2;
                    Random random2 = new Random();
                    do
                    {
                        Console.WriteLine("Nhap n[1, {0}]: ", Max - 1);
                        n2 = Int32.Parse(Console.ReadLine());

                    } while (n2 < 1 || n2 > Max - 1);
                    for (i2 = 0; i2 < n2; ++i2)
                        Console.Write("{0} ", a2[i2] = random2.Next() % 201 - 100);
                    for (c2 = i2 = 0; i2 < n2; ++i2)
                        if (a2[i2] % 4 == 0 && Math.Abs(a2[i2]) % 10 == 6) c2++;
                    Console.Write("\nCo {0} phan tu chia het cho 4, tan cung 6\n", c2);
                    Console.Write("Nhan doi phan tu le:\n");
                    for (i2 = 0; i2 < n2; ++i2)
                        if (a2[i2] % 2 != 0) a2[i2] *= 2;
                    for (i2 = 0; i2 < n2; ++i2)
                        Console.Write("{0} ", a2[i2]);
                    break;
                case 66:
                    int[] a3 = new int[Max];
                    int n3, i3, k3, maxpos, minpos;
                    Random random3 = new Random();
                    do
                    {
                        Console.WriteLine("Nhap n[1, {0}]: ", Max - 1);
                        n3 = Int32.Parse(Console.ReadLine());

                    } while (n3 < 1 || n3 > Max - 1);
                    for (i3 = 0; i3 < n3; ++i3)
                        Console.Write("{0} ", a3[i3] = random3.Next() % 201 - 100);
                    maxpos = minpos = 0;
                    for (i3 = 1; i3 < n3; ++i3)
                    {
                        if (a3[i3] < a3[minpos]) minpos = i3;
                        if (a3[i3] > a3[maxpos]) maxpos = i3;
                    }
                    Console.WriteLine("\nmax = " + a3[maxpos]);
                    Console.WriteLine("min = " + a3[minpos]);
                    for (k3 = i3 = maxpos + 1; i3 < n3; ++i3)
                        if (a3[i3] != a3[maxpos]) a3[k3++] = a3[i3];
                    n3 = k3;
                    for (i3 = 0; i3 < n3; ++i3)
                        Console.Write("{0} ", a3[i3]);
                    break;
                default: Console.WriteLine("Khong co bai nay"); break;
            }

            Console.ReadKey();
        }
    }
}
