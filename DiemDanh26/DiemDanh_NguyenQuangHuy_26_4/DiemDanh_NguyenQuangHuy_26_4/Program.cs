using System;

namespace DiemDanh_NguyenQuangHuy_26_4
{
    class PTBH224
    {
        private double a224, b224, c224;

        public PTBH224()
        {
        }

        public PTBH224(double a224, double b224, double c224)
        {
            this.a224 = a224;
            this.b224 = b224;
            this.c224 = c224;
        }

        public double A224 { get => a224; set => a224 = value; }
        public double B224 { get => b224; set => b224 = value; }
        public double C224 { get => c224; set => c224 = value; }

        public double delta224(double a224, double b224, double c224)
        {
            return b224 * b224 - 4 * a224 * c224;
        }

        public void GiaiHPT(double a224, double b224, double c224)
        {
            if (delta224(a224, b224, c224) > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem : ");
                Console.WriteLine("X1 = {0}", ((-b224 - Math.Sqrt(delta224(a224,b224,c224)) / 2 * a224)));
                Console.WriteLine("X2 = {0}", ((-b224 + Math.Sqrt(delta224(a224, b224, c224))) / 2 * a224));

            }
            else if (delta224(a224, b224, c224) == 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem kep nghiem");
                Console.WriteLine("X1 = X2 {0}", -b224 / 2 * a224);
            }
            else if (delta224(a224, b224, c224) < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double a224, b224, c224;
            Console.WriteLine("Nhap vao a : ");
            a224 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao b : ");
            b224 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao c : ");
            c224 = float.Parse(Console.ReadLine());
            PTBH224 ptb2 = new PTBH224();
            ptb2.GiaiHPT(a224, b224, c224);
        }
    }
}
