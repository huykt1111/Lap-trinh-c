using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class CanBo
    {
        protected string hoTen;
        protected int tuoi;
        protected string gioiTinh;
        protected string diaChi;

        public CanBo(string hoTen, int tuoi, string gioiTinh, string diaChi)
        {
            this.hoTen = hoTen;
            this.tuoi = tuoi;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
        }

        public CanBo()
        {
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }


        public virtual void Input()
        {
            Console.WriteLine("=====NHap du lieu Can bo=====");
            Console.WriteLine("Nhap Ho va Ten : ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            tuoi = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gioi tinh:  ");
            gioiTinh = DieuKien.Gender();
            Console.WriteLine("Nhap dia chi: ");
            diaChi = Console.ReadLine();
        }

        public virtual void Display()
        {
            Console.Write("Ho va Ten: {0} , Ngay sinh : {1} , Gioi tinh: {2} , Dia chi: {3}", hoTen, tuoi, gioiTinh, diaChi);
        }

    }
}
