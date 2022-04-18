using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class KySu : CanBo
    {
        private string nghanhDaoTao;

        public KySu(string hoTen, int tuoi, string gioiTinh, string diaChi,string nghanhDaoTao) : base(hoTen,tuoi,gioiTinh,diaChi)
        {
            this.nghanhDaoTao = nghanhDaoTao;
        }

        public KySu()
        {
        }

        public string NghanhDaoTao { get => nghanhDaoTao; set => nghanhDaoTao = value; }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap nganh quan ly: ");
            nghanhDaoTao = Console.ReadLine();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" , Nganh quan ly: " + nghanhDaoTao);
        }
    }
}
