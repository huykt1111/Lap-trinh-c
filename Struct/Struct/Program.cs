using System;

namespace Struct
{
    class Program
    {
        struct SinhVien
        {
            public string HoTen224;
            public string MSV224;
            public string Lop224;
            enum GioiTinh
            {
                Nam,
                Nu
            };
            public double DiemToan224;
            public double DiemLy224;
            public double DiemHoa224;
        }


        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.Write(" Ho ten: ");
            SV.HoTen224 = Console.ReadLine();
            Console.Write(" Ma sinh vien: ");
            SV.MSV224 = Console.ReadLine();
            Console.Write(" Lop: ");
            SV.Lop224 = Console.ReadLine();
            Console.Write(" Diem Toan: ");
            SV.DiemToan224 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem Ly: ");
            SV.DiemLy224 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem Hoa: ");
            SV.DiemHoa224 = Double.Parse(Console.ReadLine());
        }

        static void XuatTTSV(SinhVien SV)
        {
            Console.WriteLine(" Ho ten: " + SV.HoTen224);
            Console.WriteLine(" Ma so: " + SV.MSV224);
            Console.WriteLine(" Diem toan: " + SV.DiemToan224);
            Console.WriteLine(" Diem ly: " + SV.DiemLy224);
            Console.WriteLine(" Diem van: " + SV.DiemHoa224);
            Console.WriteLine(" Diem trung binh: " + DiemTBSV(SV));
        }

        static double DiemTBSV(SinhVien SV)
        {
            return (SV.DiemToan224 + SV.DiemLy224 + SV.DiemHoa224) / 3;
        }
       
        static void Main(string[] args)
        {
            
            int n224,i224,j224;
            Console.WriteLine("Nhap so sinh vien: ");
            n224 = Int32.Parse(Console.ReadLine());
            SinhVien[] sv224 = new SinhVien[n224];
            for (i224 = 0; i224 < n224; i224++)
            {
                Console.WriteLine("Nhap sinh vien thu " + i224);
                NhapThongTinSinhVien(out sv224[i224]);
            }
            foreach(SinhVien item224 in sv224)
            {
                XuatTTSV(item224);
            }
            Console.WriteLine("Nhap ten sinh vien: ");
            string ten224 = Console.ReadLine();
            for ( j224 = 0; j224 < n224; j224++)
            {
                if (ten224 == sv224[j224].HoTen224)
                {
                    Console.WriteLine("Co sinh vien o vi tri thu {0} va co diem trung binh la {1}",j224 + 1, DiemTBSV(sv224[j224]));
                }
              
            }
            if (j224 == n224)
            {
                Console.WriteLine("Khong co sinh vien trong danh sach");
            }

        }
    }
}
