using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_basic.Interface
{
    internal class NhanVien: QuanLy
    {
        public void Them()
        {
            Console.WriteLine("Them nhan vien");

        }
        public void Sua()
        {
            Console.WriteLine("Chinh sua  thong tin nhan vien ");


        }
        public void Xoa()
        {
            Console.WriteLine("Xoa nhan vien");

        }
    }
}
