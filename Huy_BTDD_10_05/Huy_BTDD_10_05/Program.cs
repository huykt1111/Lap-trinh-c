using System;

namespace Huy_BTDD_10_05
{
    class Program
    {
        static void nhap(int[] a)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuat(int[] a)
        {
            Console.Write("Hien thi mang:");
            for (int i = 0; i < 10; i++)
                Console.Write(a[i] + " ");
        }

        static void GTLNNN(int[] a)
        {
            int mx, mn,i;
            mx = a[0];
            mn = a[0];

            for (i = 1; i < 10; i++)
            {
                if (a[i] > mx)
                {
                    mx = a[i];
                }


                if (a[i] < mn)
                {
                    mn = a[i];
                }
            }
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", mx);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", mn);
        }

        static void SXGG(int[] a)
        {
            int i,j,tmp;
            for (i = 0; i < 10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (a[i] < a[j])
                    {
                        tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }

        }

        static void SXTD(int[] a)
        {
            int i, j, tmp;
            for (i = 0; i < 10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (a[i] > a[j])
                    {
                        tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] a224 = new int[10];
            nhap(a224);
            xuat(a224);
            GTLNNN(a224);
            Console.WriteLine("Mang theo thu tu giam dan la:");
            SXGG(a224);
            xuat(a224);
            Console.WriteLine("Mang theo thu tu tang dan la:");
            SXTD(a224);
            xuat(a224);
        }
    }
}
