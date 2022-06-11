using System;
using System.Collections.Generic;

namespace _1911505310224_NguyenQuangHuy_BTLCuoiKy
{
    class DieuKien
    {
        public static string Phong()
        {
            Console.WriteLine("1. Phong A");
            Console.WriteLine("2. Phong B");
            Console.WriteLine("3. Phong C");
            int d;
            do
            {
                while (true)
                {
                    try
                    {
                        d = int.Parse(Console.ReadLine());
                        switch (d)
                        {
                            case 1:
                                return "Phong A";
                                break;
                            case 2:
                                return "Phong B";
                                break;
                            case 3:
                                return "Phong C";
                                break;
                            default:
                                Console.WriteLine("Lua chon lai");
                                break;

                        }
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Nhap lai!!");
                    }
                }
            } while (d != 1 || d != 2 || d != 3);

        }
        public static int ITG()
        {
            int a;
            while (true)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    return a;
                }
                catch (System.Exception)
                {

                    Console.WriteLine("Nhap lai!!");
                }
            }
        }
    }
    class Nguoi
    {
        private string hoten224;
        private int tuoi224;
        private int cmnd224;
        public Nguoi()
        {
        }

        public Nguoi(string hoten224, int tuoi224, int cmnd224)
        {
            this.Hoten224 = hoten224;
            this.Tuoi224 = tuoi224;
            this.Cmnd224 = cmnd224;
        }

        public string Hoten224 { get => hoten224; set => hoten224 = value; }
        public int Tuoi224 { get => tuoi224; set => tuoi224 = value; }
        public int Cmnd224 { get => cmnd224; set => cmnd224 = value; }

        public virtual void InputNguoi()
        {
            Console.WriteLine("Nhap Ho va Ten : ");
            hoten224 = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            tuoi224 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cmnd: ");
            cmnd224 = Int32.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Ho va Ten: {0} , Ngay sinh : {1}, CMND: {2}", hoten224, tuoi224, cmnd224);
        }
    }
    class KhachSan : Nguoi
    {
        private int songaythue224;
        private string loaiphong224;
        private int giatien224;
        private DateTime ngaythuephong224;
        Nguoi nguoithue224 = new Nguoi();

        public KhachSan()
        {
        }

        public KhachSan(int songaythue224, string loaiphong224, int giatien224, Nguoi nguoithue224)
        {
            this.songaythue224 = songaythue224;
            this.loaiphong224 = loaiphong224;
            this.nguoithue224 = nguoithue224;
            this.Giatien224 = giatien224;
        }

        public void InputKhachSan()
        {
            DateTime dt = DateTime.Today.AddDays(0);
            ngaythuephong224 = dt;   
            Console.WriteLine("Nhap so ngay thue: ");
            songaythue224 = DieuKien.ITG();
            Console.WriteLine("Nhap loai phong: ");
            loaiphong224 = DieuKien.Phong();
            giatien224 = 0;
            if (loaiphong224.Equals("Phong A"))
            {
                giatien224 = 500;
            }
            else if (loaiphong224.Equals("Phong B"))
            {
                giatien224 = 300;
            }
            else if (loaiphong224.Equals("Phong C"))
            {
                giatien224 = 100;
            }
            nguoithue224 = new Nguoi();
            nguoithue224.InputNguoi();
        }
        public void Display()
        {
            Console.WriteLine("So ngay thue: {0}, Loai Phong: {1}, So tien: {2}$", songaythue224, loaiphong224, giatien224);
            nguoithue224.Display();
        }

        public int Songaythue224 { get => songaythue224; set => songaythue224 = value; }
        public string Loaiphong224 { get => loaiphong224; set => loaiphong224 = value; }
        internal Nguoi Nguoithue224 { get => nguoithue224; set => nguoithue224 = value; }
        public int Giatien224 { get => giatien224; set => giatien224 = value; }
        public DateTime Ngaythuephong { get => ngaythuephong224; set => ngaythuephong224 = value; }
    }
    class ThuePhong
    {
        private List<KhachSan> khachsans224 = new List<KhachSan>();

        public ThuePhong()
        {
        }

        public void add()
        {
            KhachSan ks = new KhachSan();
            ks.InputKhachSan();
            khachsans224.Add(ks);
        }

        public void delete()
        {
            Console.WriteLine("Nhap so CMND: ");
            int cmnd = DieuKien.ITG();
            int S = 0;
            for (int i = 0; i < khachsans224.Count; i++)
            {
                if (khachsans224[i].Nguoithue224.Cmnd224.Equals(cmnd))
                {
                    khachsans224.RemoveAt(i);
                    Console.WriteLine("Xoa thanh cong");
                    S = S + 1;
                }
            }
            if (S == 0)
            {
                Console.WriteLine("Khong co nguoi nay trong khach san");
                //adsad
            }
        }

        public void View()
        {
            if (khachsans224.Count == 0)
            {
                Console.WriteLine("Khong co can bo trong danh sach , vui vong them can bo");
            }
            else
            {
                for (int i = 0; i < khachsans224.Count; i++)
                {
                    khachsans224[i].Display();
                }
            }
        }

        public void TinhTien()
        {
            Console.WriteLine("Nhap ma cmnd: ");
            int cmnd = DieuKien.ITG();
            int S = 0;
            string loaiphong224;
            int giatien224;
            int songaythue224;
            double thanhtien224 = 0;
            for (int i = 0; i < khachsans224.Count; i++)
            {
                if (khachsans224[i].Nguoithue224.Cmnd224.Equals(cmnd))
                {
                    loaiphong224 = khachsans224[i].Loaiphong224;
                    giatien224 = khachsans224[i].Giatien224;
                    songaythue224 = khachsans224[i].Songaythue224;
                    thanhtien224 = giatien224 * songaythue224;
                    Console.WriteLine("Khach hang thue phong loai: {0} va co gia tien la {1}$.Tong tien phai tra trong {2} ngay thue la {3}$", loaiphong224, giatien224, songaythue224, thanhtien224);
                    S = S + 1;
                }
            }
            if (S == 0)
            {
                Console.WriteLine("Khong co nguoi nay trong khach san");
            }
        }

        public void ThongKe()
        {
            if (khachsans224.Count == 0)
            {
                Console.WriteLine("Khong co ai thue phong");
            }
            else
            {
                int num224;
                do
                {
                    Console.WriteLine("1. Thong ke danh sach thue phong theo thang");
                    Console.WriteLine("2. Thong ke danh sach thue phong theo nam");
                    Console.WriteLine("3. Thong ke danh sach thue phong theo quy");
                    Console.WriteLine("4. Thoat");
                    Console.WriteLine("Nhap hinh thuc muon thong ke: ");
                    num224 = DieuKien.ITG();
                    switch (num224)
                    {
                        case 1:
                            Console.WriteLine("Nhap thang muon thong ke: ");
                            int thang224 = DieuKien.ITG();
                            for (int i = 0; i < khachsans224.Count; i++)
                            {
                                if (khachsans224[i].Ngaythuephong.Month.Equals(thang224))
                                {
                                    khachsans224[i].Display();
                                }
                            }
                            break;
                        case 2:
                            Console.WriteLine("Nhap nam muon thong ke: ");
                            int nam224 = DieuKien.ITG();
                            for (int i = 0; i < khachsans224.Count; i++)
                            {
                                if (khachsans224[i].Ngaythuephong.Year.Equals(nam224))
                                {
                                    khachsans224[i].Display();
                                }
                            }
                            break;
                        case 3: break;
                        case 4: break;
                        default: Console.WriteLine("Nhap sai");break;

                    }
                } while (num224 != 4);
                    
            }
        }

        public void ThongTinPhongDat()
        {
            int pa, pb, pc;
            pa = 0;
            pb = 0;
            pc = 0;
            Console.WriteLine("Nhap nam muon tinh: ");
            int nam224 = DieuKien.ITG();
            for (int i = 0; i < khachsans224.Count; i++)
            {
                if (khachsans224[i].Ngaythuephong.Year.Equals(nam224))
                {
                    if (khachsans224[i].Loaiphong224.Equals("Phong A"))
                    {
                        pa = pa + 1;
                    }
                    if (khachsans224[i].Loaiphong224.Equals("Phong B"))
                    {
                        pb = pb + 1;
                    }
                    if (khachsans224[i].Loaiphong224.Equals("Phong C"))
                    {
                        pc = pc + 1;
                    }
           
                }
            }
            if (pa > pb && pa > pc)
            {
                Console.WriteLine("Phong A duoc dat nhieu nhat");
            }
            if (pb > pa && pb > pc)
            {
                Console.WriteLine("Phong B duoc dat nhieu nhat");
            }
            if (pc > pa && pc > pb)
            {
                Console.WriteLine("Phong C duoc dat nhieu nhat");
            }
            if (pa < pb && pa < pc)
            {
                Console.WriteLine("Phong A duoc dat it nhat");
            }
            if (pb < pa && pb < pc)
            {
                Console.WriteLine("Phong B duoc dat it nhat");
            }
            if (pc < pa && pc < pb)
            {
                Console.WriteLine("Phong C duoc dat it nhat");
            }

        }

        public void TongTienThue()
        {
            if (khachsans224.Count == 0)
            {
                Console.WriteLine("Khong co ai thue phong");
            }
            else
            {
                int num224;
                do
                {
                    Console.WriteLine("1. Tong tien thue theo thang");
                    Console.WriteLine("2. Tong tien thue theo nam");
                    Console.WriteLine("3. Tong tien thue theo quy");
                    Console.WriteLine("4. Thoat");
                    Console.WriteLine("Nhap hinh thuc muon tinh tong tien: ");
                    num224 = DieuKien.ITG();
                    switch (num224)
                    {
                        case 1:
                            Console.WriteLine("Nhap thang muon tinh: ");
                            int thang224 = DieuKien.ITG();
                            int S224 = 0;
                            for (int i = 0; i < khachsans224.Count; i++)
                            {
                                if (khachsans224[i].Ngaythuephong.Month.Equals(thang224))
                                {
                                   
                                    S224=S224+khachsans224[i].Giatien224;
                                }
                            }
                            Console.WriteLine("Tong tien thu duoc trong thang {0} la {1}", thang224, S224);
                            break;
                        case 2:
                            Console.WriteLine("Nhap nam muon tinh: ");
                            int nam224 = DieuKien.ITG();
                            int T224 = 0;
                            for (int i = 0; i < khachsans224.Count; i++)
                            {
                                if (khachsans224[i].Ngaythuephong.Year.Equals(nam224))
                                {
                                    T224 = T224 + khachsans224[i].Giatien224;
                                }
                            }
                            Console.WriteLine("Tong tien thu duoc trong nam {0} la {1}", nam224, T224);
                            break;
                        case 3: break;
                        case 4: break;
                        default: Console.WriteLine("Nhap sai"); break;

                    }
                } while (num224 != 4);

            }
        }

        public void Menu()
        {
            int choose224;
            do
            {
                Console.WriteLine("1. Them nguoi thue moi");
                Console.WriteLine("2. Xem tat cac nguoi thue phong");
                Console.WriteLine("3. Xoa nguoi thue");
                Console.WriteLine("4. Tinh tien thue phong");
                Console.WriteLine("5. Thong ke cac thong tin thue theo thang, nam, quy");
                Console.WriteLine("6. Thong tin phong duoc thue nhieu nhat/ it nhat trong nam");
                Console.WriteLine("7. Tinh tong tien thue theo thang, nam, quy");
                Console.WriteLine("8. Thoat");
                Console.WriteLine("Moi ban chon chuc nang: ");
                choose224 = DieuKien.ITG();
                switch (choose224)
                {
                    case 1:
                        add();
                        break;
                    case 2:
                        View();
                        break;
                    case 3:
                        delete();
                        break;
                    case 4:
                        TinhTien();
                        break;
                    case 5:
                        ThongKe();
                        break;
                    case 6:
                        ThongTinPhongDat();
                        break;
                    case 7:
                        TongTienThue();
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Nhap lai !!!");
                        break;
                }
            } while (choose224 != 8);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ThuePhong tp224 = new ThuePhong();
            tp224.Menu();
            Console.ReadKey();
        }
    }
}
