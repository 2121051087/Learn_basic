using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Learn_basic.CS009
{
    public delegate void SuKienNhapSo(int x);
    class DuLieuNhap : EventArgs
    {
        public int data { get; set; }
        public DuLieuNhap(int x) => data = x;
    }
    class UserInput
    {
       

        public event EventHandler sukiennhapso;
        public void Input()
        {
            do
            {
                Console.Write("Nhap vao so nguyen : ");
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                sukiennhapso?.Invoke(this,new DuLieuNhap(i));
                Console.WriteLine("--------------");
            } while (true);
        }
    }
    class TinhCan
    {
        public void sub(UserInput input)
        {
            input.sukiennhapso  += Can;
        }
        public void Can(object sender,EventArgs e)
        {
            DuLieuNhap dulieunhap = (DuLieuNhap)e;
            int i = dulieunhap.data;
            Console.WriteLine($"Can bac hai cua {i} la : {Math.Sqrt(i)}");
        }
    }
    class TinhBinhPhuong
    {
        public void sub(UserInput input)
        {
            input.sukiennhapso += BinhPhuong;
        }
        public void BinhPhuong(object sender,EventArgs e)
        {
            DuLieuNhap dulieunhap = (DuLieuNhap)e;
            int i = dulieunhap.data;
            Console.WriteLine($"Binh Phuong cua {i} la : {i * i}");
        }
    }
}
