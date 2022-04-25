using System;

namespace NguyenQuangHuy_TinhDaHinh
{
    class HinhHoc
    {
        public virtual void LoaiHinh()
        {
            Console.WriteLine("Hinh Hoc");
        }
    }
    class TamGiac : HinhHoc
    {
        public override void LoaiHinh()
        {
            Console.WriteLine("Hình tam giác có 3 cạnh và 3 đỉnh");
        }
    }
    class TuGiac : HinhHoc
    {
        public override void LoaiHinh()
        {
            Console.WriteLine("Hình tứ giác có 4 cạnh và 4 đỉnh");
        }
    }
    class HinhBinhHanh : HinhHoc
    {
        public override void LoaiHinh()
        {
            Console.WriteLine("Hình hình bình hành có 2 cặp cạnh đối xong xong không bằng nhau");
        }
    }
    class HinhChuNhat : HinhHoc
    {
        public override void LoaiHinh()
        {
            Console.WriteLine("Hình chữ nhật có 4 góc vuông và có 2 cặp cạnh đối xong xong không bằng nhau");
        }
    }
    class HinhVuong : HinhHoc
    {
        public override void LoaiHinh()
        {
            Console.WriteLine("Hình vuông có 4 cạnh và 4 góc bằng nhau (4 góc vuông)");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int hinh;
            Console.WriteLine("1. Hinh tam giac");
            Console.WriteLine("2. Hinh tu giac");
            Console.WriteLine("3. Hinh binh hanh ");
            Console.WriteLine("4. Hinh chu nhat ");
            Console.WriteLine("5. Hinh vuong ");
            Console.WriteLine("===============*===============");
            Console.WriteLine("Chọn loại hinh: ");
            hinh = Int32.Parse(Console.ReadLine());
            switch (hinh)
            {
                case 1:
                    HinhHoc tg = new TamGiac();
                    tg.LoaiHinh();
                    break;
                case 2:
                    HinhHoc bg = new TuGiac();
                    bg.LoaiHinh();
                    break;
                case 3:
                    HinhHoc hbh = new HinhBinhHanh();
                    hbh.LoaiHinh();
                    break;
                case 4:
                    HinhHoc hcn = new HinhChuNhat();
                    hcn.LoaiHinh();
                    break;
                case 5:
                    HinhHoc hv = new HinhVuong();
                    hv.LoaiHinh();
                    break;
                default: Console.WriteLine("Không có trong bài!!!!!");break;
            }


        }
    }
}
