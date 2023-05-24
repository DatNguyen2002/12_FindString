using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhap ten vao danh sach
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            //Tao mot Array ten la studen
            string[] studen = new string[n];
            //thuc hien chusc nang nhapten sinh sinh vien vao danh sach
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Nhap ten sinh vien thu {i} ");
                string names = Console.ReadLine();
                //Luu ten nhap vao vi tri thu i
                studen[i] = names;
            }
            //Nhap ten can tim
            Console.WriteLine("Nhap ten Can Tim:");
            string findName = Console.ReadLine();

            /// su dung phuong thuc 'Any' de kiem tra xem trong mang Studen dung voi dieu kien
            /// name o day la bien de lap qua tung phan tu trong mang nham so sanh voi findName voi nem trong Array
            /// 'StringComparison.OrdinalIgnoreCase'  Day la tham so duoc chuyen tham so Equals de xac dinh cach thuc so sanh
            ///                                       Dam bao viec so sanh se bo qua chu viet hoa hoac chu viet thuong  
            bool index = studen.Any(name => name.Equals(findName, StringComparison.OrdinalIgnoreCase));


            if(index)
            {
                Console.WriteLine($"Ten {findName} da co trong mang");
            }
            else
            {
                Console.WriteLine("Ten Khong ton Tai");
            }
            Console.ReadKey();
        }
        public static void TimTen()
        {
            string[] studens = { "Dat", "Hai", "Phong", "Nga", "Mai" };

            Console.Write("Nhập tên cần kiểm tra: ");
            string name = Console.ReadLine();

            bool Find = false;
            for (int i = 0; i < studens.Length; i++)
            {
                if (studens[i] == name)
                {
                    Console.WriteLine($"Da tim thay ten {name} o vi tri {i}");
                    Find = true;
                }
            }
            if (!Find)
            {
                Console.WriteLine($"khong tim thay ten {name} trong danhs sach");
            }
        }
    }
}
