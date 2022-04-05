using System;
namespace _1911505310224_NguyenQuangHuy_ThiLan1
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Cal(double a224, double b224)
            {
                Console.WriteLine("Tong hai so {0} va {1} la: {2}", a224, b224, a224 + b224);
                Console.WriteLine("Hieu hai so {0} va {1} la: {2}", a224, b224, a224 - b224);
                Console.WriteLine("Tich hai so {0} va {1} la: {2}", a224, b224, a224 * b224);
                Console.WriteLine("Thuong hai so {0} va {1} la: {2}", a224, b224, a224 / b224);
            }
            
            static void SinhVien(string hten224,string lop224,string msv224)
            {
                Console.WriteLine("Ho ten: {0}\n" +
                    "Lop: {1}\n" +
                    "Ma sinh vien: {2}\n",hten224,lop224,msv224);
            }

            static void CoDo()
            {
                for (int i224 = 0; i224 <= 10; i224++)
                {
                    Console.WriteLine();
                    for (int j224 = 0; j224 <= 20; j224++)
                    {

                        if (i224 == 5 && j224 == 10)
                        {

                            Console.Write("*");
                        }
                        else
                            Console.Write("=");
                    }
                }
            }

            int sobai224;
            Console.WriteLine( "1.Viết phương thức in ra tổng, hiệu, tích, thương của 2 số đc nhập vào bàn phím cho trước.\n" +
                               "2.Viết phương thức In ra lá cờ Việt Nam bằng các dấu = và *\n" +
                               "3.Viết phương thức đổi số thập phân thành số nhị phân từ một số thập phân nhập vào từ bàn phím.\n" +
                               "4.Viết phương thức in ra các thông tin của bản thân(họ tên, lớp, mã sv)\n");
            Console.WriteLine("Nhap so bai: ");
            sobai224 = Int32.Parse(Console.ReadLine());
            switch (sobai224)
            {
                case 1:
                    double a224, b224;
                    Console.WriteLine("Nhap so thu nhat: ");
                    a224 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap so thu hai: ");
                    b224 = Double.Parse(Console.ReadLine());
                    Cal(a224,b224);
                    break;
                case 2:
                    CoDo();
                    break;
                case 3:
                    string answer224;
                    string result224;

                    Console.Write("Nhap mot so bat ky trong he thap phan: ");
                    answer224 = Console.ReadLine();

                    int num = Convert.ToInt32(answer224);
                    result224 = "";
                    while (num > 1)
                    {
                        int remainder = num % 2;
                        result224 = Convert.ToString(remainder) + result224;
                        num /= 2;
                    }
                    result224 = Convert.ToString(num) + result224;
                    Console.WriteLine("So trong he nhi phan tuong ung la: {0}", result224);
                    break;
                case 4:
                    string hten224, lop224, msv224;
                    Console.WriteLine("Nhap ho ten: ");
                    hten224 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Nhap lop: ");
                    lop224 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Nhap ma sinh vien: ");
                    msv224 = Convert.ToString(Console.ReadLine());

                    SinhVien(hten224, lop224, msv224);
                    break;
            }
            Console.ReadLine();

        }
    }
}
