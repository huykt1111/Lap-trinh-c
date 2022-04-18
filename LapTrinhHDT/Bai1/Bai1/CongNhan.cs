using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class CongNhan : CanBo
    {
        private int bac;


        public CongNhan(string hoTen, int tuoi, string gioiTinh, string diaChi, int bac):base(hoTen, tuoi, gioiTinh, diaChi)
        {
            this.bac = bac;
        }

        public CongNhan()
        {
        }

        public int Bac { get => bac; set => bac = value; }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap cap bac: ");
            bac = DieuKien.Level();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" , Cap Bac: " + bac + "/7");
        }
    }
}
