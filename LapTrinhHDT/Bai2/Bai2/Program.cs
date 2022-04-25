using System;
using System.Collections.Generic;

namespace Bai2
{
    class Check
    {
        public static int choose()
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
    class Document
    {
        private string matl;
        private string nxb;
        private int soban;

        public string Matl { get => matl; set => matl = value; }
        public string Nxb { get => nxb; set => nxb = value; }
        public int Soban { get => soban; set => soban = value; }

        public Document()
        {
        }
        public Document(string matl, string nxb, int soban)
        {
            this.Matl = matl;
            this.Nxb = nxb;
            this.Soban = soban;
        }

        public virtual void Input()
        {
            Console.WriteLine("=====Nhap du lieu tai lieu=====");
            Console.WriteLine("Nhap ma tai lieu : ");
            matl = Console.ReadLine();
            Console.WriteLine("Nhap ten nha xuat ban: ");
            nxb = Console.ReadLine();
            Console.WriteLine("So ban phat hanh:  ");
            soban = Int32.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.Write("Ma tai lieu: {0} , Ten nha xuat ban : {1} , So ban phat hanh: {2}", matl, nxb, soban);
        }

    }

    class Book : Document
    {
        private string tentg;
        private int sotrang;

        public Book()
        {
        }
        public Book(string matl, string nxb, int soban, string tentg, int sotrang) : base(matl, nxb, soban)
        {
            this.tentg = tentg;
            this.sotrang = sotrang;
        }
        public string Tentg { get => tentg; set => tentg = value; }
        public int Sotrang { get => sotrang; set => sotrang = value; }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap ten tac gia: ");
            tentg = Console.ReadLine();
            Console.WriteLine("Nhap so trang: ");
            sotrang = Int32.Parse(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" , Ten tac gia: {0} , So trang: {1}", tentg, sotrang);
        }
    }
    class Journal : Document
    {
        private int soph;
        private int thangph;
        public Journal()
        {
        }
        public Journal(string matl, string nxb, int soban, int soph, int thangph) : base(matl, nxb, soban)
        {
            this.Soph = soph;
            this.Thangph = thangph;
        }

        public int Soph { get => soph; set => soph = value; }
        public int Thangph { get => thangph; set => thangph = value; }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap so phat hanh: ");
            soph = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang phat hanh: ");
            thangph = Int32.Parse(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" , So phat hanh: {0} , Thang phat hanh: {1}", soph, thangph);
        }
    }
    class Newspaper : Document
    {
        private string nph;

        public Newspaper()
        {
        }
        public Newspaper(string matl, string nxb, int soban, string nph) : base(matl, nxb, soban)
        {
            this.nph = nph;
        }

        public string Nph { get => nph; set => nph = value; }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap ngay phat hanh: ");
            nph = Console.ReadLine();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" , Ngay phat hanh: " + nph);
        }
    }
    class QLTL
    {
        private List<Document> tailieus = new List<Document>();
        public void add()
        {
            int num;
            do
            {
                Console.WriteLine("===Chon vi tri muon them===");
                Console.WriteLine("1.Sach");
                Console.WriteLine("2.Tap chi");
                Console.WriteLine("3. Bao");
                Console.WriteLine("4.Thoat");
                int d = Check.choose();
                num = d;
                switch (d)
                {
                    case 1:
                        Book book = new Book();
                        book.Input();
                        tailieus.Add(book);
                        break;
                    case 2:
                        Journal jn = new Journal();
                        jn.Input();
                        tailieus.Add(jn);
                        break;
                    case 3:
                        Newspaper ns = new Newspaper();
                        ns.Input();
                        tailieus.Add(ns);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Nhap lai !!");
                        break;
                }
            } while (num != 4);
        }
        public void delete()
        {
            Console.WriteLine("Nhap ma tai lieu can xoa: ");
            string matl = Console.ReadLine();
            for (int i = 0; i < tailieus.Count; i++)
            {
                if (tailieus[i].Matl.Equals(matl))
                {
                    tailieus.RemoveAt(i);
                }
            }
        }
        public void View()
        {
            if (tailieus.Count == 0)
            {
                Console.WriteLine("Khong co tai lieu trong danh sach , vui vong them tai lieu");
            }
            for (int i = 0; i < tailieus.Count; i++)
            {
                tailieus[i].Display();
            }
        }
        public void search()
        {
            Console.WriteLine("Nhap ma tai lieu can tim: ");
            string matl = Console.ReadLine();
            for (int i = 0; i < tailieus.Count; i++)
            {
                if (tailieus[i].Matl.Equals(matl))
                {
                    tailieus[i].Display();
                }
            }
        }
        public void Menu()
        {
            int choose;
            do
            {
                Console.WriteLine("1. Them moi tai lieu");
                Console.WriteLine("2. Xoa tai lieu theo ma");
                Console.WriteLine("3. Hiện thị thông tin về tài liệu");
                Console.WriteLine("4. Tìm kiếm tài liệu theo loại: Sách, tạp chí, báo.");
                Console.WriteLine("5. Thoat");
                choose = Check.choose();
                switch (choose)
                {
                    case 1:
                        add();
                        break;
                    case 2:
                        delete();
                        break;
                    case 3:
                        View();
                        break;
                    case 4:
                        search();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Nhap lai !!!");
                        break;
                }
            } while (choose != 5);
        }
        class Program
        {
            static void Main(string[] args)
            {
                QLTL q = new QLTL();
                q.Menu();
            }
        }
    }
}
