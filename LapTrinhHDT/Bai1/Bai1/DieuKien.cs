using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class DieuKien
    {
        public static DateTime ConvertStrignToDateTime()
        {
            String c;
            while (true)
            {
                try
                {
                    c = Console.ReadLine();
                    DateTime myDate = DateTime.ParseExact(c, "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    return myDate;
                }
                catch (System.Exception)
                {

                    Console.WriteLine("nhap lai: ");
                }

            }

        }
        public static DateTime ConvertStrignToDateTime(string c)
        {

            c = Console.ReadLine();
            DateTime myDate = DateTime.ParseExact(c, "yyyy-MM-dd",
                               System.Globalization.CultureInfo.InvariantCulture);
            return myDate;

        }

        public static string ConvertDateTimeToString(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd");
        }

        public static String Gender()
        {
            Console.WriteLine("1. Nam");
            Console.WriteLine("2. Nu");
            Console.WriteLine("3. Khong ro");
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
                                return "Nam";
                                break;
                            case 2:
                                return "Nu";
                                break;
                            case 3:
                                return "Khong biet";
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

        public static int Level()
        {
            int a;
            while (true)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    if (a > 7)
                    {
                        Console.WriteLine("cap bac khong hon 7!");
                        a = int.Parse(Console.ReadLine());
                    }
                    return a;
                }
                catch (System.Exception)
                {

                    Console.WriteLine("Nhap lai!!");
                }
            }
        }
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
}
