using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2_Bai1
{

    enum WeekDays221
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    } 
    class Program
    {
        static void Main(string[] args)
        {
            //im here now
            // Lấy tên của một giá trị Enum
            Console.WriteLine(Enum.GetName(typeof(WeekDays221), 4));

            // In ra danh sách các hằng số của Enum
            Console.WriteLine("WeekDays constant names:");
            foreach (string str in Enum.GetNames(typeof(WeekDays221)))
            {
                Console.WriteLine(str);
            }

            // Chuyển đổi chuỗi sang Enum bằng TryParse
            Console.WriteLine("Enum.TryParse():");
            WeekDays221 wdEnum;
            if (Enum.TryParse("1", out wdEnum))
            {
                Console.WriteLine(wdEnum);
            }

            Console.ReadKey();
        }
    }
}
