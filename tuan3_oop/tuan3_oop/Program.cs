using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan3_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee employee1 = new PartTimeEmployee("Nguyen Van Khanh",18000,6);
            Console.WriteLine("Ten nhan vien 1: (part time)" + employee1.GetName());
            Console.WriteLine("Luong nhan vien:" + employee1.CalculateSalary());

            Console.WriteLine("                                   ");

            IEmployee employee2 = new FullTimeEmployee("NguyenVanKhanh_221", 20000);
            Console.WriteLine("Ten nhan vien 2: (full time)" + employee2.GetName());
            Console.WriteLine("Luong nhan vien: " + employee2.CalculateSalary());

        }
    }
}
