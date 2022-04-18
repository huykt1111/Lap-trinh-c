using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class NhanVien : CanBo
    {
        private string congViec;

        public NhanVien(string hoTen, int tuoi, string gioiTinh, string diaChi, string congViec) : base(hoTen, tuoi, gioiTinh, diaChi)
        {
            this.congViec = congViec;
        }

        public NhanVien()
        {
        }

        public string CongViec { get => congViec; set => congViec = value; }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap Cong viec: ");
            congViec = Console.ReadLine();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" , Nhan vien phuc vu: " + congViec);
        }
    }
}
