using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Learn_basic.DaHinh;
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
         
            Product p2 = new Iphone();
            p2.TestProduct();
            Console.WriteLine("====================================");
            Category c1 = new SamSung();
            c1.TestCategory();
            thucHanh th1 = new thucHanh(100);
            th1.ShowPrice();
            th1.OderAction(36);

            Console.WriteLine("====================================");
            Category c2 = new LapTop();
            c2.TestCategory();
            thucHanh th = new thucHanh(100);
            th.ShowPrice();
            th.OderAction(36);

            Console.WriteLine("====================================");
            Animal Cat1  = new Cat();
            Cat1.showInFo();
            Console.WriteLine("       --------------------------");
            Animal Dog1 = new Dog();
            Dog1.showInFo();
            Console.WriteLine("====================================");
            haha objTest = new haha();
            Console.WriteLine("====================================");
            khuon<double> myObj = new khuon<double>(23.45);
            myObj.methodParameter(35);

            Console.WriteLine("====================================");
            toan toanObj = new toan();
            toanObj.nhan(3.3f,4.4f);
        }
        
    }


}

    
