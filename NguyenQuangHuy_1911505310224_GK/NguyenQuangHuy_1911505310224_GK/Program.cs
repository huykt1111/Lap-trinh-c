using System;

namespace NguyenQuangHuy_1911505310224_GK
{
    class Program
    {
        static int luythua(int n)
        {
            int S = 0;
            for(int i = 1; i <= n; i++)
            {
                S = S + i;
            }
            return S;
        }

        static void nhap(int[] a, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = Int32.Parse(Console.ReadLine());
            }
        }

        static string ChuyenSo(string number)
        {
            string[] dv = { "", "mươi", "trăm", "nghìn", "triệu", "tỉ" };
            string[] cs = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string doc;
            int i, j, k, n, len, found, ddv, rd;

            len = number.Length;
            number += "ss";
            doc = "";
            found = 0;
            ddv = 0;
            rd = 0;

            i = 0;
            while (i < len)
            {
                //So chu so o hang dang duyet
                n = (len - i + 2) % 3 + 1;

                //Kiem tra so 0
                found = 0;
                for (j = 0; j < n; j++)
                {
                    if (number[i + j] != '0')
                    {
                        found = 1;
                        break;
                    }
                }

                //Duyet n chu so
                if (found == 1)
                {
                    rd = 1;
                    for (j = 0; j < n; j++)
                    {
                        ddv = 1;
                        switch (number[i + j])
                        {
                            case '0':
                                if (n - j == 3) doc += cs[0] + " ";
                                if (n - j == 2)
                                {
                                    if (number[i + j + 1] != '0') doc += "lẻ ";
                                    ddv = 0;
                                }
                                break;
                            case '1':
                                if (n - j == 3) doc += cs[1] + " ";
                                if (n - j == 2)
                                {
                                    doc += "mười ";
                                    ddv = 0;
                                }
                                if (n - j == 1)
                                {
                                    if (i + j == 0) k = 0;
                                    else k = i + j - 1;

                                    if (number[k] != '1' && number[k] != '0')
                                        doc += "mốt ";
                                    else
                                        doc += cs[1] + " ";
                                }
                                break;
                            case '5':
                                if (i + j == len - 1)
                                    doc += "lăm ";
                                else
                                    doc += cs[5] + " ";
                                break;
                            default:
                                doc += cs[(int)number[i + j] - 48] + " ";
                                break;
                        }

                        //Doc don vi nho
                        if (ddv == 1)
                        {
                            doc += dv[n - j - 1] + " ";
                        }
                    }
                }


                //Doc don vi lon
                if (len - i - n > 0)
                {
                    if ((len - i - n) % 9 == 0)
                    {
                        if (rd == 1)
                            for (k = 0; k < (len - i - n) / 9; k++)
                                doc += "tỉ ";
                        rd = 0;
                    }
                    else
                        if (found != 0) doc += dv[((len - i - n + 1) % 9) / 3 + 2] + " ";
                }

                i += n;
            }

            if (len == 1)
                if (number[0] == '0' || number[0] == '5') return cs[(int)number[0] - 48];

            return doc;
        }


        static void xuat(int[] a,int n)
        {
            Console.Write("Mang: ");
            for(int i=0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }

        static void Main(string[] args)
        {
            int sobai;
            Console.WriteLine("Nhap so bai: ");
            sobai = Int32.Parse(Console.ReadLine());
            switch (sobai)
            {
                case 1:
                    int n;
                    do
                    {
                        Console.WriteLine("Nhap so nguyen tu 6-99: ");
                        n = Int32.Parse(Console.ReadLine());
                    } while (n > 5 || n < 100);
                    Console.Write("S = 1 +...+ 1*...*{0} la {1}", n, luythua(n));
                    break;
                case 2:
                    
                    int n1,k,i;
                    Console.WriteLine("Nhap so phan tu cua mang: ");
                    n1 = Int32.Parse(Console.ReadLine());
                    int[] a = new int[100];
                    nhap(a, n1);
                    xuat(a, n1);
                    Console.Write("Nhap vao gia tri can kiem tra: ");
                    k = Int32.Parse(Console.ReadLine());
                    for(i = 0; i < n1; i++)
                    {
                        if (k == a[i])
                        {
                            Console.WriteLine("{0} ton tai o vi tri {1}", k, i+1);
                            break;
                        }
                    }
                    if (i == n1)
                    {
                        Console.WriteLine("{0} khong co trong mang", k);
                    }
                    break;
                case 3:
                    int n2;
                    do
                    {
                        Console.WriteLine("Nhap so nguyen tu nho hon 9999: ");
                        n2 = Int32.Parse(Console.ReadLine());
                    } while (n2 >= 9999);
                    string str1 = n2.ToString();
                    ChuyenSo(str1);
                    break;


            }
            Console.ReadKey();
        }
    }
}
