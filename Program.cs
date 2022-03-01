using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapCB1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chon;
            do
            {
                Console.WriteLine("-----MENU-----");
                Console.WriteLine("1. Cau 1!");
                Console.WriteLine("2. Cau 2!");
                Console.WriteLine("3. Cau 3!");
                Console.WriteLine("4. Cau 4!");
                Console.Write("Nhap lua chon: ");
                chon = Convert.ToInt32(Console.ReadLine());
                if (chon == 1)
                    cau1();
                else if (chon == 2)
                    cau2();
                else if (chon == 3)
                    cau3();
                else if (chon == 4)
                    cau4();
            } while (chon <= 4 && chon >= 1);
        }

        private static void cau1()
        {
            Console.WriteLine("Nhap mot so nguyen: ");
            int so = Convert.ToInt32(Console.ReadLine());
            if (so >= 0)
                Console.WriteLine("Day la so nguyen duong");
            else if (so < 0)
                Console.WriteLine("Day la so nguyen am");
        }

        private static void cau2()
        {
            Console.WriteLine("Nhap mot so nguyen: ");
            int so = Convert.ToInt32(Console.ReadLine());
            switch (so)
            {
                case 0: Console.WriteLine("Khong"); break;
                case 1: Console.WriteLine("Mot"); break;
                case 2: Console.WriteLine("Hai"); break;
                case 3: Console.WriteLine("Ba"); break;
                case 4: Console.WriteLine("Bon"); break;
                case 5: Console.WriteLine("Nam"); break;
                case 6: Console.WriteLine("Sau"); break;
                case 7: Console.WriteLine("Bay"); break;
                case 8: Console.WriteLine("Tam"); break;
                case 9: Console.WriteLine("Chin"); break;
                default:
                    Console.WriteLine("Failed");
                break;
            }
        }

        private static void cau3()
        {
            double a, b, c;
            Console.WriteLine("Nhap 3 so: ");
            a = Convert.ToDouble(Console.Read());
            b = Convert.ToDouble(Console.Read());
            c = Convert.ToDouble(Console.Read());
            if (a + b > c && b + c > a && c + a > b)
                Console.WriteLine("Ba so la canh cua 1 tam giac");
            else
                Console.WriteLine("Ba so khong la canh cua 1 tam giac");
        }

        private static void cau4()
        {
            double a, b, c;
            Console.WriteLine("Nhap 3 so: ");
            a = Convert.ToDouble(Console.Read());
            b = Convert.ToDouble(Console.Read());
            c = Convert.ToDouble(Console.Read());
            if (a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b)
                Console.WriteLine("Ba so la canh cua 1 tam giac vuong");
            else
                Console.WriteLine("Ba so khong la canh cua 1 tam giac vuong");
        }
    
    }
}
