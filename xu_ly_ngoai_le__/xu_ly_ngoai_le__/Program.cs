using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xu_ly_ngoai_le__
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 0;
            try
            {
                //các lệnh 
                /*giám sát về lỗi nếu 1 dòng code nào đó trong try phát sinh lỗi thì không kết thúc 
                 chương trình tại đó mà nóp sẽ chuyển hướng chương trình sang khổi khác , 
                va chương trình chạy từ khối catch trở đi*/
                var c = a / b;
                /*khi lỗi phát sinh trở ra thì sẽ phát sinh 1 execption, hoặc kế thừa từ execption*/
                Console.WriteLine(c);
                /*nếu không có lỗi thì sẽ bỏ qua khối catch và chương trình được chạy tiếp*/
            }
            catch(Exception e)
            {
                
                Console.WriteLine(e.Message);//vì sao lỗi 
                Console.WriteLine(e.StackTrace);//lỗi xảy ra tại đâu
                Console.WriteLine(e.GetType().Name);//lấy kiểu của execption và lấy tên
                // va nó sẽ hiện là : DivideByZeroException : lỗi chia cho 0 của biến
                //và ta sẽ ghi vào () của catch từ đó t bắt được lỗi là không đc chia cho không và in ra
                //Console.WriteLine("không được chia cho không!!");
                Console.WriteLine("phep chia co loi !!");
            }   
            Console.WriteLine("ket thuc truong trinh !!");


            /*try
            {
                user1("", 17);  
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
        }
        static void user1(string name, int age)
        {
            if (string.IsNullOrEmpty(name))//kiểm tra trong chuỗi , thực hiện phương thức tĩnh IsNullOrEmpty
            {
                Exception exception = new Exception("ten phai khac rong");
                throw exception;// code sẽ dừng lại tại đây
                /*throw: Một chương trình ném một exception khi có một vấn đề xuất hiện.
                 * Điều này được thực hiện bởi sử dụng từ khóa throw trong C#.*/
            }
            //... chương trình
            if (age < 18)
            {
                throw new Exception("tuoi phai > 18");
            }
        }
    }
}
/*finally: Một khối finally được sử dụng để thực thi một tập hợp lệnh đã cho, dù có hay không một 
 * exception đươc ném hoặc không được ném. Ví dụ, nếu bạn mở một file, nó phải được đóng, nếu không 
 * sẽ có một exception được tạo ra.*/
/*
try
{
   // các lệnh có thể gây ra ngoại lệ (exception)
}
catch( tên_ngoại_lệ e1 )
{
   // phần code để xử lý lỗi
}
catch( tên_ngoại_lệ e2 )
{
   // phần code để xử lý lỗi
}
catch( tên_ngoại_lệ eN )
{
   // phần code để xử lý lỗi
}
finally
{
   // các lệnh được thực thi dù có trỵ̣() có lỗi xảy ra hay không 
}
*/
