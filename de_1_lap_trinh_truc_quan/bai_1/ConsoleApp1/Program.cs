using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HangHoa
    {
        public string ten;
        public int masanpham;
        public string xuatxu;
        public int ngay, thang, nam;
        public HangHoa()
        {

        }
        public void nhaptt()
        {
            Console.Write("nhap ten san pham : ");
            ten = Console.ReadLine();
            Console.Write("nhap ma san pham : ");
            masanpham = int.Parse(Console.ReadLine());
            Console.Write("nhap xuat xu : ");
            xuatxu = Console.ReadLine();
            Console.Write("nhap ngay xuat kho : ");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("nhap thang xuat kho : ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("nhap nam xuat kho : ");
            nam = int.Parse(Console.ReadLine());
        }
    }
    class HangDienMay : HangHoa
    {
        public int soluongnhapkho;
        public int soluongxuatkho;
        public int giasanpham;
        public int ngay1, thang1, nam1;
        public HangDienMay()
        {

        }
        public void nhaptt1()
        {
            nhaptt();
            Console.Write("nhap so luong nhap kho : ");
            soluongnhapkho = int.Parse(Console.ReadLine());
            Console.Write("nhap so luong xuat kho : ");
            soluongxuatkho = int.Parse(Console.ReadLine());
            Console.Write("nhap ngay bao hanh : ");
            ngay1 = int.Parse(Console.ReadLine());
            Console.Write("nhap thang bao hanh : ");
            thang1 = int.Parse(Console.ReadLine());
            Console.Write("nhap nam bao hanh : ");
            nam1 = int.Parse(Console.ReadLine());
            Console.Write("nhap gia san pham : ");
            giasanpham = int.Parse(Console.ReadLine());
        }
        public int tinhtien()
        {
            return giasanpham * soluongxuatkho;
        }
        public void hienthi()
        {
            Console.WriteLine("{0}        {1}             {2}/{3}/{4}           " +
                "{5}           {6}                 {7}           {8}/{9}/{10}        " +
                "{11}              {12}", ten, masanpham, ngay, thang, nam, xuatxu, soluongnhapkho, soluongxuatkho,
                ngay1, thang1, nam1, giasanpham, tinhtien());
        }
        public void thongtin()
        {
            int r = 1;
            if (xuatxu == "Japan" && soluongnhapkho < 5)
            {
                Console.WriteLine(r + "{0}        {1}             {2}/{3}/{4}           " +
                "{5}           {6}                 {7}           {8}/{9}/{10}        " +
                "{11}              {12}", ten, masanpham, ngay, thang, nam, xuatxu, soluongnhapkho, soluongxuatkho,
                ngay1, thang1, nam1, giasanpham, tinhtien());
                r++;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("nhap so hang hoa muon nhap : ");
                n = int.Parse(Console.ReadLine());
                if(n <= 2)
                {
                    Console.Write("nhap so hang hoa muon nhap : ");
                    n = int.Parse(Console.ReadLine());
                }
            } while (n <= 2);
            List<HangDienMay> d = new List<HangDienMay>();
            HangDienMay a;
            for(int i = 0; i < n; i++)
            {
                a = new HangDienMay();
                Console.WriteLine("nhap hang hoa thu {0} : ", i + 1);
                a.nhaptt1();
                d.Add(a);
            }
            Console.WriteLine("---------------------------------------thong tin hang hoa------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("stt  ten       ma hang hoa       ngay/thang/nam xuat kho         " +
                "xuat xu         so luong nhap kho        so luong xuat kho             " +
                "ngay/thang/nam bao hanh         gia san pham     tien san pham da ban");
            for(int i = 0; i < d.Count; i++)
            {
                Console.Write(i + 1);
                d[i].hienthi();
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------thong tin hang hoa------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("stt  ten       ma hang hoa       ngay/thang/nam xuat kho         " +
                "xuat xu         so luong nhap kho        so luong xuat kho             " +
                "ngay/thang/nam bao hanh         gia san pham     tien san pham da ban");
            for (int i = 0; i < d.Count; i++)
            {
                Console.Write(i + 1);
                d[i].thongtin();
            }
        }   
    }
}
