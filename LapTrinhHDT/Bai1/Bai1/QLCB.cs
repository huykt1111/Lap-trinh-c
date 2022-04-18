using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class QLCB
    {
        private List<CanBo> canbos = new List<CanBo>();

        public void add()
        {
            int num;
            do
            {
                Console.WriteLine("===Chon vi tri muon them===");
                Console.WriteLine("1.Nhan vien");
                Console.WriteLine("2.Ki Su");
                Console.WriteLine("3.Cong nhan");
                Console.WriteLine("4.Thoat");
                int d = DieuKien.choose();
                num = d;
                switch (d)
                {
                    case 1:
                        NhanVien nv = new NhanVien();
                        nv.Input();
                        canbos.Add(nv);
                        break;
                    case 2:
                        KySu ks = new KySu();
                        ks.Input();
                        canbos.Add(ks);
                        break;
                    case 3:
                        CongNhan cn = new CongNhan();
                        cn.Input();
                        canbos.Add(cn);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Nhap lai !!");
                        break;
                }
            } while (num != 4);
        }
        public void search()
        {
            Console.WriteLine("Nhap ten can bo can tim: ");
            String name = Console.ReadLine();
            for (int i = 0; i < canbos.Count; i++)
            {
                if (canbos[i].HoTen.Equals(name))
                {
                    canbos[i].Display();
                }
            }
        }
        public void View()
        {
            if (canbos.Count == 0)
            {
                Console.WriteLine("Khong co can bo trong danh sach , vui vong them can bo");
            }
            for (int i = 0; i < canbos.Count; i++)
            {
                canbos[i].Display();
            }
        }

        public QLCB() { }
        public void Menu()
        {
            int choose;
            do
            {
                Console.WriteLine("1. Nhap thong tin moi cho can bo");
                Console.WriteLine("2. Tim kiem theo ho va ten");
                Console.WriteLine("3. Hien thi thong tin cua toan can bo");
                Console.WriteLine("4. Thoat");
                choose = DieuKien.choose();
                switch (choose)
                {
                    case 1:
                        add();
                        break;
                    case 2:
                        search();
                        break;
                    case 3:
                        View();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Nhap lai !!!");
                        break;
                }
            } while (choose != 4);
        }
    }
}
