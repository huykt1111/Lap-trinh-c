using System;

namespace NguyenQuangHuy_1911505310224_BtapLan2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sobai224;
            Console.WriteLine("Bai 1: Tinh dien tich mat cau\n" +
                "Bai 2: Tinh khoan cach AB\n" +
                "Bai 3: Xác định điểm M nằm trong, trên hay nằm ngoài đường tròn\n" +
                "Bai 4: Hãy cho biết loại tam giác và tính diện tích tam giác đó\n" +
                "Bai 12: Giai he phuong trinh 2 an\n" +
                "Bai 13: Kiểm tra ngày và tháng nhập có hợp lệ hay không.Tính thứ trong tuần của ngày đó\n" +
                "Bai 18: Viết chương trình nhập vào số giờ, xuất ra số tương đương tính theo tuần,theo ngày và theo giờ\n" +
                "Bai 20: Tính tiền điện phải trả\n" +
                "Bai 22: Viết chương trình liệt kê, đếm và tính tổng các ước số của số nguyên dương n\n" +
                "Bai 25: Tính ước số chung lớn nhất và bội số chung nhỏ nhất của a, b.\n" +
                "Bai 31: Viết chương trình in bảng cửu chương từ 2 đến 9 ra màn hình.\n" +
                "Bài 39: Tìm các bộ số nguyên dương(x, y, z) (x, y, z < 100) là 3 số nguyên liên tiếp hoặc 3 số chẵn liên tiếp\n");
            Console.WriteLine("Nhap so bai: ");
            sobai224 = Int32.Parse(Console.ReadLine());
            switch (sobai224)
            {
                case 1: //Tinh dien tich mat cau 
                   string s224;
                   double S224, V224, R224;
                   Console.Write("Nhập diện tích của mặt cầu: ");
                   s224 = Console.ReadLine();
                   if (double.TryParse(s224, out S224) == false)
                   {
                       Console.WriteLine("Nhập sai");
                   }
                   else
                   {
                       R224 = Math.Sqrt(S224 / (4 * 3.141593));
                       V224 = (4 * 1.0 / 3) * 3.141593 * Math.Pow(R224, 3);
                       Console.WriteLine("Thể tích V của hình cầu là: V=" + V224);
                   }
                   break;
                case 2://Tinh khoan cach AB
                    double xA224, xB224, yA224, yB224, AB224;
                    Console.WriteLine("Nhập tọa độ điểm A(xA,yA): ");
                    Console.Write("Mời nhập xA: ");
                    xA224 = Double.Parse(Console.ReadLine());
                    Console.Write("Mời nhập yA: ");
                    yA224 = Double.Parse(Console.ReadLine());
                    Console.Write("Mời nhập xB: ");
                    xB224 = Double.Parse(Console.ReadLine());
                    Console.Write("Mời nhập yb: ");
                    yB224 = Double.Parse(Console.ReadLine());
                    AB224 = Math.Sqrt(Math.Pow((xB224 - xA224), 2) + Math.Pow((yB224 - yA224), 2));
                    Console.WriteLine("Độ dài đoạn AB là " + AB224);
                    break;
                case 3:// Xác định điểm M nằm trong, trên hay nằm ngoài đường tròn.
                    double xC224, yC224, RR224, xM224, yM224, d224;
                    Console.Write("Nhap toa do tam C(xC,yC): ");
                    xC224 = Double.Parse(Console.ReadLine());
                    yC224 = Double.Parse(Console.ReadLine());
                    Console.Write("Nhap ban kinh R: ");
                    RR224 = Double.Parse(Console.ReadLine());
                    Console.Write("Nhap toa do M(xM,yM): ");
                    xM224 = Double.Parse(Console.ReadLine());
                    yM224 = Double.Parse(Console.ReadLine());
                    d224 = RR224 - Math.Sqrt(Math.Pow(xM224 - xC224, 2) + Math.Pow(yM224 - yC224, 2));
                    if (d224 > 0)
                    {
                        Console.WriteLine("M nằm trong C");
                    }
                    else if (d224 < 0)
                    {
                        Console.WriteLine("M nằm ngoài C");
                    }
                    else
                    {
                        Console.WriteLine("M nằm trên C");
                    }
                    break;
                case 4://Hãy cho biết loại tam giác và tính diện tích tam giác đó
                    double a224, b224, c224, p224, SS224;
                    Console.Write("Nhập độ dài 3 cạnh a,b,c: ");
                    a224 = Double.Parse(Console.ReadLine());
                    b224 = Double.Parse(Console.ReadLine());
                    c224 = Double.Parse(Console.ReadLine());

                    if (a224 <= 0 || b224 <= 0 || c224 <= 0 && a224 + b224 > c224 && b224 + c224 > a224 && c224 + a224 > b224)
                    {
                        Console.WriteLine("Không phải tam giác");
                    }
                    else
                    {
                        int f = 0;
                        if (a224 == b224 || b224 == c224 || c224 == a224)
                            f += 1;
                        if (a224 == b224 && b224 == c224)
                            f += 1;
                        if (a224 * a224 + b224 * b224 == c224 * c224 || b224 * b224 + c224 * c224 == a224 * a224 || a224 * a224 + c224 * c224 == b224 * b224)
                            f += 3;
                        switch (f)
                        {
                            case 0:
                                Console.WriteLine("Tam giác thường");
                                break;
                            case 1:
                                Console.WriteLine("Tam giác cân");
                                break;
                            case 2:
                                Console.WriteLine("Tam giác đều");
                                break;
                            case 3:
                                Console.WriteLine("Tam giác vuông");
                                break;
                            case 4:
                                Console.WriteLine("Tam giác vuông cân");
                                break;

                        }
                        p224 = (a224 + b224 + c224) / 2;
                        SS224 = Math.Sqrt(p224 * (p224 - a224) * (p224 - b224) * (p224 - c224));
                        Console.WriteLine("Diện tích tam giác S = " + SS224);

                    }
                    break;
                case 12: //Giai he phuong trinh 2 an
                    double a1224, b1224, c1224, a2224, b2224, c2224, dx224, dy224, dd224, x224, y224;
                    Console.Write("Nhap a1, b1, c1: ");
                    a1224 = Double.Parse(Console.ReadLine());
                    b1224 = Double.Parse(Console.ReadLine());
                    c1224 = Double.Parse(Console.ReadLine());
                    Console.Write("Nhap a2, b2, c2: ");
                    a2224 = Double.Parse(Console.ReadLine());
                    b2224 = Double.Parse(Console.ReadLine());
                    c2224 = Double.Parse(Console.ReadLine());

                    dd224 = (a1224 * b2224 - a2224 * b1224);
                    dx224 = (c1224 * b2224 - c2224 * b1224);
                    dy224 = (a1224 * c2224 - a2224 * c1224);
                    if (dd224 == 0)
                    {
                        if (dx224 + dy224 == 0)
                            Console.WriteLine("He phuong trinh co vo so nghiem");
                        else
                            Console.WriteLine("He phuong trinh vo nghiem");
                    }
                    else
                    {
                        x224 = dx224 / dd224;
                        y224 = dy224 / dd224;
                        Console.WriteLine("Phuong trinh co nghiem x={0}, y={1}", x224, y224);
                    }
                    break;
                case 13://Kiểm tra ngày và tháng nhập có hợp lệ hay không.Tính thứ trong tuần của ngày đó
                    int ddd224, m224, yy224, topofmonth224, dayofweek224, year224, month224, day224;
                    rt224:
                    Console.WriteLine("Nhap ngay , thang va nam : ");
                    ddd224 = Int32.Parse(Console.ReadLine());
                    m224 = Int32.Parse(Console.ReadLine());
                    yy224 = Int32.Parse(Console.ReadLine());

                    if (yy224 < 1582)
                    {
                        Console.WriteLine("Lich Gregorian bat dau tu nam 1582");
                        goto rt224;
                    }
                    if (m224 < 1 || m224 > 12)
                    {
                        Console.WriteLine("Thang nhap khong hop le");
                        goto rt224;
                    }
                    if (ddd224 < 1 || ddd224 > 31)
                    {
                        Console.WriteLine("Ngay khong hop le");
                        goto rt224;
                    }
                    switch (m224)
                    {
                        case 4: case 6: case 9: case 11: topofmonth224 = 30; break;
                        case 2:
                            if ((yy224 % 4 == 0 && yy224 % 100 != 0) || yy224 % 400 == 0)
                            {
                                topofmonth224 = 29;
                            }
                            else
                            {
                                topofmonth224 = 28;
                            }
                            break;
                        default: topofmonth224 = 31; break;
                    }
                    Console.WriteLine("Hop le");
                    year224 = yy224 - (14 - m224) / 12;
                    month224 = m224 + 12 * ((14 - m224) / 12) - 2;
                    dayofweek224 = (ddd224 + year224 + (year224 / 4) - (year224 / 100) + (year224 / 400) + (31 * month224) / 12) % 7;
                    switch (dayofweek224)
                    {
                        case 0: Console.WriteLine("Chu nhat"); break;
                        case 1: Console.WriteLine("Thu hai"); break;
                        case 2: Console.WriteLine("Thu ba"); break;
                        case 3: Console.WriteLine("Thu tu"); break;
                        case 4: Console.WriteLine("Thu nam"); break;
                        case 5: Console.WriteLine("Thu sau"); break;
                        case 6: Console.WriteLine("Thu bay"); break;
                    }
                    break;
                case 18: //Bai 18: Viết chương trình nhập vào số giờ, xuất ra số tương đương tính theo tuần,theo ngày và theo giờ
                    int h224, w224, dyy224, o224;
                    Console.WriteLine("Nhap so gio: ");
                    h224 = Int32.Parse(Console.ReadLine());
                    w224 = h224 / (24 * 7);
                    dyy224 = (h224 % (24 * 7)) / 24;
                    o224 = (h224 % (24 * 7)) % 24;
                    Console.WriteLine("{0} tuan, {1} ngay, {2} gio", w224, dyy224, o224);
                    break;
                case 20://Tính tiền điện phải trả
                    int kw224, money224;
                    Console.WriteLine("Nhap so kW tieu thu: ");
                    kw224 = Int32.Parse(Console.ReadLine());
                    if (kw224 <= 100)
                        money224 = kw224 * 500;
                    else if (kw224 <= 250)
                        money224 = 500 * 100 + 800 * (kw224 - 100);
                    else if (kw224 <= 350)
                        money224 = 500 * 100 + 800 * (250 - 100) + 1000 * (kw224 - 250);
                    else
                        money224 = 500 * 100 + 800 * (250 - 100) + 1000 * (350 - 250) + 1500 * (kw224 - 350);
                    Console.WriteLine("Chi phi la: " + money224);
                    break;
                case 22://Viết chương trình liệt kê, đếm và tính tổng các ước số của số nguyên dương n
                    int n224, SSS224, count224;
                    SSS224 = 0;
                    count224 = 0;
                    do
                    {
                        Console.WriteLine("Nhap so nguyen duong: ");
                        n224 = Int32.Parse(Console.ReadLine());
                        if (n224 < 0)
                        {
                            Console.WriteLine("Nhap sai nhap lai");
                        }
                    } while (n224 <= 0);
                    Console.WriteLine("Cac uoc so cua {0} la ", n224);
                    for (int i = 1; i <= n224; i++)
                    {
                        if (n224 % i == 0)
                        {
                            Console.Write("{0} ", i);
                            count224++;
                            SSS224 = SSS224 + i;
                        }
                    }
                    Console.WriteLine("\nCo {0} uoc so.Tong cac so cua {1} la {2}", count224, n224, SSS224);
                    break;
                case 25: //Tính ước số chung lớn nhất và bội số chung nhỏ nhất của a, b.
                    int a, b, uc, bc;
                    Console.WriteLine("Nhap hai so nguyen duong a,b: ");
                    a = Int32.Parse(Console.ReadLine());
                    b = Int32.Parse(Console.ReadLine());
                    for (uc = a; uc >= 1; uc--)
                    {
                        if (a % uc == 0 && b % uc == 0)
                        {
                            Console.WriteLine("UCLN({0},{1}) la {2}", a, b, uc);
                            break;
                        }
                    }
                    for (bc = a; bc <= a * b; bc++)
                    {
                        if (bc % a == 0 && bc % b == 0)
                        {
                            Console.WriteLine("BCNN({0},{1}) la {2}", a, b, bc);
                            break;
                        }
                    }
                    break;
                case 31: //Viết chương trình in bảng cửu chương từ 2 đến 9 ra màn hình.
                    int num224, sonhan224;
                    Console.WriteLine("Bang cuu chuong");
                    num224 = 2;
                    do
                    {
                        sonhan224 = 1;
                        do
                        {
                            Console.WriteLine("{0} x {1} = {2}", num224, sonhan224, num224 * sonhan224);
                            sonhan224++;
                        }
                        while (sonhan224 <= 10);

                        Console.WriteLine();
                        num224++;

                    } while (num224 <= 9);
                    break;
                case 39: //Tìm các bộ số nguyên dương(x, y, z) (x, y, z < 100) là 3 số nguyên liên tiếp hoặc 3 số chẵn liên tiếp
                    int xx224, yyy224, zz224;
                    for (xx224 = 1; xx224 < 100; ++xx224)
                        for (yyy224 = 1; yyy224 < 100; ++yyy224)
                            for (zz224 = 1; zz224 < 100; ++zz224)
                            {
                                if (xx224 * xx224 + yyy224 * yyy224 == zz224 * zz224)
                                {
                                    if (yyy224 - xx224 == 1 && zz224 - yyy224 == 1)
                                        Console.WriteLine("{0}, {1}, {2} la ba so nguyen lien tiep", xx224, yyy224, zz224);
                                    if (yyy224 % 2 == 0 && yyy224 - xx224 == 2 && zz224 - yyy224 == 2)
                                        Console.WriteLine("{0}, {1}, {2} la ba so chan lien tiep", xx224, yyy224, zz224);
                                }
                            }
                    break;
                default: Console.WriteLine("Khong co bai nay"); break;
                Console.ReadKey();
            }
        }
    }
}
