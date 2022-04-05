using System;

namespace NguyenQuangHuy_1911505310224_BaiTapLan1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai 1 : Kiem tra so la nguyen hay am
            string n224;
            int N224;
            Console.Write("Nhập vào một số nguyên: ");
            n224 = Console.ReadLine();
            if (int.TryParse(n224, out N224) == false)
            {
                Console.WriteLine("Nhập sai");
            }
            else
            {
                if (N224 > 0)
                {
                    Console.WriteLine("Đây là số nguyên dương");
                }
                else
                {
                    Console.WriteLine("Đây là số nguyên âm");
                }
            }

            //Bai 2
            int k224;
            Console.WriteLine("Nhap 1 so bat ky tu 1 den 9: ");
            k224 = Int32.Parse(Console.ReadLine());
            switch (k224)
            {
                case 0: Console.WriteLine("Không"); break;
                case 1: Console.WriteLine("Một"); break;
                case 2: Console.WriteLine("Hai"); break;
                case 3: Console.WriteLine("Ba"); break;
                case 4: Console.WriteLine("Bốn"); break;
                case 5: Console.WriteLine("Năm"); break;
                case 6: Console.WriteLine("Sáu"); break;
                case 7: Console.WriteLine("Bảy"); break;
                case 8: Console.WriteLine("Tám"); break;
                case 9: Console.WriteLine("Chín"); break;
                default:
                    Console.WriteLine("Nhap sai");break;
            }

            //Bai 3: Kiem tra 3 canh co phai la tam giac khong?
            double x224, y224, z224;
            Console.Write("Nhập độ dài 3 cạnh a,b,c: ");
            x224 = Double.Parse(Console.ReadLine());
            y224 = Double.Parse(Console.ReadLine());
            z224 = Double.Parse(Console.ReadLine());
            
            if( x224 > 0 && y224 > 0 && z224 > 0 && x224 + y224 > z224 && y224 + z224 > x224 && z224 + x224 > y224)
            {
                Console.WriteLine("Là tam giác");
            }
            else
            {
                Console.WriteLine("Không phải tam giác");
            }

            //Bai 4 : Kiem tra co phai 3 cạnh của một tam giác vuông hay không
            double a224, b224, c224;
            Console.Write("Nhập độ dài 3 cạnh a,b,c: ");
            a224 = Double.Parse(Console.ReadLine());
            b224 = Double.Parse(Console.ReadLine());
            c224 = Double.Parse(Console.ReadLine());

            if (a224 > 0 && b224 > 0 && c224 > 0 && a224 + b224 > c224 && b224 + c224 > a224 && c224 + a224 > b224)
            {
                if (a224 * a224 == b224 * b224 + c224 * c224 || b224 * b224 == a224 * a224 + c224 * c224 || c224 * c224 == a224 * a224 + b224 * b224)
                {
                    Console.WriteLine("La tam giac vuong");
                }
                else
                {
                    Console.WriteLine("Khong phai tam giac vuong");
                }
            }
            else
            {
                Console.WriteLine("Không phải tam giác");
            }
            Console.ReadKey();

        }
    }
}
