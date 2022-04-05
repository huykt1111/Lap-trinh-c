using System;

namespace _1911505310224_NguyenQuangHuy_Btap22
{
    class Program
    {
        static int TinhTongN(int n)
        {
            int S = 0,T;
            T = n;
            while (T != 0)
            {
                S += T % 10;
                T /= 10;
            }
            return S;
        }
        static double tinha(double m,double l,int n)
        {
            return m * Math.Pow((1 + l), n);
        }
        static double TinhLai(double money,double laixuat,int nam)
        {
            double S = 0;

            for(int i = 1; i <= nam; i++)
            {
                S = tinha(money, laixuat, nam);
            }
            return S; 
        }
        static void TamGiacCan(int n)
        {
            int q = 0;
            while (n > 0)
            {
                
                for(int i = 1; i < n; i++)          
                    Console.Write(" ");
                for (int j = 0; j <= q; j++)
                    Console.Write("*");
                n--;
                q += 2;
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            int sobai;
            Console.WriteLine("Bai 1: Cho so tu nhien n nhap tu ban phim, hay tinh tong cua n so tu nhieu dau tien su dung vong lap.\n" +
                "Bai 2: Nhap vao so tien gui ban dau tien lai moi nam va so nam gui tien hay tinh so tien nhan duoc sau n nam\n" +
                "Bai 3: Nhap vao mot so tu nhien n, in ra man hinh tam giac can rong co chieu cao la n duoc tao thanh tu nhung dau *, co su dung vong lap");
            Console.WriteLine("Nhap so bai:");
            sobai = Int32.Parse(Console.ReadLine());
            switch (sobai)
            {
                case 1: int n224;
                    Console.WriteLine("Nhap so tu nhien n: ");
                    n224 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Tong cua cac so tu nhien co trong n la: " + TinhTongN(n224));
                    break;
                case 2:
                    double m224,l224;
                    int y224;
                    Console.WriteLine("Nhap so tien gui: ");
                    m224 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap so lai suat: ");
                    l224 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap so nam gui: ");
                    y224 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Tong so tien nhan duoc sau {0} la {1} ",y224,TinhLai(m224,l224,y224));
                    break;
                case 3:
                    int stg224;
                    Console.WriteLine("Nhap so tu nhien n: ");
                    stg224 = Int32.Parse(Console.ReadLine());
                    TamGiacCan(stg224);
                    break;
                default: Console.WriteLine("Khong co bai nay");break;
            }
            Console.ReadKey();
        }
    }
}
