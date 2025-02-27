using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EnumAndOptionalParameter
{
    enum UserRole
    {
        Admin221, Editor221, Viewer221
    }

    class Program
    {
        // Hàm với tham số tùy chọn .
        static void ShowUserRole(UserRole role = UserRole.Viewer221)
        {
            Console.WriteLine($"User role: {role}");
        }

        static void Main()
        {
            ShowUserRole(); // Mặc định Viewer
            ShowUserRole(UserRole.Admin221); // Truyền giá trị Enum cụ thể

            Console.ReadKey();
        }
    }
}

