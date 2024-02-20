using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Learn_basic.CS009;
using Learn_basic.DaHinh;
using Learn_basic.Delegate;
using Learn_basic.Event;
using Learn_basic.Generic;
using Learn_basic.Interface;
using Learn_basic.KeThua;
using Learn_basic.TruuTuong;


namespace Learn_basic
{

    public class Program
    {
        static void Main(string[] args)
        {
            UserInput userInput = new UserInput();
            userInput.sukiennhapso += (sender,e) =>
            {
                DuLieuNhap dulieunhap = (DuLieuNhap)e;
                Console.WriteLine("Ban vua nhap so : " + dulieunhap.data);
            };

            TinhCan tinhCan = new TinhCan();
            tinhCan.sub(userInput);

            TinhBinhPhuong binhPhuong = new TinhBinhPhuong();
            binhPhuong.sub(userInput);
            userInput.Input();

        }
        
        

        
    }



}

    
