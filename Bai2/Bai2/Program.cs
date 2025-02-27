using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {

        // Hàm tính tổng với tham số tùy chọn (mặc định b = 10)
        static int Sum221(int a221, int b221 = 10)
        {
            return a221 + b221;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tong khi chỉ truyền một số: " + Sum221(5)); // Mặc định b = 10
            Console.WriteLine("Tong khi truyền đủ hai số: " + Sum221(5, 20)); // b = 20

            Console.ReadKey();

        }
    }
}
