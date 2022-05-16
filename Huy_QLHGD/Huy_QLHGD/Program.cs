using System;

namespace Huy_QLHGD
{
    /*Nguoi*/
    class Nguoi
    {
        private string hoten224;
        private int tuoi224;
        private string nghenghiep224;
        private int cmnd224;

        public Nguoi()
        {
        }

        public Nguoi(string hoten224, int tuoi224, string nghenghiep224, int cmnd224)
        {
            this.Hoten224 = hoten224;
            this.Tuoi224 = tuoi224;
            this.Nghenghiep224 = nghenghiep224;
            this.Cmnd224 = cmnd224;
        }

        public string Hoten224 { get => hoten224; set => hoten224 = value; }
        public int Tuoi224 { get => tuoi224; set => tuoi224 = value; }
        public string Nghenghiep224 { get => nghenghiep224; set => nghenghiep224 = value; }
        public int Cmnd224 { get => cmnd224; set => cmnd224 = value; }

        public virtual void InputNguoi()
        {
            Console.WriteLine("Nhap Ho va Ten : ");
            hoten224 = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            tuoi224 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nghe nghiep:  ");
            nghenghiep224 = Console.ReadLine();
            Console.WriteLine("Nhap so cmnd: ");
            cmnd224 = Int32.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Ho va Ten: {0} , Ngay sinh : {1} , Nghe nghiep: {2} , CMND: {3}", hoten224, tuoi224, nghenghiep224, cmnd224);
        }
    }
    /*HoDan*/
    class HoDan : Nguoi
    {
        private int sotv224;
        private int sonha224;
        private Nguoi[] thanhvien224 = new Nguoi[10];

        public int Sotv224 { get => sotv224; set => sotv224 = value; }
        public int Sonha224 { get => sonha224; set => sonha224 = value; }
        internal Nguoi[] Thanhvien224 { get => thanhvien224; set => thanhvien224 = value; }

        public HoDan()
        {

        }

        public HoDan(int sotv224, int sonha224, Nguoi[] thanhvien224)
        {
            this.sotv224 = sotv224;
            this.sonha224 = sonha224;
            this.thanhvien224 = thanhvien224;
        }

        public void InputHoDan()
        {
            Console.WriteLine("Nhap so thanh vien: ");
            sotv224 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nha: ");
            sonha224 = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= Sotv224; i++)
            {
                Console.WriteLine("Nhap so thanh vien thu " + i);
                thanhvien224[i] = new Nguoi();
                thanhvien224[i].InputNguoi();
            }
        }
        public void Display()
        {
            Console.WriteLine("So thanh vien: {0}, So nha: {1}",Sotv224,sonha224);
            for(int i=1;i<= sotv224; i++)
            {
                Console.WriteLine("Thanh vien thu " + i);
                thanhvien224[i].Display();
            }
        }
    }
    /*KhuPho*/
    class KhuPho
    {
        private HoDan[] dshodan224= new HoDan[10];
        private int sohodan224;

        public void InputKhuPho()
        {
            Console.WriteLine("Nhap so ho dan: ");
            sohodan224 = Int32.Parse(Console.ReadLine());
            for(int i = 1; i <= sohodan224; i++)
            {
                Console.WriteLine("Nhap so ho dan thu " + i);
                dshodan224[i] = new HoDan();
                dshodan224[i].InputHoDan();
            }
            Console.WriteLine("Thong tin tat ca ho dan: ");
            for (int i = 1; i <= sohodan224; i++)
            {
                Console.WriteLine("Ho dan thu " + i);
                dshodan224[i].Display();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KhuPho ql = new KhuPho();
            ql.InputKhuPho();
            Console.ReadKey();
        }
    }
}
